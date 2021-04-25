using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServidor
{
    class Servidor
    {
        public Servidor(System.Windows.Forms.TextBox txbLogServidor)
        {
            this.txbLogServidor = txbLogServidor;
            ThreadServidor = new Thread(ServidorRodando);
            ThreadServidor.Start();
            ThreadServidor.IsBackground = true;
        }

        public System.Windows.Forms.TextBox txbLogServidor;
        public Thread ThreadServidor;
        public delegate void ClienteConectado(TcpClient Conexao);


        public void ServidorRodando()
        {
            int ClientesConectados = 0;
            TcpListener EscutandoPorta = new TcpListener(3030);
            EscutandoPorta.Start();

            txbLogServidor.Text = "Aguardando Conexões";

            while (true)
            {
                TcpClient Conexao;
                Conexao = EscutandoPorta.AcceptTcpClient();

                EscutandoCliente(Conexao);

            }
        }

        public void EscutandoCliente(TcpClient Conexao)
        {
            while(true)
            {

                txbLogServidor.Text += "\r\nAlgo aconteceu";
                NetworkStream stream = Conexao.GetStream();
                StreamReader sr = new StreamReader(Conexao.GetStream());

                txbLogServidor.Text += "\r\r" + sr.ReadLine();
            }

        }

    }
}
