
namespace ChatServidor
{
    partial class frmChatServidor
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbLogServidor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir Servidor porta 3030";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbLogServidor
            // 
            this.txbLogServidor.Location = new System.Drawing.Point(12, 68);
            this.txbLogServidor.Multiline = true;
            this.txbLogServidor.Name = "txbLogServidor";
            this.txbLogServidor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbLogServidor.Size = new System.Drawing.Size(360, 348);
            this.txbLogServidor.TabIndex = 2;
            // 
            // frmChatServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 428);
            this.Controls.Add(this.txbLogServidor);
            this.Controls.Add(this.button1);
            this.Name = "frmChatServidor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txbLogServidor;
    }
}

