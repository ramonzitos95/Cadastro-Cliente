using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxPessoa_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPessoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string itemPessoa = comboBoxPessoa.Text;
            if (itemPessoa == "Juridica")
            {
                txtBoxCPF_CNPJ.Mask = "00.000.000/0000-00";
                lblPessoa.Text = "CNPJ";
                lblRG_IE.Text = "I.E.";
            }
            else
            {
                txtBoxCPF_CNPJ.Mask = "000.000.000-00";
                lblPessoa.Text = "CPF";
                lblRG_IE.Text = "RG.";
            }

        }

        private void txtBoxCPF_CNPJ_Leave(object sender, EventArgs e)
        {
            if (txtBoxCPF_CNPJ.Text.Trim().Equals("___,___,___-__") || txtBoxCPF_CNPJ.Text.Trim().Equals("__,___,___/____-__"))
            {
                MessageBox.Show("Campo de preenchimento obrigatório!");
                txtBoxCPF_CNPJ.Focus();
            }
        }

        private void txtBoxNome_Leave(object sender, EventArgs e)
        {
            if (txtBoxNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo de preenchimento obrigatório!");
                txtBoxNome.Focus();
            }
        }

        private void txtBoxDataNascimento_Leave(object sender, EventArgs e)
        {
            if (txtBoxDataNascimento.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo de preenchimento obrigatório!");
                txtBoxDataNascimento.Focus();
            }
        }
    }
}
