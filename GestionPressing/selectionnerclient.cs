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
    public partial class selectionnerclient : Form
    {
        public event EventHandler UpdateTextBox;
        public selectionnerclient()
        {
            InitializeComponent();
        }

        private void selectionnerclient_Load(object sender, EventArgs e)
        {
            this.Closing += new CancelEventHandler(Form2_Closing);
            Clients.tableclients.Clear();
            Clients.afficherclients();
            BindingSource bsclients = new BindingSource();
            bsclients.DataSource = Clients.tableclients;
            dataGridView1.DataSource = bsclients;
            txtmle.DataBindings.Add("Text", bsclients, "matricule");
            txtnom.DataBindings.Add("Text", bsclients, "nom");
            txtprenom.DataBindings.Add("Text", bsclients, "prenom");
            txttel.DataBindings.Add("Text", bsclients, "telephone");
            txtquartier.DataBindings.Add("Text", bsclients, "quartier");
        }
        void Form2_Closing(object sender, CancelEventArgs e)
        {
            this.OnUpdateTextBox();
        }

        private void OnUpdateTextBox()
        {
            if (this.UpdateTextBox != null)
            {
                UpdateTextBoxEventArgs e = new UpdateTextBoxEventArgs(this.txtmle.Text);
                this.UpdateTextBox.Invoke(this, e);
            }
        }


        private void btannuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btselectionner_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }
    }
}
