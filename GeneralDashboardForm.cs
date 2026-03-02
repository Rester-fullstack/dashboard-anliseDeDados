using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DashboardVendasApp
{
    public partial class GeneralDashboardForm : Form
    {
        string conexao = @"Server=DESKTOP-CQC32GO;Database=DashboardVendas;Trusted_Connection=True;";


        public GeneralDashboardForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarTotalPedidos();
            CarregarTicketMedio();
        }

        private void CarregarTotalPedidos()
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT COUNT(DISTINCT Order_ID) FROM train";

                SqlCommand cmd = new SqlCommand(query, conn);
                int totalPedidos = (int)cmd.ExecuteScalar();

                lblTotalPedidos.Text = totalPedidos.ToString();
            }
        }

        private void CarregarTicketMedio()
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string query = @"
                SELECT 
                SUM(Sales) / COUNT(DISTINCT Order_ID)
                FROM train";

                SqlCommand cmd = new SqlCommand(query, conn);
                decimal ticketMedio = Convert.ToDecimal(cmd.ExecuteScalar());

                lblTicketMedio.Text = ticketMedio.ToString("C2");
            }
        }

        private void lblTotalPedidos_Click(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            SalesYearDashboardForm yearForm = new SalesYearDashboardForm();
            yearForm.Show();
        }
    }
}
