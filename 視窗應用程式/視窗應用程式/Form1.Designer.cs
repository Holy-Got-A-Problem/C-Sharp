
namespace 視窗應用程式
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btmOk = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(143, 89);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(317, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(143, 184);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(41, 15);
            this.lblShow.TabIndex = 3;
            this.lblShow.Text = "label2";
            // 
            // btmOk
            // 
            this.btmOk.Location = new System.Drawing.Point(146, 298);
            this.btmOk.Name = "btmOk";
            this.btmOk.Size = new System.Drawing.Size(75, 23);
            this.btmOk.TabIndex = 4;
            this.btmOk.Text = "確定";
            this.btmOk.UseVisualStyleBackColor = true;
            // 
            // btmExit
            // 
            this.btmExit.Location = new System.Drawing.Point(342, 298);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(75, 23);
            this.btmExit.TabIndex = 5;
            this.btmExit.Text = "結束";
            this.btmExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btmOk);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btmOk;
        private System.Windows.Forms.Button btmExit;
    }
}

