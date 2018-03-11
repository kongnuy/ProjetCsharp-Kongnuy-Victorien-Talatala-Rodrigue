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
    public partial class formulairevetement : Form
    {
        static bool v = false;
        MySqlConnection cnx;
        MySqlDataAdapter adp;
        public static DataTable tabtypevet;
        BindingSource bstypevet;
        public string cod2;
        public string typv;
       
        public formulairevetement()
        {
            InitializeComponent();

            Program.tabvet = new DataTable();
            Program.tabvet.Columns.Add("MleClient", Type.GetType("System.String"));
            Program.tabvet.Columns.Add("Idvetement", Type.GetType("System.String"));
            Program.tabvet.Columns.Add("TypeVetement", Type.GetType("System.String"));
            Program.tabvet.Columns.Add("Quantite", Type.GetType("System.Double"));
            Program.tabvet.Columns.Add("PU_lavage", Type.GetType("System.Double"));
            Program.tabvet.Columns.Add("PU_traitement", Type.GetType("System.Double"));
            Program.tabvet.Columns.Add("Total", Type.GetType("System.Double"), "Quantite * PU_lavage");

            dataGridView1.DataSource = Program.tabvet;

            

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }  

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            if (rdclientexistant.Checked == true)
            {
                txtmle.Enabled = false;
                txtnom.Enabled =false;
                txtprenom.Enabled =false;
                txttel.Enabled = false;
                txtquartier.Enabled = false;

                selectionnerclient formclient = new selectionnerclient();
                formclient.UpdateTextBox += new EventHandler(form2_UpdateTextBox);
                formclient.ShowDialog();
                              
            }
            
            
        }

        private void formulairevetement_Load(object sender, EventArgs e)
        {
            if (Program.btmodifier == "")
            {
                rdexistanttype.Checked = true;
                txtcompartiment.Enabled = false;
                txtfichelavage.Enabled = false;
                txtficherepassage.Enabled = false;
                dtdateeffretrait.Enabled = false;
                txtcod.Hide();
                txtmle.Enabled = false;
                txtnom.Enabled = false;
                txtprenom.Enabled = false;
                txttel.Enabled = false;
                txtquartier.Enabled = false;
                rdclientnouveau.Checked = true;            
            }

            if (Program.btmodifier == "modifiervetement")
            {
               
                dataGridView1.DataSource = Vetements.tablevetements;

                txtmle.DataBindings.Add("Text", Vetements.tablevetements, "proprietaire");
                txtcod.DataBindings.Add("Text", Vetements.tablevetements, "type_v");
                txtquantitevetement.DataBindings.Add("Text", Vetements.tablevetements, "Quantite");
                dtdatedepotvetement.DataBindings.Add("Text", Vetements.tablevetements, "date_depot");
                dtdatedispovetement.DataBindings.Add("Text", Vetements.tablevetements, "date_disponibilite");
                dtdatedepotvetement.Enabled = false;
                gpinfoclient.Enabled = false;
                rdexistanttype.Enabled = false;
                rdnouveautype.Enabled = false;
                txtpulavage.Enabled = false;
                txtputraitementtype.Enabled = false;
                cbtypevetement.Enabled = false;
                txtcod.Hide();
                dtdatedispovetement.Enabled = false;
                dtdateeffretrait.Enabled = false;
                btcreerfacture.Hide();
                txtquantitevetement.Enabled = true;
                
            }
        }

        private void btannuller_Click(object sender, EventArgs e)
        {
           
            
        }
        void form2_UpdateTextBox(object sender, EventArgs e)
        {
            UpdateTextBoxEventArgs tbea = e as UpdateTextBoxEventArgs;
            this.txtmle.Text = tbea.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            formulairevetement_Load(null, null);
        }

        private void txtmle_TextChanged(object sender, EventArgs e)
        {
            Program.mle = txtmle.Text;
            if (Program.mle != "")
            {
                Program.seConnecter();
                MySqlCommand cmd;
                cmd = Program.con.CreateCommand();
                cmd = new MySqlCommand("SELECT * FROM clients WHERE matricule = '" + Program.mle + "'", Program.con);
                MySqlDataReader dr = cmd.ExecuteReader();

                string mle;
                string nm;
                string prnm;
                int tel;
                string quartier;

                while (dr.Read())
                {
                    mle = dr.GetString(0);
                    nm = dr.GetString(1);
                    prnm = dr.GetString(2);
                    tel = Int32.Parse(dr.GetString(3));
                    quartier = dr.GetString(4);

                    txtmle.Text = mle;
                    txtnom.Text = nm;
                    txtprenom.Text = prnm;
                    txttel.Text = tel.ToString();
                    txtquartier.Text = quartier;
                }



            }
        }

        private void rdclientnouveau_CheckedChanged(object sender, EventArgs e)
        {
            if (rdclientnouveau.Checked == true)
            {
                txtmle.Text = Clients.creermatricule();
                txtnom.Text = "";
                txtprenom.Text = "";
                txttel.Text = "";
                txtquartier.Text = "";

                txtmle.Enabled = false;
                txtnom.Enabled = true;
                txtprenom.Enabled = true;
                txttel.Enabled = true;
                txtquartier.Enabled = true;
            }
            
        }

        private void rdexistanttype_CheckedChanged(object sender, EventArgs e)
        {
            
            cbtypevetement.Show();
            if (rdexistanttype.Checked == true)
            {
               
                cnx = new MySqlConnection("database=pressingconjecture; datasource=localhost; userid=root; password= ");
                string req = "SELECT * FROM typevetement";
                adp = new MySqlDataAdapter(req, cnx);
                tabtypevet = new DataTable();
                adp.Fill(tabtypevet);
                adp.FillSchema(tabtypevet, SchemaType.Source);
                bstypevet = new BindingSource();
                bstypevet.DataSource = tabtypevet;
                bstypevet.Sort = "libelle asc";
                cbtypevetement.DataSource = bstypevet;
                cbtypevetement.DisplayMember = "libelle";
                cbtypevetement.ValueMember = "code_t";


                if (v == false)
                {
                   
                    txtcod.DataBindings.Add("Text", bstypevet, "code_t");
                    v = true;
                }
                

                txtputraitementtype.Enabled = false;
                txtpulavage.Enabled = false;


            }

        }

        private void cbtypevetement_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM typevetement WHERE libelle = '" + cbtypevetement.Text + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string put;
            string pul;
            while (dr.Read())
            {
                put = dr.GetString(2);
                pul = dr.GetString(3);
              
                txtputraitementtype.Text = put;
                txtpulavage.Text = pul;
                
            }
            

        }

        private void rdnouveautype_CheckedChanged(object sender, EventArgs e)
        {
           

            if (rdnouveautype.Checked == true)
            {
                v = false;
                txtcod.DataBindings.Clear();
                cbtypevetement.Hide();
                txttypevetement.Enabled = true;
                txtputraitementtype.Enabled = true;
                txtpulavage.Enabled = true;
                txttypevetement.Text = Vetements.creercodetypevetement();
                txttypevetement.Text = "";
                txtputraitementtype.Text = "";
                txtpulavage.Text = "";
                txtquantitevetement.Text = "";
            }
        }

        private void btenregistrer_Click(object sender, EventArgs e)
        {
            if (Program.btmodifier == "")
            {
           
                    if (rdclientexistant.Checked == true)
                    {
                        Clients.tableauclient[0] = "E";
                    }
                    if (rdclientnouveau.Checked == true)
                    {
                        Clients.tableauclient[0] = "N";
                    }
                    Clients.tableauclient[1] = txtmle.Text;
                    Clients.tableauclient[2] = txtnom.Text;
                    Clients.tableauclient[3] = txtprenom.Text;
                    Clients.tableauclient[4] = txttel.Text;
                    Clients.tableauclient[5] = txtquartier.Text;
            
                    if (rdexistanttype.Checked == true)
                    {
                        Vetements.tableauvetement[0] = "E";
                        typv = cbtypevetement.Text;
                    }
                    if (rdnouveautype.Checked == true)
                    {
                        Vetements.tableauvetement[0] = "N";
                        typv = txttypevetement.Text;
                    }

                    Vetements.tableauvetement[1] = cbtypevetement.Text;
                    Vetements.tableauvetement[2] = txttypevetement.Text;
                    Vetements.tableauvetement[3] = txtputraitementtype.Text;
                    Vetements.tableauvetement[4] = txtpulavage.Text;
                    Vetements.tableauvetement[5] = txtquantitevetement.Text;
                    Vetements.tableauvetement[6] = dtdatedepotvetement.Text;
                    Vetements.tableauvetement[7] = dtdatedispovetement.Text;

                    DataRow dr = Program.tabvet.NewRow();
                    dr["MleClient"] = txtmle.Text;
                    dr["Idvetement"] = txtcod.Text;
                    dr["TypeVetement"] = typv;
                    dr["Quantite"] = txtquantitevetement.Text;
                    dr["PU_lavage"] = txtpulavage.Text;
                    dr["PU_traitement"] = txtputraitementtype.Text;
                    Program.tabvet.Rows.Add(dr);

                    dataGridView1.Refresh();
                    gpinfoclient.Enabled = false;
            }
        }

        private void btcreerfacture_Click(object sender, EventArgs e)
        {
            object ob;
            ob = Program.tabvet.Compute("Sum(Total)", "MleClient='"+ txtmle.Text +"'");
            Program.montant = Convert.ToDouble(ob);
             
            Infofacture formfacture = new Infofacture();
            formfacture.Show();
            this.Close();
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM typevetement WHERE code_t = '" + txtcod.Text + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                cbtypevetement.Text = dr.GetString(1);
                txtputraitementtype.Text = dr.GetString(2);
                txtpulavage.Text = dr.GetString(3);
            }

        }
    }
}
