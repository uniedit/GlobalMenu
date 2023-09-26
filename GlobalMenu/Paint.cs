using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GlobalMenu {
    public partial class Paint : Form {
        public Paint() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) {
            Process.Start(@"mspaint");
        }

        private void button1_Click(object sender, EventArgs e) {
            Process.Start(@"ms-paint:");
        }
    }
}
