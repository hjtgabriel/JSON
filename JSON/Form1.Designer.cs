namespace JSON
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCarnet = new TextBox();
            txtedad = new TextBox();
            txtnombre = new TextBox();
            btnAgregar = new Button();
            btnMostrar = new Button();
            btnElimanar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display Semib", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 22);
            label1.Name = "label1";
            label1.Size = new Size(540, 80);
            label1.TabIndex = 0;
            label1.Text = "Lista de Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label2.Location = new Point(24, 187);
            label2.Name = "label2";
            label2.Size = new Size(187, 27);
            label2.TabIndex = 1;
            label2.Text = "Numero de Carnet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label3.Location = new Point(118, 262);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            label4.Location = new Point(150, 333);
            label4.Name = "label4";
            label4.Size = new Size(61, 27);
            label4.TabIndex = 3;
            label4.Text = "Edad:";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(218, 190);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(176, 27);
            txtCarnet.TabIndex = 4;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(218, 333);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(176, 27);
            txtedad.TabIndex = 5;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(218, 262);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(176, 27);
            txtnombre.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(247, 378);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 42);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            btnMostrar.Location = new Point(422, 400);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(110, 38);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnElimanar
            // 
            btnElimanar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold);
            btnElimanar.Location = new Point(678, 400);
            btnElimanar.Name = "btnElimanar";
            btnElimanar.Size = new Size(110, 38);
            btnElimanar.TabIndex = 9;
            btnElimanar.Text = "Eliminar";
            btnElimanar.UseVisualStyleBackColor = true;
            btnElimanar.Click += btnElimanar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(422, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(366, 213);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnElimanar);
            Controls.Add(btnMostrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtnombre);
            Controls.Add(txtedad);
            Controls.Add(txtCarnet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Estudiantes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCarnet;
        private TextBox txtedad;
        private TextBox txtnombre;
        private Button btnAgregar;
        private Button btnMostrar;
        private Button btnElimanar;
        private DataGridView dataGridView1;
    }
}
