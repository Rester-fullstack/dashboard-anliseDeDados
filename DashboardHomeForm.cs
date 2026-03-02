using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardVendasApp
{
    public partial class DashboardHomeForm : Form
    {
        string conexao = @"Server=DESKTOP-CQC32GO;Database=DashboardVendas;Trusted_Connection=True;";

        public DashboardHomeForm()
        {
            InitializeComponent();
            CarregarResumo();
            CarregarGraficoRegiao();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CarregarResumo()
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT FaturamentoTotal FROM vw_ResumoDashboard";

                SqlCommand cmd = new SqlCommand(query, conn);
                var resultado = cmd.ExecuteScalar();

                label1.Text = "Faturamento Total: " + Convert.ToDecimal(resultado).ToString("C");
            }
        }

        private void CarregarGraficoRegiao()
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                string query = "SELECT Region, TotalVendas FROM vw_VendasPorRegiao";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                chart1.Series.Clear();
                chart1.Series.Add("Vendas");

                while (reader.Read())
                {
                    chart1.Series["Vendas"].Points.AddXY(
                        reader["Region"].ToString(),
                        Convert.ToDecimal(reader["TotalVendas"])
                    );
                }
            }
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            GeneralDashboardForm overview = new GeneralDashboardForm();
            overview.Show();
        }
    }
}