namespace UI
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSueldoBrutoAgregar = new TextBox();
            txtDNIAgregar = new TextBox();
            txtNombreApellidoAgregar = new TextBox();
            btnCrearEmpleado = new Button();
            dgvEmpleados = new DataGridView();
            btnAgregarEmpleados = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSueldoBrutoAgregar);
            groupBox1.Controls.Add(txtDNIAgregar);
            groupBox1.Controls.Add(txtNombreApellidoAgregar);
            groupBox1.Controls.Add(btnCrearEmpleado);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 165);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 6;
            label3.Text = "Sueldo Bruto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 108);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "DNI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre y Apellido";
            // 
            // txtSueldoBrutoAgregar
            // 
            txtSueldoBrutoAgregar.Location = new Point(323, 162);
            txtSueldoBrutoAgregar.Name = "txtSueldoBrutoAgregar";
            txtSueldoBrutoAgregar.Size = new Size(237, 27);
            txtSueldoBrutoAgregar.TabIndex = 3;
            // 
            // txtDNIAgregar
            // 
            txtDNIAgregar.Location = new Point(323, 105);
            txtDNIAgregar.Name = "txtDNIAgregar";
            txtDNIAgregar.Size = new Size(237, 27);
            txtDNIAgregar.TabIndex = 2;
            // 
            // txtNombreApellidoAgregar
            // 
            txtNombreApellidoAgregar.Location = new Point(323, 48);
            txtNombreApellidoAgregar.Name = "txtNombreApellidoAgregar";
            txtNombreApellidoAgregar.Size = new Size(237, 27);
            txtNombreApellidoAgregar.TabIndex = 1;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(12, 217);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(548, 142);
            btnCrearEmpleado.TabIndex = 0;
            btnCrearEmpleado.Text = "CrearEmpleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += button1_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(572, 12);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(650, 353);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAgregarEmpleados
            // 
            btnAgregarEmpleados.Location = new Point(1023, 398);
            btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            btnAgregarEmpleados.Size = new Size(199, 72);
            btnAgregarEmpleados.TabIndex = 1;
            btnAgregarEmpleados.Text = "Agregar Empleados";
            btnAgregarEmpleados.UseVisualStyleBackColor = true;
            btnAgregarEmpleados.Click += btnAgregarEmpleados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 622);
            Controls.Add(btnAgregarEmpleados);
            Controls.Add(dgvEmpleados);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvEmpleados;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSueldoBrutoAgregar;
        private TextBox txtDNIAgregar;
        private TextBox txtNombreApellidoAgregar;
        private Button btnCrearEmpleado;
        private Button btnAgregarEmpleados;
    }
}
