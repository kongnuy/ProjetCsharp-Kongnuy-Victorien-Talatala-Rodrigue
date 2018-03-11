using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionPressing
{
    class Dedomages
    {
        public static DataTable tablesdedomages = new DataTable();

        private string code_d;
        private int montant;
        private string beneficiare;
        private string date_dedomage;

        public Dedomages()
        {
            this.code_d = "";
            this.montant = 0;
            this.beneficiare = "";
            this.date_dedomage = "";
        }

        public Dedomages(string code_d, int montant, string beneficiare, string date_dedomage)
        {
            this.code_d = code_d;
            this.montant = montant;
            this.beneficiare = beneficiare;
            this.date_dedomage = date_dedomage;
        }

        public string Code_d
        {
            get { return this.code_d; }
            set { this.code_d = value; }
        }

        public int Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }

        public string Beneficiare
        {
            get { return this.beneficiare; }
            set { this.beneficiare = value; }
        }

        public string Date_dedomage
        {
            get { return this.date_dedomage; }
            set { this.date_dedomage = value; }
        }


        public static string creermatricule()
        {
            Program.seConnecter();
            MySqlCommand cmd = new MySqlCommand("SELECT code_d FROM dedomagement ORDER BY code_d DESC LIMIT 1", Program.con);
            string nb = cmd.ExecuteScalar().ToString();

            string nf = nb.Substring(2);
            int ng = Int32.Parse(nf);
            ng = ng + 1;
            string nh = "D0" + ng.ToString();

            return nh;

        }

        public static void afficherdedomages()
        {
            string req = "SELECT * FROM dedomagement";
            string cnx = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            MySqlDataAdapter adp = new MySqlDataAdapter(req, cnx);

            adp.Fill(Dedomages.tablesdedomages);


        }
    }
}
