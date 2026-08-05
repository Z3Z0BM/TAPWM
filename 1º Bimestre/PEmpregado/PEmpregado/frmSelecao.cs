using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEmpregado
{
    public partial class frmSelecao : Form
    {
        public frmSelecao()
        {
            InitializeComponent();
        }

        private void btn_para_mensalista_Click(object sender, EventArgs e)
        {
            frmMensalista frmMensalista = new frmMensalista();
            frmMensalista.Show();
        }

        private void btn_para_horista_Click(object sender, EventArgs e)
        {
            frmHorista frmHorista = new frmHorista();
            frmHorista.Show();
        }
    }
}
