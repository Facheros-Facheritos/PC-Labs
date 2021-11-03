
namespace CapPresentacion
{
    partial class FrmCPU
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
            this.txtMemRAM = new System.Windows.Forms.TextBox();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.txtSisRefrigeracion = new System.Windows.Forms.TextBox();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.txtPlacaBase = new System.Windows.Forms.TextBox();
            this.txtDiscoDuro = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnInterpretar = new System.Windows.Forms.Button();
            this.btnTransformar = new System.Windows.Forms.Button();
            this.btnEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemRAM
            // 
            this.txtMemRAM.Location = new System.Drawing.Point(538, 32);
            this.txtMemRAM.Name = "txtMemRAM";
            this.txtMemRAM.Size = new System.Drawing.Size(133, 20);
            this.txtMemRAM.TabIndex = 0;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(538, 162);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(133, 20);
            this.txtTarjeta.TabIndex = 1;
            // 
            // txtSisRefrigeracion
            // 
            this.txtSisRefrigeracion.Location = new System.Drawing.Point(538, 136);
            this.txtSisRefrigeracion.Name = "txtSisRefrigeracion";
            this.txtSisRefrigeracion.Size = new System.Drawing.Size(133, 20);
            this.txtSisRefrigeracion.TabIndex = 2;
            // 
            // txtProcesador
            // 
            this.txtProcesador.Location = new System.Drawing.Point(538, 84);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(133, 20);
            this.txtProcesador.TabIndex = 3;
            // 
            // txtPlacaBase
            // 
            this.txtPlacaBase.Location = new System.Drawing.Point(538, 110);
            this.txtPlacaBase.Name = "txtPlacaBase";
            this.txtPlacaBase.Size = new System.Drawing.Size(133, 20);
            this.txtPlacaBase.TabIndex = 4;
            // 
            // txtDiscoDuro
            // 
            this.txtDiscoDuro.Location = new System.Drawing.Point(538, 58);
            this.txtDiscoDuro.Name = "txtDiscoDuro";
            this.txtDiscoDuro.Size = new System.Drawing.Size(133, 20);
            this.txtDiscoDuro.TabIndex = 5;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(481, 196);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 6;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(571, 196);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 7;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(41, 315);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar()";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(153, 315);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 9;
            this.btnProcesar.Text = "Procesar()";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnInterpretar
            // 
            this.btnInterpretar.Location = new System.Drawing.Point(257, 315);
            this.btnInterpretar.Name = "btnInterpretar";
            this.btnInterpretar.Size = new System.Drawing.Size(75, 23);
            this.btnInterpretar.TabIndex = 10;
            this.btnInterpretar.Text = "Interpretar()";
            this.btnInterpretar.UseVisualStyleBackColor = true;
            this.btnInterpretar.Click += new System.EventHandler(this.btnInterpretar_Click);
            // 
            // btnTransformar
            // 
            this.btnTransformar.Location = new System.Drawing.Point(365, 315);
            this.btnTransformar.Name = "btnTransformar";
            this.btnTransformar.Size = new System.Drawing.Size(84, 23);
            this.btnTransformar.TabIndex = 11;
            this.btnTransformar.Text = "Transformar()";
            this.btnTransformar.UseVisualStyleBackColor = true;
            this.btnTransformar.Click += new System.EventHandler(this.btnTransformar_Click);
            // 
            // btnEncender
            // 
            this.btnEncender.Location = new System.Drawing.Point(490, 315);
            this.btnEncender.Name = "btnEncender";
            this.btnEncender.Size = new System.Drawing.Size(75, 23);
            this.btnEncender.TabIndex = 12;
            this.btnEncender.Text = "Encender()";
            this.btnEncender.UseVisualStyleBackColor = true;
            this.btnEncender.Click += new System.EventHandler(this.btnEncender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(596, 315);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 13;
            this.btnApagar.Text = "Apagar()";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(430, 61);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(102, 13);
            this.textBox6.TabIndex = 33;
            this.textBox6.Text = "Disco Duro :";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(430, 87);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(102, 13);
            this.textBox5.TabIndex = 32;
            this.textBox5.Text = "Procesador :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(430, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 13);
            this.textBox4.TabIndex = 31;
            this.textBox4.Text = "Placa Base :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(430, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 13);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "Sistemas de Refrig. :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(430, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 13);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "Tarjeta :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(430, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 13);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Memoria RAM :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapPresentacion.Properties.Resources.WhatsApp_Image_2021_11_02_at_10_36_47_PM;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 363);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEncender);
            this.Controls.Add(this.btnTransformar);
            this.Controls.Add(this.btnInterpretar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtDiscoDuro);
            this.Controls.Add(this.txtPlacaBase);
            this.Controls.Add(this.txtProcesador);
            this.Controls.Add(this.txtSisRefrigeracion);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.txtMemRAM);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCPU";
            this.Text = "FrmCPU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemRAM;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TextBox txtSisRefrigeracion;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.TextBox txtPlacaBase;
        private System.Windows.Forms.TextBox txtDiscoDuro;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnInterpretar;
        private System.Windows.Forms.Button btnTransformar;
        private System.Windows.Forms.Button btnEncender;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}