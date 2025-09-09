using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text, out numero1))
            {
                errorProvider1.SetError(txtNumero1, "Número 1 inválido.");
                txtNumero1.Focus();
            }
            else
                errorProvider1.SetError(txtNumero1, "");
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            try
            {
                errorProvider2.SetError(txtNumero2, "");
                numero2 = Convert.ToDouble(txtNumero2.Text);
            }
            catch
            {
                errorProvider2.SetError(txtNumero2, "Número 2 inválido.");
                txtNumero2.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resultado = numero1 + numero2;
            txtResultado.Text = resultado.ToString("N10");
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            resultado = numero1 - numero2;
            txtResultado.Text = resultado.ToString("N10");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString("N10");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (numero2 == 0)
            {
                txtResultado.Text = "Não é possível dividir por 0";
            }
            else
            {
                resultado = numero1 / numero2;
                txtResultado.Text = resultado.ToString("N10");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja sair?", "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
