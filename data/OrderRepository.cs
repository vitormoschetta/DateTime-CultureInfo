using Dapper;
using Npgsql;

public class OrderRepository
{
    public static void Save(Order order)
    {
        using (var connection = new NpgsqlConnection(
            "Server=localhost;Port=5498;Database=postgres;User Id=postgres;Password=postgres;"))
        {
            connection.Open();
            var sql = @"
                INSERT INTO ""order"" (id, date)
                VALUES (@Id, @Date)";
            connection.Execute(sql, new { Id = order.Id, Date = order.Date3 });
            connection.Close();
        }
    }
}