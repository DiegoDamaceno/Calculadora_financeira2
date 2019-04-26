using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Financeira

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double vp, taxa, pmt, tempo, vt, vj;

        public double Vp { get => vp; set => vp = value; }
        public double Taxa { get => taxa; set => taxa = value; }
        public double Pmt { get => pmt; set => pmt = value; }
        public double Tempo { get => tempo; set => tempo = value; }
        public double Vt { get => vt; set => vt = value; }
        public double Vj { get => vj; set => vj = value; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {

                    Application.Exit();

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtVp.Clear();
            txtJuro.Clear();
            txtResult.Clear();
            txtTotal.Clear();
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            vp = Convert.ToDouble(txtVp.Text);
            taxa = Convert.ToDouble(txtTaxa.Text);
            tempo = Convert.ToDouble(txtTempo.Text);
            pmt = vp * (((taxa / 100) * (Math.Pow((1 + (taxa / 100)), tempo))) / (Math.Pow((1 + (taxa / 100)), tempo) - 1));
            txtResult.Text = pmt.ToString();
            vt = pmt * tempo;
            txtTotal.Text = vt.ToString();
            vj = vt - vp;
            txtJuro.Text = vj.ToString();


        }



       private void btnSair_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                Application.Exit();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtJuro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

