namespace BookShop.UI
{
    partial class 用户信息修改
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textModifyUserName = new System.Windows.Forms.TextBox();
            this.textModifyPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "修改密码：";
            // 
            // textModifyUserName
            // 
            this.textModifyUserName.Location = new System.Drawing.Point(399, 66);
            this.textModifyUserName.Name = "textModifyUserName";
            this.textModifyUserName.Size = new System.Drawing.Size(100, 25);
            this.textModifyUserName.TabIndex = 2;
            // 
            // textModifyPassword
            // 
            this.textModifyPassword.Location = new System.Drawing.Point(399, 159);
            this.textModifyPassword.Name = "textModifyPassword";
            this.textModifyPassword.Size = new System.Drawing.Size(100, 25);
            this.textModifyPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "提交修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // 用户信息修改
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textModifyPassword);
            this.Controls.Add(this.textModifyUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "用户信息修改";
            this.Text = "用户信息修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textModifyUserName;
        private System.Windows.Forms.TextBox textModifyPassword;
        private System.Windows.Forms.Button button1;
    }
}