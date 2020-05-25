namespace DHMI_PHONE_DİRECTORY_SYSTEM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.search_bttn = new System.Windows.Forms.Button();
            this.listing_bttn = new System.Windows.Forms.Button();
            this.update_bttn = new System.Windows.Forms.Button();
            this.adding_bttn = new System.Windows.Forms.Button();
            this.deletion_bttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_bttn
            // 
            this.search_bttn.AutoSize = true;
            this.search_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.search_bttn.FlatAppearance.BorderSize = 0;
            this.search_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.search_bttn.Location = new System.Drawing.Point(205, 58);
            this.search_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.search_bttn.Name = "search_bttn";
            this.search_bttn.Size = new System.Drawing.Size(375, 57);
            this.search_bttn.TabIndex = 0;
            this.search_bttn.Text = "SEARCH";
            this.search_bttn.UseVisualStyleBackColor = false;
            this.search_bttn.Click += new System.EventHandler(this.search_bttn_Click);
            // 
            // listing_bttn
            // 
            this.listing_bttn.AutoSize = true;
            this.listing_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.listing_bttn.FlatAppearance.BorderSize = 0;
            this.listing_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listing_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.listing_bttn.Location = new System.Drawing.Point(205, 124);
            this.listing_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.listing_bttn.Name = "listing_bttn";
            this.listing_bttn.Size = new System.Drawing.Size(375, 57);
            this.listing_bttn.TabIndex = 1;
            this.listing_bttn.Text = "LISTING";
            this.listing_bttn.UseVisualStyleBackColor = false;
            this.listing_bttn.Click += new System.EventHandler(this.listing_bttn_Click);
            // 
            // update_bttn
            // 
            this.update_bttn.AutoSize = true;
            this.update_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.update_bttn.FlatAppearance.BorderSize = 0;
            this.update_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.update_bttn.Location = new System.Drawing.Point(205, 191);
            this.update_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(375, 57);
            this.update_bttn.TabIndex = 2;
            this.update_bttn.Text = "UPDATE";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // adding_bttn
            // 
            this.adding_bttn.AutoSize = true;
            this.adding_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.adding_bttn.FlatAppearance.BorderSize = 0;
            this.adding_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adding_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.adding_bttn.Location = new System.Drawing.Point(205, 257);
            this.adding_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.adding_bttn.Name = "adding_bttn";
            this.adding_bttn.Size = new System.Drawing.Size(375, 57);
            this.adding_bttn.TabIndex = 3;
            this.adding_bttn.Text = "ADDING";
            this.adding_bttn.UseVisualStyleBackColor = false;
            this.adding_bttn.Click += new System.EventHandler(this.adding_bttn_Click);
            // 
            // deletion_bttn
            // 
            this.deletion_bttn.AutoSize = true;
            this.deletion_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(254)))));
            this.deletion_bttn.FlatAppearance.BorderSize = 0;
            this.deletion_bttn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletion_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.deletion_bttn.Location = new System.Drawing.Point(205, 323);
            this.deletion_bttn.Margin = new System.Windows.Forms.Padding(0);
            this.deletion_bttn.Name = "deletion_bttn";
            this.deletion_bttn.Size = new System.Drawing.Size(375, 57);
            this.deletion_bttn.TabIndex = 4;
            this.deletion_bttn.Text = "DELETION";
            this.deletion_bttn.UseVisualStyleBackColor = false;
            this.deletion_bttn.Click += new System.EventHandler(this.deletion_bttn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.deletion_bttn);
            this.panel1.Controls.Add(this.adding_bttn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.search_bttn);
            this.panel1.Controls.Add(this.listing_bttn);
            this.panel1.Controls.Add(this.update_bttn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(625, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "DHMI DEPARTMENTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_bttn;
        private System.Windows.Forms.Button listing_bttn;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.Button adding_bttn;
        private System.Windows.Forms.Button deletion_bttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

