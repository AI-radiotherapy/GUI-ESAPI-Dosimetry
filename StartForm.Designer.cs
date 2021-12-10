
namespace DoseVolumeGUI {
    partial class StartForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.planSetupCheckLists = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorCalculateLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.structureCheckLists = new System.Windows.Forms.CheckedListBox();
            this.errorCourseLabel = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchHNButton = new System.Windows.Forms.Button();
            this.patientHN = new System.Windows.Forms.TextBox();
            this.HN = new System.Windows.Forms.Label();
            this.seletectAllPlan = new System.Windows.Forms.CheckBox();
            this.selectAllStructure = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // planSetupCheckLists
            // 
            this.planSetupCheckLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.planSetupCheckLists.FormattingEnabled = true;
            this.planSetupCheckLists.Location = new System.Drawing.Point(12, 181);
            this.planSetupCheckLists.Name = "planSetupCheckLists";
            this.planSetupCheckLists.Size = new System.Drawing.Size(181, 105);
            this.planSetupCheckLists.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.structureCheckLists);
            this.panel1.Controls.Add(this.errorCourseLabel);
            this.panel1.Controls.Add(this.courseBox);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.searchHNButton);
            this.panel1.Controls.Add(this.planSetupCheckLists);
            this.panel1.Controls.Add(this.patientHN);
            this.panel1.Controls.Add(this.HN);
            this.panel1.Controls.Add(this.seletectAllPlan);
            this.panel1.Controls.Add(this.selectAllStructure);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 593);
            this.panel1.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(9, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 16);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Patient:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.errorCalculateLabel);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 63);
            this.panel2.TabIndex = 12;
            // 
            // errorCalculateLabel
            // 
            this.errorCalculateLabel.AutoSize = true;
            this.errorCalculateLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorCalculateLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCalculateLabel.ForeColor = System.Drawing.Color.Orange;
            this.errorCalculateLabel.Location = new System.Drawing.Point(19, 40);
            this.errorCalculateLabel.Name = "errorCalculateLabel";
            this.errorCalculateLabel.Size = new System.Drawing.Size(140, 14);
            this.errorCalculateLabel.TabIndex = 13;
            this.errorCalculateLabel.Text = "Press calculate to analysis";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(107, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Config";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.configButton_Click);
            // 
            // structureCheckLists
            // 
            this.structureCheckLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.structureCheckLists.FormattingEnabled = true;
            this.structureCheckLists.Location = new System.Drawing.Point(12, 316);
            this.structureCheckLists.Name = "structureCheckLists";
            this.structureCheckLists.Size = new System.Drawing.Size(181, 180);
            this.structureCheckLists.TabIndex = 9;
            this.structureCheckLists.SelectedValueChanged += new System.EventHandler(this.structureCheckLists_SelectedValueChanged);
            // 
            // errorCourseLabel
            // 
            this.errorCourseLabel.AutoSize = true;
            this.errorCourseLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorCourseLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCourseLabel.ForeColor = System.Drawing.Color.Red;
            this.errorCourseLabel.Location = new System.Drawing.Point(9, 141);
            this.errorCourseLabel.Name = "errorCourseLabel";
            this.errorCourseLabel.Size = new System.Drawing.Size(111, 14);
            this.errorCourseLabel.TabIndex = 6;
            this.errorCourseLabel.Text = "Please select course";
            // 
            // courseBox
            // 
            this.courseBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.courseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Location = new System.Drawing.Point(12, 117);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(181, 21);
            this.courseBox.TabIndex = 4;
            this.courseBox.SelectionChangeCommitted += new System.EventHandler(this.courseBox_SelectionChangeCommitted);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(10, 82);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(87, 14);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "Please input HN";
            // 
            // searchHNButton
            // 
            this.searchHNButton.BackColor = System.Drawing.Color.SlateGray;
            this.searchHNButton.FlatAppearance.BorderSize = 0;
            this.searchHNButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchHNButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHNButton.Location = new System.Drawing.Point(118, 58);
            this.searchHNButton.Name = "searchHNButton";
            this.searchHNButton.Size = new System.Drawing.Size(75, 23);
            this.searchHNButton.TabIndex = 1;
            this.searchHNButton.Text = "Search";
            this.searchHNButton.UseVisualStyleBackColor = false;
            this.searchHNButton.Click += new System.EventHandler(this.searchHNButton_Click);
            // 
            // patientHN
            // 
            this.patientHN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.patientHN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientHN.Location = new System.Drawing.Point(12, 62);
            this.patientHN.Name = "patientHN";
            this.patientHN.Size = new System.Drawing.Size(100, 13);
            this.patientHN.TabIndex = 0;
            this.patientHN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.patientHN_KeyDown);
            // 
            // HN
            // 
            this.HN.AutoSize = true;
            this.HN.BackColor = System.Drawing.Color.Transparent;
            this.HN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HN.ForeColor = System.Drawing.Color.White;
            this.HN.Location = new System.Drawing.Point(12, 43);
            this.HN.Name = "HN";
            this.HN.Size = new System.Drawing.Size(27, 16);
            this.HN.TabIndex = 2;
            this.HN.Text = "HN";
            // 
            // seletectAllPlan
            // 
            this.seletectAllPlan.AutoSize = true;
            this.seletectAllPlan.BackColor = System.Drawing.Color.Transparent;
            this.seletectAllPlan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seletectAllPlan.ForeColor = System.Drawing.Color.White;
            this.seletectAllPlan.Location = new System.Drawing.Point(118, 162);
            this.seletectAllPlan.Name = "seletectAllPlan";
            this.seletectAllPlan.Size = new System.Drawing.Size(75, 20);
            this.seletectAllPlan.TabIndex = 8;
            this.seletectAllPlan.Text = "Select all";
            this.seletectAllPlan.UseVisualStyleBackColor = false;
            this.seletectAllPlan.CheckedChanged += new System.EventHandler(this.seletectAllPlan_CheckedChanged);
            // 
            // selectAllStructure
            // 
            this.selectAllStructure.AutoSize = true;
            this.selectAllStructure.BackColor = System.Drawing.Color.Transparent;
            this.selectAllStructure.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllStructure.ForeColor = System.Drawing.Color.White;
            this.selectAllStructure.Location = new System.Drawing.Point(118, 297);
            this.selectAllStructure.Name = "selectAllStructure";
            this.selectAllStructure.Size = new System.Drawing.Size(75, 20);
            this.selectAllStructure.TabIndex = 11;
            this.selectAllStructure.Text = "Select all";
            this.selectAllStructure.UseVisualStyleBackColor = false;
            this.selectAllStructure.CheckedChanged += new System.EventHandler(this.selectAllStructure_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plans";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Structure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Courses";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.resultTextBox.Location = new System.Drawing.Point(200, 0);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(592, 593);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "";
            // 
            // StartForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(792, 593);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "StartForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox planSetupCheckLists;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchHNButton;
        private System.Windows.Forms.TextBox patientHN;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label HN;
        private System.Windows.Forms.Label errorCourseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox seletectAllPlan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox structureCheckLists;
        private System.Windows.Forms.CheckBox selectAllStructure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label errorCalculateLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}