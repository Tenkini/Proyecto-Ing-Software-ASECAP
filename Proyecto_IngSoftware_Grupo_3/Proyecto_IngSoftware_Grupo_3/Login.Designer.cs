namespace Proyecto_IngSoftware_Grupo_3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.imagenLogo = new System.Windows.Forms.PictureBox();
            this.textBoxRut = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenLogo
            // 
            this.imagenLogo.Image = ((System.Drawing.Image)(resources.GetObject("imagenLogo.Image")));
            this.imagenLogo.Location = new System.Drawing.Point(240, 14);
            this.imagenLogo.Margin = new System.Windows.Forms.Padding(5);
            this.imagenLogo.Name = "imagenLogo";
            this.imagenLogo.Size = new System.Drawing.Size(199, 193);
            this.imagenLogo.TabIndex = 0;
            this.imagenLogo.TabStop = false;
            // 
            // textBoxRut
            // 
            this.textBoxRut.Location = new System.Drawing.Point(240, 240);
            this.textBoxRut.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRut.Name = "textBoxRut";
            this.textBoxRut.PlaceholderText = "RUT";
            this.textBoxRut.Size = new System.Drawing.Size(199, 32);
            this.textBoxRut.TabIndex = 1;
            this.textBoxRut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(240, 303);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PlaceholderText = "Contraseña";
            this.textBoxPassword.Size = new System.Drawing.Size(199, 32);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(280, 358);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(5);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(118, 38);
            this.buttonConfirmar.TabIndex = 3;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 456);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxRut);
            this.Controls.Add(this.imagenLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PantallaPrincipal";
            this.Text = "ASECAP Software";
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imagenLogo;
        private TextBox textBoxRut;
        private TextBox textBoxPassword;
        private Button buttonConfirmar;
    }
}