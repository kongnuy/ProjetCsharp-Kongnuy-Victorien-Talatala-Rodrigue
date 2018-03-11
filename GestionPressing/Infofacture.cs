using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GestionPressing
{
    public partial class Infofacture : Form
    {
        public static DataTable tabfacture = new DataTable();
        public Infofacture()
        {
            InitializeComponent();

           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string code_f = Factures.creercode_f();
            Factures facture = new Factures();
            facture.Code_f = code_f;
            facture.Montant = Program.montant;
            facture.Mention = Program.mention;
            facture.Date_creation = Program.datemysql(dtdatedepot.Text);

            Factures.Ajouterfacture(facture);

            switch (Clients.tableauclient[0])
            {
                case "E":
                    foreach (DataRow dr in Program.tabvet.Rows)
                    {
                        string id = Vetements.creeridentifiant();
                        string mle = Convert.ToString(dr["MleClient"]);
                        string idtypvet = Convert.ToString(dr["Idvetement"]);
                        string libtypvet = Convert.ToString(dr["TypeVetement"]);
                        int qte = Convert.ToInt32(dr["Quantite"]);
                        string ddpot = Program.datemysql(dtdatedepot.Text);
                        string ddispo = Program.datemysql(dtdatedispo.Text);

                        int veriff = Vetements.verifiercodetypevetement(libtypvet);

                        if (veriff == 1)
                        {
                           Vetements.Enregistrervetement(id, idtypvet, qte, mle, ddpot, ddispo);

                            Factures.Ajouterlignefacture(code_f, mle, id);

                            MessageBox.Show("Enregistrement reussie");
                        }
                        
                        if (veriff == 0)
                        {
                            string cod = Vetements.creercodetypevetement();
                            string lib = Convert.ToString(dr["TypeVetement"]);
                            int pu_t = Convert.ToInt32(dr["PU_lavage"]);
                            int pu_l = Convert.ToInt32(dr["PU_lavage"]);

                            Vetements.Enregistrertypevetement(cod, lib, pu_t, pu_l);
                            
                            Vetements.Enregistrervetement(id, cod, qte, mle, ddpot, ddispo);

                            Factures.Ajouterlignefacture(code_f, mle, id);

                            MessageBox.Show("Enregistrement reussie");
                        }
                            
                        
                    }
                    break;
                case "N":
                    Clients client = new Clients();
                    client.Mle = Clients.tableauclient[1];
                    client.Nom = Clients.tableauclient[2];
                    client.Prenom = Clients.tableauclient[3];
                    client.Tel= Convert.ToInt32(Clients.tableauclient[4]);
                    client.Quartier = Clients.tableauclient[5];
                    client.Date_ajout = Program.datemysql(dtdatedepot.Text);
                    Clients.Ajouterclient(client);

                    foreach (DataRow dr in Program.tabvet.Rows)
                    {
                        string id = Vetements.creeridentifiant();
                        string mle = Convert.ToString(dr["MleClient"]);
                        string idtypvet = Convert.ToString(dr["Idvetement"]);
                        string libtypvet = Convert.ToString(dr["TypeVetement"]);
                        int qte = Convert.ToInt32(dr["Quantite"]);
                        string ddpot = Program.datemysql(dtdatedepot.Text);
                        string ddispo = Program.datemysql(dtdatedispo.Text);

                        int veriff = Vetements.verifiercodetypevetement(libtypvet);

                        if (veriff == 1)
                        {
                            Vetements.Enregistrervetement(id, idtypvet, qte, mle, ddpot, ddispo);

                            Factures.Ajouterlignefacture(code_f, mle, id);

                            MessageBox.Show("Enregistrement reussie");
                        }

                        if (veriff == 0)
                        {
                            string cod = Vetements.creercodetypevetement();
                            string lib = Convert.ToString(dr["TypeVetement"]);
                            int pu_t = Convert.ToInt32(dr["PU_lavage"]);
                            int pu_l = Convert.ToInt32(dr["PU_lavage"]);

                            Vetements.Enregistrertypevetement(cod, lib, pu_t, pu_l);

                            Vetements.Enregistrervetement(id, cod, qte, mle, ddpot, ddispo);

                            Factures.Ajouterlignefacture(code_f, mle, id);

                            MessageBox.Show("Enregistrement reussie");
                        }
                    }
                    break;
            }
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Infofacture_Load(object sender, EventArgs e)
        {
    

            if (Program.menu != "facture")
            {
                string st = Factures.creercode_f();
                lbltitre.Text = "FACTURE N°" + st+" "+ "du";
                dataGridView1.DataSource = Program.tabvet;
                txttypevetement.DataBindings.Add("Text", Program.tabvet, "TypeVetement");
                txtquantite.DataBindings.Add("Text", Program.tabvet, "Quantite");
                txtpulavage.DataBindings.Add("Text", Program.tabvet, "PU_lavage");
                gbinfoclient.Enabled = false;
                montanttotal.Text = Program.montant.ToString();

                txtmle.Text = Clients.tableauclient[1];
                txtnom.Text = Clients.tableauclient[2];
                txtprenom.Text = Clients.tableauclient[3];
                txttel.Text = Clients.tableauclient[4];
                txtquartier.Text = Clients.tableauclient[5];

            }
            

             if (Program.menu == "facture")
             {
                lbltitre.Text = "FACTURE N°" + Program.code_f +" "+ "du";
                gbinfoclient.Enabled = false;
                dataGridView1.Enabled = false;
                string mle = Factures.mleclient(Program.code_f);
                string[] infoclient = Clients.infoclient(mle);
                txtmle.Text = infoclient[0];
                txtnom.Text = infoclient[1];
                txtprenom.Text = infoclient[2];
                txttel.Text = infoclient[3];
                txtquartier.Text = infoclient[4];

                txttypevetement.Enabled = false;
                txtpulavage.Enabled = false;
                dtdatedepot.Enabled = false;
                dtdatefacture.Enabled = false;
                txtquantite.Enabled = false;
                dtdateretraiteff.Enabled = true;
                btajouter.Enabled = false;
                btretirer.Enabled = false;
                btmodifier.Enabled = false;
                txtmt.Hide();
                //string infovetement = Vetements.infovetement()
                string[] infofacture = Factures.infofacture(Program.code_f);
                montanttotal.Text = infofacture[1];
                
                
                lblmontantpayer.Text = infofacture[2];
                lblmention.Text = Factures.montantapayer(Program.code_f);
                Vetements.tablevetementsfacture.Clear();
                Vetements.affichervetementsfacture(Program.code_f);
                
                dataGridView1.DataSource = Vetements.tablevetementsfacture;

               
                
               
            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btajouter_Click(object sender, EventArgs e)
        {

        }

        private void btannuller_Click(object sender, EventArgs e)
        {
           
            
            this.Close();
        }

        private void txtmle_TextChanged(object sender, EventArgs e)
        {
            
         }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txttypevetement_TextChanged(object sender, EventArgs e)
        {

        }

        void form2_UpdateTextBox(object sender, EventArgs e)
        {
            UpdateTextBoxEventArgs tbea = e as UpdateTextBoxEventArgs;
            this.txtmt.Text = tbea.Text;
        }
        private void btregler_Click(object sender, EventArgs e)
        {
            Program.mp = lblmontantpayer.Text;
            Program.mt = montanttotal.Text;
            Program.rp = lblmention.Text;

            payerfacture form = new payerfacture();
            form.UpdateTextBox += new EventHandler(form2_UpdateTextBox);
            form.ShowDialog();

            
            
        }

        private void txtmt_TextChanged(object sender, EventArgs e)
        {
            int mt = Int32.Parse(txtmt.Text);

            Factures.Modifiermontant(mt, Program.code_f);
            
            Infofacture_Load(null, null);
            
        }
    }
}
