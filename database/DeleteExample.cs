
using System.Data;
using MySql.Data.MySqlClient;

namespace Chapter4Database{
    class DeleteExample{
        public static void Main(string[] args){
            string connectionString = "datasource = localhost; port = 3306; username = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);

            Console.Write("Enter Student ID to delete: ");
            int studentId = int.Parse(Console.ReadLine() ?? "");

            string deleteQuery = "DELETE FROM students WHERE student_id = " + studentId;
 
            try
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(deleteQuery, connection);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Record deleted successfully.");
                }
                else
                {
                    Console.WriteLine("No record found for the Student ID.");
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



// string deleteQuery = "DELETE FROM students WHERE student_id = @StudentID";

// SqlCommand command = new SqlCommand(deleteQuery, connection);
// command.Parameters.AddWithValue("@StudentID", studentId);