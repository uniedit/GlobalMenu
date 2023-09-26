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
    public partial class Notepad : Form {
        public Notepad() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Process.Start(@"C:\Program Files\Notepad++\notepad++.exe");
        }

        private void button3_Click(object sender, EventArgs e) {
            Process.Start(@"notepad.exe");
        }
    }
}
