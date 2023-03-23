using BookKing.DataTransfer;
using BookKing.Models;
using Npgsql;

namespace BookKing.Repository
{
    public class ItemRepository
    {
        private readonly string _connectionString;

        public IEnumerable<Item> ReadItems()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                var command = new NpgsqlCommand("SELECT * FROM items", connection);

                using (var reader = command.ExecuteReader())
                {
                    var users = new List<Item>();

                    while (reader.Read())
                    {
                        var user = new Item
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2)
                        };

                        users.Add(user);
                    }

                    return users;
                }
            }
            return new List<Item>();
        }


        public long UpsertItem(Item item) { 
            return 1; 
        }

        public long DeleteItem(long itemId)
        {
            return 1;
        }
    }
}
