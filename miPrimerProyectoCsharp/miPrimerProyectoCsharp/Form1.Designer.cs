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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(82, 64);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(48, 16);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Num 1:";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(132, 61);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 22);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(132, 89);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 22);
            this.txtnum2.TabIndex = 3;
            this.txtnum2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(82, 92);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(48, 16);
            this.lblnum2.TabIndex = 2;
            this.lblnum2.Text = "Num 2:";
            this.lblnum2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(269, 44);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(159, 86);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(82, 178);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(89, 16);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "Respuesta:  ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(715, 347);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnum1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblrespuesta;
    }
}

