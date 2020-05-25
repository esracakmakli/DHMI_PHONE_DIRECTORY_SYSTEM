namespace DHMI_PHONE_DİRECTORY_SYSTEM
{
    partial class SEARCH
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet = new DHMI_PHONE_DİRECTORY_SYSTEM.DHMI_PHONE_DİRECTORY_SYSTEMDataSet();
            this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new DHMI_PHONE_DİRECTORY_SYSTEM.DHMI_PHONE_DİRECTORY_SYSTEMDataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Department Search";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dHMI_PHONE_DİRECTORY_SYSTEMDataSet
            // 
            this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet.DataSetName = "DHMI_PHONE_DİRECTORY_SYSTEMDataSet";
            this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource
            // 
            this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource.DataSource = this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet;
            this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource.Position = 0;
            // 
            // dEPARTMENTSBindingSource
            // 
            this.dEPARTMENTSBindingSource.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource.DataSource = this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource;
            // 
            // dEPARTMENTSTableAdapter
            // 
            this.dEPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(94, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 100);
            this.panel1.TabIndex = 4;
            // 
            // back_bttn
            // 
            this.back_bttn.AutoSize = true;
            this.back_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.back_bttn.FlatAppearance.BorderSize = 0;
            this.back_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.back_bttn.Location = new System.Drawing.Point(168, 290);
            this.back_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(453, 35);
            this.back_bttn.TabIndex = 6;
            this.back_bttn.Text = "BACK";
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click_1);
            // 
            // SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.panel1);
            this.Name = "SEARCH";
            this.Text = "SEARCH";
            this.Load += new System.EventHandler(this.SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource;
        private DHMI_PHONE_DİRECTORY_SYSTEMDataSet dHMI_PHONE_DİRECTORY_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private DHMI_PHONE_DİRECTORY_SYSTEMDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_bttn;
    }
}