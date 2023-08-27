using Insulter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsulterWindow
{
    public partial class Insulter : Form
    {
        private Insult insult;
        public Insulter()
        {
            InitializeComponent();
            insult = new Insult();
            lblInsult.Text = insult.Value;
        }

        private void btnInsult_Click(object sender, EventArgs e)
        {
            insult.generateInsult();
            lblInsult.Text = insult.Value;
        }
    }
}
