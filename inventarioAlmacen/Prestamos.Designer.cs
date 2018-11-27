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
            this.dgv_ProductosPedidos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dud_cantidad = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_personal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ProductosPedidos
            // 
            this.dgv_ProductosPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductosPedidos.Location = new System.Drawing.Point(26, 153);
            this.dgv_ProductosPedidos.Name = "dgv_ProductosPedidos";
            this.dgv_ProductosPedidos.Size = new System.Drawing.Size(418, 150);
            this.dgv_ProductosPedidos.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lts/Pza";
            // 
            // dud_cantidad
            // 
            this.dud_cantidad.Location = new System.Drawing.Point(133, 73);
            this.dud_cantidad.Name = "dud_cantidad";
            this.dud_cantidad.Size = new System.Drawing.Size(47, 20);
            this.dud_cantidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad";
            // 
            // cb_personal
            // 
            this.cb_personal.FormattingEnabled = true;
            this.cb_personal.Location = new System.Drawing.Point(133, 27);
            this.cb_personal.Name = "cb_personal";
            this.cb_personal.Size = new System.Drawing.Size(121, 21);
            this.cb_personal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal";
            // 
            // btn_pedido
            // 
            this.btn_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(240)))), ((int)(((byte)(179)))));
            this.btn_pedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedido.Location = new System.Drawing.Point(313, 116);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(131, 31);
            this.btn_pedido.TabIndex = 5;
            this.btn_pedido.Text = "Pedir";
            this.btn_pedido.UseVisualStyleBackColor = false;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.dgv_ProductosPedidos);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dud_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_personal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prestamos";
            this.Text = "Prestamos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ProductosPedidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown dud_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_personal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pedido;
    }
}