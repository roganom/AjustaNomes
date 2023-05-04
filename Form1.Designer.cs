namespace AjustaNomes
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.chkRecursivo = new System.Windows.Forms.CheckBox();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.DeletaPastas = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnEscolherPasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(537, 120);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(135, 46);
            this.btnExecutar.TabIndex = 5;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkRecursivo
            // 
            this.chkRecursivo.AutoSize = true;
            this.chkRecursivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecursivo.Location = new System.Drawing.Point(32, 109);
            this.chkRecursivo.Name = "chkRecursivo";
            this.chkRecursivo.Size = new System.Drawing.Size(113, 28);
            this.chkRecursivo.TabIndex = 3;
            this.chkRecursivo.Text = "Recursivo";
            this.chkRecursivo.UseVisualStyleBackColor = true;
            this.chkRecursivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPasta
            // 
            this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasta.Location = new System.Drawing.Point(32, 67);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(640, 26);
            this.txtPasta.TabIndex = 2;
            // 
            // DeletaPastas
            // 
            this.DeletaPastas.AutoSize = true;
            this.DeletaPastas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletaPastas.Location = new System.Drawing.Point(32, 138);
            this.DeletaPastas.Name = "DeletaPastas";
            this.DeletaPastas.Size = new System.Drawing.Size(177, 28);
            this.DeletaPastas.TabIndex = 4;
            this.DeletaPastas.Text = "Deletar subpastas";
            this.DeletaPastas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a pasta a organizar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEscolherPasta
            // 
            this.btnEscolherPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolherPasta.Location = new System.Drawing.Point(274, 27);
            this.btnEscolherPasta.Name = "btnEscolherPasta";
            this.btnEscolherPasta.Size = new System.Drawing.Size(107, 31);
            this.btnEscolherPasta.TabIndex = 1;
            this.btnEscolherPasta.Text = "Escolher pasta";
            this.btnEscolherPasta.UseVisualStyleBackColor = true;
            this.btnEscolherPasta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 201);
            this.Controls.Add(this.btnEscolherPasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletaPastas);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.chkRecursivo);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "Ajusta nomes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.CheckBox chkRecursivo;
        private System.Windows.Forms.TextBox textTexto;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.CheckBox DeletaPastas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnEscolherPasta;
    }
}

