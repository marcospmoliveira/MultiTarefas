using System;
using System.Windows.Forms;

namespace MultiTarefas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            frmIMC frm = new frmIMC();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConversor frm = new frmConversor();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmJokenpo frm = new frmJokenpo();
            frm.Show();
        }
    }
}
