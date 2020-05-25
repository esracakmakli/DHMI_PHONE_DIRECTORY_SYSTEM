namespace DHMI_PHONE_DİRECTORY_SYSTEM
{
    partial class DELETE
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
            this.department_select = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.back_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // department_select
            // 
            this.department_select.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.department_select.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.department_select.FormattingEnabled = true;
            this.department_select.Location = new System.Drawing.Point(228, 96);
            this.department_select.Name = "department_select";
            this.department_select.Size = new System.Drawing.Size(344, 28);
            this.department_select.TabIndex = 1;
            this.department_select.Text = "Department Search";
            this.department_select.SelectedIndexChanged += new System.EventHandler(this.department_select_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 107);
            this.dataGridView1.TabIndex = 9;
            // 
            // delete_bttn
            // 
            this.delete_bttn.AutoSize = true;
            this.delete_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.delete_bttn.FlatAppearance.BorderSize = 0;
            this.delete_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.delete_bttn.Location = new System.Drawing.Point(228, 292);
            this.delete_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(344, 42);
            this.delete_bttn.TabIndex = 10;
            this.delete_bttn.Text = "DELETE";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // back_bttn
            // 
            this.back_bttn.AutoSize = true;
            this.back_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.back_bttn.FlatAppearance.BorderSize = 0;
            this.back_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.back_bttn.Location = new System.Drawing.Point(228, 355);
            this.back_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(344, 42);
            this.back_bttn.TabIndex = 12;
            this.back_bttn.Text = "BACK";
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click_1);
            // 
            // DELETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.department_select);
            this.Name = "DELETE";
            this.Text = "DELETE";
            this.Load += new System.EventHandler(this.DELETE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox department_select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button back_bttn;
    }
}