using System;
using System.IO;
using System.Windows.Forms;

namespace AjustaNomes
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pastaCompleta;
            string pasta = "";
            string parent = "";

            pastaCompleta = txtPasta.Text;
            pasta = new DirectoryInfo(pastaCompleta).Name;
            parent = new DirectoryInfo(pastaCompleta).Parent.FullName;

            if (chkRecursivo.Checked)
            {
                MoveDiretorios(pastaCompleta);
            }
            else
            {
                MoveArquivos(pastaCompleta);
            }
        }
        private void MoveDiretorios(string pastaCompleta)
        {
            string[] diretorios = Directory.GetDirectories(pastaCompleta);
            foreach (string item in diretorios)
            {
                MoveDiretorios(item);

                MoveArquivos(item);
                if (DeletaPastas.Checked)
                    Directory.Delete(item);
            }
            if (pastaCompleta != txtPasta.Text)
                MoveArquivos(pastaCompleta);
        }
        private void MoveArquivos(string pastaCompleta)
        {
            string pasta = new DirectoryInfo(pastaCompleta).Name;
            string parent = new DirectoryInfo(pastaCompleta).Parent.FullName;
            string destino;
            string[] arquivos = Directory.GetFiles(pastaCompleta);


            foreach (string itemArq in arquivos)
            {
                destino = parent + @"\" + pasta + "_" + Path.GetFileName(itemArq);

                if (!File.Exists(destino))
                    File.Move(itemArq, destino);
                else
                {
                    ArquivoExiste(itemArq, destino);
                }
            }
        }

        private void ArquivoExiste(string pasta, string destino)
        {
            string destinoOriginal = destino;
            bool tentaNovamente = true;
            while (tentaNovamente)
            {
                i++;
                string nome = destinoOriginal.Substring(0, destinoOriginal.Length - 4);
                string extensao = destinoOriginal.Substring(destinoOriginal.Length - 4, 4);
                destino = nome + "(" + i + ")" + extensao;
                if (!File.Exists(destino))
                {
                    File.Move(pasta, destino);
                    tentaNovamente = false;
                    i = 0;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRecursivo.Checked)
                DeletaPastas.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


