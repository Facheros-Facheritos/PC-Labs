
namespace CapPresentacion
{
    partial class FrmAccesorio
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
            this.txtTeclado = new System.Windows.Forms.TextBox();
            this.txtMouse = new System.Windows.Forms.TextBox();
            this.txtParlantes = new System.Windows.Forms.TextBox();
            this.txtImpresora = new System.Windows.Forms.TextBox();
            this.txtAudifonos = new System.Windows.Forms.TextBox();
            this.txtCamaraWeb = new System.Windows.Forms.TextBox();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnComplementar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeclado
            // 
            this.txtTeclado.Location = new System.Drawing.Point(252, 12);
            this.txtTeclado.Name = "txtTeclado";
            this.txtTeclado.Size = new System.Drawing.Size(100, 20);
            this.txtTeclado.TabIndex = 0;
            // 
            // txtMouse
            // 
            this.txtMouse.Location = new System.Drawing.Point(252, 142);
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.Size = new System.Drawing.Size(100, 20);
            this.txtMouse.TabIndex = 2;
            // 
            // txtParlantes
            // 
            this.txtParlantes.Location = new System.Drawing.Point(252, 116);
            this.txtParlantes.Name = "txtParlantes";
            this.txtParlantes.Size = new System.Drawing.Size(100, 20);
            this.txtParlantes.TabIndex = 3;
            // 
            // txtImpresora
            // 
            this.txtImpresora.Location = new System.Drawing.Point(252, 64);
            this.txtImpresora.Name = "txtImpresora";
            this.txtImpresora.Size = new System.Drawing.Size(100, 20);
            this.txtImpresora.TabIndex = 4;
            // 
            // txtAudifonos
            // 
            this.txtAudifonos.Location = new System.Drawing.Point(252, 90);
            this.txtAudifonos.Name = "txtAudifonos";
            this.txtAudifonos.Size = new System.Drawing.Size(100, 20);
            this.txtAudifonos.TabIndex = 5;
            // 
            // txtCamaraWeb
            // 
            this.txtCamaraWeb.Location = new System.Drawing.Point(252, 38);
            this.txtCamaraWeb.Name = "txtCamaraWeb";
            this.txtCamaraWeb.Size = new System.Drawing.Size(100, 20);
            this.txtCamaraWeb.TabIndex = 6;
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.Color.Black;
            this.btnEscribir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEscribir.Location = new System.Drawing.Point(298, 238);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 7;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.Black;
            this.btnLeer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeer.Location = new System.Drawing.Point(417, 217);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(50, 391);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar()";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnRecibir
            // 
            this.btnRecibir.Location = new System.Drawing.Point(214, 391);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(75, 23);
            this.btnRecibir.TabIndex = 10;
            this.btnRecibir.Text = "Recibir()";
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(389, 391);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 11;
            this.btnEjecutar.Text = "Ejecutar()";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnComplementar
            // 
            this.btnComplementar.Location = new System.Drawing.Point(550, 391);
            this.btnComplementar.Name = "btnComplementar";
            this.btnComplementar.Size = new System.Drawing.Size(100, 23);
            this.btnComplementar.TabIndex = 12;
            this.btnComplementar.Text = "Complementar()";
            this.btnComplementar.UseVisualStyleBackColor = true;
            this.btnComplementar.Click += new System.EventHandler(this.btnComplementar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapPresentacion.Properties.Resources.ssassads;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(141, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Teclado :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(141, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Mouse :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox3.Location = new System.Drawing.Point(141, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Parlantes :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox4.Location = new System.Drawing.Point(141, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(78, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Audifonos :";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox5.Location = new System.Drawing.Point(141, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Impresora :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox6.Location = new System.Drawing.Point(141, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(78, 20);
            this.textBox6.TabIndex = 19;
            this.textBox6.Text = "Camara Web :";
            // 
            // FrmAccesorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 435);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnComplementar);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.txtCamaraWeb);
            this.Controls.Add(this.txtAudifonos);
            this.Controls.Add(this.txtImpresora);
            this.Controls.Add(this.txtParlantes);
            this.Controls.Add(this.txtMouse);
            this.Controls.Add(this.txtTeclado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAccesorio";
            this.Text = "FrmAccesorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeclado;
        private System.Windows.Forms.TextBox txtMouse;
        private System.Windows.Forms.TextBox txtParlantes;
        private System.Windows.Forms.TextBox txtImpresora;
        private System.Windows.Forms.TextBox txtAudifonos;
        private System.Windows.Forms.TextBox txtCamaraWeb;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnComplementar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}