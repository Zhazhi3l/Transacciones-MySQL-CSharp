namespace Transacciones_MySQL
{
    partial class FrmDescontinuar
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtBuscarCodigo = new TextBox();
            btnBuscar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            cmbFiltros = new ComboBox();
            btnDescontinuar = new Button();
            dgvProductos = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Lavender;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvProductos, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Size = new Size(888, 513);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtBuscarCodigo, 0, 1);
            tableLayoutPanel2.Controls.Add(btnBuscar, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(594, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(0, 20, 0, 20);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.043478F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.47826F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.47826F));
            tableLayoutPanel2.Size = new Size(291, 186);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // txtBuscarCodigo
            // 
            tableLayoutPanel2.SetColumnSpan(txtBuscarCodigo, 2);
            txtBuscarCodigo.Dock = DockStyle.Fill;
            txtBuscarCodigo.Location = new Point(3, 42);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(285, 27);
            txtBuscarCodigo.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightBlue;
            btnBuscar.Dock = DockStyle.Right;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.WhiteSmoke;
            btnBuscar.Location = new Point(194, 105);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 58);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.52941F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4705868F));
            tableLayoutPanel3.Controls.Add(cmbFiltros, 0, 1);
            tableLayoutPanel3.Controls.Add(btnDescontinuar, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new Size(585, 186);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // cmbFiltros
            // 
            cmbFiltros.Dock = DockStyle.Fill;
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Location = new Point(3, 30);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(424, 28);
            cmbFiltros.TabIndex = 0;
            // 
            // btnDescontinuar
            // 
            btnDescontinuar.BackColor = Color.LightBlue;
            btnDescontinuar.Dock = DockStyle.Bottom;
            btnDescontinuar.FlatAppearance.BorderSize = 0;
            btnDescontinuar.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescontinuar.ForeColor = Color.WhiteSmoke;
            btnDescontinuar.Location = new Point(433, 125);
            btnDescontinuar.Name = "btnDescontinuar";
            btnDescontinuar.Size = new Size(149, 29);
            btnDescontinuar.TabIndex = 1;
            btnDescontinuar.Text = "Descontinuar";
            btnDescontinuar.UseVisualStyleBackColor = false;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dgvProductos, 3);
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.Location = new Point(3, 195);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(882, 315);
            dgvProductos.TabIndex = 2;
            // 
            // FrmDescontinuar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 513);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmDescontinuar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Descontinuar productos";
            Load += FrmDescontinuar_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtBuscarCodigo;
        private Button btnBuscar;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cmbFiltros;
        private Button btnDescontinuar;
        private DataGridView dgvProductos;
    }
}
