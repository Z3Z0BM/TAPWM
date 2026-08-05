using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEmpregado
{
    internal abstract class Empregado
    {
        private int matricula; //Atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        public int Matricula //Propriedade
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string NomeEmpregado
        {
            get
            {
                return nomeEmpregado;
            }
            set
            {
                nomeEmpregado = value;
            }
        }

        public DateTime DataEntradaEmpresa
        {
            get
            {
                return dataEntradaEmpresa;
            }
            set
            {
                dataEntradaEmpresa = value;
            }
        }

        //Método são ações/comportamentos
        //Virtual --> pode ser sobreescito
        public virtual int TempoTrabalho()
        {
            //Representa um intervalo de tempo
            TimeSpan span =
                DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }
        public abstract double SalarioBruto();

        public Empregado() //Construtor
        {
            System.Windows.Forms.MessageBox.Show("Aqui é empregado");
        }

        //public static String Empregado = hcte
        //{

        //}
    }
}