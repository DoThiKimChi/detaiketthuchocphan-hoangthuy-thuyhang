namespace xếp_số_h__t
{
    partial class frmbangxephang
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.txttennguoichoi = new System.Windows.Forms.TextBox();
            this.lsvtennguoichoi = new System.Windows.Forms.ListView();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(28, 83);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txttennguoichoi
            // 
            this.txttennguoichoi.Location = new System.Drawing.Point(143, 31);
            this.txttennguoichoi.Name = "txttennguoichoi";
            this.txttennguoichoi.Size = new System.Drawing.Size(100, 20);
            this.txttennguoichoi.TabIndex = 1;
            // 
            // lsvtennguoichoi
            // 
            this.lsvtennguoichoi.Location = new System.Drawing.Point(12, 127);
            this.lsvtennguoichoi.Name = "lsvtennguoichoi";
            this.lsvtennguoichoi.Size = new System.Drawing.Size(260, 123);
            this.lsvtennguoichoi.TabIndex = 2;
            this.lsvtennguoichoi.UseCompatibleStateImageBehavior = false;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(109, 83);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Người Chơi";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(190, 83);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmbangxephang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lsvtennguoichoi);
            this.Controls.Add(this.txttennguoichoi);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmbangxephang";
            this.Text = "frmbangxephang";
            this.Load += new System.EventHandler(this.frmbangxephang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txttennguoichoi;
        private System.Windows.Forms.ListView lsvtennguoichoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
    }
}