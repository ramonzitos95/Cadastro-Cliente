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
        Arquivo arq = new Arquivo();
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                string json = arq.lerArquivo();

                var clientes = JsonConvert.DeserializeObject<List<ClienteDTO>>(json); //Deserializando o json

                if (clientes != null)
                {
                    foreach (var c in clientes)
                    {
                        listViewClientes.Items.Add(c.codigo.ToString(), 0);
                        listViewClientes.Items.Add(c.Nome, 1);
                        listViewClientes.Items.Add(c.cpf_cnpj, 2);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Form1 formCadastro = new Form1();
            formCadastro.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<ClienteDTO> clientes = new List<ClienteDTO>();

            if (listViewClientes.SelectedItems.Count > 0)
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if(clientes[i].codigo == Convert.ToInt64(listViewClientes.SelectedItems[0].Text))
                    {
                        clientes.RemoveAt(i);
                        listViewClientes.Items.Remove(listViewClientes.SelectedItems[0]);
                        string json = JsonConvert.SerializeObject(clientes);
                        arq.gravacaoArquivos(json);
                    }
                }
            }
            //listViewClientes.Items.RemoveAt(listViewClientes.SelectedItems.IndexOf);
        }
    }
}
