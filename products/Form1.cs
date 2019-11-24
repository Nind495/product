namespace products
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WcfProduct;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceProduct service = new ServiceProduct();
            DBGClient.DataSource = service.SelectClient();
            DBGProduct.DataSource = service.SelectProduct();
            DBGSale.DataSource = service.SelectSale();
        }

        private void BTAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                client.FirstName = tbFirstname.Text;
                client.LastName = tbLastname.Text;
                ServiceProduct service;
                service = new ServiceProduct();
                

                if (service.InsertClient(client) == 1)
                {
                    MessageBox.Show("Запись добавлена");
                    DBGClient.DataSource = service.SelectClient();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }  
        }

        private void BTView_Click(object sender, EventArgs e)
        {
            ServiceProduct service = new ServiceProduct();
            DBGClient.DataSource = service.SelectClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceProduct service = new ServiceProduct();
            DBGProduct.DataSource = service.SelectProduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceProduct service = new ServiceProduct();
            DBGSale.DataSource = service.SelectSale();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}