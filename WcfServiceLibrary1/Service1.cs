using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using WcfServiceLibrary1;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Security.Cryptography.X509Certificates;
using    System.Windows;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.

    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectDB();
        }

        private SqlConnection connection;
        private SqlCommand comand;
        private SqlConnectionStringBuilder strSqlConnect;
        private DataTable ClientTable;
        private DataTable saleTable;
        private DataTable ProductTable;

        public List<Tsale> SelectSaleAll()
        {
               List<Tsale> sales = new List<Tsale>();
               
                
            /*string strCommand = "Select * from sale ";
            comand.CommandText = strCommand;*/
            DataTableReader reader;
            reader = saleTable.CreateDataReader();
            while (reader.Read())
            {
                Tsale sale = new Tsale();
                int index = reader.GetOrdinal("idsale");
                sale.idsale = Convert.ToInt32(reader[index]);
                index = reader.GetOrdinal("client_id");
                sale.client_id = Convert.ToInt32(reader[index]);
                index = reader.GetOrdinal("product_id");
                sale.product_id = Convert.ToInt32(reader[index]);
                index = reader.GetOrdinal("rn_ktk");
                sale.rn_ktk = Convert.ToInt64(reader[index]);
                sales.Add(sale);
            }
        
            return sales;


        }
        void ConnectDB()
        {
            try
            {
                strSqlConnect = new SqlConnectionStringBuilder();
                strSqlConnect.DataSource =
                    @"APOLLO-PS\SQLEXPRESS"; //Возвращает или задает имя или сетевой адрес экземпляра SQL Server, с которым устанавливается соединение.
                strSqlConnect.InitialCatalog =
                    "BaseDevice"; //Возвращает или задает имя базы данных, связанной с подключением.
                strSqlConnect.Encrypt =
                    true; //Возвращает или задает логическое значение, указывающее, использует ли SQL Server шифрование 
                strSqlConnect.TrustServerCertificate =
                    true; //Возвращает или задает значение, указывающее, будет ли шифроваться канал, если обход цепочки сертификатов для проверки доверия не выполняется
                strSqlConnect.ConnectTimeout =
                    30; //Получает или задает продолжительность времени ожидания подключения к серверу (в секундах) перед прекращением попытки подключения и созданием ошибки
                strSqlConnect.AsynchronousProcessing =
                    true; //Возвращает или задает логическое значение, указывающее, допускается ли асинхронная обработка соединением, созданным с использованием данной строки подключения.
                strSqlConnect.MultipleActiveResultSets =
                    true; //Если указано значение true, приложение может поддерживать несколько активных наборов результатов (режим MARS). Если указано значение false, приложение должно обработать или отменить все наборы результатов из одного пакета, прежде чем выполнять любой другой пакет для данного подключения.
                strSqlConnect.IntegratedSecurity =
                    true; //Возвращает или задает логическое значение, определяющее способ проверки подлинности: либо при подключении указаны идентификатор пользователя и пароль (значение false), либо использованы учетные данные текущей учетной записи Windows (значение true).

                connection = new SqlConnection(strSqlConnect.ToString());
                comand = connection.CreateCommand();
                //***********Создаем виртуальную таблицу клиентов************
                string strCommand = "select * from client";
                comand.CommandText = strCommand;
                ClientTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comand);
                adapter.Fill(ClientTable);
                //**************************************************

                //***********Создаем виртуальную таблицу Продаж************
                strCommand = "select * from sale";
                comand.CommandText = strCommand;
                saleTable = new DataTable();
                adapter.SelectCommand = comand;
                adapter.Fill(saleTable);
                //**************************************************
                //***********Создаем виртуальную таблицу продуктов************
                strCommand = "select * from product";
                comand.CommandText = strCommand;
                ProductTable = new DataTable();
                adapter.SelectCommand = comand;
                adapter.Fill(ProductTable);
                //**************************************************




            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int insertProduct(TProduct product)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            return 6;
        }



        public int insertClient(Tclient clients)
        {
            try
            {
                comand.CommandText = "insert client  (firstname,lastname) values (@firstn, @lastn)";

                comand.Parameters.Add("firstn", clients.Firstname);
                comand.Parameters.Add("lastn", clients.Lastname);
                comand.CommandType = CommandType.Text;
                connection.Open();
                return comand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Tclient> SelectClient()
        {
            comand.CommandText = "select * from client";
            comand.CommandType = CommandType.Text;
            connection.Open();
            SqlDataReader reader = comand.ExecuteReader();
            List<Tclient> clients = new List<Tclient>();
            while (reader.Read())
            {
                Tclient client = new Tclient();
                int index = reader.GetOrdinal("idclient");
                client.Idclient = Convert.ToInt32((reader[index]));

                index = reader.GetOrdinal("firstname");
                client.Firstname = reader[index].ToString();

                index = reader.GetOrdinal("lastname");
                client.Lastname = reader[index].ToString();

                clients.Add(client);
            }
            return clients;


        }

        public List<TProduct> Selectproduct()
        {
            List<TProduct> products;
            products = new List<TProduct>();

            comand.CommandText = "select * from product";
            comand.CommandType = CommandType.Text;
            connection.Open();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                TProduct Product = new TProduct();
                int index = reader.GetOrdinal("idproduct");
                Product.Idproduct = Convert.ToInt32(reader[index]);

                index = reader.GetOrdinal("expiration_date");
                Product.Expiration_date = reader.GetDateTime(index);

                index = reader.GetOrdinal("name");
                Product.Name = reader[index].ToString();
                products.Add(Product);

            }




            return products;
        }

        public List<Tclient> selectClientAll()
        {
            string strCommand = "select * from client";
            comand.CommandText = strCommand;
            ClientTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            adapter.Fill(ClientTable);
            DataTableReader reader;
            reader = ClientTable.CreateDataReader();
            List<Tclient> clients = new List<Tclient>();
            while (reader.Read())
            {
                Tclient client = new Tclient();
                int index = reader.GetOrdinal("idclient");
                client.Idclient = Convert.ToInt32((reader[index]));

                index = reader.GetOrdinal("firstname");
                client.Firstname = reader[index].ToString();

                index = reader.GetOrdinal("lastname");
                client.Lastname = reader[index].ToString();

                clients.Add(client);
            }
            return clients;



        }

    }
}



