namespace CapaPresentacion
{
    partial class FormInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInmueble));
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cbx_arriendoID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbx_tipoinmueble = new System.Windows.Forms.ComboBox();
            this.txt_DescripcionInmueble = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAddinmueble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ciudad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ciudad.Location = new System.Drawing.Point(24, 232);
            this.txt_ciudad.Multiline = true;
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(253, 33);
            this.txt_ciudad.TabIndex = 87;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label40.Location = new System.Drawing.Point(20, 207);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(87, 21);
            this.label40.TabIndex = 86;
            this.label40.Text = "Ciudad:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_direccion.Location = new System.Drawing.Point(24, 154);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(253, 33);
            this.txt_direccion.TabIndex = 84;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(160, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(214, 21);
            this.label25.TabIndex = 83;
            this.label25.Text = "Registre Inmueble";
            // 
            // cbx_arriendoID
            // 
            this.cbx_arriendoID.Font = new System.Drawing.Font("MS Gothic", 15.75F);
            this.cbx_arriendoID.FormattingEnabled = true;
            this.cbx_arriendoID.Location = new System.Drawing.Point(24, 89);
            this.cbx_arriendoID.Name = "cbx_arriendoID";
            this.cbx_arriendoID.Size = new System.Drawing.Size(253, 29);
            this.cbx_arriendoID.TabIndex = 82;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(20, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 21);
            this.label16.TabIndex = 81;
            this.label16.Text = "Id Arriendo:";
            // 
            // cbx_tipoinmueble
            // 
            this.cbx_tipoinmueble.Font = new System.Drawing.Font("MS Gothic", 15.75F);
            this.cbx_tipoinmueble.FormattingEnabled = true;
            this.cbx_tipoinmueble.Items.AddRange(new object[] {
            "Lote",
            "Casa",
            "Apartamento",
            "Condominio",
            "Aparta-Estudio",
            "Local"});
            this.cbx_tipoinmueble.Location = new System.Drawing.Point(313, 89);
            this.cbx_tipoinmueble.Name = "cbx_tipoinmueble";
            this.cbx_tipoinmueble.Size = new System.Drawing.Size(253, 29);
            this.cbx_tipoinmueble.TabIndex = 80;
            // 
            // txt_DescripcionInmueble
            // 
            this.txt_DescripcionInmueble.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescripcionInmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_DescripcionInmueble.Location = new System.Drawing.Point(313, 169);
            this.txt_DescripcionInmueble.Multiline = true;
            this.txt_DescripcionInmueble.Name = "txt_DescripcionInmueble";
            this.txt_DescripcionInmueble.Size = new System.Drawing.Size(253, 96);
            this.txt_DescripcionInmueble.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(309, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 21);
            this.label15.TabIndex = 78;
            this.label15.Text = "Descripcion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(20, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 21);
            this.label18.TabIndex = 77;
            this.label18.Text = "Direccion:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(309, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 21);
            this.label19.TabIndex = 76;
            this.label19.Text = "Tipo Inmueble:";
            // 
            // btnAddinmueble
            // 
            this.btnAddinmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddinmueble.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddinmueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddinmueble.Image = ((System.Drawing.Image)(resources.GetObject("btnAddinmueble.Image")));
            this.btnAddinmueble.Location = new System.Drawing.Point(522, 280);
            this.btnAddinmueble.Name = "btnAddinmueble";
            this.btnAddinmueble.Size = new System.Drawing.Size(44, 37);
            this.btnAddinmueble.TabIndex = 75;
            this.btnAddinmueble.UseVisualStyleBackColor = true;
            this.btnAddinmueble.Click += new System.EventHandler(this.btnAddinmueble_Click);
            // 
            // FormInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 344);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cbx_arriendoID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbx_tipoinmueble);
            this.Controls.Add(this.txt_DescripcionInmueble);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnAddinmueble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInmueble";
            this.Text = "FormInmueble";
            this.Load += new System.EventHandler(this.FormInmueble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbx_arriendoID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbx_tipoinmueble;
        private System.Windows.Forms.TextBox txt_DescripcionInmueble;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAddinmueble;
    }
}