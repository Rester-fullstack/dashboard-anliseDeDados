namespace DashboardVendasApp
{
    partial class SalesYearDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lblFaturamentoAno = new System.Windows.Forms.Label();
            this.lblTotalPedidosAno = new System.Windows.Forms.Label();
            this.lblTicketMedioAno = new System.Windows.Forms.Label();
            this.chartVendasMensais = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartVendasMensais)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(131, 32);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(222, 21);
            this.cmbAno.TabIndex = 0;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // lblFaturamentoAno
            // 
            this.lblFaturamentoAno.AutoSize = true;
            this.lblFaturamentoAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturamentoAno.Location = new System.Drawing.Point(22, 126);
            this.lblFaturamentoAno.Name = "lblFaturamentoAno";
            this.lblFaturamentoAno.Size = new System.Drawing.Size(21, 20);
            this.lblFaturamentoAno.TabIndex = 1;
            this.lblFaturamentoAno.Text = "...";
            // 
            // lblTotalPedidosAno
            // 
            this.lblTotalPedidosAno.AutoSize = true;
            this.lblTotalPedidosAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidosAno.Location = new System.Drawing.Point(181, 126);
            this.lblTotalPedidosAno.Name = "lblTotalPedidosAno";
            this.lblTotalPedidosAno.Size = new System.Drawing.Size(21, 20);
            this.lblTotalPedidosAno.TabIndex = 2;
            this.lblTotalPedidosAno.Text = "...";
            // 
            // lblTicketMedioAno
            // 
            this.lblTicketMedioAno.AutoSize = true;
            this.lblTicketMedioAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketMedioAno.Location = new System.Drawing.Point(346, 126);
            this.lblTicketMedioAno.Name = "lblTicketMedioAno";
            this.lblTicketMedioAno.Size = new System.Drawing.Size(21, 20);
            this.lblTicketMedioAno.TabIndex = 3;
            this.lblTicketMedioAno.Text = "...";
            // 
            // chartVendasMensais
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVendasMensais.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVendasMensais.Legends.Add(legend1);
            this.chartVendasMensais.Location = new System.Drawing.Point(12, 223);
            this.chartVendasMensais.Name = "chartVendasMensais";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "1 Serie";
            this.chartVendasMensais.Series.Add(series1);
            this.chartVendasMensais.Size = new System.Drawing.Size(483, 215);
            this.chartVendasMensais.TabIndex = 4;
            this.chartVendasMensais.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Faturamento do ano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total de Pedidos no Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ticket Médio do Ano";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartVendasMensais);
            this.Controls.Add(this.lblTicketMedioAno);
            this.Controls.Add(this.lblTotalPedidosAno);
            this.Controls.Add(this.lblFaturamentoAno);
            this.Controls.Add(this.cmbAno);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartVendasMensais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label lblFaturamentoAno;
        private System.Windows.Forms.Label lblTotalPedidosAno;
        private System.Windows.Forms.Label lblTicketMedioAno;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVendasMensais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}