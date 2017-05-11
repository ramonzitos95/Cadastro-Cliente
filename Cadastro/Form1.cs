using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        private static int codigo = 0;
       
           
        public Form1()
        {
            InitializeComponent();
            txtBoxCodigo.Text = serializar().ToString();
        }

        public int serializar()
        {
            Arquivo arq = new Arquivo();
            int contador = 0;
            string json = arq.lerArquivo();
            var clientes = JsonConvert.DeserializeObject<List<ClienteDTO>>(json); //Deserializando o json

            if (clientes != null)
            {
                foreach (var c in clientes)
                {
                    contador = c.codigo;
                }
            }
            contador += 1;
            return contador;
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

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            ClienteDAO cliente = new ClienteDAO();
            try
            {
                cliente.codigo = Convert.ToInt32(txtBoxCodigo.Text);
                cliente.Nome = txtBoxNome.Text;
                cliente.dataNascimento = txtBoxDataNascimento.Text;
                cliente.RG_IE = txtBoxRG_IE.Text;
                cliente.cpf_cnpj = txtBoxCPF_CNPJ.Text;
                cliente.email = txtBoxEmail.Text;
                cliente.telefonePrincipal = txtBoxTelefonePrincipal.Text;
                cliente.telefoneSecundario = txtBoxTelefoneSecundario.Text;
                cliente.cidade = txtBoxCidade.Text;
                cliente.uf = txtBoxUf.Text;
                cliente.cep = txtBoxCEP.Text;
                cliente.logradouro = txtBoxLogradouro.Text;
                cliente.numero = Convert.ToInt32(txtBoxNumero.Text);
                cliente.complemento = txtBoxComplemento.Text;
                
                List<ClienteDTO> clientes = new List<ClienteDTO>();
                clientes.Add(cliente);
                string json = JsonConvert.SerializeObject(clientes);                

                Arquivo arq = new Cadastro.Arquivo();
                bool cadastrou =arq.gravacaoArquivos(json); //Gravando conteudo Json no arquivo

                if (cadastrou)
                    MessageBox.Show("Cliente " + cliente.Nome + " cliente.cadastrado com sucesso!");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();

        }

        
    }
}
