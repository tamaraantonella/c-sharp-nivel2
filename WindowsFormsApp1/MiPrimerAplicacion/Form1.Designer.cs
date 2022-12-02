namespace MiPrimerAplicacion
{
    partial class Formulario
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelForm = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(325, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 37);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelForm.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelForm.Location = new System.Drawing.Point(308, 239);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(56, 19);
            this.labelForm.TabIndex = 1;
            this.labelForm.Text = "Etiqueta";
            this.labelForm.MouseLeave += new System.EventHandler(this.labelForm_MouseLeave);
            this.labelForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelForm_MouseMove);
            // 
            // textLastName
            // 
            this.textLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textLastName.Location = new System.Drawing.Point(400, 239);
            this.textLastName.MaxLength = 32;
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 2;
            this.textLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLastName_KeyPress);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formulario_FormClosing);
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.Click += new System.EventHandler(this.Formulario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.TextBox textLastName;
    }
}

