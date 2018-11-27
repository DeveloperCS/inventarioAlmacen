namespace inventarioAlmacen
{
    partial class Articulos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pedir = new System.Windows.Forms.Button();
            this.txt_modificar = new System.Windows.Forms.Button();
            this.txt_remov = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // Pedir
            // 
            this.Pedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(232)))), ((int)(((byte)(152)))));
            this.Pedir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pedir.Location = new System.Drawing.Point(493, 392);
            this.Pedir.Name = "Pedir";
            this.Pedir.Size = new System.Drawing.Size(75, 23);
            this.Pedir.TabIndex = 1;
            this.Pedir.Text = "Pedir";
            this.Pedir.UseVisualStyleBackColor = false;
            this.Pedir.Click += new System.EventHandler(this.Pedir_Click);
            // 
            // txt_modificar
            // 
            this.txt_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(184)))), ((int)(((byte)(102)))));
            this.txt_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_modificar.Location = new System.Drawing.Point(574, 392);
            this.txt_modificar.Name = "txt_modificar";
            this.txt_modificar.Size = new System.Drawing.Size(75, 23);
            this.txt_modificar.TabIndex = 2;
            this.txt_modificar.Text = "Modificar";
            this.txt_modificar.UseVisualStyleBackColor = false;
            // 
            // txt_remov
            // 
            this.txt_remov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.txt_remov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_remov.Location = new System.Drawing.Point(655, 392);
            this.txt_remov.Name = "txt_remov";
            this.txt_remov.Size = new System.Drawing.Size(75, 23);
            this.txt_remov.TabIndex = 3;
            this.txt_remov.Text = "Remover";
            this.txt_remov.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Search";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_remov);
            this.Controls.Add(this.txt_modificar);
            this.Controls.Add(this.Pedir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Articulos";
            this.Text = "Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Pedir;
        private System.Windows.Forms.Button txt_modificar;
        private System.Windows.Forms.Button txt_remov;
        private System.Windows.Forms.TextBox textBox1;
    }
}