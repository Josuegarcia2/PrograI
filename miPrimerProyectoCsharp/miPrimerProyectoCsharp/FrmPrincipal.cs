using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void docToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objDocentes = new Form1();
            objDocentes.MdiParent = this;
            objDocentes.Show();
        }
    }
    
}
