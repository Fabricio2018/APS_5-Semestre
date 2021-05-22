using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServidor
{
    public partial class frmChatServidor : Form
    {
        public frmChatServidor()
        {
            InitializeComponent();
        }
        



        private void button1_Click(object sender, EventArgs e)
        {
            Servidor servidor = new Servidor(txbLogServidor);
        }
    }
}
