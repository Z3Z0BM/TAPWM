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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtbox_nome.Text;

            objHorista.Matricula =
                Convert.ToInt32(txtbox_matricula.Text);

            objHorista.SalarioHora =
                Convert.ToDouble(txtbox_salario.Text);

            objHorista.NumeroHora =
                Convert.ToDouble(txtbox_hora.Text);

            objHorista.DataEntradaEmpresa =
                Convert.ToDateTime(txtbox_data.Text);

            objHorista.DiasFalta =
                Convert.ToInt32(txtbox_falta.Text);

            //Mostrando valores
            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
                "\n" + "Matrícula:" + objHorista.Matricula +
                "\n" + "Tempo Trabalho:" + objHorista.TempoTrabalho() +
                "\n" + "Salário:" + 
                objHorista.SalarioBruto().ToString("N2"));
        }
    }
}
