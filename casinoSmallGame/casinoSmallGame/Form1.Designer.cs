namespace casinoSmallGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this._lblAcount = new System.Windows.Forms.Label();
            this._lblPassword = new System.Windows.Forms.Label();
            this._txtAccount = new System.Windows.Forms.TextBox();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 674);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _lblAcount
            // 
            this._lblAcount.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._lblAcount.Location = new System.Drawing.Point(168, 157);
            this._lblAcount.Name = "_lblAcount";
            this._lblAcount.Size = new System.Drawing.Size(198, 90);
            this._lblAcount.TabIndex = 1;
            this._lblAcount.Text = "帳號 :";
            this._lblAcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblPassword
            // 
            this._lblPassword.Font = new System.Drawing.Font("微軟正黑體", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._lblPassword.Location = new System.Drawing.Point(168, 281);
            this._lblPassword.Name = "_lblPassword";
            this._lblPassword.Size = new System.Drawing.Size(198, 90);
            this._lblPassword.TabIndex = 2;
            this._lblPassword.Text = "密碼 :";
            this._lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _txtAccount
            // 
            this._txtAccount.Font = new System.Drawing.Font("Old English Text MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAccount.Location = new System.Drawing.Point(349, 179);
            this._txtAccount.Multiline = true;
            this._txtAccount.Name = "_txtAccount";
            this._txtAccount.Size = new System.Drawing.Size(351, 55);
            this._txtAccount.TabIndex = 15;
            // 
            // _txtPassword
            // 
            this._txtPassword.Font = new System.Drawing.Font("Old English Text MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.Location = new System.Drawing.Point(349, 303);
            this._txtPassword.Multiline = true;
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.Size = new System.Drawing.Size(351, 55);
            this._txtPassword.TabIndex = 16;
            // 
            // _btnLogin
            // 
            this._btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._btnLogin.Location = new System.Drawing.Point(349, 423);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(167, 66);
            this._btnLogin.TabIndex = 19;
            this._btnLogin.Text = "登入";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(533, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 66);
            this.button2.TabIndex = 20;
            this.button2.Text = "註冊";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 758);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._btnLogin);
            this.Controls.Add(this._txtPassword);
            this.Controls.Add(this._txtAccount);
            this.Controls.Add(this._lblPassword);
            this.Controls.Add(this._lblAcount);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "樂透派彩系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _lblAcount;
        private System.Windows.Forms.Label _lblPassword;
        private System.Windows.Forms.TextBox _txtAccount;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.Button button2;
    }
}

