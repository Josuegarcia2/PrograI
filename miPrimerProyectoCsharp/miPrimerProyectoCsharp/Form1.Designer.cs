namespace miPrimerProyectoCsharp
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
            this.grbBusquedaAlumnos = new System.Windows.Forms.GroupBox();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarUsuarios = new System.Windows.Forms.TextBox();
            this.grbedicionusuario = new System.Windows.Forms.GroupBox();
            this.btneliminarusuario = new System.Windows.Forms.Button();
            this.btnmodificarusuario = new System.Windows.Forms.Button();
            this.btnagregarusuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.lblResgistroUsuarios = new System.Windows.Forms.Label();
            this.btnultimousuario = new System.Windows.Forms.Button();
            this.btnsiguienteusuario = new System.Windows.Forms.Button();
            this.btnanteriorusuario = new System.Windows.Forms.Button();
            this.btnPrimerousuario = new System.Windows.Forms.Button();
            this.grbDatosusuarios = new System.Windows.Forms.GroupBox();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.Label();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.grbBusquedaAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.grbedicionusuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.grbDatosusuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaAlumnos
            // 
            this.grbBusquedaAlumnos.Controls.Add(this.grdUsuarios);
            this.grbBusquedaAlumnos.Controls.Add(this.txtBuscarUsuarios);
            this.grbBusquedaAlumnos.Location = new System.Drawing.Point(354, 73);
            this.grbBusquedaAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.grbBusquedaAlumnos.Name = "grbBusquedaAlumnos";
            this.grbBusquedaAlumnos.Padding = new System.Windows.Forms.Padding(2);
            this.grbBusquedaAlumnos.Size = new System.Drawing.Size(548, 262);
            this.grbBusquedaAlumnos.TabIndex = 11;
            this.grbBusquedaAlumnos.TabStop = false;
            this.grbBusquedaAlumnos.Text = "Busqueda usuarios";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.usuario,
            this.clave,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdUsuarios.Location = new System.Drawing.Point(21, 59);
            this.grdUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.RowHeadersWidth = 51;
            this.grdUsuarios.RowTemplate.Height = 24;
            this.grdUsuarios.Size = new System.Drawing.Size(510, 187);
            this.grdUsuarios.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "idUsuario";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "CLAVE";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 250;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // txtBuscarUsuarios
            // 
            this.txtBuscarUsuarios.Location = new System.Drawing.Point(21, 37);
            this.txtBuscarUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarUsuarios.Name = "txtBuscarUsuarios";
            this.txtBuscarUsuarios.Size = new System.Drawing.Size(380, 20);
            this.txtBuscarUsuarios.TabIndex = 4;
            // 
            // grbedicionusuario
            // 
            this.grbedicionusuario.Controls.Add(this.btneliminarusuario);
            this.grbedicionusuario.Controls.Add(this.btnmodificarusuario);
            this.grbedicionusuario.Controls.Add(this.btnagregarusuario);
            this.grbedicionusuario.Location = new System.Drawing.Point(354, 354);
            this.grbedicionusuario.Margin = new System.Windows.Forms.Padding(2);
            this.grbedicionusuario.Name = "grbedicionusuario";
            this.grbedicionusuario.Padding = new System.Windows.Forms.Padding(2);
            this.grbedicionusuario.Size = new System.Drawing.Size(329, 81);
            this.grbedicionusuario.TabIndex = 10;
            this.grbedicionusuario.TabStop = false;
            this.grbedicionusuario.Text = "EDICION";
            // 
            // btneliminarusuario
            // 
            this.btneliminarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminarusuario.Location = new System.Drawing.Point(221, 28);
            this.btneliminarusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminarusuario.Name = "btneliminarusuario";
            this.btneliminarusuario.Size = new System.Drawing.Size(104, 43);
            this.btneliminarusuario.TabIndex = 3;
            this.btneliminarusuario.Text = "ELIMINAR";
            this.btneliminarusuario.UseVisualStyleBackColor = true;
            // 
            // btnmodificarusuario
            // 
            this.btnmodificarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificarusuario.Location = new System.Drawing.Point(97, 28);
            this.btnmodificarusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificarusuario.Name = "btnmodificarusuario";
            this.btnmodificarusuario.Size = new System.Drawing.Size(120, 43);
            this.btnmodificarusuario.TabIndex = 2;
            this.btnmodificarusuario.Text = "MODIFICAR";
            this.btnmodificarusuario.UseVisualStyleBackColor = true;
            // 
            // btnagregarusuario
            // 
            this.btnagregarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarusuario.Location = new System.Drawing.Point(4, 28);
            this.btnagregarusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregarusuario.Name = "btnagregarusuario";
            this.btnagregarusuario.Size = new System.Drawing.Size(88, 43);
            this.btnagregarusuario.TabIndex = 0;
            this.btnagregarusuario.Text = "NUEVO";
            this.btnagregarusuario.UseVisualStyleBackColor = true;
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.lblResgistroUsuarios);
            this.grbNavegacionUsuario.Controls.Add(this.btnultimousuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnsiguienteusuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnanteriorusuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimerousuario);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(33, 354);
            this.grbNavegacionUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(268, 81);
            this.grbNavegacionUsuario.TabIndex = 9;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "NAVEGACION";
            // 
            // lblResgistroUsuarios
            // 
            this.lblResgistroUsuarios.AutoSize = true;
            this.lblResgistroUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResgistroUsuarios.Location = new System.Drawing.Point(105, 46);
            this.lblResgistroUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResgistroUsuarios.Name = "lblResgistroUsuarios";
            this.lblResgistroUsuarios.Size = new System.Drawing.Size(42, 13);
            this.lblResgistroUsuarios.TabIndex = 11;
            this.lblResgistroUsuarios.Text = "x de n";
            // 
            // btnultimousuario
            // 
            this.btnultimousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnultimousuario.Location = new System.Drawing.Point(202, 28);
            this.btnultimousuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnultimousuario.Name = "btnultimousuario";
            this.btnultimousuario.Size = new System.Drawing.Size(46, 43);
            this.btnultimousuario.TabIndex = 3;
            this.btnultimousuario.Text = ">|";
            this.btnultimousuario.UseVisualStyleBackColor = true;
            // 
            // btnsiguienteusuario
            // 
            this.btnsiguienteusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguienteusuario.Location = new System.Drawing.Point(152, 28);
            this.btnsiguienteusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnsiguienteusuario.Name = "btnsiguienteusuario";
            this.btnsiguienteusuario.Size = new System.Drawing.Size(46, 43);
            this.btnsiguienteusuario.TabIndex = 2;
            this.btnsiguienteusuario.Text = ">";
            this.btnsiguienteusuario.UseVisualStyleBackColor = true;
            // 
            // btnanteriorusuario
            // 
            this.btnanteriorusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanteriorusuario.Location = new System.Drawing.Point(55, 28);
            this.btnanteriorusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnanteriorusuario.Name = "btnanteriorusuario";
            this.btnanteriorusuario.Size = new System.Drawing.Size(46, 43);
            this.btnanteriorusuario.TabIndex = 1;
            this.btnanteriorusuario.Text = "<";
            this.btnanteriorusuario.UseVisualStyleBackColor = true;
            // 
            // btnPrimerousuario
            // 
            this.btnPrimerousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerousuario.Location = new System.Drawing.Point(4, 28);
            this.btnPrimerousuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrimerousuario.Name = "btnPrimerousuario";
            this.btnPrimerousuario.Size = new System.Drawing.Size(46, 43);
            this.btnPrimerousuario.TabIndex = 0;
            this.btnPrimerousuario.Text = "|<";
            this.btnPrimerousuario.UseVisualStyleBackColor = true;
            // 
            // grbDatosusuarios
            // 
            this.grbDatosusuarios.Controls.Add(this.txtTelefonoUsuario);
            this.grbDatosusuarios.Controls.Add(this.lblTelefonoUsuario);
            this.grbDatosusuarios.Controls.Add(this.idUsuario);
            this.grbDatosusuarios.Controls.Add(this.txtDireccionUsuario);
            this.grbDatosusuarios.Controls.Add(this.lblDireccionUsuario);
            this.grbDatosusuarios.Controls.Add(this.txtNombreUsuario);
            this.grbDatosusuarios.Controls.Add(this.lblNombreUsuario);
            this.grbDatosusuarios.Controls.Add(this.txtClaveUsuario);
            this.grbDatosusuarios.Controls.Add(this.lblClaveUsuario);
            this.grbDatosusuarios.Controls.Add(this.txtUsuario);
            this.grbDatosusuarios.Controls.Add(this.lblUsuario);
            this.grbDatosusuarios.Controls.Add(this.lblIdUsuario);
            this.grbDatosusuarios.Enabled = false;
            this.grbDatosusuarios.Location = new System.Drawing.Point(33, 73);
            this.grbDatosusuarios.Margin = new System.Windows.Forms.Padding(2);
            this.grbDatosusuarios.Name = "grbDatosusuarios";
            this.grbDatosusuarios.Padding = new System.Windows.Forms.Padding(2);
            this.grbDatosusuarios.Size = new System.Drawing.Size(268, 262);
            this.grbDatosusuarios.TabIndex = 8;
            this.grbDatosusuarios.TabStop = false;
            this.grbDatosusuarios.Text = "DATOS";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(122, 240);
            this.txtTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtTelefonoUsuario.TabIndex = 12;
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(30, 245);
            this.lblTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(70, 13);
            this.lblTelefonoUsuario.TabIndex = 11;
            this.lblTelefonoUsuario.Text = "TELEFONO :";
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.Location = new System.Drawing.Point(140, 37);
            this.idUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(35, 13);
            this.idUsuario.TabIndex = 10;
            this.idUsuario.Text = "label1";
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(122, 202);
            this.txtDireccionUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtDireccionUsuario.TabIndex = 9;
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Location = new System.Drawing.Point(30, 207);
            this.lblDireccionUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(69, 13);
            this.lblDireccionUsuario.TabIndex = 8;
            this.lblDireccionUsuario.Text = "DIRECCION:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(122, 159);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(30, 164);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(60, 13);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = " NOMBRE:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(122, 118);
            this.txtClaveUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtClaveUsuario.TabIndex = 5;
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Location = new System.Drawing.Point(30, 118);
            this.lblClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(44, 13);
            this.lblClaveUsuario.TabIndex = 4;
            this.lblClaveUsuario.Text = "CLAVE:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(122, 77);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 77);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "USUARIO :";
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(30, 37);
            this.lblIdUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(24, 13);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(934, 509);
            this.Controls.Add(this.grbBusquedaAlumnos);
            this.Controls.Add(this.grbedicionusuario);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbDatosusuarios);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "CONVERSORES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbBusquedaAlumnos.ResumeLayout(false);
            this.grbBusquedaAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.grbedicionusuario.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.grbDatosusuarios.ResumeLayout(false);
            this.grbDatosusuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaAlumnos;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.TextBox txtBuscarUsuarios;
        private System.Windows.Forms.GroupBox grbedicionusuario;
        private System.Windows.Forms.Button btneliminarusuario;
        private System.Windows.Forms.Button btnmodificarusuario;
        private System.Windows.Forms.Button btnagregarusuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Label lblResgistroUsuarios;
        private System.Windows.Forms.Button btnultimousuario;
        private System.Windows.Forms.Button btnsiguienteusuario;
        private System.Windows.Forms.Button btnanteriorusuario;
        private System.Windows.Forms.Button btnPrimerousuario;
        private System.Windows.Forms.GroupBox grbDatosusuarios;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.Label idUsuario;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
    }
}

