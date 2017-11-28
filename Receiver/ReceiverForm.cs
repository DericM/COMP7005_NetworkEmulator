using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receiver
{
    public partial class ReceiverForm : Form
    {
        public ReceiverForm()
        {
            InitializeComponent();
        }

        Receiver receiver;

        private void ReceiverForm_Load(object sender, EventArgs e)
        {
            receiver = new Receiver();
            receiver.connect();
        }
    }
}
