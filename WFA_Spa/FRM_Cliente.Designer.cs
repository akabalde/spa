namespace WFA_Spa
{
    partial class FRM_Cliente
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
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_Borrar = new System.Windows.Forms.Button();
            this.DGV_Clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(221, 27);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(101, 47);
            this.BTN_Agregar.TabIndex = 0;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BTN_Borrar
            // 
            this.BTN_Borrar.Location = new System.Drawing.Point(479, 27);
            this.BTN_Borrar.Name = "BTN_Borrar";
            this.BTN_Borrar.Size = new System.Drawing.Size(101, 47);
            this.BTN_Borrar.TabIndex = 2;
            this.BTN_Borrar.Text = "Borrar";
            this.BTN_Borrar.UseVisualStyleBackColor = true;
            // 
            // DGV_Clientes
            // 
            this.DGV_Clientes.AllowUserToAddRows = false;
            this.DGV_Clientes.AllowUserToDeleteRows = false;
            this.DGV_Clientes.AllowUserToResizeRows = false;
            this.DGV_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Clientes.Location = new System.Drawing.Point(12, 92);
            this.DGV_Clientes.MultiSelect = false;
            this.DGV_Clientes.Name = "DGV_Clientes";
            this.DGV_Clientes.ReadOnly = true;
            this.DGV_Clientes.RowHeadersVisible = false;
            this.DGV_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV_Clientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.DGV_Clientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Clientes.RowTemplate.Height = 28;
            this.DGV_Clientes.RowTemplate.ReadOnly = true;
            this.DGV_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Clientes.Size = new System.Drawing.Size(776, 346);
            this.DGV_Clientes.TabIndex = 3;
            // 
            // FRM_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_Clientes);
            this.Controls.Add(this.BTN_Borrar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_Agregar);
            this.Name = "FRM_Cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FRM_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_Borrar;
        private System.Windows.Forms.DataGridView DGV_Clientes;
    }
}