namespace WcfProduct
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using System.Configuration;

    public class ServiceProduct : IServiceProduct
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        public ServiceProduct()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            _connection = new SqlConnection(connectionString.ToString());
            _command = _connection.CreateCommand();
        }

        /// <summary>
        /// Connection.
        /// </summary>
        private SqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        /// <summary>
        /// Command.
        /// </summary>
        public SqlCommand  Command
        {
            get
            {
                return _command;
            }

            set
            {
                _command = value;
            }
        }

        /// <summary>
        /// Вывести таблицу Sale.
        /// </summary>
        /// <returns></returns>
        public List<Sale> SelectSale()
        {
            try
            {

                List<Sale> sales = new List<Sale>();
                Connection.Open();
                Command.CommandText = "SELECT * FROM sale";
                SqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    Sale sale = new Sale();
                    int index = reader.GetOrdinal("idsale");
                    sale.SaleId = Convert.ToInt32(reader[index]);
                    index = reader.GetOrdinal("client_id");
                    sale.ClientId = Convert.ToInt32(reader[index]);
                    index = reader.GetOrdinal("product_id");
                    sale.ProductId = Convert.ToInt32(reader[index]);
                    sales.Add(sale);
                }

                return sales;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            finally
            {
                Connection.Close();
            }
            
        }

        /// <summary>
        /// Добавление клиента в таблицу Client.
        /// </summary>
        /// <param name="clients">Заполненный клиент.</param>
        /// <returns></returns>
        public int InsertClient(Client clients)
        {
            try
            {
                Command.CommandText = "INSERT client  (firstname,lastname) VALUES (@FirstName, @LastName)";
                Command.Parameters.AddWithValue("FirstName", clients.FirstName);
                Command.Parameters.AddWithValue("LastName", clients.LastName);
                Command.CommandType = CommandType.Text;
                Connection.Open();
                return Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Вывести  таблицу Client
        /// </summary>
        /// <returns></returns>
        public List<Client> SelectClient()
        {
            try
            {
                Command.CommandText = "select * from client";
                Connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                List<Client> clients = new List<Client>();

                while (reader.Read())
                {
                    Client client = new Client();
                    int index = reader.GetOrdinal("idclient");
                    client.ClientId = Convert.ToInt32((reader[index]));

                    index = reader.GetOrdinal("firstname");
                    client.FirstName = reader[index].ToString();

                    index = reader.GetOrdinal("lastname");
                    client.LastName = reader[index].ToString();

                    clients.Add(client);
                }

                return clients;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Вывести список Продуктов из таблицы Product.
        /// </summary>
        /// <returns></returns>
        public List<Product> SelectProduct()
        {
            try
            {
                List<Product> products;
                products = new List<Product>();
                Connection.Open();
                Command.CommandText = "select * from product";
                SqlDataReader reader = Command.ExecuteReader();
                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                while (reader.Read())
                {
                    Product Product = new Product();
                    int index = reader.GetOrdinal("idproduct");
                    Product.ProductId = Convert.ToInt32(reader[index]);

                    index = reader.GetOrdinal("expiration_date");
                    Product.ExpirationDate = reader.GetDateTime(index);

                    index = reader.GetOrdinal("name");
                    Product.Name = reader[index].ToString();
                    products.Add(Product);
                }

                return products;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}