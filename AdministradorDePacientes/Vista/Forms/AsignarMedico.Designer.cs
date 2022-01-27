
namespace Vista.Forms
{
    partial class AsignarMedico
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedicos = new System.Windows.Forms.ComboBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Médicos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Paciente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseWaitCursor = true;
            // 
            // comboBoxMedicos
            // 
            this.comboBoxMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.comboBoxMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMedicos.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxMedicos.FormattingEnabled = true;
            this.comboBoxMedicos.Location = new System.Drawing.Point(113, 105);
            this.comboBoxMedicos.Name = "comboBoxMedicos";
            this.comboBoxMedicos.Size = new System.Drawing.Size(176, 23);
            this.comboBoxMedicos.TabIndex = 31;
            this.comboBoxMedicos.Text = "Seleccionar";
            this.comboBoxMedicos.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMedicos_Validating);
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.comboBoxPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(113, 176);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(176, 23);
            this.comboBoxPaciente.TabIndex = 32;
            this.comboBoxPaciente.Text = "Seleccionar";
            this.comboBoxPaciente.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPaciente_Validating);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignar.Location = new System.Drawing.Point(83, 257);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAsignar.Size = new System.Drawing.Size(146, 43);
            this.btnAsignar.TabIndex = 35;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(83, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "Asignación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.UseWaitCursor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AsignarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(317, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.comboBoxPaciente);
            this.Controls.Add(this.comboBoxMedicos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AsignarMedico";
            this.Text = "Asignar Médico";
            this.Load += new System.EventHandler(this.AsignarMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedicos;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}