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
            var users = new List<Item>();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                var command = new NpgsqlCommand("SELECT id, name, image_url, description FROM item", connection);

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        var user = new Item
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            ImageUrl = reader.GetString(2),
                            Description = reader.GetString(3)
                        };

                        users.Add(user);
                    }
                }
            }
            return users;
        }


        public long UpsertItem(Item item) {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                var command = new NpgsqlCommand("INSERT INTO item (id, account_id, name, image_url, description) VALUES ('"+item.Id+"','"+item.AccountId+"','"+item.Name+"','"+item.ImageUrl+"','"+item.Description+ "') ON CONFLICT (id) DO UPDATE SET name = EXCLUDED.name, image_url = EXCLUDED.image_url, description = EXCLUDED.description", connection);

                command.ExecuteScalar();
            }
            return 1;
        }

        public long DeleteItem(long itemId)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                var command = new NpgsqlCommand("DELETE FROM item WHERE id = "+itemId, connection);

                command.ExecuteScalar();
            }
            return 1;
        }
    }
}
