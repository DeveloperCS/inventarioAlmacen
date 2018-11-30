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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contenedor));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.colorEs = new System.Windows.Forms.Panel();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.txtTituloBar = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelInicio = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnIni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelBarraSuperior.SuspendLayout();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.panelMenu.Controls.Add(this.labelUser);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.colorEs);
            this.panelMenu.Controls.Add(this.btnPrestamos);
            this.panelMenu.Controls.Add(this.btnInv);
            this.panelMenu.Controls.Add(this.btnIni);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Location = new System.Drawing.Point(0, 70);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 580);
            this.panelMenu.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelUser.Location = new System.Drawing.Point(118, 36);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(74, 24);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Usuario";
            // 
            // colorEs
            // 
            this.colorEs.BackColor = System.Drawing.Color.Aqua;
            this.colorEs.Location = new System.Drawing.Point(1, 100);
            this.colorEs.Name = "colorEs";
            this.colorEs.Size = new System.Drawing.Size(10, 60);
            this.colorEs.TabIndex = 2;
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.panelBarraSuperior.Controls.Add(this.txtTituloBar);
            this.panelBarraSuperior.Controls.Add(this.btnMinimizar);
            this.panelBarraSuperior.Controls.Add(this.btnCerrar);
            this.panelBarraSuperior.Location = new System.Drawing.Point(250, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(1050, 70);
            this.panelBarraSuperior.TabIndex = 1;
            this.panelBarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraSuperior_MouseDown);
            // 
            // txtTituloBar
            // 
            this.txtTituloBar.AutoSize = true;
            this.txtTituloBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloBar.ForeColor = System.Drawing.Color.White;
            this.txtTituloBar.Location = new System.Drawing.Point(96, 20);
            this.txtTituloBar.Name = "txtTituloBar";
            this.txtTituloBar.Size = new System.Drawing.Size(99, 33);
            this.txtTituloBar.TabIndex = 2;
            this.txtTituloBar.Text = "label1";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelCentral.Location = new System.Drawing.Point(250, 70);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1050, 580);
            this.panelCentral.TabIndex = 2;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCentral_Paint);
            // 
            // panelInicio
            // 
            this.panelInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panelInicio.Controls.Add(this.pictureBox2);
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(250, 70);
            this.panelInicio.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::inventarioAlmacen.Resource1.LogoContenedor;
            this.pictureBox2.Location = new System.Drawing.Point(47, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::inventarioAlmacen.Resource1.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(982, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::inventarioAlmacen.Resource1.cerr;
            this.btnCerrar.Location = new System.Drawing.Point(1013, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventarioAlmacen.Resource1.user;
            this.pictureBox1.Location = new System.Drawing.Point(53, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.White;
            this.btnPrestamos.Image = global::inventarioAlmacen.Resource1.prestar;
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 220);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPrestamos.Size = new System.Drawing.Size(250, 60);
            this.btnPrestamos.TabIndex = 1;
            this.btnPrestamos.Text = "     Prestamos";
            this.btnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnInv
            // 
            this.btnInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btnInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInv.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnInv.FlatAppearance.BorderSize = 0;
            this.btnInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInv.ForeColor = System.Drawing.Color.White;
            this.btnInv.Image = global::inventarioAlmacen.Resource1.eninven;
            this.btnInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInv.Location = new System.Drawing.Point(0, 160);
            this.btnInv.Name = "btnInv";
            this.btnInv.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInv.Size = new System.Drawing.Size(250, 60);
            this.btnInv.TabIndex = 0;
            this.btnInv.Text = "     Inventario";
            this.btnInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInv.UseVisualStyleBackColor = false;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnIni
            // 
            this.btnIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIni.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.White;
            this.btnIni.Image = global::inventarioAlmacen.Resource1.icons8_home_32;
            this.btnIni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIni.Location = new System.Drawing.Point(0, 100);
            this.btnIni.Name = "btnIni";
            this.btnIni.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnIni.Size = new System.Drawing.Size(250, 60);
            this.btnIni.TabIndex = 3;
            this.btnIni.Text = "     Inicio";
            this.btnIni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIni.UseVisualStyleBackColor = true;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::inventarioAlmacen.Resource1.item;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 280);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "     Item2";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(164)))), ((int)(((byte)(227)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::inventarioAlmacen.Resource1.item;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 340);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "     Item3";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelInicio);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelBarraSuperior);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenedor";
            this.Load += new System.EventHandler(this.Contenedor_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelBarraSuperior.PerformLayout();
            this.panelInicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}