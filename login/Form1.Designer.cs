namespace login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntlogin = new System.Windows.Forms.Button();
            this.bntcancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(18, 89);
            this.txtlogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtlogin.Multiline = true;
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(321, 29);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(18, 150);
            this.txtsenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsenha.Multiline = true;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(321, 29);
            this.txtsenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOGIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "SENHA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bntlogin
            // 
            this.bntlogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntlogin.ForeColor = System.Drawing.Color.White;
            this.bntlogin.Location = new System.Drawing.Point(18, 195);
            this.bntlogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntlogin.Name = "bntlogin";
            this.bntlogin.Size = new System.Drawing.Size(88, 23);
            this.bntlogin.TabIndex = 4;
            this.bntlogin.Text = "LOGIN";
            this.bntlogin.UseVisualStyleBackColor = false;
            this.bntlogin.Click += new System.EventHandler(this.bntlogin_Click);
            // 
            // bntcancelar
            // 
            this.bntcancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bntcancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntcancelar.ForeColor = System.Drawing.Color.White;
            this.bntcancelar.Location = new System.Drawing.Point(251, 195);
            this.bntcancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntcancelar.Name = "bntcancelar";
            this.bntcancelar.Size = new System.Drawing.Size(88, 23);
            this.bntcancelar.TabIndex = 4;
            this.bntcancelar.Text = "CANCELAR";
            this.bntcancelar.UseVisualStyleBackColor = false;
            this.bntcancelar.Click += new System.EventHandler(this.bntcancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIGGOBOOK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntcancelar);
            this.Controls.Add(this.bntlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntlogin;
        private System.Windows.Forms.Button bntcancelar;
        private System.Windows.Forms.Label label1;
    }
}

