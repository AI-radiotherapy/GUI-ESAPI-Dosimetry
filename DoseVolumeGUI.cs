using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
// using System.Threading.Tasks;
// using System.Windows.Forms;

// TODO: Replace the following version attributes by creating AssemblyInfo.cs. You can do this in the properties of the Visual Studio project.
[assembly: AssemblyVersion("1.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0")]

// TODO: Uncomment the following line if the script requires write access.
// [assembly: ESAPIScript(IsWriteable = true)]

namespace DoseVolumeGUI {
    class Program {

        [STAThread]
        static void Main(string[] args) {
            try {
                using (Application app = Application.CreateApplication()) {
                    Execute(app);
                }
            } catch (Exception e) {
                Console.Error.WriteLine(e.ToString());
            }
        }
        static void Execute(Application app) {

            
            StartForm startForm = new StartForm();
            startForm.SetApplication(app);
            startForm.ShowDialog();

        }

    }

    class PlanResults {
        string _planName;
        List<StructResults> _structResultsList = new List<StructResults>();

        public PlanResults(string planName, List<StructResults> structResultsList) {
            _planName = planName;
            _structResultsList = structResultsList;
        }

    }

    struct StructResults {
        string structName;
        string maxDose;
        string minDose;
        string meanDose;
        string medianDose;
        string volume;
        double eud;
        double tcp;
        double ntcp;

        public StructResults(string structname,
            string maxdose, string mindose,
            string meandose,
            string mediandose,
            string planvolume,
            double planeud,
            double plantcp,
            double planntcp
        ) {
            structName = structname;
            maxDose = maxdose;
            minDose = mindose;
            meanDose = meandose;
            medianDose = mediandose;
            volume = planvolume;
            eud = planeud;
            tcp = plantcp;
            ntcp = planntcp;
        }

    }
}

