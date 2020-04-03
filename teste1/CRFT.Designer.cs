namespace teste1
{
    partial class File_Destino
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_Destino));
            this.button1 = new System.Windows.Forms.Button();
            this.FB_Origem = new System.Windows.Forms.FolderBrowserDialog();
            this.TXT_Origem = new System.Windows.Forms.TextBox();
            this.TXT_selecorigem = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_selecdestino = new System.Windows.Forms.Label();
            this.FB_Destino = new System.Windows.Forms.FolderBrowserDialog();
            this.TXT_Destino = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileorigem = new System.Windows.Forms.OpenFileDialog();
            this.filedestino = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_Origem
            // 
            this.TXT_Origem.Location = new System.Drawing.Point(12, 231);
            this.TXT_Origem.Name = "TXT_Origem";
            this.TXT_Origem.Size = new System.Drawing.Size(211, 20);
            this.TXT_Origem.TabIndex = 1;
            // 
            // TXT_selecorigem
            // 
            this.TXT_selecorigem.AutoSize = true;
            this.TXT_selecorigem.Location = new System.Drawing.Point(28, 116);
            this.TXT_selecorigem.Name = "TXT_selecorigem";
            this.TXT_selecorigem.Size = new System.Drawing.Size(182, 13);
            this.TXT_selecorigem.TabIndex = 2;
            this.TXT_selecorigem.Text = "Selecione o arquivo ou pasta origem:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Selecionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_selecdestino
            // 
            this.txt_selecdestino.AutoSize = true;
            this.txt_selecdestino.Location = new System.Drawing.Point(314, 116);
            this.txt_selecdestino.Name = "txt_selecdestino";
            this.txt_selecdestino.Size = new System.Drawing.Size(132, 13);
            this.txt_selecdestino.TabIndex = 4;
            this.txt_selecdestino.Text = "Selecione a pasta destino:";
            // 
            // TXT_Destino
            // 
            this.TXT_Destino.Location = new System.Drawing.Point(274, 231);
            this.TXT_Destino.Name = "TXT_Destino";
            this.TXT_Destino.Size = new System.Drawing.Size(211, 20);
            this.TXT_Destino.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "INICIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "ROBOCOPY FILE TRANSFER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ATENÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Em casos de transferências entre disco local e fileserver, favor realizar o mapea" +
    "mento do fileserver.";
            // 
            // fileorigem
            // 
            this.fileorigem.FileName = "File_Origem";
            // 
            // filedestino
            // 
            this.filedestino.FileName = "File_Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo de transferência:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(562, 297);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pasta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(562, 321);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Arquivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // File_Destino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 357);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TXT_Destino);
            this.Controls.Add(this.txt_selecdestino);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXT_selecorigem);
            this.Controls.Add(this.TXT_Origem);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "File_Destino";
            this.Text = "CRFT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog FB_Origem;
        private System.Windows.Forms.TextBox TXT_Origem;
        private System.Windows.Forms.Label TXT_selecorigem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txt_selecdestino;
        private System.Windows.Forms.FolderBrowserDialog FB_Destino;
        private System.Windows.Forms.TextBox TXT_Destino;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog fileorigem;
        private System.Windows.Forms.OpenFileDialog filedestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

