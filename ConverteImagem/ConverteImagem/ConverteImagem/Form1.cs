using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string>();
        string resultado="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.90;
            lblmsg.Text = "";
            btnConverter.Enabled = false;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lbImagens.Items.Clear();
            lista.Clear();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Bmp image(*.bmp)|*.bmp|" + "Jpg image(*.jpg)|*.jpg|" + "Png image(*.png)|*.png|" +
                "Gif image(*.gif)|*.gif|" + "Emf image(*.emf)|*.emf|" + "Exif image(*.exif)|*.exif|" + "Icon image(*.ico)|*.ico|" +
                "Wmf image(*.wmf)|*.wmf|" + "Tiff image(*.tiff)|*.tiff|" + "Todos os Arqs.(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] info = openFileDialog1.FileNames;
                foreach (string s in info)
                {
                    lbImagens.Items.Add(Path.GetFileName(s));
                    lista.Add(s);
                }
            }
       }

        private void btnConverter_Click(object sender, EventArgs e)
        {
             string str="";
             int f = 0;
             int total = lbImagens.Items.Count;
             if (cboFormatoImagem.SelectedIndex >= 0  && total > 0 )
             {
                 str = cboFormatoImagem.Items[cboFormatoImagem.SelectedIndex].ToString();
                 string path = "";

                 foreach (string s in lista)
                 {
                     Image img = Image.FromFile(@s);
                     path = resultado + "\\" + Path.GetFileNameWithoutExtension(s) + "." + str.ToLower();
                     try
                     {
                         switch (str)
                         {
                             case "Bmp":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Bmp);
                                 break;
                             case "Jpg":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Jpeg);
                                 break;
                             case "Gif":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Gif);
                                 break;
                             case "Png":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Png);
                                 break;
                             case "Emf":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Emf);
                                 break;
                             case "Exif":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Exif);
                                 break;
                             case "Ico":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Icon);
                                 break;
                             case "Wmf":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Wmf);
                                 break;
                             case "Tiff":
                                 img.Save(@path, System.Drawing.Imaging.ImageFormat.Tiff);
                                 break;
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Erro : " + ex.Message);
                         return;
                     }
                     f++;
                 }
                 lblmsg.Text = f.ToString() + " Imagem(ens) Convertida(s) com Sucesso !!!";
             }
             else
             {
                 MessageBox.Show("Selecione o formato de sáida ou selecione uma imagem para converter ! !", "*** Alerta ***", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 cboFormatoImagem.Select();
                 cboFormatoImagem.Focus();
             }
        }

        private void btnPastaDestino_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                resultado = folderBrowserDialog1.SelectedPath;
                lblDestino.Text = resultado.ToString();
            }
            btnConverter.Enabled = true;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ? ", "Sair", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboFormatoImagem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
