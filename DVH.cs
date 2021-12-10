using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace DoseVolumeGUI {
    static class DVH {
        public static void DVHCalculation(Dose dose) {

            int[,] buffer = new int[dose.XSize, dose.YSize];

            for (int z = 0;z<dose.ZSize; z++) {
                dose.GetVoxels(z, buffer);
            }
        }
        public static DVHData GetDVH(PlanSetup plan, Structure structure) {
            return plan.GetDVHCumulativeData(structure,
                    DoseValuePresentation.Absolute,
                    VolumePresentation.Relative,
                    0.01
                );

        }
        public static DVHData GetDVH(PlanUncertainty plan, Structure structure) {
            return plan.GetDVHCumulativeData(structure,
                    DoseValuePresentation.Absolute,
                    VolumePresentation.Relative,
                    0.01
                );

        }

        private static double GetEUD(double[,] data, double aParameter) {
            double eud = 0;

            for (int i = 0;i< data.GetLength(0); i++) {
                eud += Math.Pow(data[i, 0], aParameter) * data[i, 1];
            }

            eud = Math.Pow(eud/100, 1 / aParameter);
            eud = Math.Round(eud, 1);
            return eud;
        }

        public static double GetNTCPFromDVH(DVHData data) {
            return 0.0;
        }

        public static double GetTCPFromDVH(DVHData data) {
            return 0.0;
        }

        public static Dictionary<string, double> DVHToParameters(DVHData data, StructConfig structConfig) {
            Dictionary<string, double> parameters = new Dictionary<string, double>();
            Console.WriteLine(structConfig.structureName);
            double[,] diffDVH = new double[data.CurveData.Length-1, 2];
            for (int i = 1; i < data.CurveData.Length; i++) {
                diffDVH[i-1, 0] = (data.CurveData[i].DoseValue.Dose + data.CurveData[i-1].DoseValue.Dose)/2;
                diffDVH[i-1, 1] = data.CurveData[i-1].Volume - data.CurveData[i].Volume;
            }
            double eud = GetEUD(diffDVH, structConfig.eud);
            parameters.Add("eud", eud);

            return parameters;
        }
    }
}
