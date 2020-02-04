using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expeditapplikationversion1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)

        {



           



        }

        private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
