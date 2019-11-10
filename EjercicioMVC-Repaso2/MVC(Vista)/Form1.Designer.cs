namespace MVC_Vista_
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
            this.dtpaises = new System.Windows.Forms.DataGridView();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardarcambios = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpaises
            // 
            this.dtpaises.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpaises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpais,
            this.nombrepais});
            this.dtpaises.Location = new System.Drawing.Point(12, 328);
            this.dtpaises.Name = "dtpaises";
            this.dtpaises.Size = new System.Drawing.Size(296, 119);
            this.dtpaises.TabIndex = 0;
            this.dtpaises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtpaises_CellClick);
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "idpais";
            this.idpais.HeaderText = "Código";
            this.idpais.Name = "idpais";
            // 
            // nombrepais
            // 
            this.nombrepais.DataPropertyName = "nombrepais";
            this.nombrepais.HeaderText = "Pais";
            this.nombrepais.Name = "nombrepais";
            this.nombrepais.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(128, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paises";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(67, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "GESTIÓN PAISES";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(153, 159);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(32, 162);
            this.txtpais.MaxLength = 50;
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 20);
            this.txtpais.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(33, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pais";
            // 
            // btnguardarcambios
            // 
            this.btnguardarcambios.Location = new System.Drawing.Point(234, 182);
            this.btnguardarcambios.Name = "btnguardarcambios";
            this.btnguardarcambios.Size = new System.Drawing.Size(75, 34);
            this.btnguardarcambios.TabIndex = 6;
            this.btnguardarcambios.Text = "Guardar cambios";
            this.btnguardarcambios.UseVisualStyleBackColor = true;
            this.btnguardarcambios.Click += new System.EventHandler(this.btnguardarcambios_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(153, 188);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(153, 217);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(32, 211);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 9;
            this.txtcodigo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(33, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Código";
            this.label4.Visible = false;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(10, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardarcambios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpaises);
            this.Name = "Form1";
            this.Text = "GESTION PAISES";
            ((System.ComponentModel.ISupportInitialize)(this.dtpaises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtpaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardarcambios;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnvolver;
    }
}

