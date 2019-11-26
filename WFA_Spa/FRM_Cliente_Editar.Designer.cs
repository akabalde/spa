namespace WFA_Spa
{
    partial class FRM_Cliente_Editar
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
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.TXT_Email = new System.Windows.Forms.TextBox();
            this.TXT_DNI = new System.Windows.Forms.TextBox();
            this.TXT_Apellido = new System.Windows.Forms.TextBox();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.Location = new System.Drawing.Point(496, 142);
            this.BTN_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(163, 35);
            this.BTN_Guardar.TabIndex = 17;
            this.BTN_Guardar.Text = "Guardar cambios";
            this.BTN_Guardar.UseVisualStyleBackColor = true;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // TXT_Email
            // 
            this.TXT_Email.Location = new System.Drawing.Point(509, 81);
            this.TXT_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Email.Name = "TXT_Email";
            this.TXT_Email.Size = new System.Drawing.Size(148, 26);
            this.TXT_Email.TabIndex = 16;
            // 
            // TXT_DNI
            // 
            this.TXT_DNI.Location = new System.Drawing.Point(199, 81);
            this.TXT_DNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_DNI.Name = "TXT_DNI";
            this.TXT_DNI.Size = new System.Drawing.Size(148, 26);
            this.TXT_DNI.TabIndex = 15;
            this.TXT_DNI.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_DNI_Validating);
            // 
            // TXT_Apellido
            // 
            this.TXT_Apellido.Location = new System.Drawing.Point(509, 41);
            this.TXT_Apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Apellido.Name = "TXT_Apellido";
            this.TXT_Apellido.Size = new System.Drawing.Size(148, 26);
            this.TXT_Apellido.TabIndex = 14;
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(199, 41);
            this.TXT_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(148, 26);
            this.TXT_Nombre.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRM_Cliente_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 218);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.TXT_Email);
            this.Controls.Add(this.TXT_DNI);
            this.Controls.Add(this.TXT_Apellido);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Cliente_Editar";
            this.Text = "Editar cliente";
            this.Load += new System.EventHandler(this.FRM_Cliente_Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.TextBox TXT_Email;
        private System.Windows.Forms.TextBox TXT_DNI;
        private System.Windows.Forms.TextBox TXT_Apellido;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}