using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatarHistóricoCotações
{
    public partial class Form1 : Form
    {
        string caminhoDoArquivo;
        string caminhoParaSalvarArqivo;
        
        public Form1()
        {
            InitializeComponent();
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

            HistóricoCotação histórico = new HistóricoCotação();
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

        private void Salvar_Click(object sender, EventArgs e)
        {
        }
    }
}
