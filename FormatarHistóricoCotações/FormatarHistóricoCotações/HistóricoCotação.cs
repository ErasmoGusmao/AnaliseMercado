using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace FormatarHistóricoCotações
{
    class HistóricoCotação
    {
        public void EscreveArquivo()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado\FormatarHistóricoCotações\Arquivos de Testes\DemoCotacoesHistoricas12022003.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado\FormatarHistóricoCotações\Arquivos de Testes\teste2.txt", false))
                {
                    writer.WriteLine("CÓPIA DO ARQUIVO COM HISTÓRICO DE COTAÇÃO");
                    writer.WriteLine("=========================================");

                    while (!reader.EndOfStream) //EndOfStream é a propriedade que informa se não há mais dados restando para ler no arquivo
                    {
                        string linhaCotação = reader.ReadLine();
                        writer.WriteLine("-> " + linhaCotação);
                    }
                    writer.WriteLine("=========================================");
                }
            }
        }

        public void FormatarArquivo() {
            using (StreamReader reader = new StreamReader(@"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado\FormatarHistóricoCotações\Arquivos de Testes\DemoCotacoesHistoricas12022003.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado\FormatarHistóricoCotações\Arquivos de Testes\CotaçãoFormatada.txt", false))
                {
                    while (!reader.EndOfStream)
                    {
                        string linhaCotação = reader.ReadLine(); //Ler linha do arquivo original

                         writer.WriteLine(linhaCotação.Substring(0, 2) + "\t" + linhaCotação.Substring(2, 8) + "\t" + linhaCotação.Substring(10, 2)
                            + "\t" + linhaCotação.Substring(12, 12) + "\t" + linhaCotação.Substring(24, 3) + "\t" + linhaCotação.Substring(27, 12)
                            + "\t" + linhaCotação.Substring(39, 10) + "\t" + linhaCotação.Substring(49, 3) + "\t" + linhaCotação.Substring(52, 4)
                            + "\t" + linhaCotação.Substring(56, 11) + "\t" + linhaCotação.Substring(69, 11) + "\t" + linhaCotação.Substring(82, 11)
                            + "\t" + linhaCotação.Substring(95, 11) + "\t" + linhaCotação.Substring(108, 11) + "\t" + linhaCotação.Substring(121, 11)
                            + "\t" + linhaCotação.Substring(134, 11) + "\t" + linhaCotação.Substring(147, 5) + "\t" + linhaCotação.Substring(152, 18)
                            + "\t" + linhaCotação.Substring(170, 16) + "\t" + linhaCotação.Substring(188, 11) + "\t" + linhaCotação.Substring(201, 1)
                            + "\t" + linhaCotação.Substring(202, 8) + "\t" + linhaCotação.Substring(210, 7) + "\t" + linhaCotação.Substring(217, 7)
                            + "\t" + linhaCotação.Substring(230, 12) + "\t" + linhaCotação.Substring(242, 3));

/*                           writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}\t{18}\t{19}\t{20}\t{21}\t{22}\t{23}\t{24}\t{25}",
                           linhaCotação.Substring(0, 2), data.ToString("dd/mm/yyyy"), linhaCotação.Substring(10, 2),
                           linhaCotação.Substring(12, 12),linhaCotação.Substring(24, 3),linhaCotação.Substring(27, 12),
                           linhaCotação.Substring(39, 10),linhaCotação.Substring(49, 3),linhaCotação.Substring(52, 4),
                           linhaCotação.Substring(56, 11),linhaCotação.Substring(69, 11),linhaCotação.Substring(82, 11),
                           linhaCotação.Substring(95, 11),linhaCotação.Substring(108, 11),linhaCotação.Substring(121, 11),
                           linhaCotação.Substring(134, 11),linhaCotação.Substring(147, 5),linhaCotação.Substring(152, 18),
                           linhaCotação.Substring(170, 16),linhaCotação.Substring(188, 11),linhaCotação.Substring(201, 1),
                           linhaCotação.Substring(202, 8),linhaCotação.Substring(210, 7),linhaCotação.Substring(217, 7),
                           linhaCotação.Substring(230, 12),linhaCotação.Substring(242, 3));
*/                       

                    }
                }
            }
        }

        public void TratarDataTeste() { //Testar algorítio de formatação de data
            using (StreamReader reader = new StreamReader(@"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado\FormatarHistóricoCotações\Arquivos de Testes\Arquivo de Data AAAAMMDD.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado\FormatarHistóricoCotações\Arquivos de Testes\Arquivo de Data CORRIGIDO.txt", false)) {

/*                        string testeData = "20151125";
                          DateTime data = DateTime.ParseExact(testeData, "yyyymmdd", DateTimeFormatInfo.InvariantInfo);
                          writer.WriteLine(data.ToString("dd/mm/yyyy"));
*/
                    while (!reader.EndOfStream) 
                    { 
                    string DataYYYYMMDD = reader.ReadLine(); //Ler linha do arquivo
                    DateTime DataCorrigida = DateTime.ParseExact(DataYYYYMMDD, "yyyymmdd", DateTimeFormatInfo.InvariantInfo); //Converte um String em DateTime
                    writer.WriteLine(DataCorrigida.ToString("dd/mm/yyyy")); //Escreve a data corrigida no novo arquivo
                    }
                }
            }
        }
    }
}
