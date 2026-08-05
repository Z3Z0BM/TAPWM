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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btn_instanciar_mensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.NomeEmpregado = 
                txtbox_nome.Text;

            objMensalista.Matricula =
                Convert.ToInt32(txtbox_matricula.Text);

            objMensalista.DataEntradaEmpresa =
                Convert.ToDateTime(txtbox_data_entrada_na_empresa.Text);

            objMensalista.SalarioMensal =
                Convert.ToDouble(txtbox_salario_mensal.Text);

            //get
            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado + 
                "\n" + "Matrícula=" + objMensalista.Matricula + 
                "\n" + "Tempo Trabalho" + objMensalista.TempoTrabalho() + 
                "\n" + "Salário Final=" + objMensalista.SalarioBruto().ToString("N2"));
        }

        private void btn_instanciar_mensalista_passando_parametros_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                Convert.ToInt16(txtbox_matricula.Text),
                txtbox_nome.Text, Convert.ToDateTime(txtbox_data_entrada_na_empresa),
                Convert.ToDouble(txtbox_salario_mensal));

            MessageBox.Show("Nome=" + objMensalista.NomeEmpregado +
                    "\n" + "Matrícula=" + objMensalista.Matricula +
                    "\n" + "Tempo Trabalho" + objMensalista.TempoTrabalho() +
                    "\n" + "Salário Final=" + objMensalista.SalarioBruto().ToString("N2"));
        }
    }
}
