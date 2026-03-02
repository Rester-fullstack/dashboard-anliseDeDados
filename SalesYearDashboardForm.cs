using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DashboardVendasApp
{
    public partial class SalesYearDashboardForm : Form
    {
        string conexao = @"Server=DESKTOP-CQC32GO;Database=DashboardVendas;Trusted_Connection=True;";

        public SalesYearDashboardForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarAnos();
        }

        private void CarregarAnos()
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = @"
                SELECT DISTINCT YEAR(Order_Date) AS Ano
                FROM train
                ORDER BY Ano";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbAno.Items.Add(reader["Ano"].ToString());
                }
            }
        }

        private void CarregarFaturamentoAno(int ano)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = @"
                SELECT SUM(Sales)
                FROM train
                WHERE YEAR(Order_Date) = @Ano";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ano", ano);

                decimal faturamento = Convert.ToDecimal(cmd.ExecuteScalar());

                lblFaturamentoAno.Text = faturamento.ToString("C2");
            }
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int anoSelecionado = Convert.ToInt32(cmbAno.SelectedItem);
            CarregarFaturamentoAno(anoSelecionado);
            CarregarTotalPedidosAno(anoSelecionado);
            CarregarTicketMedioAno(anoSelecionado);
            CarregarGraficoMensal(anoSelecionado);
        }

        private void CarregarTotalPedidosAno(int ano)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = @"
                SELECT COUNT(DISTINCT Order_ID)
                FROM train
                WHERE YEAR(Order_Date) = @Ano";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ano", ano);

                int totalPedidos = Convert.ToInt32(cmd.ExecuteScalar());

                lblTotalPedidosAno.Text = totalPedidos.ToString();
            }
        }

        private void CarregarTicketMedioAno(int ano)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = @"
                SELECT 
                    SUM(Sales) / COUNT(DISTINCT Order_ID)
                FROM train
                WHERE YEAR(Order_Date) = @Ano";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ano", ano);

                decimal ticketMedio = Convert.ToDecimal(cmd.ExecuteScalar());

                lblTicketMedioAno.Text = ticketMedio.ToString("C2");
            }
        }

        private void CarregarGraficoMensal(int ano)
        {
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();

                string query = @"
                SELECT 
                    MONTH(Order_Date) AS Mes,
                    SUM(Sales) AS TotalVendas
                FROM train
                WHERE YEAR(Order_Date) = @Ano
                GROUP BY MONTH(Order_Date)
                ORDER BY Mes";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ano", ano);

                SqlDataReader reader = cmd.ExecuteReader();

                chartVendasMensais.Series[0].Points.Clear();

                chartVendasMensais.Series[0].IsValueShownAsLabel = false;
                chartVendasMensais.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                chartVendasMensais.Series[0].MarkerSize = 6;
                chartVendasMensais.Series[0].BorderWidth = 3;
                chartVendasMensais.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartVendasMensais.Legends[0].Enabled = false;

                chartVendasMensais.ChartAreas[0].AxisY.LabelStyle.Format = "C0";
                chartVendasMensais.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartVendasMensais.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

                while (reader.Read())
                {
                    int mesNumero = Convert.ToInt32(reader["Mes"]);
                    decimal total = Convert.ToDecimal(reader["TotalVendas"]);

                    string nomeMes = new DateTime(2024, mesNumero, 1)
                                        .ToString("MMM", new System.Globalization.CultureInfo("pt-BR"));

                    chartVendasMensais.Series[0].Points.AddXY(nomeMes, total);
                }
            }
        }
    }
}