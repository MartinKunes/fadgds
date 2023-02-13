using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130223
{


    internal class ConnectionDB
    {

        private SqlConnection connection;

        public ConnectionDB(){

        SqlConnectionStringBuilder consStringBuilder = new SqlConnectionStringBuilder();
        consStringBuilder.UserID = "sa";
            consStringBuilder.Password = "student";
            consStringBuilder.InitialCatalog = "Cviceni";
            consStringBuilder.DataSource = "PC959";
            consStringBuilder.ConnectTimeout = 30;

            connection = new SqlConnection(consStringBuilder.ConnectionString);
                    connection.Open();
                    Console.WriteLine("Pripojeno");


            }

        public void VypisCz()
        {

            /*   string cmd = "insert into dable(jmeno, prijmeni, vek) values('petra', 'pajaa', 61);";
               using (SqlCommand command = new SqlCommand(cmd, connection))

               {
                   command.ExecuteNonQuery();
               }
            */


            string query2 = "select en.slovo, cz.slovo from en inner join preklad on en.id = preklad.id_en inner join cz on cz.id = preklad.id_cz;";
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
                reader.Close();
            }

        }



        public void VypisCz2( String slovo)
        {

            /*   string cmd = "insert into dable(jmeno, prijmeni, vek) values('petra', 'pajaa', 61);";
               using (SqlCommand command = new SqlCommand(cmd, connection))

               {
                   command.ExecuteNonQuery();
               }
            */


            string query2 = "select en.slovo, cz.slovo from en inner join preklad on en.id = preklad.id_en inner join cz on cz.id = preklad.id_cz;";
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   if(  reader[0].ToString() == slovo ){ 
                    Console.WriteLine(/*reader[0].ToString()*/slovo + " " + reader[1].ToString());
                }
                }
            }

        }




    }
}

