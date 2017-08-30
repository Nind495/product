using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  products.ServiceReference1;

namespace products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Service1Client service = new Service1Client();
            DBGClient.DataSource = service.selectClientAll();
            DBGProduct.DataSource = service.Selectproduct();
            DBGSale.DataSource = service.SelectSaleAll();
        }

        private void BTAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                Tclient client = new Tclient();
                client.Firstname = tbFirstname.Text;
                client.Lastname = tbLastname.Text;
                Service1Client service;
                service = new Service1Client();
                

                if (service.insertClient(client) == 1) ;
                {
                    MessageBox.Show("Запись добавлена");
                    DBGClient.DataSource=service.selectClientAll();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }    
        
          
        }

        private void BTView_Click(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();
            DBGClient.DataSource = service.selectClientAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();
            DBGProduct.DataSource = service.Selectproduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client service = new Service1Client();
            DBGSale.DataSource = service.SelectSaleAll();
            //MessageBox.Show(service.SelectSaleAll());
        }
      
    }
}
