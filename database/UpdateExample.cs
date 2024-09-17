
using System.Data;
using MySql.Data.MySqlClient;

namespace Chapter4Database{
    class UpdateExample{
        public static void Main(string[] args){
            string connectionString = "datasource = localhost; port = 3306; username = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);

            Console.Write("Enter Student ID to update: ");
            int studentId = int.Parse(Console.ReadLine() ?? "");
        
            Console.Write("Enter First Name: ");
            string? firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string? lastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            string? address = Console.ReadLine();

            string updateQuery = "UPDATE bca.students SET first_name = '" + firstName 
                + "', last_name = '" + lastName + "', address = '" + address + "' WHERE student_id = " + studentId;

            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(updateQuery, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record updated successfully.");
                }
                else
                {
                    Console.WriteLine("No record found with the given Student ID.");
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




// string updateQuery = "UPDATE students SET first_name = @FirstName, last_name = @LastName, address = @Address WHERE student_id = @StudentID";
// SqlCommand command = new SqlCommand(updateQuery, connection);
// command.Parameters.AddWithValue("@FirstName", firstName);
// command.Parameters.AddWithValue("@LastName", lastName);
// command.Parameters.AddWithValue("@Address", address);
// command.Parameters.AddWithValue("@StudentID", studentId);