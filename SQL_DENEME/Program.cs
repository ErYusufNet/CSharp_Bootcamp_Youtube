using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Surname: ");
        string surname = Console.ReadLine();

        Console.WriteLine("City: ");
        string city = Console.ReadLine();

        Console.WriteLine("Salary: ");
        decimal salary;
        while (!decimal.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine("Geçerli bir maaş giriniz.");
        }

        Console.WriteLine("Job: ");
        string job = Console.ReadLine();

        try
        {
            InsertEmployeeData(name, surname, city, salary, job);
            Console.WriteLine("Veri başarıyla eklendi!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Veri eklenirken bir hata oluştu: " + ex.Message);
        }
    }

    static void InsertEmployeeData(string name, string surname, string city, decimal salary, string job)
    {
        string connectionString = "Data Source=localhost;Initial Catalog=PersonelDataBase;User ID=your_username;Password=your_password;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO Employee (Name, Surname, City, Salary, Job) VALUES (@Name, @Surname, @City, @Salary, @Job)";
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Surname", surname);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@Job", job);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
