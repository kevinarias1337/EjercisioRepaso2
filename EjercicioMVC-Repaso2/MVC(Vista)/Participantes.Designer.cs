namespace MVC_Vista_
{
    partial class Participantes
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.dtparticipantes = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtparticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "GESTIÓN PARTICIPANTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(47, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cédula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(109, 146);
            this.txtcedula.MaxLength = 9;
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(74, 20);
            this.txtcedula.TabIndex = 7;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress);
            // 
            // cmbpais
            // 
            this.cmbpais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Location = new System.Drawing.Point(109, 218);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(121, 21);
            this.cmbpais.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(64, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "País:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(109, 172);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(132, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(58, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Edad:";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(109, 194);
            this.txtedad.MaxLength = 3;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(36, 20);
            this.txtedad.TabIndex = 12;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // dtparticipantes
            // 
            this.dtparticipantes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtparticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtparticipantes.Location = new System.Drawing.Point(44, 295);
            this.dtparticipantes.Name = "dtparticipantes";
            this.dtparticipantes.Size = new System.Drawing.Size(240, 150);
            this.dtparticipantes.TabIndex = 13;
            this.dtparticipantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtparticipantes_CellClick);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(223, 268);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 16;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "País del participante:";
            this.label6.Visible = false;
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblpais.Location = new System.Drawing.Point(110, 255);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(27, 13);
            this.lblpais.TabIndex = 18;
            this.lblpais.Text = "Pais";
            this.lblpais.Visible = false;
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Location = new System.Drawing.Point(116, 268);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(96, 23);
            this.btnguardarcambios.TabIndex = 19;
            this.btnguardarcambios.Text = "Guardar Cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(29, 268);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 20;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(223, 242);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dtparticipantes);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Participantes";
            this.Text = "Participantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtparticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.DataGridView dtparticipantes;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
    }
}