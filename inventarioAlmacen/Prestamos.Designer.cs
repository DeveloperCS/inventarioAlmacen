namespace inventarioAlmacen
{
    partial class Prestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.dataGLista = new System.Windows.Forms.DataGridView();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.bdAlmacenDataSet1 = new inventarioAlmacen.bdAlmacenDataSet();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbFechaR = new System.Windows.Forms.Label();
            this.datFechaR = new System.Windows.Forms.DateTimePicker();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGLista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdAlmacenDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGLista
            // 
            this.dataGLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.Desc});
            this.dataGLista.Location = new System.Drawing.Point(43, 129);
            this.dataGLista.Name = "dataGLista";
            this.dataGLista.ReadOnly = true;
            this.dataGLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGLista.Size = new System.Drawing.Size(945, 335);
            this.dataGLista.TabIndex = 0;
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(169)))), ((int)(((byte)(226)))));
            this.btnPrestar.FlatAppearance.BorderSize = 0;
            this.btnPrestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPrestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.ForeColor = System.Drawing.Color.White;
            this.btnPrestar.Location = new System.Drawing.Point(729, 493);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(259, 47);
            this.btnPrestar.TabIndex = 2;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // lbID
            // 
            this.lbID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.lbID.Location = new System.Drawing.Point(39, 103);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(177, 23);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "Lista de Articulos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productoToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.if_plus_1646001;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.productoToolStripMenuItem.Text = "Agregar";
            this.productoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.if_error_1646012;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editarToolStripMenuItem.Image = global::inventarioAlmacen.Resource1.icons8_sincronizar_64;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(412, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Articulo:";
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(725, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Seleccione ..",
            "Higiene y Limpieza",
            "Herramientas y Otros"});
            this.cbTipo.Location = new System.Drawing.Point(552, 53);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(822, 53);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleado.TabIndex = 7;
            // 
            // bdAlmacenDataSet1
            // 
            this.bdAlmacenDataSet1.DataSetName = "bdAlmacenDataSet";
            this.bdAlmacenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(598, 506);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbFechaR
            // 
            this.lbFechaR.AutoSize = true;
            this.lbFechaR.Location = new System.Drawing.Point(697, 103);
            this.lbFechaR.Name = "lbFechaR";
            this.lbFechaR.Size = new System.Drawing.Size(95, 13);
            this.lbFechaR.TabIndex = 9;
            this.lbFechaR.Text = "Fecha de Regreso";
            this.lbFechaR.Visible = false;
            // 
            // datFechaR
            // 
            this.datFechaR.Location = new System.Drawing.Point(796, 100);
            this.datFechaR.Name = "datFechaR";
            this.datFechaR.Size = new System.Drawing.Size(190, 20);
            this.datFechaR.TabIndex = 10;
            this.datFechaR.Visible = false;
            // 
            // item
            // 
            this.item.HeaderText = "item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripcion";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 562);
            this.Controls.Add(this.datFechaR);
            this.Controls.Add(this.lbFechaR);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.dataGLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGLista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdAlmacenDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrestar;
        public System.Windows.Forms.Label lbID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private bdAlmacenDataSet bdAlmacenDataSet1;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label lbFechaR;
        public System.Windows.Forms.DateTimePicker datFechaR;
        private System.Windows.Forms.DataGridView dataGLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
    }
}