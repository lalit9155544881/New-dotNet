using MySql.Data.MySqlClient;
using System;

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Port=3306;Database=Gla;User ID=root;Password=Lalit@123";

        using (MySqlConnection con = new MySqlConnection(connectionString))
        {
            try
            {   
                con.Open();
                Console.WriteLine("MySQL Database Connected Successfully!");

                // Insert data into student table
                string insertQuery = "INSERT INTO student (id, name, age, course) VALUES (@id, @name, @age, @course)";
                using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@id", 1);
                    insertCmd.Parameters.AddWithValue("@name", "John Doe");
                    insertCmd.Parameters.AddWithValue("@age", 20);
                    insertCmd.Parameters.AddWithValue("@course", "Computer Science");
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }

                // Select and display data
                string query = "SELECT * FROM student";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["id"]} - {reader["name"]} - {reader["age"]} - {reader["course"]}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}