using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sender
{
    public partial class SenderForm : Form
    {
        public SenderForm()
        {
            InitializeComponent();
        }

        Sender sender;

        private void SenderForm_Load(object sender, EventArgs e)
        {
            this.sender = new Sender();
            this.sender.Connect("localhost", 7005);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            this.sender.StartDataStream();
        }
    }
}
