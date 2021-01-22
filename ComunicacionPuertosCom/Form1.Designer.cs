namespace ComunicacionPuertosCom
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
            this.btnBuscarPuertos = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.cmbBufferRate = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.tbDatosEnviar = new System.Windows.Forms.TextBox();
            this.tbDatosRecibidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarPuertos
            // 
            this.btnBuscarPuertos.Location = new System.Drawing.Point(32, 67);
            this.btnBuscarPuertos.Name = "btnBuscarPuertos";
            this.btnBuscarPuertos.Size = new System.Drawing.Size(117, 23);
            this.btnBuscarPuertos.TabIndex = 0;
            this.btnBuscarPuertos.Text = "Buscar Puertos";
            this.btnBuscarPuertos.UseVisualStyleBackColor = true;
            this.btnBuscarPuertos.Click += new System.EventHandler(this.btnBuscarPuertos_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(415, 67);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(118, 23);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "CONECTAR";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviarDatos
            // 
            this.btnEnviarDatos.Location = new System.Drawing.Point(32, 279);
            this.btnEnviarDatos.Name = "btnEnviarDatos";
            this.btnEnviarDatos.Size = new System.Drawing.Size(117, 23);
            this.btnEnviarDatos.TabIndex = 2;
            this.btnEnviarDatos.Text = "Enviar Datos";
            this.btnEnviarDatos.UseVisualStyleBackColor = true;
            this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buffer Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datos Recibidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stop Bits";
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(185, 67);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(174, 21);
            this.cmbPuertos.TabIndex = 7;
            // 
            // cmbBufferRate
            // 
            this.cmbBufferRate.FormattingEnabled = true;
            this.cmbBufferRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "9600",
            "19200"});
            this.cmbBufferRate.Location = new System.Drawing.Point(185, 113);
            this.cmbBufferRate.Name = "cmbBufferRate";
            this.cmbBufferRate.Size = new System.Drawing.Size(174, 21);
            this.cmbBufferRate.TabIndex = 8;
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cmbParity.Location = new System.Drawing.Point(185, 169);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(174, 21);
            this.cmbParity.TabIndex = 9;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopBits.Location = new System.Drawing.Point(185, 224);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(174, 21);
            this.cmbStopBits.TabIndex = 10;
            // 
            // tbDatosEnviar
            // 
            this.tbDatosEnviar.Location = new System.Drawing.Point(185, 279);
            this.tbDatosEnviar.Name = "tbDatosEnviar";
            this.tbDatosEnviar.Size = new System.Drawing.Size(174, 20);
            this.tbDatosEnviar.TabIndex = 11;
            // 
            // tbDatosRecibidos
            // 
            this.tbDatosRecibidos.Location = new System.Drawing.Point(185, 320);
            this.tbDatosRecibidos.Name = "tbDatosRecibidos";
            this.tbDatosRecibidos.Size = new System.Drawing.Size(174, 20);
            this.tbDatosRecibidos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 374);
            this.Controls.Add(this.tbDatosRecibidos);
            this.Controls.Add(this.tbDatosEnviar);
            this.Controls.Add(this.cmbStopBits);
            this.Controls.Add(this.cmbParity);
            this.Controls.Add(this.cmbBufferRate);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarDatos);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnBuscarPuertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarPuertos;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.ComboBox cmbBufferRate;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.TextBox tbDatosEnviar;
        private System.Windows.Forms.TextBox tbDatosRecibidos;
    }
}

