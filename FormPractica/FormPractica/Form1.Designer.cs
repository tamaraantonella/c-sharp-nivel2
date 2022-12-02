namespace FormPractica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_lastname = new System.Windows.Forms.Label();
            this.box_lastname = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.box_name = new System.Windows.Forms.TextBox();
            this.label_age = new System.Windows.Forms.Label();
            this.box_age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(12, 23);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(59, 13);
            this.label_lastname.TabIndex = 0;
            this.label_lastname.Text = "APELLIDO";
            // 
            // box_lastname
            // 
            this.box_lastname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.box_lastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.box_lastname.Location = new System.Drawing.Point(87, 20);
            this.box_lastname.MaxLength = 32;
            this.box_lastname.Name = "box_lastname";
            this.box_lastname.Size = new System.Drawing.Size(442, 20);
            this.box_lastname.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 55);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(54, 13);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "NOMBRE";
            // 
            // box_name
            // 
            this.box_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.box_name.Location = new System.Drawing.Point(87, 52);
            this.box_name.MaxLength = 32;
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(442, 20);
            this.box_name.TabIndex = 3;
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Location = new System.Drawing.Point(12, 87);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(37, 13);
            this.label_age.TabIndex = 4;
            this.label_age.Text = "EDAD";
            // 
            // box_age
            // 
            this.box_age.Location = new System.Drawing.Point(87, 84);
            this.box_age.MaxLength = 32;
            this.box_age.Name = "box_age";
            this.box_age.Size = new System.Drawing.Size(42, 20);
            this.box_age.TabIndex = 5;
            this.box_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_age_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DIRECCIÓN";
            // 
            // box_address
            // 
            this.box_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.box_address.Location = new System.Drawing.Point(87, 120);
            this.box_address.MaxLength = 32;
            this.box_address.Name = "box_address";
            this.box_address.Size = new System.Drawing.Size(442, 20);
            this.box_address.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "RESULTADO";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(15, 180);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(510, 109);
            this.results.TabIndex = 9;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Beige;
            this.btn_ok.FlatAppearance.BorderSize = 2;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ok.Location = new System.Drawing.Point(175, 302);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(73, 28);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "Aceptar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Beige;
            this.btn_cancel.FlatAppearance.BorderSize = 2;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cancel.Location = new System.Drawing.Point(278, 302);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(73, 28);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(552, 342);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_age);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.box_lastname);
            this.Controls.Add(this.label_lastname);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(568, 381);
            this.MinimumSize = new System.Drawing.Size(568, 381);
            this.Name = "Form1";
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.TextBox box_lastname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.TextBox box_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox box_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}

