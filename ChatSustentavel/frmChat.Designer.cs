
namespace ChatSustentavel
{
    partial class frmChat
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
            this.txbIpServidor = new System.Windows.Forms.TextBox();
            this.lblIpServidor = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txbChat = new System.Windows.Forms.TextBox();
            this.txbMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbIpServidor
            // 
            this.txbIpServidor.Enabled = false;
            this.txbIpServidor.Location = new System.Drawing.Point(80, 25);
            this.txbIpServidor.Name = "txbIpServidor";
            this.txbIpServidor.Size = new System.Drawing.Size(213, 20);
            this.txbIpServidor.TabIndex = 0;
            // 
            // lblIpServidor
            // 
            this.lblIpServidor.AutoSize = true;
            this.lblIpServidor.Location = new System.Drawing.Point(12, 28);
            this.lblIpServidor.Name = "lblIpServidor";
            this.lblIpServidor.Size = new System.Drawing.Size(62, 13);
            this.lblIpServidor.TabIndex = 1;
            this.lblIpServidor.Text = "IP Servidor:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Enabled = false;
            this.txbUsuario.Location = new System.Drawing.Point(80, 60);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(213, 20);
            this.txbUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 67);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(306, 57);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txbChat
            // 
            this.txbChat.Location = new System.Drawing.Point(12, 97);
            this.txbChat.Multiline = true;
            this.txbChat.Name = "txbChat";
            this.txbChat.Size = new System.Drawing.Size(369, 334);
            this.txbChat.TabIndex = 5;
            // 
            // txbMensagem
            // 
            this.txbMensagem.Location = new System.Drawing.Point(12, 453);
            this.txbMensagem.Name = "txbMensagem";
            this.txbMensagem.Size = new System.Drawing.Size(281, 20);
            this.txbMensagem.TabIndex = 6;
            this.txbMensagem.TextChanged += new System.EventHandler(this.txbMensagem_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(306, 450);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 23);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 485);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbMensagem);
            this.Controls.Add(this.txbChat);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblIpServidor);
            this.Controls.Add(this.txbIpServidor);
            this.Name = "frmChat";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIpServidor;
        private System.Windows.Forms.Label lblIpServidor;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txbChat;
        private System.Windows.Forms.TextBox txbMensagem;
        private System.Windows.Forms.Button btnEnviar;
    }
}

