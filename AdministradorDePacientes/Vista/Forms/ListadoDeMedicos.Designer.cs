
namespace Vista.Forms
{
    partial class ListadoDeMedicos
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
            this.dgvListadoDeMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDeMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoDeMedicos
            // 
            this.dgvListadoDeMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListadoDeMedicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.dgvListadoDeMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDeMedicos.Location = new System.Drawing.Point(12, 24);
            this.dgvListadoDeMedicos.Name = "dgvListadoDeMedicos";
            this.dgvListadoDeMedicos.RowTemplate.Height = 25;
            this.dgvListadoDeMedicos.Size = new System.Drawing.Size(660, 369);
            this.dgvListadoDeMedicos.TabIndex = 1;
            // 
            // ListadoDeMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(684, 420);
            this.Controls.Add(this.dgvListadoDeMedicos);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ListadoDeMedicos";
            this.Text = "Listado De Médicos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDeMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoDeMedicos;
    }
}