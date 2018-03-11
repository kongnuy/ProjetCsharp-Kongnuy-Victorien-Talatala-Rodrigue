using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPressing
{
    public partial class payerfacture : Form
    {
        public event EventHandler UpdateTextBox;
        public payerfacture()
        {
            InitializeComponent();

            montanttotal.Text = Program.mt;
            lblmontantpayer.Text = Program.mp;
            lblmention.Text = Program.rp;
        }

        private void payerfacture_Load(object sender, EventArgs e)
        {

            this.Closing += new CancelEventHandler(Form2_Closing);

            
        }

        private void OnUpdateTextBox()
        {
            if (this.UpdateTextBox != null)
            {
                UpdateTextBoxEventArgs e = new UpdateTextBoxEventArgs(this.txtmontant.Text);
                this.UpdateTextBox.Invoke(this, e);
            }
        }

        void Form2_Closing(object sender, CancelEventArgs e)
        {
            this.OnUpdateTextBox();
        }

        private void btimprimer_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
