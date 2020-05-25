namespace DHMI_PHONE_DİRECTORY_SYSTEM
{
    partial class LISTING
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
            this.back_bttn = new System.Windows.Forms.Button();
            this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet = new DHMI_PHONE_DİRECTORY_SYSTEM.DHMI_PHONE_DİRECTORY_SYSTEMDataSet();
            this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_bttn
            // 
            this.back_bttn.AutoSize = true;
            this.back_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.back_bttn.FlatAppearance.BorderSize = 0;
            this.back_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.back_bttn.Location = new System.Drawing.Point(231, 355);
            this.back_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(444, 45);
            this.back_bttn.TabIndex = 9;
            this.back_bttn.Text = "BACK";
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(230, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(445, 329);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // LISTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(864, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_bttn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LISTING";
            this.Text = "LISTING";
            this.Load += new System.EventHandler(this.LISTING_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dHMI_PHONE_DİRECTORY_SYSTEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_bttn;
        private DHMI_PHONE_DİRECTORY_SYSTEMDataSet dHMI_PHONE_DİRECTORY_SYSTEMDataSet;
        private System.Windows.Forms.BindingSource dHMIPHONEDİRECTORYSYSTEMDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}