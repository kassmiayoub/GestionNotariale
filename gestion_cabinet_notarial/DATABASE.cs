using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cabinet_notarial
{
     static class DATABASE
    {
        public static string ConnectionString { get; set; } = "data source=.;initial catalog =gestion_cabinet_cotarial;integrated security=True;";
        public static SqlConnection Connection;
        public static SqlConnection GetConnetion
        {
            get
            {
                Connection = new SqlConnection(ConnectionString);
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();
                return Connection;
            }
        }
        static public void createDirectory()
        {
            if (!Directory.Exists("C:\\NotarialBackup"))
            {
                Directory.CreateDirectory("C:\\NotarialBackup");

            }
        }
        public static void BackUpDataBase(string path)
        {
            createDirectory();
            string FileName;
            //try
            //{
                FileName = $"GestionCabinetNotarial_{DateTime.Now.ToString("ddMMyyyyHHmmss")}.BAK";
            //    int i = 0;
            //    do
            //    {
            //        i++;
            //        FileName = $"AVOCATMAROC-{DateTime.Now.ToString("dd-MM-yyyy")}-{i}.BAK";
            //    } while (File.Exists($"{TextBoxSavePath.Text}\\{FileName}"));
                SqlCommand SC = new SqlCommand($@"BACKUP DATABASE gestion_cabinet_cotarial TO DISK = 'C:\\NotarialBackup\\{FileName}'", GetConnetion);
                //{ TextBoxSavePath.Text}\\{ FileName}
                SC.ExecuteNonQuery();                

                /****************************************************************************************
                                   La base  de données s'enregistre  sur le disque C
                            après cela le fichier sera copié au chemin qui a choisis l'utilisateur
                            car l'écriture d'aprés sql server faut Privilège administrateur
                 ***************************************************************************************/

                    File.Copy($"C:\\NotarialBackup\\{FileName}", $"{path}\\{FileName}", true);
        }
        static public void Restordatabase(string path)
        {            
            FileInfo fileInfo = new FileInfo(path);
            if (!Directory.Exists($"C:\\NotarialBackup\\{ fileInfo.Name}"))
            {
                File.Copy(path, $"C:\\NotarialBackup\\{fileInfo.Name}", true);
            }
            var SC =
                new SqlCommand($@"USE master; ALTER DATABASE gestion_cabinet_cotarial SET SINGLE_USER WITH ROLLBACK IMMEDIATE 
                                RESTORE DATABASE gestion_cabinet_cotarial FROM DISK = 'C:\\NotarialBackup\\{fileInfo.Name}' 
                                with replace
                                ALTER DATABASE gestion_cabinet_cotarial SET MULTI_USER",
                    GetConnetion);
            SC.ExecuteNonQuery();
        }
        static public SqlDataAdapter getinfocabinet()
        {
            DataTable dt = new DataTable();
           // SqlCommand sc = new  SqlCommand("select [Typeclient],[Nom],[Prenom] from [dbo].[partes] p inner join [dbo].[client] c on c.idClient = p.idClient  where p.numdossier = 122", GetConnetion);
            //SqlDataReader sdr = sc.ExecuteReader();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select [Typeclient],[Nom],[Prenom] from [dbo].[partes] p inner join [dbo].[client] c on c.idClient = p.idClient  where p.numdossier = {THEME.numdossier}", GetConnetion);
           // dt.Load(sdr);
            return sqlDataAdapter;
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zéro";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " milliard ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Mille ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Cent ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";

                var unitsMap = new[] { "zéro", "Un", "deux", "Troi", "Quatre", "Cinq", "six", "Sept", "huit", "neuf", "Dix", "Onze", "Douze", "treize", "Quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
                var tensMap = new[] { "zéro", "Dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}
