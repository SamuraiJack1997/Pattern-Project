using ProviderDatabaseLibrary;
using ProviderDatabaseLibrary.Factories;
using ProviderDatabaseLibrary.Interfaces;
using ProviderDatabaseLibrary.Models;
using System.Data;
using System.Windows.Forms;

namespace ProviderGUI
{
    public partial class Form1 : Form
    {
        private IProvider db;//TODO odabir baze za rad
        Provider provider = Provider.Instance;

        public Form1()
        {
            InitializeComponent();
            //TODO Dodavanje podataka za Provajdera iz config.txt fajla pomocu dijaloga

            ////ODABIR BAZE
            provider.setProviderData("SBB", @"Data Source=(localdb)\baza2; Initial Catalog = PROVIDER; Integrated Security = True","MySQL");
            //provider.setProviderData("MTS", @"Data Source=C:\Users\aleks\Desktop\DS_Projekat\PROVIDER.db;","SQLite");

            //Primer povlacenja podataka
            db = ProviderFactory.Provider(provider.getDatabaseType());
            List<Client> clients = new List<Client>();
            clients = db.getAllClients();
            foreach (var client in clients)
            {
                label1.Text += client.ToString()+"\n";
            }

            //poziv funkcije za popunjavanje DataGridView-a
            InitDataGridView1();
            InitDataGridView2();

        }

        private void InitDataGridView1()
        {
            db = ProviderFactory.Provider(provider.getDatabaseType());
            List<Client> clients = new List<Client>();
            clients = db.getAllClients();
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Surname", typeof(string));


            // Add some rows to the DataTable
            foreach (var client in clients)
            {
                dataTable.Rows.Add(
                    client.Username,
                    client.Name,
                    client.Surname
                    );
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;

            // Optionally, you can customize the DataGridView appearance and behavior
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitDataGridView2()
        {
            db = ProviderFactory.Provider(provider.getDatabaseType());
            List<Plan> activatedPlans = new List<Plan>();
            activatedPlans = db.getActivatedClientPlansByClientID(1);//TODO selektovani indeks proslediti

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(float));
            dataTable.Columns.Add("Plan_Type",typeof(string));

            // Add some rows to the DataTable
            foreach (var activatedPlan in activatedPlans)
            {
                dataTable.Rows.Add(
                    activatedPlan.Name,
                    activatedPlan.Price,
                    activatedPlan.getPlanType()
                    );
            }

            // Bind the DataTable to the DataGridView
            dataGridView2.DataSource = dataTable;

            // Optionally, you can customize the DataGridView appearance and behavior
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
