namespace MediaPonderada
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPortugues = new System.Windows.Forms.Label();
            this.textBoxPortugues = new System.Windows.Forms.TextBox();
            this.lblMatematica = new System.Windows.Forms.Label();
            this.textBoxMatematica = new System.Windows.Forms.TextBox();
            this.lblCiencia = new System.Windows.Forms.Label();
            this.textBoxCiencia = new System.Windows.Forms.TextBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(98, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule Media Ponderada";
            // 
            // lblPortugues
            // 
            this.lblPortugues.AutoSize = true;
            this.lblPortugues.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortugues.Location = new System.Drawing.Point(24, 103);
            this.lblPortugues.Name = "lblPortugues";
            this.lblPortugues.Size = new System.Drawing.Size(160, 20);
            this.lblPortugues.TabIndex = 1;
            this.lblPortugues.Text = "Digite nota de portugues:";
            this.lblPortugues.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxPortugues
            // 
            this.textBoxPortugues.Location = new System.Drawing.Point(28, 126);
            this.textBoxPortugues.Name = "textBoxPortugues";
            this.textBoxPortugues.Size = new System.Drawing.Size(168, 20);
            this.textBoxPortugues.TabIndex = 2;
            // 
            // lblMatematica
            // 
            this.lblMatematica.AutoSize = true;
            this.lblMatematica.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatematica.Location = new System.Drawing.Point(27, 169);
            this.lblMatematica.Name = "lblMatematica";
            this.lblMatematica.Size = new System.Drawing.Size(167, 20);
            this.lblMatematica.TabIndex = 3;
            this.lblMatematica.Text = "Digite nota de matemática:";
            // 
            // textBoxMatematica
            // 
            this.textBoxMatematica.Location = new System.Drawing.Point(30, 192);
            this.textBoxMatematica.Name = "textBoxMatematica";
            this.textBoxMatematica.Size = new System.Drawing.Size(165, 20);
            this.textBoxMatematica.TabIndex = 4;
            // 
            // lblCiencia
            // 
            this.lblCiencia.AutoSize = true;
            this.lblCiencia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiencia.Location = new System.Drawing.Point(27, 230);
            this.lblCiencia.Name = "lblCiencia";
            this.lblCiencia.Size = new System.Drawing.Size(144, 20);
            this.lblCiencia.TabIndex = 5;
            this.lblCiencia.Text = "Digite nota de Ciência:";
            // 
            // textBoxCiencia
            // 
            this.textBoxCiencia.Location = new System.Drawing.Point(31, 253);
            this.textBoxCiencia.Name = "textBoxCiencia";
            this.textBoxCiencia.Size = new System.Drawing.Size(165, 20);
            this.textBoxCiencia.TabIndex = 6;
            // 
            // btnClique
            // 
            this.btnClique.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClique.Location = new System.Drawing.Point(59, 318);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(89, 30);
            this.btnClique.TabIndex = 7;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(158, 318);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 30);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(257, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 30);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediaPonderada.Properties.Resources.Mediaponderada;
            this.pictureBox1.Location = new System.Drawing.Point(210, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 360);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.textBoxCiencia);
            this.Controls.Add(this.lblCiencia);
            this.Controls.Add(this.textBoxMatematica);
            this.Controls.Add(this.lblMatematica);
            this.Controls.Add(this.textBoxPortugues);
            this.Controls.Add(this.lblPortugues);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Ponderada";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPortugues;
        private System.Windows.Forms.TextBox textBoxPortugues;
        private System.Windows.Forms.Label lblMatematica;
        private System.Windows.Forms.TextBox textBoxMatematica;
        private System.Windows.Forms.Label lblCiencia;
        private System.Windows.Forms.TextBox textBoxCiencia;
        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

