using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Diagnostics;

using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace DoseVolumeGUI {
    public partial class StartForm : Form {

        private static VMS.TPS.Common.Model.API.Application app;
        private bool isPatientFound = false;
        private bool isCourseSelected = false;
        private bool isPlanSelected = false;
        private List<PlanResults> planResultsList = new List<PlanResults>();

        public StartForm() {
            InitializeComponent();
        }

        public void SetApplication(VMS.TPS.Common.Model.API.Application varianApp) {
            app = varianApp;
        }

        private void searchPatient(String patientHNText) {

            // Close patient first
            app.ClosePatient();

            // remove all course in previous patient
            resetCourse();

            // remove all plan in previous course
            resetPlanSetup();

            Patient patient = app.OpenPatientById(patientHNText);

            if (patient == null) {
                errorLabel.Text = "Patient not found.";
                errorLabel.ForeColor = System.Drawing.Color.Red;
                return;
            } else {
                patientSelection();
            }

            // Set patient name
            nameLabel.Text = $"Patient: {patient.FirstName} {patient.LastName}";
             
            // Check if there is course in patient
            if (patient.Courses.Count() == 0){
                errorCourseLabel.Text = "No course found.";
                errorCourseLabel.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Add course to Combobox
            foreach (Course course in patient.Courses) {
                courseBox.Items.Add(course);
            }

        }

        private void courseBox_SelectionChangeCommitted(object sender, EventArgs e) {

            // Remove plan in previous course
            resetPlanSetup();
            Course course;

            // Get selected course
            try {
                course = (Course)courseBox.SelectedItem;
                courseSelection();
            } catch  {
                errorCourseLabel.Text = "Course error.";
                return;
            }
            
            // Add planSetup to Checklistbox
            foreach (PlanSetup planSetup in course.PlanSetups) {
                if (planSetup.Dose != null) {

                    planSetupCheckLists.Items.Add(planSetup);

                }
            }

            // Add Structure of first plan to checklistbox
            if (planSetupCheckLists.Items.Count != 0) {
                PlanSetup planSetup = (PlanSetup)planSetupCheckLists.Items[0];

                StructureSet structureSet = planSetup.StructureSet;
                foreach (Structure structure in structureSet.Structures) {
                    structureCheckLists.Items.Add(structure);

                }
            } else {

            }

        }



        private void patientHN_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchPatient(patientHN.Text.ToString());
            }
        }

        private void searchHNButton_Click(object sender, EventArgs e) {
            searchPatient(patientHN.Text.ToString());
        }

        private void patientSelection() {
            errorLabel.Text = "Patient found.";
            errorLabel.ForeColor = System.Drawing.Color.Green;
            isPatientFound = true;
        }

        private void courseSelection() {
            errorCourseLabel.Text = "";
            isCourseSelected = true;
        }

        private void resetCourse() {
            // Delete config file
            File.Delete("config.json");

            courseBox.Items.Clear();
            errorCourseLabel.Text = "Please select course";
            isCourseSelected = false;
        }

        private void resetPlanSetup() {
            // Delete config file
            File.Delete("config.json");

            planSetupCheckLists.Items.Clear();
            // errorPlanSetupLabel.Text = "Please select plan";
            isPlanSelected = false;
        }

        private void resetStructure() {
            File.Delete("config.json");
        }
        private void structureCheckLists_SelectedValueChanged(object sender, EventArgs e) {
            resetStructure();
        }


        private void configButton_Click(object sender, EventArgs e) {
            if (structureCheckLists.CheckedItems.Count == 0) {
                errorCalculateLabel.ForeColor = System.Drawing.Color.Red;
                errorCalculateLabel.Text = "Please select structure for config";
                return;
            }
            if (!File.Exists("config.json")) {
                createJsonConfig();
            }
            Process.Start("notepad.exe", "config.json");


        }

        private void createJsonConfig() {
            Config config = new Config();
            List<StructConfig> eud = new List<StructConfig>();
            foreach (Structure structure in structureCheckLists.CheckedItems) {
                eud.Add(new StructConfig() {
                    structureName = structure.Id
                }) ;
            }
            config.structConfig = eud;

            string strJson = JsonSerializer.Serialize<Config>(config);
            File.WriteAllText("config.json", strJson);

        }

        private Config readConfig() {
            string jsonStr = File.ReadAllText("config.json");
            Config config = JsonSerializer.Deserialize<Config>(jsonStr);
            return config;
        }

        private void calculateButton_Click(object sender, EventArgs e) {


            if (planSetupCheckLists.CheckedItems.Count == 0) {
                errorCalculateLabel.ForeColor = System.Drawing.Color.Red;
                errorCalculateLabel.Text = "Please select plan before calculate";
                return;
            }
            if (structureCheckLists.CheckedItems.Count == 0) {
                errorCalculateLabel.ForeColor = System.Drawing.Color.Red;
                errorCalculateLabel.Text = "Please select structure before calculate";
                return;
            }
            resultTextBox.Text = "";
            errorCalculateLabel.Text = "";
            planResultsList.Clear();

            if (!File.Exists("config.json")) {
                createJsonConfig();
            }

            Config config = readConfig();

            foreach (PlanSetup planSetup in planSetupCheckLists.CheckedItems) {

            
                List<StructResults> structResultsList = new List<StructResults>();
                foreach (Structure structure in structureCheckLists.CheckedItems) {
                    DVHData normalPlanDVH =  DVH.GetDVH(planSetup, structure);
                    /*foreach (PlanUncertainty planUncertainty in planSetup.PlanUncertainties) {
                        DVHData uncertaintyPlanDVH = DVH.GetDVH(planUncertainty, structure);

                    }*/
                    StructConfig structConfig = config.structConfig.Where(tmp => tmp.structureName == structure.Id).FirstOrDefault(); 
                    Dictionary<string, double> parameters = DVH.DVHToParameters(normalPlanDVH, structConfig);
                    String text = $@"
Plan: {planSetup.Id}
ROIs: {structure.Id}
    Max dose: {normalPlanDVH.MaxDose}           gEUD: {parameters["eud"]} cGy
    Min dose: {normalPlanDVH.MinDose}           NTCP:
    Mean dose: {normalPlanDVH.MeanDose}         TCP:
    Median dose: {normalPlanDVH.MedianDose}     
    Volume: {normalPlanDVH.Volume}
";
                    StructResults structResults = new StructResults(
                            planSetup.Id,
                            normalPlanDVH.MaxDose.ToString(),
                            normalPlanDVH.MinDose.ToString(),
                            normalPlanDVH.MeanDose.ToString(),
                            normalPlanDVH.MedianDose.ToString(),
                            normalPlanDVH.Volume.ToString(),
                            parameters["eud"],
                            0,
                            0
                        );
                    structResultsList.Add(structResults);
                    resultTextBox.AppendText(text);
                }

                PlanResults planResults = new PlanResults(planSetup.Id, structResultsList);
                planResultsList.Add(planResults);

            }

        }

        private void selectAllStructure_CheckedChanged(object sender, EventArgs e) {
            if (selectAllStructure.Checked == true) {
                for (int i = 0; i < structureCheckLists.Items.Count; i++) {
                    structureCheckLists.SetItemChecked(i, true);
                }
            } else {
                for (int i = 0; i < structureCheckLists.Items.Count; i++) {
                    structureCheckLists.SetItemChecked(i, false);
                }
            }
        }

        private void seletectAllPlan_CheckedChanged(object sender, EventArgs e) {
            if (seletectAllPlan.Checked == true) {
                for (int i = 0; i < planSetupCheckLists.Items.Count; i++) {
                    planSetupCheckLists.SetItemChecked(i, true);
                }
            } else {
                for (int i = 0; i < planSetupCheckLists.Items.Count; i++) {
                    planSetupCheckLists.SetItemChecked(i, false);
                }
            }
        }

        
    }
}
