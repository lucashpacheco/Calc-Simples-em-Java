using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Faculdade
{
    public partial class Form1 : Form

    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subtrai();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soma();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            multiplica();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dividi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void soma()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            
            txtoperacao.Text = Convert.ToString('+');

            double resultado = a + b;

            txtresultado.Text = Convert.ToString(resultado);

            txtaguardo.Text = Convert.ToString("Operação Concluida");
        }
        public void subtrai()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            txtoperacao.Text = Convert.ToString('-');

            double resultado = a - b;
            
            txtresultado.Text = Convert.ToString(resultado);

            txtaguardo.Text = "Operação Concluida";



        }

        public void multiplica()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            txtoperacao.Text = Convert.ToString('*');
            double resultado = a * b;
            txtresultado.Text = Convert.ToString(resultado);

            txtaguardo.Text = "Operação Concluida";
        }
        public void dividi()
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            txtoperacao.Text = Convert.ToString('/');
            double resultado = a - b;
            txtresultado.Text = Convert.ToString(resultado);

            txtaguardo.Text = "Operação Concluida";
        }

        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            txtoperacao.Text = Convert.ToString('?');

            txtresultado.Text = "Resultado";

            txtaguardo.Text = "Aguardando operação...";
        }

        
    }
}
