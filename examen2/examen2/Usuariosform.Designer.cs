namespace examen2
{
    partial class Usuariosform
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codigotextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.contraseñatextBox = new System.Windows.Forms.TextBox();
            this.correotextBox = new System.Windows.Forms.TextBox();
            this.rolcomboBox = new System.Windows.Forms.ComboBox();
            this.estaactivocheckBox = new System.Windows.Forms.CheckBox();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.usuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado";
            // 
            // codigotextBox
            // 
            this.codigotextBox.Enabled = false;
            this.codigotextBox.Location = new System.Drawing.Point(182, 25);
            this.codigotextBox.Name = "codigotextBox";
            this.codigotextBox.Size = new System.Drawing.Size(411, 27);
            this.codigotextBox.TabIndex = 1;
            // 
            // nombretextBox
            // 
            this.nombretextBox.Enabled = false;
            this.nombretextBox.Location = new System.Drawing.Point(182, 78);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(411, 27);
            this.nombretextBox.TabIndex = 3;
            // 
            // contraseñatextBox
            // 
            this.contraseñatextBox.Enabled = false;
            this.contraseñatextBox.Location = new System.Drawing.Point(182, 132);
            this.contraseñatextBox.Name = "contraseñatextBox";
            this.contraseñatextBox.Size = new System.Drawing.Size(411, 27);
            this.contraseñatextBox.TabIndex = 5;
            // 
            // correotextBox
            // 
            this.correotextBox.Enabled = false;
            this.correotextBox.Location = new System.Drawing.Point(182, 191);
            this.correotextBox.Name = "correotextBox";
            this.correotextBox.Size = new System.Drawing.Size(411, 27);
            this.correotextBox.TabIndex = 7;
            // 
            // rolcomboBox
            // 
            this.rolcomboBox.Enabled = false;
            this.rolcomboBox.FormattingEnabled = true;
            this.rolcomboBox.IntegralHeight = false;
            this.rolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.rolcomboBox.Location = new System.Drawing.Point(182, 256);
            this.rolcomboBox.Name = "rolcomboBox";
            this.rolcomboBox.Size = new System.Drawing.Size(121, 28);
            this.rolcomboBox.TabIndex = 9;
            // 
            // estaactivocheckBox
            // 
            this.estaactivocheckBox.AutoSize = true;
            this.estaactivocheckBox.Location = new System.Drawing.Point(182, 309);
            this.estaactivocheckBox.Name = "estaactivocheckBox";
            this.estaactivocheckBox.Size = new System.Drawing.Size(113, 24);
            this.estaactivocheckBox.TabIndex = 11;
            this.estaactivocheckBox.Text = "checkBox1";
            this.estaactivocheckBox.UseVisualStyleBackColor = true;
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(85, 351);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(97, 32);
            this.nuevobutton.TabIndex = 12;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // modificarbutton
            // 
            this.modificarbutton.Location = new System.Drawing.Point(215, 351);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(107, 32);
            this.modificarbutton.TabIndex = 13;
            this.modificarbutton.Text = "Modificar ";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Location = new System.Drawing.Point(349, 351);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(88, 32);
            this.guardarbutton.TabIndex = 14;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(476, 351);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(99, 32);
            this.eliminarbutton.TabIndex = 15;
            this.eliminarbutton.Text = "Eliminar ";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(616, 351);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(92, 32);
            this.cancelarbutton.TabIndex = 16;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // usuariosdataGridView
            // 
            this.usuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdataGridView.Location = new System.Drawing.Point(-3, 400);
            this.usuariosdataGridView.Name = "usuariosdataGridView";
            this.usuariosdataGridView.RowHeadersWidth = 51;
            this.usuariosdataGridView.RowTemplate.Height = 24;
            this.usuariosdataGridView.Size = new System.Drawing.Size(992, 266);
            this.usuariosdataGridView.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Usuariosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 678);
            this.Controls.Add(this.usuariosdataGridView);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.estaactivocheckBox);
            this.Controls.Add(this.rolcomboBox);
            this.Controls.Add(this.correotextBox);
            this.Controls.Add(this.contraseñatextBox);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.codigotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Usuariosform";
            this.Text = "Usuariosform";
            this.Load += new System.EventHandler(this.Usuariosform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codigotextBox;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.TextBox contraseñatextBox;
        private System.Windows.Forms.TextBox correotextBox;
        private System.Windows.Forms.ComboBox rolcomboBox;
        private System.Windows.Forms.CheckBox estaactivocheckBox;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button modificarbutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.DataGridView usuariosdataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}