
using System.Data;
using MySql.Data.MySqlClient;

namespace Chapter4Database{
    class ReadExample{
        public static void Main(string[] args){
            string connectionString = "datasource = localhost; port = 3306; username = root; password = root";
            MySqlConnection connection = new MySqlConnection(connectionString);

            // Specify your SQL query
            string query = "SELECT * FROM bca.students";

            // Create a MySqlDataAdapter
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

            // Create a DataSet to store the retrieved data
            DataSet dataSet = new DataSet();

            try
            {
                // Open the database connection
                connection.Open();

                // Fill the DataSet with data from the database
                adapter.Fill(dataSet, "student");

                // Iterate through the rows in the DataTable
                foreach (DataRow row in dataSet.Tables["student"]!.Rows)
                {
                    // Access data using column names or indices
                    int studentId = Convert.ToInt32(row["student_id"]);
                    string studentName = row["first_name"].ToString() + " " + row["last_name"].ToString();
                    string address = row["address"].ToString() + "";

                    // Print or process the retrieved data
                    Console.WriteLine($"Student ID: {studentId}, Student Name: {studentName}, Address: {address}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }

        }
    }
}