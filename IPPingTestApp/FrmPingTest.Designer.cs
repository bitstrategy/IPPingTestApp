namespace IPPingTestApp
{
    partial class FrmPingTest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIPAddr = new System.Windows.Forms.Label();
            this.txtlblAddr = new System.Windows.Forms.TextBox();
            this.btnStartPing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIPAddr
            // 
            this.lblIPAddr.AutoSize = true;
            this.lblIPAddr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIPAddr.Location = new System.Drawing.Point(26, 69);
            this.lblIPAddr.Name = "lblIPAddr";
            this.lblIPAddr.Size = new System.Drawing.Size(57, 21);
            this.lblIPAddr.TabIndex = 0;
            this.lblIPAddr.Text = "IP地址";
            // 
            // txtlblAddr
            // 
            this.txtlblAddr.Location = new System.Drawing.Point(89, 68);
            this.txtlblAddr.Name = "txtlblAddr";
            this.txtlblAddr.Size = new System.Drawing.Size(275, 23);
            this.txtlblAddr.TabIndex = 1;
            // 
            // btnStartPing
            // 
            this.btnStartPing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartPing.Location = new System.Drawing.Point(382, 62);
            this.btnStartPing.Name = "btnStartPing";
            this.btnStartPing.Size = new System.Drawing.Size(101, 35);
            this.btnStartPing.TabIndex = 2;
            this.btnStartPing.Text = "开始ping";
            this.btnStartPing.UseVisualStyleBackColor = true;
            this.btnStartPing.Click += new System.EventHandler(this.btnStartPing_Click);
            // 
            // FrmPingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 257);
            this.Controls.Add(this.btnStartPing);
            this.Controls.Add(this.txtlblAddr);
            this.Controls.Add(this.lblIPAddr);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPingTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP ping测试App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPingTest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPAddr;
        private System.Windows.Forms.TextBox txtlblAddr;
        private System.Windows.Forms.Button btnStartPing;
    }
}

