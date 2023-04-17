namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbImagens = new System.Windows.Forms.ListBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPastaDestino = new System.Windows.Forms.Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.cboFormatoImagem = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.lbImagens);
            this.groupBox1.Controls.Add(this.btnProcurar);
            this.groupBox1.Location = new System.Drawing.Point(14, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(453, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Imagem";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(387, 367);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 49);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbImagens
            // 
            this.lbImagens.FormattingEnabled = true;
            this.lbImagens.ItemHeight = 17;
            this.lbImagens.Location = new System.Drawing.Point(14, 38);
            this.lbImagens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbImagens.Name = "lbImagens";
            this.lbImagens.Size = new System.Drawing.Size(366, 378);
            this.lbImagens.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(387, 38);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(60, 38);
            this.btnProcurar.TabIndex = 0;
            this.btnProcurar.Text = "...";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblDestino);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPastaDestino);
            this.groupBox2.Controls.Add(this.lblmsg);
            this.groupBox2.Controls.Add(this.btnConverter);
            this.groupBox2.Controls.Add(this.cboFormatoImagem);
            this.groupBox2.Location = new System.Drawing.Point(473, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(321, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converter Imagem Para";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblDestino
            // 
            this.lblDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestino.Location = new System.Drawing.Point(18, 154);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(285, 94);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "c:\\dados\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasta Destino";
            // 
            // btnPastaDestino
            // 
            this.btnPastaDestino.Location = new System.Drawing.Point(232, 106);
            this.btnPastaDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPastaDestino.Name = "btnPastaDestino";
            this.btnPastaDestino.Size = new System.Drawing.Size(71, 39);
            this.btnPastaDestino.TabIndex = 3;
            this.btnPastaDestino.Text = "...";
            this.btnPastaDestino.UseVisualStyleBackColor = true;
            this.btnPastaDestino.Click += new System.EventHandler(this.btnPastaDestino_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(15, 261);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 17);
            this.lblmsg.TabIndex = 2;
            // 
            // btnConverter
            // 
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverter.Location = new System.Drawing.Point(18, 345);
            this.btnConverter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(285, 71);
            this.btnConverter.TabIndex = 1;
            this.btnConverter.Text = "Converter Imagem(ens)             ";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // cboFormatoImagem
            // 
            this.cboFormatoImagem.FormattingEnabled = true;
            this.cboFormatoImagem.Items.AddRange(new object[] {
            "Bmp",
            "Jpg",
            "Gif",
            "Png",
            "Emf",
            "Exif",
            "Ico",
            "Wmf",
            "Tiff"});
            this.cboFormatoImagem.Location = new System.Drawing.Point(18, 54);
            this.cboFormatoImagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFormatoImagem.Name = "cboFormatoImagem";
            this.cboFormatoImagem.Size = new System.Drawing.Size(285, 25);
            this.cboFormatoImagem.TabIndex = 0;
            this.cboFormatoImagem.Text = "Selecione formato de Saída";
            this.cboFormatoImagem.SelectedIndexChanged += new System.EventHandler(this.cboFormatoImagem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(71, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Converter Imagem para outro Formato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbImagens;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboFormatoImagem;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnPastaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

