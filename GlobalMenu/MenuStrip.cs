using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalMenu {
    public partial class MenuStrip : Form {
        public MenuStrip() {
            InitializeComponent();
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e) {
            Consulta consult = new Consulta();
            consult.ShowDialog();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e) {
        }

        public class CustomColorTable : ProfessionalColorTable {
            public override Color MenuStripGradientBegin => Color.FromArgb(27, 25, 29);
            public override Color MenuStripGradientEnd => Color.FromArgb(27, 25, 29);

            public override Color MenuItemPressedGradientBegin => Color.FromArgb(46, 46, 46);
            public override Color MenuItemPressedGradientMiddle => Color.FromArgb(46, 46, 46);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(46, 46, 46);

            public override Color MenuBorder => Color.FromArgb(66, 66, 66);

            public override Color MenuItemSelected => Color.FromArgb(61, 61, 61);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(61, 61, 61);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(61, 61, 61);
            public override Color MenuItemBorder => Color.FromArgb(112, 112, 112);

            public override Color ToolStripDropDownBackground => Color.FromArgb(46, 46, 46);

            public override Color ImageMarginGradientBegin => Color.FromArgb(46, 46, 46);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(46, 46, 46);
            public override Color ImageMarginGradientEnd => Color.FromArgb(46, 46, 46);
        }
    }
}
