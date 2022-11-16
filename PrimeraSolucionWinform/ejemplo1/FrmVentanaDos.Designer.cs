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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(29, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Saludar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa tu nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(117, 21);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 2;
            // 
            // saludarLabel
            // 
            this.saludarLabel.AutoSize = true;
            this.saludarLabel.Location = new System.Drawing.Point(288, 300);
            this.saludarLabel.Name = "saludarLabel";
            this.saludarLabel.Size = new System.Drawing.Size(0, 13);
            this.saludarLabel.TabIndex = 3;
            this.saludarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(26, 57);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(89, 13);
            this.labelUbicacion.TabIndex = 4;
            this.labelUbicacion.Text = "Ingresá tu ciudad";
            // 
            // textUbicacion
            // 
            this.textUbicacion.Location = new System.Drawing.Point(117, 54);
            this.textUbicacion.Name = "textUbicacion";
            this.textUbicacion.Size = new System.Drawing.Size(100, 20);
            this.textUbicacion.TabIndex = 5;
            // 
            // listViewPets
            // 
            this.listViewPets.HideSelection = false;
            this.listViewPets.Location = new System.Drawing.Point(29, 173);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(193, 74);
            this.listViewPets.TabIndex = 6;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.View = System.Windows.Forms.View.List;
            // 
            // btnAddPets
            // 
            this.btnAddPets.Location = new System.Drawing.Point(147, 129);
            this.btnAddPets.Name = "btnAddPets";
            this.btnAddPets.Size = new System.Drawing.Size(75, 23);
            this.btnAddPets.TabIndex = 7;
            this.btnAddPets.Text = "Agregar";
            this.btnAddPets.UseVisualStyleBackColor = true;
            this.btnAddPets.Click += new System.EventHandler(this.btnAddPets_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agregá tus mascotas";
            // 
            // tbPets
            // 
            this.tbPets.Location = new System.Drawing.Point(29, 132);
            this.tbPets.Name = "tbPets";
            this.tbPets.Size = new System.Drawing.Size(100, 20);
            this.tbPets.TabIndex = 9;
            // 
            // FrmVentanaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmVentanaDos";
            this.Text = "Form2";
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
    }
}