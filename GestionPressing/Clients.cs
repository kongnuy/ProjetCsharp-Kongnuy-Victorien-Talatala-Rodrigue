using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionPressing
{
    class Clients
    {
        public static DataTable tableclients = new DataTable();
        
        
        private string mle;
        private string nom;
        private string prenom;
        private int tel;
        private string quartier;
        private string date_ajout;

        public string Mle
        {
            get { return this.mle;}
            set { this.mle = value;}
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public int Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string Quartier
        {
            get { return this.quartier; }
            set { this.quartier = value; }
        }

        public string Date_ajout
        {
            get { return this.date_ajout; }
            set { this.date_ajout = value; }
        }

        public Clients()
        {
            this.mle = "";
            this.nom = "";
            this.prenom = "";
            this.tel = 0;
            this.quartier = "";
            this.date_ajout = "";
        }

        public Clients(string mle, string nom, string prenom, int tel, string quartier, string date_ajout)
        {
            this.mle = mle;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.quartier = quartier;
            this.date_ajout = date_ajout;
        }

        public static string[] tableauclient = new string[6];
        public static string creermatricule()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT matricule FROM clients ORDER BY matricule DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(2);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "CL0" + ng.ToString();

            return nh;
            
        }

        public static string creerdate()
        {
            Random rd = new Random();
            string ann = rd.Next(2010, 2017).ToString();
            string ms = rd.Next(1, 9).ToString();
            string jr = rd.Next(1, 9).ToString();

            if (ms.Length < 2)
            {
                ms = "0" + ms;
            }
            if (jr.Length < 2)
            {
                jr = "0" + jr;
            }
            string dt = ann + "-" + ms + "-" + jr;

            return dt;
        }

        public static int creertel()
        {
            Random telph = new Random();
            string n0 = telph.Next(5, 9).ToString();
            string n1 = telph.Next(0, 9).ToString();
            string n2 = telph.Next(0, 9).ToString();
            string n3 = telph.Next(0, 9).ToString();
            string n4 = telph.Next(0, 9).ToString();
            string n5 = telph.Next(0, 9).ToString();
            string n6 = telph.Next(0, 9).ToString();
            string n7 = telph.Next(0, 9).ToString();

            string t = "6" + n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;
            int tel = Int32.Parse(t);
            return tel;
        }

        public static void afficherclients()
        {
            string req = "SELECT * FROM clients";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);
           
            adp.Fill(Clients.tableclients);
            
            
        }
        

        public static void Ajouterclient(Clients client)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
           
            string req = "INSERT INTO clients VALUES(?client.Mle, ?client.Nom, ?client.Prenom, ?client.Tel, ?client.Quartier, ?client.Date_ajout)";
            cmd = new MySqlCommand(req, Program.con);

            cmd.Parameters.AddWithValue("?client.Mle", client.Mle);
            cmd.Parameters.AddWithValue("?client.Nom", client.Nom);
            cmd.Parameters.AddWithValue("?client.Prenom", client.Prenom);
            cmd.Parameters.AddWithValue("?client.Tel", client.Tel);
            cmd.Parameters.AddWithValue("?client.Quartier", client.Quartier);
            cmd.Parameters.AddWithValue("?client.Date_ajout", client.Date_ajout);
            cmd.ExecuteNonQuery();

            Program.con.Close();
        }
       public static void Modifierclient(string mle, string nm, string prnm, int tel, string qutr)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "UPDATE clients SET nom = '"+ nm+ "', prenom = '"+ prnm +"', telephone = '"+ tel +"', quartier = '"+ qutr +"' WHERE matricule = '"+ mle +"'";
            cmd = new MySqlCommand(req, Program.con);
            cmd.ExecuteNonQuery();
        }

        public static void Supprimerclient(string mle)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();

            string req = "DELETE FROM clients WHERE matricule = '" + mle + "'";
            cmd = new MySqlCommand(req, Program.con);
            cmd.ExecuteNonQuery();
        }

      public static string[] infoclient(string mle)
        {
            Program.seConnecter();
            MySqlCommand cmd;
            cmd = Program.con.CreateCommand();
            cmd = new MySqlCommand("SELECT * FROM clients WHERE matricule = '" + mle + "'", Program.con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string[] tabinfoclient = new string[5];
            while (dr.Read())
            {
                tabinfoclient[0] = dr.GetString(0);
                tabinfoclient[1] = dr.GetString(1);
                tabinfoclient[2] = dr.GetString(2);
                tabinfoclient[3] = dr.GetString(3);
                tabinfoclient[4] = dr.GetString(4);
            }

            return tabinfoclient;
        } 
    }
}
