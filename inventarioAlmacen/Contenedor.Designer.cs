namespace inventarioAlmacen
{
    partial class Contenedor
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.colorEs = new System.Windows.Forms.Panel();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.txtTituloBar = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.colorEs);
            this.panelMenu.Controls.Add(this.btnPrestamos);
            this.panelMenu.Controls.Add(this.btnInv);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // colorEs
            // 
            this.colorEs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colorEs.Location = new System.Drawing.Point(-3, 153);
            this.colorEs.Name = "colorEs";
            this.colorEs.Size = new System.Drawing.Size(10, 50);
            this.colorEs.TabIndex = 2;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 200);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(250, 50);
            this.btnPrestamos.TabIndex = 1;
            this.btnPrestamos.Text = "Item2";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnInv
            // 
            this.btnInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInv.Location = new System.Drawing.Point(0, 153);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(250, 50);
            this.btnInv.TabIndex = 0;
            this.btnInv.Text = "Inventario";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelBarraSuperior.Controls.Add(this.txtTituloBar);
            this.panelBarraSuperior.Controls.Add(this.btnMinimizar);
            this.panelBarraSuperior.Controls.Add(this.btnCerrar);
            this.panelBarraSuperior.Location = new System.Drawing.Point(250, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(1050, 50);
            this.panelBarraSuperior.TabIndex = 1;
            this.panelBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::inventarioAlmacen.Resource1.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(976, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::inventarioAlmacen.Resource1.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1007, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Maroon;
            this.panelCentral.Location = new System.Drawing.Point(250, 50);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1050, 600);
            this.panelCentral.TabIndex = 2;
            // 
            // txtTituloBar
            // 
            this.txtTituloBar.AutoSize = true;
            this.txtTituloBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloBar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTituloBar.Location = new System.Drawing.Point(53, 8);
            this.txtTituloBar.Name = "txtTituloBar";
            this.txtTituloBar.Size = new System.Drawing.Size(85, 29);
            this.txtTituloBar.TabIndex = 2;
            this.txtTituloBar.Text = "label1";
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelBarraSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenedor";
            this.panelMenu.ResumeLayout(false);
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Panel colorEs;
        private System.Windows.Forms.Label txtTituloBar;
    }
}