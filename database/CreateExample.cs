
using System.Data;
using MySql.Data.MySqlClient;

namespace Chapter4Database{
    class CreateExample{
        public static void Main(string[] args){
            string connectionString = "datasource = localhost; port = 3306; username = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);

            Console.Write("Enter First Name: ");
            string? firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string? lastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            string? address = Console.ReadLine();

            // string insertQuery = "INSERT INTO bca.students (first_name, last_name, address) VALUES ('" 
            //         + firstName + "', '" + lastName + "', '" + address + "')";

            // Parameterized Query
            string insertQuery = "INSERT INTO bca.students (first_name, last_name, address) VALUES (@FirstName, @LastName, @Address)";

            
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Address", address);
 
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record inserted successfully.");
                }
                else
                {
                    Console.WriteLine("No record inserted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}




