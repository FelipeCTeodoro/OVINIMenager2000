namespace OVINIMenager2000
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMaxAbduzido = new System.Windows.Forms.Label();
            this.lblMaxTripulantes = new System.Windows.Forms.Label();
            this.lblPlanetaOrigem = new System.Windows.Forms.Label();
            this.nudMaxAbduzido = new System.Windows.Forms.NumericUpDown();
            this.nudMaxTripulantes = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbPlanetaOrigem = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAbduzido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTripulantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(285, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "OVNI MANEGER";
            // 
            // lblMaxAbduzido
            // 
            this.lblMaxAbduzido.AutoSize = true;
            this.lblMaxAbduzido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAbduzido.Location = new System.Drawing.Point(291, 127);
            this.lblMaxAbduzido.Name = "lblMaxAbduzido";
            this.lblMaxAbduzido.Size = new System.Drawing.Size(111, 16);
            this.lblMaxAbduzido.TabIndex = 1;
            this.lblMaxAbduzido.Text = "MAX.Abduzido:";
            // 
            // lblMaxTripulantes
            // 
            this.lblMaxTripulantes.AutoSize = true;
            this.lblMaxTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTripulantes.Location = new System.Drawing.Point(291, 155);
            this.lblMaxTripulantes.Name = "lblMaxTripulantes";
            this.lblMaxTripulantes.Size = new System.Drawing.Size(124, 16);
            this.lblMaxTripulantes.TabIndex = 2;
            this.lblMaxTripulantes.Text = "MAX.Tripulantes:";
            // 
            // lblPlanetaOrigem
            // 
            this.lblPlanetaOrigem.AutoSize = true;
            this.lblPlanetaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetaOrigem.Location = new System.Drawing.Point(291, 185);
            this.lblPlanetaOrigem.Name = "lblPlanetaOrigem";
            this.lblPlanetaOrigem.Size = new System.Drawing.Size(140, 16);
            this.lblPlanetaOrigem.TabIndex = 3;
            this.lblPlanetaOrigem.Text = "Planeta de Origem:";
            // 
            // nudMaxAbduzido
            // 
            this.nudMaxAbduzido.Location = new System.Drawing.Point(419, 123);
            this.nudMaxAbduzido.Name = "nudMaxAbduzido";
            this.nudMaxAbduzido.Size = new System.Drawing.Size(120, 20);
            this.nudMaxAbduzido.TabIndex = 4;
            // 
            // nudMaxTripulantes
            // 
            this.nudMaxTripulantes.Location = new System.Drawing.Point(421, 151);
            this.nudMaxTripulantes.Name = "nudMaxTripulantes";
            this.nudMaxTripulantes.Size = new System.Drawing.Size(120, 20);
            this.nudMaxTripulantes.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OVINIMenager2000.Properties.Resources.OVNI;
            this.pictureBox1.Location = new System.Drawing.Point(25, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmbPlanetaOrigem
            // 
            this.cmbPlanetaOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetaOrigem.FormattingEnabled = true;
            this.cmbPlanetaOrigem.Location = new System.Drawing.Point(436, 180);
            this.cmbPlanetaOrigem.Name = "cmbPlanetaOrigem";
            this.cmbPlanetaOrigem.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanetaOrigem.TabIndex = 7;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(339, 248);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(161, 36);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlanetaOrigem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudMaxTripulantes);
            this.Controls.Add(this.nudMaxAbduzido);
            this.Controls.Add(this.lblPlanetaOrigem);
            this.Controls.Add(this.lblMaxTripulantes);
            this.Controls.Add(this.lblMaxAbduzido);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAbduzido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTripulantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMaxAbduzido;
        private System.Windows.Forms.Label lblMaxTripulantes;
        private System.Windows.Forms.Label lblPlanetaOrigem;
        private System.Windows.Forms.NumericUpDown nudMaxAbduzido;
        private System.Windows.Forms.NumericUpDown nudMaxTripulantes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbPlanetaOrigem;
        private System.Windows.Forms.Button btnIniciar;
    }
}