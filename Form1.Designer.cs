
namespace ejemplo2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblfechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cbbOrigen = new System.Windows.Forms.ComboBox();
            this.lblTerritorios = new System.Windows.Forms.Label();
            this.gpbRaza = new System.Windows.Forms.GroupBox();
            this.rdbVampiro = new System.Windows.Forms.RadioButton();
            this.rdbHumano = new System.Windows.Forms.RadioButton();
            this.rdbElfo = new System.Windows.Forms.RadioButton();
            this.ckbMagia = new System.Windows.Forms.CheckBox();
            this.numTerritorios = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarPersonaje = new System.Windows.Forms.Button();
            this.gpbRaza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerritorios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(128, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(83, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(231, 35);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(200, 22);
            this.txbNombre.TabIndex = 1;
            // 
            // lblfechaNacimiento
            // 
            this.lblfechaNacimiento.AutoSize = true;
            this.lblfechaNacimiento.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaNacimiento.Location = new System.Drawing.Point(44, 69);
            this.lblfechaNacimiento.Name = "lblfechaNacimiento";
            this.lblfechaNacimiento.Size = new System.Drawing.Size(167, 22);
            this.lblfechaNacimiento.TabIndex = 2;
            this.lblfechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(231, 69);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(139, 106);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(72, 22);
            this.lblOrigen.TabIndex = 4;
            this.lblOrigen.Text = "Origen:";
            // 
            // cbbOrigen
            // 
            this.cbbOrigen.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbOrigen.FormattingEnabled = true;
            this.cbbOrigen.Location = new System.Drawing.Point(231, 102);
            this.cbbOrigen.Name = "cbbOrigen";
            this.cbbOrigen.Size = new System.Drawing.Size(200, 30);
            this.cbbOrigen.TabIndex = 5;
            // 
            // lblTerritorios
            // 
            this.lblTerritorios.AutoSize = true;
            this.lblTerritorios.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerritorios.Location = new System.Drawing.Point(128, 306);
            this.lblTerritorios.Name = "lblTerritorios";
            this.lblTerritorios.Size = new System.Drawing.Size(99, 22);
            this.lblTerritorios.TabIndex = 8;
            this.lblTerritorios.Text = "Territorios:";
            // 
            // gpbRaza
            // 
            this.gpbRaza.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.gpbRaza.Controls.Add(this.rdbVampiro);
            this.gpbRaza.Controls.Add(this.rdbHumano);
            this.gpbRaza.Controls.Add(this.rdbElfo);
            this.gpbRaza.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRaza.Location = new System.Drawing.Point(132, 153);
            this.gpbRaza.Name = "gpbRaza";
            this.gpbRaza.Size = new System.Drawing.Size(343, 100);
            this.gpbRaza.TabIndex = 6;
            this.gpbRaza.TabStop = false;
            this.gpbRaza.Text = "Raza:";
            // 
            // rdbVampiro
            // 
            this.rdbVampiro.AutoSize = true;
            this.rdbVampiro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVampiro.Location = new System.Drawing.Point(217, 44);
            this.rdbVampiro.Name = "rdbVampiro";
            this.rdbVampiro.Size = new System.Drawing.Size(82, 21);
            this.rdbVampiro.TabIndex = 2;
            this.rdbVampiro.TabStop = true;
            this.rdbVampiro.Text = "Vampiro";
            this.rdbVampiro.UseVisualStyleBackColor = true;
            // 
            // rdbHumano
            // 
            this.rdbHumano.AutoSize = true;
            this.rdbHumano.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHumano.Location = new System.Drawing.Point(108, 44);
            this.rdbHumano.Name = "rdbHumano";
            this.rdbHumano.Size = new System.Drawing.Size(84, 21);
            this.rdbHumano.TabIndex = 1;
            this.rdbHumano.TabStop = true;
            this.rdbHumano.Text = "Humano";
            this.rdbHumano.UseVisualStyleBackColor = true;
            // 
            // rdbElfo
            // 
            this.rdbElfo.AutoSize = true;
            this.rdbElfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElfo.Location = new System.Drawing.Point(25, 44);
            this.rdbElfo.Name = "rdbElfo";
            this.rdbElfo.Size = new System.Drawing.Size(54, 21);
            this.rdbElfo.TabIndex = 0;
            this.rdbElfo.TabStop = true;
            this.rdbElfo.Text = "Elfo";
            this.rdbElfo.UseVisualStyleBackColor = true;
            // 
            // ckbMagia
            // 
            this.ckbMagia.AutoSize = true;
            this.ckbMagia.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMagia.Location = new System.Drawing.Point(132, 268);
            this.ckbMagia.Name = "ckbMagia";
            this.ckbMagia.Size = new System.Drawing.Size(82, 26);
            this.ckbMagia.TabIndex = 7;
            this.ckbMagia.Text = "Magia";
            this.ckbMagia.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckbMagia.UseVisualStyleBackColor = true;
            // 
            // numTerritorios
            // 
            this.numTerritorios.Location = new System.Drawing.Point(240, 308);
            this.numTerritorios.Name = "numTerritorios";
            this.numTerritorios.Size = new System.Drawing.Size(120, 22);
            this.numTerritorios.TabIndex = 9;
            // 
            // btnGenerarPersonaje
            // 
            this.btnGenerarPersonaje.BackColor = System.Drawing.Color.Olive;
            this.btnGenerarPersonaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarPersonaje.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPersonaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerarPersonaje.Location = new System.Drawing.Point(180, 375);
            this.btnGenerarPersonaje.Name = "btnGenerarPersonaje";
            this.btnGenerarPersonaje.Size = new System.Drawing.Size(223, 41);
            this.btnGenerarPersonaje.TabIndex = 10;
            this.btnGenerarPersonaje.Text = "Generar Personaje";
            this.btnGenerarPersonaje.UseVisualStyleBackColor = false;
            this.btnGenerarPersonaje.Click += new System.EventHandler(this.btnGenerarPersonaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.btnGenerarPersonaje);
            this.Controls.Add(this.numTerritorios);
            this.Controls.Add(this.ckbMagia);
            this.Controls.Add(this.lblTerritorios);
            this.Controls.Add(this.gpbRaza);
            this.Controls.Add(this.cbbOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblfechaNacimiento);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.gpbRaza.ResumeLayout(false);
            this.gpbRaza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerritorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblfechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cbbOrigen;
        private System.Windows.Forms.Label lblTerritorios;
        private System.Windows.Forms.GroupBox gpbRaza;
        private System.Windows.Forms.RadioButton rdbVampiro;
        private System.Windows.Forms.RadioButton rdbHumano;
        private System.Windows.Forms.RadioButton rdbElfo;
        private System.Windows.Forms.CheckBox ckbMagia;
        private System.Windows.Forms.NumericUpDown numTerritorios;
        private System.Windows.Forms.Button btnGenerarPersonaje;
    }
}

