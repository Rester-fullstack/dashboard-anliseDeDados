namespace DashboardVendasApp
{
    partial class GeneralDashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTicketMedio = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Pedidos";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.AutoSize = true;
            this.lblTotalPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidos.Location = new System.Drawing.Point(206, 100);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(160, 25);
            this.lblTotalPedidos.TabIndex = 1;
            this.lblTotalPedidos.Text = "lblTotalPedidos";
            this.lblTotalPedidos.Click += new System.EventHandler(this.lblTotalPedidos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ticket Médio";
            // 
            // lblTicketMedio
            // 
            this.lblTicketMedio.AutoSize = true;
            this.lblTicketMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketMedio.Location = new System.Drawing.Point(185, 235);
            this.lblTicketMedio.Name = "lblTicketMedio";
            this.lblTicketMedio.Size = new System.Drawing.Size(151, 25);
            this.lblTicketMedio.TabIndex = 3;
            this.lblTicketMedio.Text = "lblTicketMedio";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(332, 372);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(133, 30);
            this.btnGen.TabIndex = 4;
            this.btnGen.Text = "Next";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // GeneralDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lblTicketMedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalPedidos);
            this.Controls.Add(this.label1);
            this.Name = "GeneralDashboardForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTicketMedio;
        private System.Windows.Forms.Button btnGen;
    }
}