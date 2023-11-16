namespace appFP.secuenciales
{
    partial class _01
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
            lblMujeres = new Label();
            lblvarones = new Label();
            txtmujeres = new TextBox();
            txtvarones = new TextBox();
            btnCalcular = new Button();
            lblPMujeres = new Label();
            lblPVarones = new Label();
            SuspendLayout();
            // 
            // lblMujeres
            // 
            lblMujeres.AutoSize = true;
            lblMujeres.Location = new Point(39, 43);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(52, 15);
            lblMujeres.TabIndex = 0;
            lblMujeres.Text = "Mujeres:";
            lblMujeres.Click += label1_Click;
            // 
            // lblvarones
            // 
            lblvarones.AutoSize = true;
            lblvarones.Location = new Point(40, 96);
            lblvarones.Name = "lblvarones";
            lblvarones.Size = new Size(51, 15);
            lblvarones.TabIndex = 0;
            lblvarones.Text = "Varones:";
            // 
            // txtmujeres
            // 
            txtmujeres.Location = new Point(110, 40);
            txtmujeres.Name = "txtmujeres";
            txtmujeres.Size = new Size(57, 23);
            txtmujeres.TabIndex = 1;
            txtmujeres.TextChanged += textBox1_TextChanged;
            // 
            // txtvarones
            // 
            txtvarones.Location = new Point(110, 93);
            txtvarones.Name = "txtvarones";
            txtvarones.Size = new Size(57, 23);
            txtvarones.TabIndex = 2;
            txtvarones.TextChanged += textBox1_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(92, 158);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPMujeres
            // 
            lblPMujeres.AutoSize = true;
            lblPMujeres.Location = new Point(198, 43);
            lblPMujeres.Name = "lblPMujeres";
            lblPMujeres.Size = new Size(17, 15);
            lblPMujeres.TabIndex = 0;
            lblPMujeres.Text = "%";
            lblPMujeres.Click += label1_Click;
            // 
            // lblPVarones
            // 
            lblPVarones.AutoSize = true;
            lblPVarones.Location = new Point(198, 101);
            lblPVarones.Name = "lblPVarones";
            lblPVarones.Size = new Size(17, 15);
            lblPVarones.TabIndex = 0;
            lblPVarones.Text = "%";
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 210);
            Controls.Add(btnCalcular);
            Controls.Add(txtvarones);
            Controls.Add(txtmujeres);
            Controls.Add(lblPVarones);
            Controls.Add(lblvarones);
            Controls.Add(lblPMujeres);
            Controls.Add(lblMujeres);
            Name = "_01";
            Text = "_01";
            Load += _01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMujeres;
        private Label lblvarones;
        private TextBox txtmujeres;
        private TextBox txtvarones;
        private Button btnCalcular;
        private Label lblPMujeres;
        private Label lblPVarones;
    }
}