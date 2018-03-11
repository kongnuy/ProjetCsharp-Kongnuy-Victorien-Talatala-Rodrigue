using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionPressing
{
    class Factures
    {
        public static DataTable tablesfactures = new DataTable();

        private string code_f;
        private double montant;
        private string mention;
        private string date_creation;

        public Factures()
        {
            this.code_f = "";
            this.montant = 0;
            this.mention = "";
            this.date_creation = "";
        }

        public Factures(string code_f, int montant, string mention, string date_creation)
        {
            this.code_f = code_f;
            this.montant = montant;
            this.mention = mention;
            this.date_creation = date_creation;
        }

        public string Code_f
        {
            get { return this.code_f; }
            set { this.code_f = value; }
        }

        public double Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }

        public string Mention
        {
            get { return this.mention; }
            set { this.mention = value; }
        }

        public string Date_creation
        {
            get { return this.date_creation; }
            set { this.date_creation = value; }
        }

        public static string creercode_f()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT code_f FROM facture ORDER BY code_f DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(2);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "FT00" + ng.ToString();

            return nh;

        }

        public static void afficherfacture()
        {
            string req = "SELECT * FROM facture";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);

            adp.Fill(Factures.tablesfactures);


        }

        public static void Ajouterfacture(Factures facture)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "INSERT INTO facture VALUES(?code_f, ?montant, ?mention, ?date_creation)";
            cmd = new MySqlCommand(req, Program.con);

            cmd.Parameters.AddWithValue("?code_f", facture.Code_f);
            cmd.Parameters.AddWithValue("?montant", facture.Montant);
            cmd.Parameters.AddWithValue("?mention", facture.Mention);
            cmd.Parameters.AddWithValue("?date_creation", facture.Date_creation);
            cmd.ExecuteNonQuery();

            Program.con.Close();
        }

        public static void Ajouterlignefacture(string code_f, string mle, string code_v)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "INSERT INTO lignefacture VALUES(?code_f, ?mle, ?code_v)";
            cmd = new MySqlCommand(req, Program.con);

            cmd.Parameters.AddWithValue("?code_f", code_f);
            cmd.Parameters.AddWithValue("?mle", mle);
            cmd.Parameters.AddWithValue("?code_v", code_v); 
            cmd.ExecuteNonQuery();

            Program.con.Close();
        }

        public static string[] infofacture(string code_f)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM facture WHERE code_f = '" + code_f + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string[] tabinfofacture = new string[4];
            while (dr.Read())
            {
                tabinfofacture[0] = dr.GetString(0);
                tabinfofacture[1] = dr.GetString(1);
                tabinfofacture[2] = dr.GetString(2);
                tabinfofacture[3] = dr.GetString(3);
               

            }

            return tabinfofacture;
        }

        public static string mleclient(string code_f)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT DISTINCT mleclient FROM lignefacture WHERE code_f = '" + code_f + "'", Program.con);
            string mle = cmd.ExecuteScalar().ToString();

            return mle;
        }
        public static string montantapayer(string code_f)
        {

            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM facture WHERE code_f = '" + code_f + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string[] tab = new string[2];
            while (dr.Read())
            {
                tab[0] = dr.GetString(1);
                tab[1] = dr.GetString(2);
                

            }

            double mt1 = double.Parse(tab[0]);
            double mt2 = double.Parse(tab[1]);
            double mt3 = mt1 - mt2;

            if (mt3 <= 0)
            {
                return "payer comptant";
            }
            else
            {
                return mt3.ToString();
            }

            


        }

        public static string montantpayer(string code_f)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT montant_payer FROM facture WHERE code_f = '" + code_f + "'", Program.con);
            string mt = cmd.ExecuteScalar().ToString();

            return mt;
        }

        public static void Modifiermontant(int mt, string code_f)
        {

            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            cmd = new MySqlCommand("SELECT montant_payer FROM facture WHERE code_f = '" + code_f + "'", Program.con);
            string mt1 = cmd.ExecuteScalar().ToString();
            int mt2 = Int32.Parse(mt1);
            int mt3 = mt + mt2;

            string req = "UPDATE facture SET montant_payer ='" + mt3 + "' WHERE code_f='"+ code_f +"'";
            cmd = new MySqlCommand(req, Program.con);
            cmd.ExecuteNonQuery();
        }
    }
}
