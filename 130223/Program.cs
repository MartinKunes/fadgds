using System.Data.SqlClient;

namespace _130223


{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionDB connectionDB = new ConnectionDB();

            connectionDB.VypisCz();

            connectionDB.VypisCz2("phone");
        }
    }
}