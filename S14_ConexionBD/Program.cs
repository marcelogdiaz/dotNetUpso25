using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14_ConexionBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connecionString = "Data Source=<INSTANCIASQL>; Initial Catalog=Northwind; Integrated Security=true";

            //llamamos a la consulta de productos
            selectProduct(connecionString, 15);
        }

        private static void selectProduct(string connecionString, int precio)
        {
            //armar la query junto con los parametros para realizar la consulta a la BD
            string queryString =
                "SELECT ProductId, ProductName, UnitPrice FROM dbo.Products " +
                "WHERE UnitPrice > @price " +
                "ORDER BY UnitPrice DESC;";

            using (SqlConnection connection = new SqlConnection(connecionString)) { 
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@price", precio);
                try
                {
                    //abrimos la conexion
                    connection.Open();
                    //ejecutamos la consulta
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //formateamos los datos para mostrarlos en pantalla
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    //cerramos la conexion
                    reader.Close();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally {
                    connection.Close();
                }
                Console.ReadLine(); 
            }
        }
    }
}
