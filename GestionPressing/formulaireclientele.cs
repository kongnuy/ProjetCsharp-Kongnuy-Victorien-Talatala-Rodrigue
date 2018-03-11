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
    public partial class formulaireclientele : Form
    {
        public void vider()
        {
            txtmle.Text = "";
            txtnom.Text = "";
            txtprenom.Text = "";
            txttel.Text = "";
            txtquartier.Text = "";

            txtmle.DataBindings.Clear();
            txtnom.DataBindings.Clear();
            txtprenom.DataBindings.Clear();
            txttel.DataBindings.Clear();
            txtquartier.DataBindings.Clear();
        }
        
        public formulaireclientele()
        {
            InitializeComponent();
           
        }

        private void btquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btajouterclient_Click(object sender, EventArgs e)
        {
            if (Program.menu == "client")
            {
                switch (btajouterclientele.Text)
                {
                    case "Ajouter":
                        gpmodifierclient.Enabled = true;
                        vider();
                        txtmle.Text = Clients.creermatricule();
                        btmodifierclientele.Enabled = false;
                        btsupprimerclientele.Text = "Annuller";
                        btajouterclientele.Text = "Enregistrer";
                        break;

                    case "Enregistrer":
                        string nm = txtnom.Text;
                        string prnm = txtprenom.Text;
                        int tel = Int32.Parse(txttel.Text);
                        string qutr = txtquartier.Text;

                        Clients client = new Clients();
                        client.Mle = Clients.creermatricule();
                        client.Nom = nm;
                        client.Prenom = prnm;
                        client.Tel = tel;
                        client.Quartier = qutr;
                        client.Date_ajout = Clients.creerdate();
                        Clients.Ajouterclient(client);

                        MessageBox.Show("Enregistrement reussie");
                        txtmle.Text = "";
                        txtnom.Text = "";
                        txtprenom.Text = "";
                        txttel.Text = "";
                        txtquartier.Text = "";
                        btajouterclientele.Text = "Ajouter";
                        btsupprimerclientele.Text = "Supprimer";
                        btmodifierclientele.Enabled = true;
                        gpmodifierclient.Enabled = false;
                        formulaireclientele_Load(null, null);
                        break;
                }
            }
            
            if (Program.menu == "vetement")
            {
                formulairevetement formvet = new formulairevetement();
                formvet.Show();
            }
        }

        private void btmodifierclient_Click(object sender, EventArgs e)
        {
          
            switch (btmodifierclientele.Text)
                {
                    case "Modifier":
                        switch (Program.menu)
                        {
                            case "client":
                                gpmodifierclient.Enabled = true;
                                btmodifierclientele.Text = "Confirmer";
                                btsupprimerclientele.Text = "Annuller";
                                btajouterclientele.Enabled = false;
                                break;
                            case "facture":
                                Program.code_f = txtidvet.Text;
                                Infofacture modfacture = new Infofacture();
                                modfacture.Show();
                                break;
                        }

                    
                         break;

                    case "Confirmer":
                        string mle = txtmle.Text;
                        string nm = txtnom.Text;
                        string prnm = txtprenom.Text;
                        int tel = Int32.Parse(txttel.Text);
                        string qutr = txtquartier.Text;

                        Clients.Modifierclient(mle, nm, prnm, tel, qutr);
                        btmodifierclientele.Text = "Modifier";
                        btsupprimerclientele.Text = "Supprimer";
                        MessageBox.Show("Modification effectuée");
                        gpmodifierclient.Enabled = false;
                        btajouterclientele.Enabled = true;
                        gpmodifierclient.Enabled = false;
                        formulaireclientele_Load(null, null);
                        break;
                }

            /*
            if (Program.menu == "vetement")
            {
                Program.btmodifier = "modifiervetement";
                formulairevetement formvet = new formulairevetement();
                formvet.Show();
            }*/
        
    }
    

    private void btsupprimerclient_Click(object sender, EventArgs e)
        {
                
            switch (btsupprimerclientele.Text)
            {
                case "Annuller":
                    formulaireclientele_Load(null, null);
                    btmodifierclientele.Enabled = true;
                    btsupprimerclientele.Text = "Supprimer";
                    btajouterclientele.Text = "Ajouter";
                    btmodifierclientele.Text = "Modifier";
                    btajouterclientele.Enabled = true;
                    gpmodifierclient.Enabled = false;
                    break;

                case "Supprimer":
                    switch (Program.menu)
                    {
                        case "client":
                            string mle = txtmle.Text;
                            DialogResult Confirmation = MessageBox.Show("Vous êtes sur le point de supprimer ce client", "Confirmation Supression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (Confirmation == DialogResult.OK)
                            {
                                Clients.Supprimerclient(mle);
                                MessageBox.Show("Suppression reussie");
                                formulaireclientele_Load(null, null);
                            }
                            break;

                        case "vetement":
                            string id = txtidvet.Text;
                            DialogResult Confirmation1 = MessageBox.Show("Vous êtes sur le point de supprimer ce vetement", "Confirmation Supression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                            if (Confirmation1 == DialogResult.OK)
                            {
                                Vetements.Supprimervetement(id);
                                MessageBox.Show("Suppression reussie");
                                formulaireclientele_Load(null, null);
                            }
                            break;
                    }


                    if (Program.menu == "vetement")
                    {

                    }
                    break;
            }

           
            //}
        }

        private void formulaireclientele_Load(object sender, EventArgs e)
        {
            
            btclients.BackColor = Color.LightSteelBlue;
            btvetements.BackColor = Color.Transparent;
            btfactures.BackColor = Color.Transparent;
            btdedomages.BackColor = Color.Transparent;
            txtidvet.Hide();
            vider();
            
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

        private void gbajoutmodifsupprquit_Enter(object sender, EventArgs e)
        {

        }

        private void btvetements_Click(object sender, EventArgs e)
        {
           

            vider();
            Program.menu = "vetement";
            gpmodifierclient.Hide();
            gpdatagrid1.Size = new Size(700, 307);
            dataGridView1.Size = new Size(690, 293);
            Vetements.tablevetements.Clear();
            Vetements.affichervetements();
            dataGridView1.DataSource = Vetements.tablevetements;
            txtidvet.DataBindings.Clear();
            txtidvet.DataBindings.Add("Text", Vetements.tablevetements, "identifiant");
            btvetements.BackColor = Color.LightSteelBlue;
            btclients.BackColor = Color.Transparent;
            btfactures.BackColor = Color.Transparent;
            btdedomages.BackColor = Color.Transparent;
            btajouterclientele.Text = "Ajouter";
            radioButton1.Text = "Date de depot";
            radioButton2.Text = "proprietaire";
            radioButton3.Hide();
            cbquartier.Hide();
            btmodifierclientele.Enabled = false;
            bttrier.Location = new Point(451, 37);
        }

        private void btclients_Click(object sender, EventArgs e)
        {
            vider();
            Program.menu = "client";
            gpmodifierclient.Show();
            gpdatagrid1.Size = new Size(571, 307);
            dataGridView1.Size = new Size(559, 293);
            Clients.afficherclients();
            BindingSource bsclients = new BindingSource();
            bsclients.DataSource = Clients.tableclients;
            dataGridView1.DataSource = bsclients;
            txtmle.DataBindings.Add("Text", bsclients, "matricule");
            txtnom.DataBindings.Add("Text", bsclients, "nom");
            txtprenom.DataBindings.Add("Text", bsclients, "prenom");
            txttel.DataBindings.Add("Text", bsclients, "telephone");
            txtquartier.DataBindings.Add("Text", bsclients, "quartier");

            btclients.BackColor = Color.LightSteelBlue;
            btvetements.BackColor = Color.Transparent;
            btfactures.BackColor = Color.Transparent;
            btdedomages.BackColor = Color.Transparent;
            radioButton1.Text = "Date";
            radioButton2.Text = "Nom";
            radioButton3.Text = "Quartier";
            btajouterclientele.Text = "Ajouter";
            radioButton3.Show();
            cbquartier.Show();
            bttrier.Location = new Point(582, 34);
        }
      

        private void btfactures_Click(object sender, EventArgs e)
        {
            Program.menu = "facture";
            vider();
            gpmodifierclient.Hide();
            gpdatagrid1.Size = new Size(700, 307);
            dataGridView1.Size = new Size(690, 293);
            Factures.afficherfacture();
            dataGridView1.DataSource = Factures.tablesfactures;
            txtidvet.DataBindings.Clear();
            txtidvet.DataBindings.Add("Text", Factures.tablesfactures, "code_f");
            btfactures.BackColor = Color.LightSteelBlue;
            btclients.BackColor = Color.Transparent;
            btvetements.BackColor = Color.Transparent;
            btdedomages.BackColor = Color.Transparent;
            radioButton1.Text = "Date";
            radioButton2.Text = "Client";
            radioButton3.Text = "Mention";
            btajouterclientele.Text = "Imprimer";
            btmodifierclientele.Enabled = true;
            radioButton3.Show();
            cbquartier.Show();
            bttrier.Location = new Point(582, 34);
        }

        private void btdedomages_Click(object sender, EventArgs e)
        {
            vider();
            gpmodifierclient.Hide();
            gpdatagrid1.Size = new Size(700, 307);
            dataGridView1.Size = new Size(690, 293);
            Dedomages.afficherdedomages();
            dataGridView1.DataSource = Dedomages.tablesdedomages;
            txtidvet.DataBindings.Clear();
            txtidvet.DataBindings.Add("Text", Dedomages.tablesdedomages, "code_d");
            btdedomages.BackColor = Color.LightSteelBlue;
            btfactures.BackColor = Color.Transparent;
            btclients.BackColor = Color.Transparent;
            btvetements.BackColor = Color.Transparent;
            btajouterclientele.Text = "Ajouter";
            radioButton1.Text = "Date";
            radioButton2.Text = "Beneficiare";
            radioButton3.Hide();
            cbquartier.Hide();
            bttrier.Location = new Point(451, 37);
        }

        private void bttrier_Click(object sender, EventArgs e)
        {
            string d = Factures.creercode_f();  
            MessageBox.Show(d);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
