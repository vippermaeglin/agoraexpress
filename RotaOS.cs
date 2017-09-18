using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agora_Express
{
    public partial class RotaOS : Form
    {
        String Rota;
        public RotaOS(String ROTA)
        {
            Rota = ROTA;
            InitializeComponent();
        }

        private void RotaOS_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new System.Uri(Rota, System.UriKind.Absolute);
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
