using System.Reflection;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CarReportSystem {
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }

        private void btVersionOK_Click(object sender, EventArgs e) {
            Close();
        }

        private void fmVersion_Load(object sender, EventArgs e) {
            var asm = Assembly.GetExecutingAssembly();
            var ver = asm.GetName().Version;
            lbVersion1.Text = "Ver" + ver.Major + "." + ver.Minor + "." + ver.Build + "." + ver.Revision;

            
            
            
        }
    }
    
}
