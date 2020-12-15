namespace WindowsFormsApp4
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
            this.numNumerador1 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador1 = new System.Windows.Forms.NumericUpDown();
            this.numNumerador2 = new System.Windows.Forms.NumericUpDown();
            this.numDenominador2 = new System.Windows.Forms.NumericUpDown();
            this.lblCalcularResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numEntero1 = new System.Windows.Forms.NumericUpDown();
            this.numEntero2 = new System.Windows.Forms.NumericUpDown();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.lblResultadoDenominador = new System.Windows.Forms.Label();
            this.lblResultadoNumerador = new System.Windows.Forms.Label();
            this.lblResultadoEntero = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero2)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumerador1
            // 
            this.numNumerador1.Location = new System.Drawing.Point(124, 62);
            this.numNumerador1.Name = "numNumerador1";
            this.numNumerador1.Size = new System.Drawing.Size(52, 20);
            this.numNumerador1.TabIndex = 0;
            this.numNumerador1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDenominador1
            // 
            this.numDenominador1.Location = new System.Drawing.Point(124, 108);
            this.numDenominador1.Name = "numDenominador1";
            this.numDenominador1.Size = new System.Drawing.Size(52, 20);
            this.numDenominador1.TabIndex = 1;
            this.numDenominador1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numNumerador2
            // 
            this.numNumerador2.Location = new System.Drawing.Point(313, 62);
            this.numNumerador2.Name = "numNumerador2";
            this.numNumerador2.Size = new System.Drawing.Size(54, 20);
            this.numNumerador2.TabIndex = 2;
            this.numNumerador2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDenominador2
            // 
            this.numDenominador2.Location = new System.Drawing.Point(313, 108);
            this.numDenominador2.Name = "numDenominador2";
            this.numDenominador2.Size = new System.Drawing.Size(54, 20);
            this.numDenominador2.TabIndex = 3;
            this.numDenominador2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCalcularResultado
            // 
            this.lblCalcularResultado.AutoSize = true;
            this.lblCalcularResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularResultado.Location = new System.Drawing.Point(406, 85);
            this.lblCalcularResultado.Name = "lblCalcularResultado";
            this.lblCalcularResultado.Size = new System.Drawing.Size(30, 31);
            this.lblCalcularResultado.TabIndex = 4;
            this.lblCalcularResultado.Text = "=";
            this.lblCalcularResultado.Click += new System.EventHandler(this.lblCalcularResultado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "__________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "__________";
            // 
            // numEntero1
            // 
            this.numEntero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntero1.Location = new System.Drawing.Point(74, 75);
            this.numEntero1.Name = "numEntero1";
            this.numEntero1.Size = new System.Drawing.Size(41, 29);
            this.numEntero1.TabIndex = 10;
            // 
            // numEntero2
            // 
            this.numEntero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEntero2.Location = new System.Drawing.Point(266, 75);
            this.numEntero2.Name = "numEntero2";
            this.numEntero2.Size = new System.Drawing.Size(41, 29);
            this.numEntero2.TabIndex = 11;
            // 
            // cboOperacion
            // 
            this.cboOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cboOperacion.Location = new System.Drawing.Point(204, 74);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(35, 32);
            this.cboOperacion.TabIndex = 12;
            // 
            // lblResultadoDenominador
            // 
            this.lblResultadoDenominador.AutoSize = true;
            this.lblResultadoDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDenominador.Location = new System.Drawing.Point(537, 114);
            this.lblResultadoDenominador.Name = "lblResultadoDenominador";
            this.lblResultadoDenominador.Size = new System.Drawing.Size(22, 31);
            this.lblResultadoDenominador.TabIndex = 17;
            this.lblResultadoDenominador.Text = ".";
            // 
            // lblResultadoNumerador
            // 
            this.lblResultadoNumerador.AutoSize = true;
            this.lblResultadoNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNumerador.Location = new System.Drawing.Point(537, 57);
            this.lblResultadoNumerador.Name = "lblResultadoNumerador";
            this.lblResultadoNumerador.Size = new System.Drawing.Size(22, 31);
            this.lblResultadoNumerador.TabIndex = 18;
            this.lblResultadoNumerador.Text = ".";
            // 
            // lblResultadoEntero
            // 
            this.lblResultadoEntero.AutoSize = true;
            this.lblResultadoEntero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoEntero.Location = new System.Drawing.Point(455, 85);
            this.lblResultadoEntero.Name = "lblResultadoEntero";
            this.lblResultadoEntero.Size = new System.Drawing.Size(22, 31);
            this.lblResultadoEntero.TabIndex = 19;
            this.lblResultadoEntero.Text = ".";
            this.lblResultadoEntero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(499, 100);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(109, 13);
            this.lblLinea.TabIndex = 16;
            this.lblLinea.Text = "_________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultadoDenominador);
            this.Controls.Add(this.lblResultadoNumerador);
            this.Controls.Add(this.lblResultadoEntero);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.numEntero2);
            this.Controls.Add(this.numEntero1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCalcularResultado);
            this.Controls.Add(this.numDenominador2);
            this.Controls.Add(this.numNumerador2);
            this.Controls.Add(this.numDenominador1);
            this.Controls.Add(this.numNumerador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenominador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumerador1;
        private System.Windows.Forms.NumericUpDown numDenominador1;
        private System.Windows.Forms.NumericUpDown numNumerador2;
        private System.Windows.Forms.NumericUpDown numDenominador2;
        private System.Windows.Forms.Label lblCalcularResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numEntero1;
        private System.Windows.Forms.NumericUpDown numEntero2;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Label lblResultadoDenominador;
        private System.Windows.Forms.Label lblResultadoNumerador;
        private System.Windows.Forms.Label lblResultadoEntero;
        private System.Windows.Forms.Label lblLinea;
    }
}

