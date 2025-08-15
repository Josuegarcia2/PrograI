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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.cmbDe = new System.Windows.Forms.ComboBox();
            this.lblA = new System.Windows.Forms.Label();
            this.cmbA = new System.Windows.Forms.ComboBox();
            this.lblValorAConvertir = new System.Windows.Forms.Label();
            this.txtValorAConvertir = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTipodeConversor = new System.Windows.Forms.Label();
            this.cmbTipoConversor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERSOR ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(66, 189);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(36, 20);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De:";
            // 
            // cmbDe
            // 
            this.cmbDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDe.FormattingEnabled = true;
            this.cmbDe.Items.AddRange(new object[] {
            "Monedas",
            "Masa",
            "Volumen ",
            "Longitud ",
            "Almacenamiento",
            "Tiempo"});
            this.cmbDe.Location = new System.Drawing.Point(130, 181);
            this.cmbDe.Name = "cmbDe";
            this.cmbDe.Size = new System.Drawing.Size(191, 28);
            this.cmbDe.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(417, 181);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(25, 20);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A:";
            // 
            // cmbA
            // 
            this.cmbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbA.FormattingEnabled = true;
            this.cmbA.Items.AddRange(new object[] {
            "Monedas",
            "Masa",
            "Volumen ",
            "Longitud ",
            "Almacenamiento",
            "Tiempo"});
            this.cmbA.Location = new System.Drawing.Point(459, 181);
            this.cmbA.Name = "cmbA";
            this.cmbA.Size = new System.Drawing.Size(191, 28);
            this.cmbA.TabIndex = 4;
            // 
            // lblValorAConvertir
            // 
            this.lblValorAConvertir.AutoSize = true;
            this.lblValorAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAConvertir.Location = new System.Drawing.Point(66, 97);
            this.lblValorAConvertir.Name = "lblValorAConvertir";
            this.lblValorAConvertir.Size = new System.Drawing.Size(140, 20);
            this.lblValorAConvertir.TabIndex = 5;
            this.lblValorAConvertir.Text = "Valor a Convertir:";
            // 
            // txtValorAConvertir
            // 
            this.txtValorAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAConvertir.Location = new System.Drawing.Point(212, 94);
            this.txtValorAConvertir.Name = "txtValorAConvertir";
            this.txtValorAConvertir.Size = new System.Drawing.Size(100, 27);
            this.txtValorAConvertir.TabIndex = 6;
            this.txtValorAConvertir.TextChanged += new System.EventHandler(this.txtValorAConvertir_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(703, 375);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(121, 49);
            this.btnConvertir.TabIndex = 7;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(840, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 49);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(28, 341);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(138, 29);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblTipodeConversor
            // 
            this.lblTipodeConversor.AutoSize = true;
            this.lblTipodeConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeConversor.Location = new System.Drawing.Point(634, 70);
            this.lblTipodeConversor.Name = "lblTipodeConversor";
            this.lblTipodeConversor.Size = new System.Drawing.Size(151, 20);
            this.lblTipodeConversor.TabIndex = 10;
            this.lblTipodeConversor.Text = "Tipo de Conversor ";
            // 
            // cmbTipoConversor
            // 
            this.cmbTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoConversor.FormattingEnabled = true;
            this.cmbTipoConversor.Location = new System.Drawing.Point(618, 93);
            this.cmbTipoConversor.Name = "cmbTipoConversor";
            this.cmbTipoConversor.Size = new System.Drawing.Size(191, 28);
            this.cmbTipoConversor.TabIndex = 11;
            this.cmbTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cmbTipoConversor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(995, 436);
            this.Controls.Add(this.cmbTipoConversor);
            this.Controls.Add(this.lblTipodeConversor);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtValorAConvertir);
            this.Controls.Add(this.lblValorAConvertir);
            this.Controls.Add(this.cmbA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cmbDe);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.ComboBox cmbDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cmbA;
        private System.Windows.Forms.Label lblValorAConvertir;
        private System.Windows.Forms.TextBox txtValorAConvertir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTipodeConversor;
        private System.Windows.Forms.ComboBox cmbTipoConversor;
    }
}

