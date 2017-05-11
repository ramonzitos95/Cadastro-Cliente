using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class ClienteDAO : ClienteDTO
    {
        List<ClienteDTO> listagemClientes = new List<ClienteDTO>();

        public void adicionarCliente(ClienteDTO cliente)
        {
            listagemClientes.Add(cliente);
        }

        public List<ClienteDTO> obterClientes()
        {
            return listagemClientes;
        }

    }
}
