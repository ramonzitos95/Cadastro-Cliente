using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class ClienteDTO
    {
        public int codigo { get; set; }
        public string Nome { get; set; }
        public string dataNascimento { get; set; }
        public string cpf_cnpj { get; set; }
        public string RG_IE { get; set; }
        public string email { get; set; }
        public string telefonePrincipal { get; set; }
        public string telefoneSecundario { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }

        
       

    }
}
