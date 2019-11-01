namespace WFA_Spa
{
    partial class FRM_Turno_Alta
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
            this.CBX_Cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBX_Tratamiento = new System.Windows.Forms.ComboBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_Turno = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // CBX_Cliente
            // 
            this.CBX_Cliente.FormattingEnabled = true;
            this.CBX_Cliente.Location = new System.Drawing.Point(181, 33);
            this.CBX_Cliente.Name = "CBX_Cliente";
            this.CBX_Cliente.Size = new System.Drawing.Size(343, 28);
            this.CBX_Cliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tratamiento";
            // 
            // CBX_Tratamiento
            // 
            this.CBX_Tratamiento.FormattingEnabled = true;
            this.CBX_Tratamiento.Location = new System.Drawing.Point(181, 85);
            this.CBX_Tratamiento.Name = "CBX_Tratamiento";
            this.CBX_Tratamiento.Size = new System.Drawing.Size(257, 28);
            this.CBX_Tratamiento.TabIndex = 1;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(665, 170);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(118, 44);
            this.BTN_Agregar.TabIndex = 3;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha / Hora";
            // 
            // DTP_Turno
            // 
            this.DTP_Turno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Turno.Location = new System.Drawing.Point(181, 139);
            this.DTP_Turno.MinDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.DTP_Turno.Name = "DTP_Turno";
            this.DTP_Turno.Size = new System.Drawing.Size(200, 26);
            this.DTP_Turno.TabIndex = 2;
            this.DTP_Turno.Value = new System.DateTime(2019, 10, 31, 21, 51, 25, 0);
            // 
            // FRM_Turno_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 244);
            this.Controls.Add(this.DTP_Turno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBX_Tratamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBX_Cliente);
            this.Name = "FRM_Turno_Alta";
            this.Text = "Alta de turno";
            this.Load += new System.EventHandler(this.FRM_Turno_Alta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBX_Tratamiento;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_Turno;
    }
}