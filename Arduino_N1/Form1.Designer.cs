namespace Arduino_N1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_encender = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.List_imagen = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.SerPort = new System.IO.Ports.SerialPort(this.components);
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.txt_EscucharSerial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_encender
            // 
            this.btn_encender.BackColor = System.Drawing.Color.Transparent;
            this.btn_encender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encender.ImageKey = "(ninguno)";
            this.btn_encender.Location = new System.Drawing.Point(198, 17);
            this.btn_encender.Name = "btn_encender";
            this.btn_encender.Size = new System.Drawing.Size(107, 68);
            this.btn_encender.TabIndex = 0;
            this.btn_encender.Text = "Encender";
            this.btn_encender.UseVisualStyleBackColor = false;
            this.btn_encender.Click += new System.EventHandler(this.btn_encender_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.Transparent;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.Location = new System.Drawing.Point(321, 17);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(106, 68);
            this.btn_apagar.TabIndex = 1;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // List_imagen
            // 
            this.List_imagen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("List_imagen.ImageStream")));
            this.List_imagen.TransparentColor = System.Drawing.Color.Transparent;
            this.List_imagen.Images.SetKeyName(0, "boton-encendido.png");
            this.List_imagen.Images.SetKeyName(1, "boton-apagado.png");
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Peru;
            this.treeView1.Location = new System.Drawing.Point(32, 126);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(171, 303);
            this.treeView1.TabIndex = 3;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(293, 196);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(277, 268);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(121, 21);
            this.CboPuertos.TabIndex = 6;
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(277, 313);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(121, 23);
            this.btn_conectar.TabIndex = 7;
            this.btn_conectar.Text = "Conectar Puerto";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // txt_EscucharSerial
            // 
            this.txt_EscucharSerial.Location = new System.Drawing.Point(277, 363);
            this.txt_EscucharSerial.Name = "txt_EscucharSerial";
            this.txt_EscucharSerial.Size = new System.Drawing.Size(121, 20);
            this.txt_EscucharSerial.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 473);
            this.Controls.Add(this.txt_EscucharSerial);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_encender);
            this.Name = "Form1";
            this.Text = "Peobador de Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_encender;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList List_imagen;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.IO.Ports.SerialPort SerPort;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.TextBox txt_EscucharSerial;
    }
}

