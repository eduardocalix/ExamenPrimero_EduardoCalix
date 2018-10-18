namespace ExamenPrimero_EduardoCalix
{
    partial class frmReseña
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbSeleccionar = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lvProductos = new System.Windows.Forms.ListBox();
            this.gbSeleccionar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(271, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo ";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // gbSeleccionar
            // 
            this.gbSeleccionar.Controls.Add(this.lvProductos);
            this.gbSeleccionar.Controls.Add(this.btnSalir);
            this.gbSeleccionar.Controls.Add(this.btnAceptar);
            this.gbSeleccionar.Controls.Add(this.txtComentario);
            this.gbSeleccionar.Controls.Add(this.txtValoracion);
            this.gbSeleccionar.Controls.Add(this.txtCorreo);
            this.gbSeleccionar.Controls.Add(this.txtNombre);
            this.gbSeleccionar.Controls.Add(this.label3);
            this.gbSeleccionar.Controls.Add(this.lblDireccion);
            this.gbSeleccionar.Controls.Add(this.lblCorreo);
            this.gbSeleccionar.Controls.Add(this.lblNombre);
            this.gbSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionar.Location = new System.Drawing.Point(12, 24);
            this.gbSeleccionar.Name = "gbSeleccionar";
            this.gbSeleccionar.Size = new System.Drawing.Size(558, 371);
            this.gbSeleccionar.TabIndex = 2;
            this.gbSeleccionar.TabStop = false;
            this.gbSeleccionar.Text = "Seleccione el producto a realizar su reseña/analisis";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(283, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(109, 317);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 35);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(271, 216);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(252, 89);
            this.txtComentario.TabIndex = 8;
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(274, 161);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(249, 26);
            this.txtValoracion.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(274, 111);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(249, 26);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(274, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comentarios ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(271, 140);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(88, 18);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Valoración";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(271, 90);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(157, 18);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo Electrónico ";
            // 
            // lvProductos
            // 
            this.lvProductos.FormattingEnabled = true;
            this.lvProductos.ItemHeight = 20;
            this.lvProductos.Location = new System.Drawing.Point(22, 36);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(226, 264);
            this.lvProductos.TabIndex = 12;
            this.lvProductos.SelectedIndexChanged += new System.EventHandler(this.lvProductos_SelectedIndexChanged);
            // 
            // frmReseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 420);
            this.Controls.Add(this.gbSeleccionar);
            this.Name = "frmReseña";
            this.Text = "Reseña/ Analisis de productos";
            this.Load += new System.EventHandler(this.frmReseña_Load);
            this.gbSeleccionar.ResumeLayout(false);
            this.gbSeleccionar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ListBox lvProductos;
    }
}

