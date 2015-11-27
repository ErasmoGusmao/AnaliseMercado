using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Collections;

namespace FormatarHistóricoCotações
{
    class HistóricoCotação
    {
        public string CaminhoDoArquivo { get; set; }
        public string CaminhoParaSalvarArquivo { get; set; }

        public HistóricoCotação() //Construtor Pega o nome do arquivo de abertura e de salvamento
        {
            CaminhoDoArquivo = "";
            CaminhoParaSalvarArquivo = "";
        }

        public void FormatarArquivoDeCotações(string caminhoDoArquivo, string caminhoParaSalvarArqivo)
        {
            try
            {
                try
                {
                    using (StreamReader reader = new StreamReader(caminhoDoArquivo))
                    {
                        using (StreamWriter writer = new StreamWriter(caminhoParaSalvarArqivo, false))
                        {

                            try
                            {
                                while (!reader.EndOfStream)
                                {
                                    string LinhaDoArquivo = reader.ReadLine();
                                    switch (LinhaDoArquivo.Substring(0, 2))
                                    {
                                        case "00":
                                            DateTime DataGeraçãoArquivo = DateTime.ParseExact(LinhaDoArquivo.Substring(23, 8), "yyyymmdd", DateTimeFormatInfo.InvariantInfo);    //Converte um String em DateTime do cabeçalho
                                            writer.WriteLine(LinhaDoArquivo.Substring(0, 2) + "\t" + LinhaDoArquivo.Substring(2, 13) + "\t" + LinhaDoArquivo.Substring(15, 8) + "\t" + DataGeraçãoArquivo.ToString("dd/mm/yyyy") + "\t" + LinhaDoArquivo.Substring(31, 214));  //Escreve o Cabeçalho
                                            break;

                                        case "01":
                                            DateTime DataPregão = DateTime.ParseExact(LinhaDoArquivo.Substring(2, 8), "yyyymmdd", DateTimeFormatInfo.InvariantInfo);    //Data do pregão
                                            DateTime DataVencimentoOpções = DateTime.ParseExact(LinhaDoArquivo.Substring(202, 8), "yyyymmdd", DateTimeFormatInfo.InvariantInfo);    //Data do vencimento de Opções

                                            //Tratamento dos valores de cotações lidos
                                            decimal PreçoAbertura = decimal.Parse(LinhaDoArquivo.Substring(56, 13)) / 100;
                                            decimal PreçoMáximo = decimal.Parse(LinhaDoArquivo.Substring(69, 13)) / 100;
                                            decimal PreçoMínimo = decimal.Parse(LinhaDoArquivo.Substring(82, 13)) / 100;
                                            decimal PreçoMédio = decimal.Parse(LinhaDoArquivo.Substring(95, 13)) / 100;
                                            decimal PreçoAnterior = decimal.Parse(LinhaDoArquivo.Substring(108, 13)) / 100;
                                            decimal PreçoMelhorCompra = decimal.Parse(LinhaDoArquivo.Substring(121, 13)) / 100;
                                            decimal PreçoMelhorVenda = decimal.Parse(LinhaDoArquivo.Substring(134, 13)) / 100;
                                            decimal VolumeTotalNegociado = decimal.Parse(LinhaDoArquivo.Substring(170, 18)) / 100;
                                            decimal PreçoExercício = decimal.Parse(LinhaDoArquivo.Substring(188, 13)) / 100;

                                            writer.WriteLine(LinhaDoArquivo.Substring(0, 2) + "\t" + DataPregão.ToString("dd/mm/yyyy") + "\t" + LinhaDoArquivo.Substring(10, 2)
                                        + "\t" + LinhaDoArquivo.Substring(12, 12) + "\t" + LinhaDoArquivo.Substring(24, 3) + "\t" + LinhaDoArquivo.Substring(27, 12)
                                        + "\t" + LinhaDoArquivo.Substring(39, 10) + "\t" + LinhaDoArquivo.Substring(49, 3) + "\t" + LinhaDoArquivo.Substring(52, 4)
                                        + "\t" + PreçoAbertura.ToString() + "\t" + PreçoMáximo.ToString() + "\t" + PreçoMínimo.ToString()
                                        + "\t" + PreçoMédio.ToString() + "\t" + PreçoAnterior.ToString() + "\t" + PreçoMelhorCompra.ToString()
                                        + "\t" + PreçoMelhorVenda.ToString() + "\t" + LinhaDoArquivo.Substring(147, 5) + "\t" + LinhaDoArquivo.Substring(152, 18)
                                        + "\t" + VolumeTotalNegociado.ToString() + "\t" + PreçoExercício.ToString() + "\t" + LinhaDoArquivo.Substring(201, 1)
                                        + "\t" + DataVencimentoOpções.ToString("dd/mm/yyyy") + "\t" + LinhaDoArquivo.Substring(210, 7) + "\t" + LinhaDoArquivo.Substring(217, 7)
                                        + "\t" + LinhaDoArquivo.Substring(230, 12) + "\t" + LinhaDoArquivo.Substring(242, 3));
                                            break;

                                        case "99":
                                            DateTime DataGeraçãoArquivoFim = DateTime.ParseExact(LinhaDoArquivo.Substring(23, 8), "yyyymmdd", DateTimeFormatInfo.InvariantInfo);    //Converte um String em DateTime do fim do arquivo
                                            writer.WriteLine(LinhaDoArquivo.Substring(0, 2) + "\t" + LinhaDoArquivo.Substring(2, 13) + "\t" + LinhaDoArquivo.Substring(15, 8) + "\t" + DataGeraçãoArquivoFim.ToString("dd/mm/yyyy") + "\t" + LinhaDoArquivo.Substring(31, 11) + "\t" + LinhaDoArquivo.Substring(42, 203));  //Escreve o Cabeçalho
                                            break;
                                    }
                                }
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Incapaz de ler arquivo com formato errado!", "Sua execução foi invalidada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("ARQUIVO NÃO ENCONTRADO!", "Sua execução foi invalidada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Caminho do arquivo histórico não informado!", "Sua execução foi invalidada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
