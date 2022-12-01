namespace ejemplo1
{
    partial class FrmVentanaDos
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.saludarLabel = new System.Windows.Forms.Label();
            this.labelUbicacion = new System.Windows.Forms.Label();
            this.textUbicacion = new System.Windows.Forms.TextBox();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.btnAddPets = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkVet = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(29, 499);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saludar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa tu nombre";
            // 
            // textNombre
            // 
            this.textNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNombre.Location = new System.Drawing.Point(154, 107);
            this.textNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(265, 26);
            this.textNombre.TabIndex = 2;
            // 
            // saludarLabel
            // 
            this.saludarLabel.AutoSize = true;
            this.saludarLabel.Location = new System.Drawing.Point(383, 484);
            this.saludarLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.saludarLabel.Name = "saludarLabel";
            this.saludarLabel.Size = new System.Drawing.Size(0, 18);
            this.saludarLabel.TabIndex = 3;
            this.saludarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbicacion.Location = new System.Drawing.Point(26, 146);
            this.labelUbicacion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(113, 18);
            this.labelUbicacion.TabIndex = 4;
            this.labelUbicacion.Text = "Ingresá tu ciudad";
            // 
            // textUbicacion
            // 
            this.textUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUbicacion.Location = new System.Drawing.Point(154, 143);
            this.textUbicacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.Size = new System.Drawing.Size(264, 26);
            this.textUbicacion.TabIndex = 5;
            // 
            // listViewPets
            // 
            this.listViewPets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPets.HideSelection = false;
            this.listViewPets.Location = new System.Drawing.Point(29, 381);
            this.listViewPets.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(253, 101);
            this.listViewPets.TabIndex = 6;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.View = System.Windows.Forms.View.List;
            // 
            // btnAddPets
            // 
            this.btnAddPets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPets.Location = new System.Drawing.Point(186, 343);
            this.btnAddPets.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddPets.Name = "btnAddPets";
            this.btnAddPets.Size = new System.Drawing.Size(96, 28);
            this.btnAddPets.TabIndex = 7;
            this.btnAddPets.Text = "Agregar";
            this.btnAddPets.UseVisualStyleBackColor = true;
            this.btnAddPets.Click += new System.EventHandler(this.btnAddPets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agregá tus mascotas";
            // 
            // tbPets
            // 
            this.tbPets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPets.Location = new System.Drawing.Point(34, 345);
            this.tbPets.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbPets.Name = "tbPets";
            this.tbPets.Size = new System.Drawing.Size(130, 26);
            this.tbPets.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingresá tu fecha de nacimiento";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaNacimiento.Location = new System.Drawing.Point(154, 182);
            this.fechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(264, 26);
            this.fechaNacimiento.TabIndex = 11;
            // 
            // checkVet
            // 
            this.checkVet.AutoSize = true;
            this.checkVet.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVet.Location = new System.Drawing.Point(33, 238);
            this.checkVet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.checkVet.Name = "checkVet";
            this.checkVet.Size = new System.Drawing.Size(217, 22);
            this.checkVet.TabIndex = 12;
            this.checkVet.Text = "Tenés veterinario de confianza?";
            this.checkVet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(23, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Perfil del usuario";
            // 
            // FrmVentanaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 623);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkVet);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddPets);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.textUbicacion);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.saludarLabel);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(927, 662);
            this.MinimumSize = new System.Drawing.Size(507, 662);
            this.Name = "FrmVentanaDos";
            this.Text = "Mi perfil";
            this.Load += new System.EventHandler(this.FrmVentanaDos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label saludarLabel;
        private System.Windows.Forms.Label labelUbicacion;
        private System.Windows.Forms.TextBox textUbicacion;
        private System.Windows.Forms.ListView listViewPets;
        private System.Windows.Forms.Button btnAddPets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.CheckBox checkVet;
        private System.Windows.Forms.Label label4;
    }
}