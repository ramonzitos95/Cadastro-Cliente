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
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            List<ClienteDAO> clientes = new List<ClienteDAO>();
            string json = lerArquivo();
            // MessageBox.Show(json);  
            ClienteDAO cliente = JsonConvert.DeserializeObject<ClienteDAO>(json); //Deserializando o json
            clientes = cliente.obterClientes();
            foreach (var c in clientes) //Adicionando clientes na lista
            {
                cliente.adicionarCliente(c);
            }

            foreach (var c in clientes)
            {
                listViewClientes.Items.Add(c.codigo.ToString(), 0);
                listViewClientes.Items.Add(c.Nome, 1);
                listViewClientes.Items.Add(c.cpf_cnpj, 2);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form1 formCadastro = new Form1();
            formCadastro.Show();
        }

        public string lerArquivo()
        {
            string pathString = "C:\\temp\\cadastro.txt";
            string retorno = "";
            using (StreamReader reader = new StreamReader(pathString, true))
            {
                retorno = reader.ReadLine();
            }

            return retorno;
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
