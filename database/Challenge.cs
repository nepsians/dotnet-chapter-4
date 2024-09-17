
using System.Data;
using MySql.Data.MySqlClient;

namespace Chapter4Database{
    class Challenge{
        public static void Main(string[] args){
            string connectionString = "datasource = localhost; port = 3306; username = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);

            Console.Write("Enter the address to search for (or part of the address): ");
            string? searchAddress = Console.ReadLine();

            MySqlDataReader? reader = null;

            // SQL query to search for students by address (using LIKE for partial matching)
            string searchQuery = "SELECT student_id, first_name, last_name, address FROM bca.students WHERE address LIKE CONCAT('%', @Address, '%')";
            
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = new MySqlCommand(searchQuery, connection);
                command.Parameters.AddWithValue("@Address", searchAddress);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    Console.WriteLine("Students living at addresses matching: " + searchAddress);
                    Console.WriteLine("---------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine("ID: {0}, First Name: {1}, Last Name: {2}, Address: {3}",
                            reader["student_id"], reader["first_name"], reader["last_name"], reader["address"]);
                    }
                }
                else
                {
                    Console.WriteLine("No students found at addresses matching: " + searchAddress);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}