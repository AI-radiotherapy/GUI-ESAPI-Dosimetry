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
    public partial class ConfigTemplate : UserControl {
        public ConfigTemplate() {
            InitializeComponent();
            eudA.Text = "2";
        }
    }
}
