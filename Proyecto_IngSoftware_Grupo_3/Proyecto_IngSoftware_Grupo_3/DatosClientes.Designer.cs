namespace Proyecto_IngSoftware_Grupo_3
{
    partial class DatosClientes
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
            this.buttonTipoCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTipoCliente
            // 
            this.buttonTipoCliente.Location = new System.Drawing.Point(163, 86);
            this.buttonTipoCliente.Name = "buttonTipoCliente";
            this.buttonTipoCliente.Size = new System.Drawing.Size(124, 25);
            this.buttonTipoCliente.TabIndex = 0;
            this.buttonTipoCliente.Text = "Tipo Cliente";
            this.buttonTipoCliente.UseVisualStyleBackColor = true;
            // 
            // DatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTipoCliente);
            this.Name = "DatosClientes";
            this.Text = "DatosClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonTipoCliente;
    }
}