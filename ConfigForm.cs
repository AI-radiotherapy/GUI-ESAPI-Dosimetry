using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoseVolumeGUI {
    public partial class ConfigForm : Form {
        public ConfigForm() {
            InitializeComponent();
            
        }

        public void AddConfigPanel(Dictionary<string, Config> config) {

            foreach (string key in config.Keys) {
                ConfigTemplate configTemplate = new ConfigTemplate();
                configTemplate.Tag = key;
                configFlowPanel.Controls.Add(configTemplate);
            }

        }
    }

    
}
