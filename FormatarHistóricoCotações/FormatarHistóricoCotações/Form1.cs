using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormatarHistóricoCotações
{
    public partial class Form1 : Form
    {
        string caminhoDoArquivo;
        string caminhoDoDiretorio;
        string caminhoParaSalvarArqivo;
        HistóricoCotação histórico; 
        
        public Form1()
        {
            InitializeComponent();
            histórico = new HistóricoCotação();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado";
            saveFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            DialogResult result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                caminhoParaSalvarArqivo = saveFileDialog1.FileName;
            }

            histórico.FormatarArquivoDeCotações(caminhoDoArquivo,caminhoParaSalvarArqivo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado";
            openFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            openFileDialog1.FileName = "Histórico_xx.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                caminhoDoArquivo = openFileDialog1.FileName;
            }
        }

        private void ConcatenaArquivos_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Erasmo\Documents\GitHub\AnaliseMercado";
            openFileDialog1.Filter = "Arquivos de Texto (*.txt)|*.txt";
            openFileDialog1.FileName = "ANO.txt";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileInfo infoArquivo = new FileInfo(Path.GetFullPath(openFileDialog1.FileName));
                caminhoDoDiretorio = infoArquivo.DirectoryName;
            }

            histórico.ConcatenaArquivos(caminhoDoDiretorio);
        }
    }
}
