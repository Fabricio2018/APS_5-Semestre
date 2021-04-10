using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatSustentavel
{
    public partial class frmChat : Form
    {
        public frmChat()
        {
            public string NomeUsuario = "";
            public StreamWriter stwEnviador;
            public StreamReader strReceptor;
            public TcpClient tcpServidor;

            public delegate void AtualizaLogCallBack(string strMensagem);
            public delegate void FechaConexaoCallBack(string strMotivo);

            public Thread mensagemThread;
            public IPAddress enderecoIP;
            public bool Conectado;

        public void btnConectar_Click(object sender, EventArgs e)
        {
            if (Conectado == false)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado a pedido do usuário");
            }
        }

        public void InicializaConexao()
        {
            enderecoIP = IPAddress.Parse(txbIpServidor.Text);
            tcpServidor = new TcpClient();
            tcpServidor.Connect(enderecoIP, 80);

            Conectado = true;

            NomeUsuario = txbUsuario.Text;

            txbIpServidor.Enabled = false;
            txbUsuario.Enabled = false;
            txbMensagem.Enabled = true;
            btnEnviar.Enabled = true;
            btnConectar.Text = "Desconectado";

            stwEnviador = new StreamWriter(tcpServidor.GetStream());
            stwEnviador.WriteLine(txbUsuario.Text);
            stwEnviador.Flush();

            mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
            mensagemThread.Start();
        }
        public void RecebeMensagens()
        {
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();

            if (ConResposta[0] == 1)
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            
            else
            {
                string Motivo = "Não Conectado: ";
                Motivo += ConResposta.Substring(2, ConResposta.Length -2);
                this.Invoke(new FechaConexaoCallBack(this.FechaConexao), new object[] { "Motivo" });
                return;
            }

            while (Conectado)
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });              
            }
        }

        public void AtualizaLog(string strMensagem)
        {
            txbChat.AppendText(strMensagem + "\r\n");
        }

        public void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviaMensagem();
        }

        public void txbMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        public void EnviaMensagem()
        {
            if (txbMensagem.Lines.Length >= 1)
            {   
                stwEnviador.WriteLine(txbMensagem.Text);
                stwEnviador.Flush();
                txbMensagem.Lines = null;
            }
            txbMensagem.Text = "";
        }
        public void FechaConexao(string Motivo)
        {
         
            txbChat.AppendText(Motivo + "\r\n");
           
            txbIpServidor.Enabled = true;
            txbUsuario.Enabled = true;
            txbMensagem.Enabled = false;
            btnEnviar.Enabled = false;
            btnConectar.Text = "Conectado!";

           
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();
        }
    }
}
