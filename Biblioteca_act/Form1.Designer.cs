namespace Biblioteca_act
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
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_idprov = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Por = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(56, 283);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 23);
            this.btn_agregar.TabIndex = 0;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(235, 283);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(87, 23);
            this.btn_mod.TabIndex = 1;
            this.btn_mod.Text = "MODIFICAR";
            this.btn_mod.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(424, 283);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(83, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(875, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "FILTRAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Location = new System.Drawing.Point(673, 330);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(52, 16);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar:";
            this.Buscar.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(309, 241);
            this.dataGridView1.TabIndex = 5;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(173, 197);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(191, 22);
            this.txtcant.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_cod);
            this.groupBox1.Controls.Add(this.txt_idprov);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.txt_costo);
            this.groupBox1.Controls.Add(this.txtcant);
            this.groupBox1.Location = new System.Drawing.Point(56, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 241);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigo de proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(173, 37);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(138, 22);
            this.txt_cod.TabIndex = 10;
            // 
            // txt_idprov
            // 
            this.txt_idprov.Location = new System.Drawing.Point(173, 154);
            this.txt_idprov.Name = "txt_idprov";
            this.txt_idprov.Size = new System.Drawing.Size(191, 22);
            this.txt_idprov.TabIndex = 9;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(173, 80);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(191, 22);
            this.txt_nom.TabIndex = 8;
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(173, 121);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(191, 22);
            this.txt_costo.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(670, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 299);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Por
            // 
            this.Por.AutoSize = true;
            this.Por.Location = new System.Drawing.Point(848, 330);
            this.Por.Name = "Por";
            this.Por.Size = new System.Drawing.Size(31, 16);
            this.Por.TabIndex = 9;
            this.Por.Text = "Por:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(723, 327);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(87, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(898, 327);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(87, 22);
            this.textBox6.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 557);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Por);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_idprov;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Por;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
    }
}

