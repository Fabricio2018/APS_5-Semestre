using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public TcpClient Cliente;
        public NetworkStream StreamCliente;
        public StreamWriter EscreveStream;
        public StreamReader LeStream;

        private void button1_Click(object sender, EventArgs e)
        {
            EscreveStream.WriteLine(txbLogServidor.Text);
            EscreveStream.Flush();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Cliente = new TcpClient("192.168.0.198", 3030);
            StreamCliente = Cliente.GetStream();
            EscreveStream = new StreamWriter(StreamCliente);
        }
    }
}
