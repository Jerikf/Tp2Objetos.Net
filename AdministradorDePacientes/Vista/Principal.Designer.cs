
namespace Vista
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconFinalizarConsulta = new FontAwesome.Sharp.IconButton();
            this.iconEstadisticas = new FontAwesome.Sharp.IconButton();
            this.iconListMedicos = new FontAwesome.Sharp.IconButton();
            this.iconListPacientes = new FontAwesome.Sharp.IconButton();
            this.iconEstadoMedico = new FontAwesome.Sharp.IconButton();
            this.iconAsignarMedico = new FontAwesome.Sharp.IconButton();
            this.iconMedico = new FontAwesome.Sharp.IconButton();
            this.iconPaciente = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panelMenu.Controls.Add(this.iconFinalizarConsulta);
            this.panelMenu.Controls.Add(this.iconEstadisticas);
            this.panelMenu.Controls.Add(this.iconListMedicos);
            this.panelMenu.Controls.Add(this.iconListPacientes);
            this.panelMenu.Controls.Add(this.iconEstadoMedico);
            this.panelMenu.Controls.Add(this.iconAsignarMedico);
            this.panelMenu.Controls.Add(this.iconMedico);
            this.panelMenu.Controls.Add(this.iconPaciente);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 481);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // iconFinalizarConsulta
            // 
            this.iconFinalizarConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconFinalizarConsulta.FlatAppearance.BorderSize = 0;
            this.iconFinalizarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconFinalizarConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconFinalizarConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconFinalizarConsulta.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconFinalizarConsulta.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconFinalizarConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFinalizarConsulta.IconSize = 30;
            this.iconFinalizarConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconFinalizarConsulta.Location = new System.Drawing.Point(0, 390);
            this.iconFinalizarConsulta.Name = "iconFinalizarConsulta";
            this.iconFinalizarConsulta.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconFinalizarConsulta.Size = new System.Drawing.Size(180, 40);
            this.iconFinalizarConsulta.TabIndex = 9;
            this.iconFinalizarConsulta.Text = "Finalizar Consulta";
            this.iconFinalizarConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconFinalizarConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconFinalizarConsulta.UseVisualStyleBackColor = true;
            this.iconFinalizarConsulta.Click += new System.EventHandler(this.iconFinalizarConsulta_Click);
            // 
            // iconEstadisticas
            // 
            this.iconEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEstadisticas.FlatAppearance.BorderSize = 0;
            this.iconEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEstadisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEstadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEstadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconEstadisticas.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEstadisticas.IconSize = 30;
            this.iconEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEstadisticas.Location = new System.Drawing.Point(0, 350);
            this.iconEstadisticas.Name = "iconEstadisticas";
            this.iconEstadisticas.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconEstadisticas.Size = new System.Drawing.Size(180, 40);
            this.iconEstadisticas.TabIndex = 8;
            this.iconEstadisticas.Text = "Estadisticas";
            this.iconEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEstadisticas.UseVisualStyleBackColor = true;
            this.iconEstadisticas.Click += new System.EventHandler(this.iconEstadisticas_Click);
            // 
            // iconListMedicos
            // 
            this.iconListMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListMedicos.FlatAppearance.BorderSize = 0;
            this.iconListMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListMedicos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconListMedicos.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconListMedicos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iconListMedicos.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconListMedicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListMedicos.IconSize = 30;
            this.iconListMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListMedicos.Location = new System.Drawing.Point(0, 310);
            this.iconListMedicos.Name = "iconListMedicos";
            this.iconListMedicos.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconListMedicos.Size = new System.Drawing.Size(180, 40);
            this.iconListMedicos.TabIndex = 7;
            this.iconListMedicos.Text = "Listado de Médicos";
            this.iconListMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListMedicos.UseVisualStyleBackColor = true;
            this.iconListMedicos.Click += new System.EventHandler(this.iconListMedicos_Click);
            // 
            // iconListPacientes
            // 
            this.iconListPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconListPacientes.FlatAppearance.BorderSize = 0;
            this.iconListPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconListPacientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconListPacientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconListPacientes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iconListPacientes.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconListPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconListPacientes.IconSize = 30;
            this.iconListPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListPacientes.Location = new System.Drawing.Point(0, 270);
            this.iconListPacientes.Name = "iconListPacientes";
            this.iconListPacientes.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconListPacientes.Size = new System.Drawing.Size(180, 40);
            this.iconListPacientes.TabIndex = 6;
            this.iconListPacientes.Text = "Listado de Pacientes";
            this.iconListPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconListPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconListPacientes.UseVisualStyleBackColor = true;
            this.iconListPacientes.Click += new System.EventHandler(this.iconListPacientes_Click);
            // 
            // iconEstadoMedico
            // 
            this.iconEstadoMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconEstadoMedico.FlatAppearance.BorderSize = 0;
            this.iconEstadoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconEstadoMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconEstadoMedico.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconEstadoMedico.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.iconEstadoMedico.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconEstadoMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEstadoMedico.IconSize = 30;
            this.iconEstadoMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEstadoMedico.Location = new System.Drawing.Point(0, 230);
            this.iconEstadoMedico.Name = "iconEstadoMedico";
            this.iconEstadoMedico.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconEstadoMedico.Size = new System.Drawing.Size(180, 40);
            this.iconEstadoMedico.TabIndex = 5;
            this.iconEstadoMedico.Text = "Estado del Médico";
            this.iconEstadoMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconEstadoMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconEstadoMedico.UseVisualStyleBackColor = true;
            this.iconEstadoMedico.Click += new System.EventHandler(this.iconEstadoMedico_Click);
            // 
            // iconAsignarMedico
            // 
            this.iconAsignarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconAsignarMedico.FlatAppearance.BorderSize = 0;
            this.iconAsignarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconAsignarMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconAsignarMedico.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconAsignarMedico.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.iconAsignarMedico.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconAsignarMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAsignarMedico.IconSize = 30;
            this.iconAsignarMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAsignarMedico.Location = new System.Drawing.Point(0, 190);
            this.iconAsignarMedico.Name = "iconAsignarMedico";
            this.iconAsignarMedico.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconAsignarMedico.Size = new System.Drawing.Size(180, 40);
            this.iconAsignarMedico.TabIndex = 4;
            this.iconAsignarMedico.Text = "Asignar Médico";
            this.iconAsignarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconAsignarMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconAsignarMedico.UseVisualStyleBackColor = true;
            this.iconAsignarMedico.Click += new System.EventHandler(this.iconAsignarMedico_Click);
            // 
            // iconMedico
            // 
            this.iconMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconMedico.FlatAppearance.BorderSize = 0;
            this.iconMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconMedico.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconMedico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.iconMedico.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconMedico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMedico.IconSize = 30;
            this.iconMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconMedico.Location = new System.Drawing.Point(0, 150);
            this.iconMedico.Name = "iconMedico";
            this.iconMedico.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconMedico.Size = new System.Drawing.Size(180, 40);
            this.iconMedico.TabIndex = 3;
            this.iconMedico.Text = "Ingresar Médico";
            this.iconMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconMedico.UseVisualStyleBackColor = true;
            this.iconMedico.Click += new System.EventHandler(this.iconMedico_Click);
            // 
            // iconPaciente
            // 
            this.iconPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPaciente.FlatAppearance.BorderSize = 0;
            this.iconPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconPaciente.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPaciente.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.iconPaciente.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPaciente.IconSize = 30;
            this.iconPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPaciente.Location = new System.Drawing.Point(0, 110);
            this.iconPaciente.Name = "iconPaciente";
            this.iconPaciente.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.iconPaciente.Size = new System.Drawing.Size(180, 40);
            this.iconPaciente.TabIndex = 2;
            this.iconPaciente.Text = "Ingresar Paciente";
            this.iconPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconPaciente.UseVisualStyleBackColor = true;
            this.iconPaciente.Click += new System.EventHandler(this.iconPaciente_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 110);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(145, 92);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.LabelTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 65);
            this.panel1.TabIndex = 1;
            // 
            // LabelTitleChildForm
            // 
            this.LabelTitleChildForm.AutoSize = true;
            this.LabelTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTitleChildForm.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTitleChildForm.Location = new System.Drawing.Point(61, 25);
            this.LabelTitleChildForm.Name = "LabelTitleChildForm";
            this.LabelTitleChildForm.Size = new System.Drawing.Size(64, 22);
            this.LabelTitleChildForm.TabIndex = 1;
            this.LabelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label LabelTitleChildForm;
        private FontAwesome.Sharp.IconButton iconPaciente;
        private FontAwesome.Sharp.IconButton iconFinalizarConsulta;
        private FontAwesome.Sharp.IconButton iconEstadisticas;
        private FontAwesome.Sharp.IconButton iconListMedicos;
        private FontAwesome.Sharp.IconButton iconListPacientes;
        private FontAwesome.Sharp.IconButton iconEstadoMedico;
        private FontAwesome.Sharp.IconButton iconAsignarMedico;
        private FontAwesome.Sharp.IconButton iconMedico;
    }
}