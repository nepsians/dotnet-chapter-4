using System.Data;
using MySql.Data.MySqlClient;

namespace Chapter4Database {
    class FullExample
    {
        MySqlConnection? connection;
        MySqlCommand? command;

        MySqlDataReader? reader = null;


        void CreateConnection()
        {
            string connectionString = "datasource = localhost; port = 3306; username = root; password = root";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        void InsertUpdateDelete(string sqlQuery)
        {
            command = new MySqlCommand(sqlQuery, connection);
            command.ExecuteNonQuery();
            Console.WriteLine("\n****************************************\nOperation performed successfully!!\n****************************************\n");
        }

        void SelectRecords(string sql)
        {
            command = new MySqlCommand (sql, connection);  
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if(dt.Rows.Count > 0) {
                Console.WriteLine(new string('-', 70));
                Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-10} {4,-10}","ID", "Reg ID", "Name", "Marks", "Address");
                Console.WriteLine(new string('-', 70));
             
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string? studentId = dt.Rows[i]["id"].ToString();
                    string? studentRegNo = dt.Rows[i]["reg_id"].ToString();
                    string? studentName = dt.Rows[i]["name"].ToString();
                    string? studentAddress = dt.Rows[i]["address"].ToString();
                    string? studentMarks = dt.Rows[i]["marks"].ToString();


                    Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-10} {4,-10}", studentId, studentRegNo, studentName, studentMarks, studentAddress );
                }
                Console.WriteLine(new string('-', 70));
                Console.WriteLine("\n\n\n");
            }
            else { Console.WriteLine("\n****************\nNo record found\n****************\n"); }
        }
        static void Main(string[] args)
        {
            FullExample obj = new FullExample();

            try
            {
                obj.CreateConnection();
                x: Console.WriteLine("");
                Console.WriteLine(new string('*', 30));
                Console.WriteLine("CONSOLE CRUD APPLICATION:");
                Console.WriteLine(new string('*', 30));

                Console.WriteLine("\n1.Insert\t 2.Update \t3.Delete \t4.Select \t5.Search \t6.Exit");

                Console.Write("\nEnter your choice:\n>> ");
                int n = Convert.ToInt32(Console.ReadLine());
                string sql = "", name = "", address = "";
                int id = 0, regNo, marks;

                switch (n)
                {
                    case 1:
                        Console.Write("\nEnter registration number of the student: \n>> ");
                        regNo = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter name of the student: \n>> ");
                        name = Console.ReadLine() ?? "";

                        Console.Write("\nEnter address of the student: \n>> ");
                        address = Console.ReadLine() ?? "";

                        Console.Write("\nEnter marks of the student: \n>> ");
                        marks = Convert.ToInt32(Console.ReadLine());

                        sql = "INSERT INTO bca.studentinformation (reg_id, name, address, marks) VALUES (" + regNo + ",'" + name + "','" + address + "', "+ marks +")";
                        obj.InsertUpdateDelete(sql);
                        break;

                    case 2:
                        Console.Write("\nEnter student id to be updated: \n>> ");
                        id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter registration number of the student: \n>> ");
                        regNo = Convert.ToInt32(Console.ReadLine());

                        Console.Write("\nEnter name of the student: \n>> ");
                        name = Console.ReadLine() ?? "";

                        Console.Write("\nEnter address of the student: \n>> ");
                        address = Console.ReadLine() ?? "";

                        Console.Write("\nEnter marks of the student: \n>> ");
                        marks = Convert.ToInt32(Console.ReadLine());

                        sql = "UPDATE bca.studentinformation SET reg_id=" + regNo + ",name='" + name + "',address='" + address + "',marks=" + marks + " WHERE id=" + id + "";
                        obj.InsertUpdateDelete(sql);
                        break;

                    case 3:
                        Console.Write("\nEnter studnet id to be deleted:\n>>");
                        id = Convert.ToInt32(Console.ReadLine());
                        sql = "DELETE FROM bca.studentinformation WHERE id=" + id;
                        obj.InsertUpdateDelete(sql);
                        break;

                    case 4:
                        sql = "SELECT * FROM bca.studentinformation";
                        obj.SelectRecords(sql);
                        break;

                    case 5: 
                        Console.Write("\nSearch students: \n>> ");
                        string? searchKey = Console.ReadLine();
                        obj.SearchStudent(searchKey ?? "");
                        break;

                    case 6:
                        goto y;

                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }

                goto x;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        y: Console.WriteLine("Exiting application");
        }

        void SearchStudent(string searchKey){
            string searchQuery = "SELECT reg_id, name, marks, address FROM bca.studentinformation WHERE name LIKE CONCAT('%', @name, '%')";

            MySqlCommand command = new MySqlCommand(searchQuery, connection);
            command.Parameters.AddWithValue("@name", searchKey);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("Students: ");
                Console.WriteLine("---------------------------------------------");

                while (reader.Read())
                {
                    Console.WriteLine("ID: {0}, First Name: {1}, Last Name: {2}, Address: {3}",
                        reader["reg_id"], reader["name"], reader["marks"], reader["address"]);
                }
            }
            else
            {
                Console.WriteLine("No students found");
            }

            reader.Close();

        }
    }

   
}