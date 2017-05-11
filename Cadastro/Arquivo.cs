using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public class Arquivo
    {
        public bool gravacaoArquivos(string conteudo)
        {

            string caminho = "C:\\temp";
            string arquivo = "cadastro.txt";

            try
            {
                string pathString = caminho + "\\" + arquivo; //Caminho para gravar o conteudo no arquivo

                if (!System.IO.File.Exists(pathString))
                {
                    System.IO.File.Create(pathString);
                }

                using (StreamWriter writer = new StreamWriter(pathString, true))
                {
                    writer.WriteLine(conteudo);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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

    }
}
