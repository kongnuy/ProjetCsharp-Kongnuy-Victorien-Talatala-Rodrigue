using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionPressing
{
    class Vetements
    {

        public static DataTable tablevetements = new DataTable();
        public static DataTable tablevetementsfacture = new DataTable();

        private string id;
        private string type;
        private string proprietaire;
        private string date_depot;
        private string date_disponibilite;
        private string compartiment;
        private string fiche_lavage;
        private string fiche_repassage;

        public Vetements()
        {
            this.id = "";
            this.type = "";
            this.proprietaire = "";
            this.date_depot = "";
            this.date_disponibilite = "";
            this.compartiment = "";
            this.fiche_lavage = "";
            this.fiche_repassage = "";
        }

        public Vetements(string id, string type, string proprietaire, string date_depot, string date_disponibilite, string compartiment, string fiche_lavage, string fiche_repassage)
        {
            this.id = id;
            this.type = type;
            this.proprietaire = proprietaire;
            this.date_depot = date_depot;
            this.date_disponibilite = date_disponibilite;
            this.compartiment = compartiment;
            this.fiche_lavage = fiche_lavage;
            this.fiche_repassage = fiche_repassage;
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Proprietaire
        {
            get { return this.proprietaire; }
            set { this.proprietaire = value; }
        }

        public string Date_depot
        {
            get { return this.Date_depot; }
            set { this.Date_depot = value; }
        }

        public string Date_disponibilite
        {
            get { return this.date_disponibilite; }
            set { this.date_disponibilite = value; }
        }

        public string Compartiment
        {
            get { return this.compartiment; }
            set { this.compartiment = value; }
        }

        public string Fiche_lavage
        {
            get { return this.fiche_lavage; }
            set { this.fiche_lavage = value; }
        }

        public string Fiche_repassagee
        {
            get { return this.fiche_repassage; }
            set { this.fiche_repassage = value; }
        }

        public static string[] tableauvetement = new string[8];

        public static int verifiercodetypevetement(string lib)
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(libelle) FROM typevetement WHERE libelle='" + lib + "'", Program.con);
            int nb = Convert.ToInt32(cmd.ExecuteScalar());

            if (nb == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }



        }
        public static string creercodetypevetement()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT code_t FROM typevetement ORDER BY code_t DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(3);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "TVT" + ng.ToString();

            return nh;

        }

        public static void Enregistrertypevetement(string code, string libelle, int pu_t, int pu_l)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "INSERT INTO typevetement VALUES(?code, ?lib, ?put, ?pul)";
            cmd = new MySqlCommand(req, Program.con);

            cmd.Parameters.AddWithValue("?code", code);
            cmd.Parameters.AddWithValue("?lib", libelle);
            cmd.Parameters.AddWithValue("?put", pu_t);
            cmd.Parameters.AddWithValue("?pul", pu_l);
            cmd.ExecuteNonQuery();

            Program.con.Close();
        }

        public static string creeridentifiant()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT identifiant FROM vetement ORDER BY identifiant DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(2);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "VT0" + ng.ToString();

            return nh;

        }
        public static void affichervetements()
        {
            string req = "SELECT * FROM vetement";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);

            adp.Fill(Vetements.tablevetements);


        }

        public static void affichervetementsfacture(string code_f)
        {
            string req = "SELECT * FROM vetement WHERE identifiant IN (SELECT vetement FROM lignefacture WHERE code_f='"+ code_f +"')";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);

            adp.Fill(Vetements.tablevetementsfacture);


        }
        public static void Enregistrervetement(string identifiant, string codetypevetement, int quantite, string proprietaire, string date_depot, string date_dispo)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "INSERT INTO vetement VALUES(?id, ?code, ?qte, ?proprio, ?ddpot, ?ddispo, ?deffrt, ?comp, ?fchl, ?fchr)";
            cmd = new MySqlCommand(req, Program.con);

            cmd.Parameters.AddWithValue("?id", identifiant);
            cmd.Parameters.AddWithValue("?code", codetypevetement);
            cmd.Parameters.AddWithValue("?qte", quantite);
            cmd.Parameters.AddWithValue("?proprio", proprietaire);
            cmd.Parameters.AddWithValue("?ddpot", date_depot);
            cmd.Parameters.AddWithValue("?ddispo", date_dispo);
            cmd.Parameters.AddWithValue("?deffrt", null);
            cmd.Parameters.AddWithValue("?comp", null);
            cmd.Parameters.AddWithValue("?fchl", null);
            cmd.Parameters.AddWithValue("?fchr", null);
            cmd.ExecuteNonQuery();

            Program.con.Close();
        }


        public static void Supprimervetement(string id)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "DELETE FROM vetement WHERE identifiant = '" + id + "'";
            cmd = new MySqlCommand(req, Program.con);
            cmd.ExecuteNonQuery();
        }

        public static string[] infovetement(string id)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM vetement WHERE identifiant = '" + id + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string[] tabinfovetement = new string[10];
            while (dr.Read())
            {
                tabinfovetement[0] = dr.GetString(0);
                tabinfovetement[1] = dr.GetString(1);
                tabinfovetement[2] = dr.GetString(2);
                tabinfovetement[3] = dr.GetString(3);
                tabinfovetement[4] = dr.GetString(4);
                tabinfovetement[5] = dr.GetString(5);
                tabinfovetement[6] = dr.GetString(6);
                tabinfovetement[7] = dr.GetString(7);
                tabinfovetement[8] = dr.GetString(8);
                tabinfovetement[9] = dr.GetString(9);
            }

            return tabinfovetement;

        }

        public static string[] infotypevetement(string id)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM typevetement WHERE code_t = '" + id + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string[] tabinfotypevetement = new string[4];
            while (dr.Read())
            {
                tabinfotypevetement[0] = dr.GetString(0);
                tabinfotypevetement[1] = dr.GetString(1);
                tabinfotypevetement[2] = dr.GetString(2);
                tabinfotypevetement[3] = dr.GetString(3);
               
            }

            return tabinfotypevetement;

        }

       
    }
}
