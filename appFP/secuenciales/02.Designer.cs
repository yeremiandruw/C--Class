namespace appFP.secuenciales
{
    partial class _02
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
            lblmetros = new Label();
            lblcentimetros = new Label();
            lblpies = new Label();
            lblpulgadas = new Label();
            lblyardas = new Label();
            txtmetros = new TextBox();
            txtcentimetros = new TextBox();
            txtpulgadas = new TextBox();
            txtpies = new TextBox();
            txtyardas = new TextBox();
            btncalcular = new Button();
            SuspendLayout();
            // 
            // lblmetros
            // 
            lblmetros.AutoSize = true;
            lblmetros.Location = new Point(56, 30);
            lblmetros.Name = "lblmetros";
            lblmetros.Size = new Size(44, 15);
            lblmetros.TabIndex = 0;
            lblmetros.Text = "Metros";
            lblmetros.Click += label3_Click;
            // 
            // lblcentimetros
            // 
            lblcentimetros.AutoSize = true;
            lblcentimetros.Location = new Point(56, 81);
            lblcentimetros.Name = "lblcentimetros";
            lblcentimetros.Size = new Size(72, 15);
            lblcentimetros.TabIndex = 0;
            lblcentimetros.Text = "Centimetros";
            // 
            // lblpies
            // 
            lblpies.AutoSize = true;
            lblpies.Location = new Point(56, 187);
            lblpies.Name = "lblpies";
            lblpies.Size = new Size(28, 15);
            lblpies.TabIndex = 0;
            lblpies.Text = "Pies";
            lblpies.Click += label5_Click;
            // 
            // lblpulgadas
            // 
            lblpulgadas.AutoSize = true;
            lblpulgadas.Location = new Point(56, 134);
            lblpulgadas.Name = "lblpulgadas";
            lblpulgadas.Size = new Size(55, 15);
            lblpulgadas.TabIndex = 0;
            lblpulgadas.Text = "Pulgadas";
            // 
            // lblyardas
            // 
            lblyardas.AutoSize = true;
            lblyardas.Location = new Point(56, 236);
            lblyardas.Name = "lblyardas";
            lblyardas.Size = new Size(41, 15);
            lblyardas.TabIndex = 0;
            lblyardas.Text = "Yardas";
            lblyardas.Click += label8_Click;
            // 
            // txtmetros
            // 
            txtmetros.Location = new Point(160, 27);
            txtmetros.Name = "txtmetros";
            txtmetros.Size = new Size(57, 23);
            txtmetros.TabIndex = 1;
            txtmetros.TextChanged += txtmetros_TextChanged;
            // 
            // txtcentimetros
            // 
            txtcentimetros.Location = new Point(160, 81);
            txtcentimetros.Name = "txtcentimetros";
            txtcentimetros.Size = new Size(57, 23);
            txtcentimetros.TabIndex = 1;
            // 
            // txtpulgadas
            // 
            txtpulgadas.Location = new Point(160, 134);
            txtpulgadas.Name = "txtpulgadas";
            txtpulgadas.Size = new Size(57, 23);
            txtpulgadas.TabIndex = 1;
            // 
            // txtpies
            // 
            txtpies.Location = new Point(160, 184);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(57, 23);
            txtpies.TabIndex = 1;
            // 
            // txtyardas
            // 
            txtyardas.Location = new Point(160, 233);
            txtyardas.Name = "txtyardas";
            txtyardas.Size = new Size(57, 23);
            txtyardas.TabIndex = 1;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(103, 292);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 2;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 359);
            Controls.Add(btncalcular);
            Controls.Add(txtyardas);
            Controls.Add(txtpies);
            Controls.Add(txtpulgadas);
            Controls.Add(txtcentimetros);
            Controls.Add(txtmetros);
            Controls.Add(lblyardas);
            Controls.Add(lblpulgadas);
            Controls.Add(lblpies);
            Controls.Add(lblcentimetros);
            Controls.Add(lblmetros);
            Name = "_02";
            Text = "_02";
            Load += _02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmetros;
        private Label lblcentimetros;
        private Label lblpies;
        private Label lblpulgadas;
        private Label lblyardas;
        private TextBox txtmetros;
        private TextBox txtcentimetros;
        private TextBox txtpulgadas;
        private TextBox txtpies;
        private TextBox txtyardas;
        private Button btncalcular;
    }
}