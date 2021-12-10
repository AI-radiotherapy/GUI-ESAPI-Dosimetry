using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoseVolumeGUI {

    public class Config {
        public List<StructConfig> structConfig { get; set; }
    }
    public class StructConfig {
        public string structureName { get; set; } 
        public double eud { get; set; } = 0.3;
        public double ntcpA { get; set; } = 0.1;
    }
}
