
namespace Vista.Forms
{
    partial class IngresarMedico
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(188, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelar.Size = new System.Drawing.Size(107, 29);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.Location = new System.Drawing.Point(41, 323);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptar.Size = new System.Drawing.Size(107, 29);
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(45, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(67, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Edad";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(81, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dni";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(8, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Especialidad";
            // 
            // textAge
            // 
            this.textAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.textAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAge.ForeColor = System.Drawing.Color.Gainsboro;
            this.textAge.Location = new System.Drawing.Point(140, 222);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(176, 16);
            this.textAge.TabIndex = 23;
            this.textAge.Validating += new System.ComponentModel.CancelEventHandler(this.textAge_Validating);
            // 
            // textDni
            // 
            this.textDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.textDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDni.ForeColor = System.Drawing.Color.Gainsboro;
            this.textDni.Location = new System.Drawing.Point(138, 182);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(176, 16);
            this.textDni.TabIndex = 21;
            this.textDni.Validating += new System.ComponentModel.CancelEventHandler(this.textDni_Validating);
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textName.Location = new System.Drawing.Point(140, 95);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(176, 16);
            this.textName.TabIndex = 19;
            this.textName.Validating += new System.ComponentModel.CancelEventHandler(this.textName_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(99, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 42);
            this.label2.TabIndex = 17;
            this.label2.Text = "Médico";
            // 
            // textLastName
            // 
            this.textLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.textLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textLastName.Location = new System.Drawing.Point(140, 138);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(176, 16);
            this.textLastName.TabIndex = 16;
            this.textLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textLastName_Validating);
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.comboBoxEspecialidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEspecialidad.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Items.AddRange(new object[] {
            "Clínico",
            "Cardiología",
            "Traumatología",
            "Hurología",
            "Podología",
            "Oftamología"});
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(138, 268);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(176, 23);
            this.comboBoxEspecialidad.TabIndex = 30;
            this.comboBoxEspecialidad.Text = "Seleccionar";
            this.comboBoxEspecialidad.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEspecialidad_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // IngresarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(335, 371);
            this.Controls.Add(this.comboBoxEspecialidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLastName);
            this.Name = "IngresarMedico";
            this.Text = "Ingresar Médico";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}