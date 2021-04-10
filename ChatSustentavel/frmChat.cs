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
            InitializeComponent();
            public string NomeUsuario = "";
            public StreamWriter stwEnviador;
            public StreamReader strReceptor;
            public TcpClient tcpServidor;

            public delegate void AtualizaLogCallBack(string strMensagem);
            public delegate void FechaConexaoCallBack(string strMotivo);

            public Thread mensagemThread;
            public IPAddress enderecoIP;
            public bool Conectado;

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (Conectado == false)
            {
                InicializaConexao();
            }
            else
            {
               
            }
        }

        private void InicializaConexao()
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
        private void RecebeMensagens()
        {
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();

            if (ConResposta[0] == 1)
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
        }
    }
}
