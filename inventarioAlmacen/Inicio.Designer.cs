namespace inventarioAlmacen
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbHer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbHig = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataPres = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDevolverArt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGenerarRepor = new System.Windows.Forms.Button();
            this.btnAgregarPres = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(366, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulos Prestados";
            this.toolTip1.SetToolTip(this.label1, "Articulos Prestados");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.lbT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 180);
            this.panel2.TabIndex = 1;
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbT.ForeColor = System.Drawing.Color.White;
            this.lbT.Location = new System.Drawing.Point(153, 106);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(24, 25);
            this.lbT.TabIndex = 3;
            this.lbT.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Todos";
            this.toolTip1.SetToolTip(this.label2, "Todos");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.lbHer);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(358, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 180);
            this.panel3.TabIndex = 2;
            // 
            // lbHer
            // 
            this.lbHer.AutoSize = true;
            this.lbHer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHer.ForeColor = System.Drawing.Color.White;
            this.lbHer.Location = new System.Drawing.Point(153, 106);
            this.lbHer.Name = "lbHer";
            this.lbHer.Size = new System.Drawing.Size(24, 25);
            this.lbHer.TabIndex = 4;
            this.lbHer.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Herramientas y Otros";
            this.toolTip1.SetToolTip(this.label3, "Herramientas y Otros");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.panel4.Controls.Add(this.lbHig);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(692, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 180);
            this.panel4.TabIndex = 2;
            // 
            // lbHig
            // 
            this.lbHig.AutoSize = true;
            this.lbHig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHig.ForeColor = System.Drawing.Color.White;
            this.lbHig.Location = new System.Drawing.Point(157, 106);
            this.lbHig.Name = "lbHig";
            this.lbHig.Size = new System.Drawing.Size(24, 25);
            this.lbHig.TabIndex = 5;
            this.lbHig.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(42, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Higiene y Limpieza";
            this.toolTip1.SetToolTip(this.label4, "Higiene y Limpieza");
            // 
            // dataPres
            // 
            this.dataPres.AllowUserToAddRows = false;
            this.dataPres.AllowUserToDeleteRows = false;
            this.dataPres.AllowUserToOrderColumns = true;
            this.dataPres.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataPres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPres.Location = new System.Drawing.Point(24, 274);
            this.dataPres.Name = "dataPres";
            this.dataPres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPres.Size = new System.Drawing.Size(528, 294);
            this.dataPres.TabIndex = 4;
            // 
            // btnDevolverArt
            // 
            this.btnDevolverArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.btnDevolverArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverArt.ForeColor = System.Drawing.Color.White;
            this.btnDevolverArt.Image = global::inventarioAlmacen.Resource1.devolver;
            this.btnDevolverArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolverArt.Location = new System.Drawing.Point(570, 428);
            this.btnDevolverArt.Name = "btnDevolverArt";
            this.btnDevolverArt.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDevolverArt.Size = new System.Drawing.Size(184, 140);
            this.btnDevolverArt.TabIndex = 9;
            this.btnDevolverArt.Text = "           Devolver            Articulo";
            this.toolTip1.SetToolTip(this.btnDevolverArt, "Devolver Articulo");
            this.btnDevolverArt.UseVisualStyleBackColor = false;
            this.btnDevolverArt.Click += new System.EventHandler(this.btnDevolverArt_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::inventarioAlmacen.Resource1.añadir_usuario;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(842, 274);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(184, 140);
            this.button3.TabIndex = 8;
            this.button3.Text = "            Añadir              Usuario";
            this.toolTip1.SetToolTip(this.button3, "Añadir Usuario");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGenerarRepor
            // 
            this.btnGenerarRepor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnGenerarRepor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRepor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnGenerarRepor.ForeColor = System.Drawing.Color.White;
            this.btnGenerarRepor.Image = global::inventarioAlmacen.Resource1.añadir_reporte;
            this.btnGenerarRepor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarRepor.Location = new System.Drawing.Point(771, 428);
            this.btnGenerarRepor.Name = "btnGenerarRepor";
            this.btnGenerarRepor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenerarRepor.Size = new System.Drawing.Size(255, 140);
            this.btnGenerarRepor.TabIndex = 7;
            this.btnGenerarRepor.Text = "        Generar          Reportes";
            this.toolTip1.SetToolTip(this.btnGenerarRepor, "Generar Reportes");
            this.btnGenerarRepor.UseVisualStyleBackColor = false;
            this.btnGenerarRepor.Click += new System.EventHandler(this.btnGenerarRepor_Click);
            // 
            // btnAgregarPres
            // 
            this.btnAgregarPres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnAgregarPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPres.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPres.Image = global::inventarioAlmacen.Resource1.AgrgarCarrito;
            this.btnAgregarPres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPres.Location = new System.Drawing.Point(570, 274);
            this.btnAgregarPres.Name = "btnAgregarPres";
            this.btnAgregarPres.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAgregarPres.Size = new System.Drawing.Size(255, 140);
            this.btnAgregarPres.TabIndex = 6;
            this.btnAgregarPres.Text = "        Agregar          Prestamo";
            this.toolTip1.SetToolTip(this.btnAgregarPres, "Agregar Prestamo");
            this.btnAgregarPres.UseVisualStyleBackColor = false;
            this.btnAgregarPres.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 580);
            this.Controls.Add(this.btnDevolverArt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGenerarRepor);
            this.Controls.Add(this.btnAgregarPres);
            this.Controls.Add(this.dataPres);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataPres;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAgregarPres;
        private System.Windows.Forms.Button btnGenerarRepor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDevolverArt;
        public System.Windows.Forms.Timer timerCheck;
    }
}