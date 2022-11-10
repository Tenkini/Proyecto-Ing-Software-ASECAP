namespace Proyecto_IngSoftware_Grupo_3
{
    partial class MenuPrincipal
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
            this.textBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.labelBuscarCliente = new System.Windows.Forms.Label();
            this.buttonDesplegarClientes = new System.Windows.Forms.Button();
            this.buttonIngresarCliente = new System.Windows.Forms.Button();
            this.linkLabelCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarCliente
            // 
            this.textBoxBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxBuscarCliente.Location = new System.Drawing.Point(482, 88);
            this.textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            this.textBoxBuscarCliente.PlaceholderText = "Buscar Cliente";
            this.textBoxBuscarCliente.Size = new System.Drawing.Size(258, 29);
            this.textBoxBuscarCliente.TabIndex = 0;
            // 
            // labelBuscarCliente
            // 
            this.labelBuscarCliente.AutoSize = true;
            this.labelBuscarCliente.Location = new System.Drawing.Point(482, 120);
            this.labelBuscarCliente.Name = "labelBuscarCliente";
            this.labelBuscarCliente.Size = new System.Drawing.Size(77, 15);
            this.labelBuscarCliente.TabIndex = 1;
            this.labelBuscarCliente.Text = "Nombre/RUT";
            // 
            // buttonDesplegarClientes
            // 
            this.buttonDesplegarClientes.Location = new System.Drawing.Point(482, 253);
            this.buttonDesplegarClientes.Name = "buttonDesplegarClientes";
            this.buttonDesplegarClientes.Size = new System.Drawing.Size(284, 43);
            this.buttonDesplegarClientes.TabIndex = 2;
            this.buttonDesplegarClientes.Text = "Desplegar todos los clientes";
            this.buttonDesplegarClientes.UseVisualStyleBackColor = true;
            this.buttonDesplegarClientes.Click += new System.EventHandler(this.buttonDesplegarClientes_Click);
            // 
            // buttonIngresarCliente
            // 
            this.buttonIngresarCliente.Location = new System.Drawing.Point(482, 337);
            this.buttonIngresarCliente.Name = "buttonIngresarCliente";
            this.buttonIngresarCliente.Size = new System.Drawing.Size(284, 43);
            this.buttonIngresarCliente.TabIndex = 3;
            this.buttonIngresarCliente.Text = "Ingresar nuevo cliente";
            this.buttonIngresarCliente.UseVisualStyleBackColor = true;
            this.buttonIngresarCliente.Click += new System.EventHandler(this.buttonIngresarCliente_Click);
            // 
            // linkLabelCerrarSesion
            // 
            this.linkLabelCerrarSesion.AutoSize = true;
            this.linkLabelCerrarSesion.Location = new System.Drawing.Point(12, 426);
            this.linkLabelCerrarSesion.Name = "linkLabelCerrarSesion";
            this.linkLabelCerrarSesion.Size = new System.Drawing.Size(76, 15);
            this.linkLabelCerrarSesion.TabIndex = 4;
            this.linkLabelCerrarSesion.TabStop = true;
            this.linkLabelCerrarSesion.Text = "Cerrar Sesión";
            this.linkLabelCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCerrarSesion_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_IngSoftware_Grupo_3.Properties.Resources.ASECAP_LOGO_FINAL;
            this.pictureBox1.Location = new System.Drawing.Point(80, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabelCerrarSesion);
            this.Controls.Add(this.buttonIngresarCliente);
            this.Controls.Add(this.buttonDesplegarClientes);
            this.Controls.Add(this.labelBuscarCliente);
            this.Controls.Add(this.textBoxBuscarCliente);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBuscarCliente;
        private Label labelBuscarCliente;
        private Button buttonDesplegarClientes;
        private Button buttonIngresarCliente;
        private LinkLabel linkLabelCerrarSesion;
        private PictureBox pictureBox1;
    }
}