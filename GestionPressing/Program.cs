using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
namespace GestionPressing
{
    public class UpdateTextBoxEventArgs : EventArgs
    {
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }

        public UpdateTextBoxEventArgs(string text)
        {
            this.text = text;
        }
    }
    
    static class Program
    {
        public static string mle = "";
        public static string menu = "facture";
        public static string btmodifier = "";
        public static MySqlConnection con;
        public static DataTable tabvet;
        public static double montant = 0;
        public static string mention = "Payer comptant";
        public static string code_f = "FT004";
        public static string mt = "";
        public static string mp = "";
        public static string rp = "";


        public static void seConnecter()
        {
            con = new MySqlConnection();
            con.ConnectionString = "database=pressingconjecture; datasource=localhost; userid=root; password= ";
            con.Open();
        }

        public static string datemysql(string dat)
        {
            string dt = dat;
            string ann = dt.Substring(6);
            string ms = dt.Substring(3, 2);
            string jr = dt.Substring(0, 2);


            return ann + "-" + ms + "-" + jr;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formulaireclientele());
        }
    }
}
