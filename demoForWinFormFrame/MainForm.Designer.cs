﻿
namespace demoForWinFormFrame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.WebViewForMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.BorderForNaviBack = new System.Windows.Forms.Panel();
            this.TextBlockForNaviBack = new System.Windows.Forms.Label();
            this.BorderForNaviForward = new System.Windows.Forms.Panel();
            this.TextBlockForNaviForward = new System.Windows.Forms.Label();
            this.BorderForNaviStop = new System.Windows.Forms.Panel();
            this.TextBlockForNaviStop = new System.Windows.Forms.Label();
            this.BorderForNaviRefresh = new System.Windows.Forms.Panel();
            this.TextBlockForNaviRefresh = new System.Windows.Forms.Label();
            this.BorderForNaviHome = new System.Windows.Forms.Panel();
            this.TextBlockForNaviHome = new System.Windows.Forms.Label();
            this.TextBoxForNaviAddress = new System.Windows.Forms.TextBox();
            this.BorderForNaviTarget = new System.Windows.Forms.Panel();
            this.TextBlockForNaviTarget = new System.Windows.Forms.Label();
            this.BorderForNaviAddress = new System.Windows.Forms.Panel();
            this.GirdForProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.WebViewForMain)).BeginInit();
            this.BorderForNaviBack.SuspendLayout();
            this.BorderForNaviForward.SuspendLayout();
            this.BorderForNaviStop.SuspendLayout();
            this.BorderForNaviRefresh.SuspendLayout();
            this.BorderForNaviHome.SuspendLayout();
            this.BorderForNaviTarget.SuspendLayout();
            this.BorderForNaviAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebViewForMain
            // 
            this.WebViewForMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebViewForMain.CreationProperties = null;
            this.WebViewForMain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebViewForMain.Location = new System.Drawing.Point(0, 71);
            this.WebViewForMain.Name = "WebViewForMain";
            this.WebViewForMain.Size = new System.Drawing.Size(1351, 690);
            this.WebViewForMain.Source = new System.Uri("https://www.bing.com", System.UriKind.Absolute);
            this.WebViewForMain.TabIndex = 0;
            this.WebViewForMain.ZoomFactor = 1D;
            // 
            // BorderForNaviBack
            // 
            this.BorderForNaviBack.BackColor = System.Drawing.Color.Transparent;
            this.BorderForNaviBack.Controls.Add(this.TextBlockForNaviBack);
            this.BorderForNaviBack.Location = new System.Drawing.Point(8, 8);
            this.BorderForNaviBack.Name = "BorderForNaviBack";
            this.BorderForNaviBack.Size = new System.Drawing.Size(62, 54);
            this.BorderForNaviBack.TabIndex = 1;
            this.BorderForNaviBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderForNaviBack_MouseDown);
            this.BorderForNaviBack.MouseEnter += new System.EventHandler(this.BorderForButton_MouseEnter);
            this.BorderForNaviBack.MouseLeave += new System.EventHandler(this.BorderForButton_MouseLeave);
            // 
            // TextBlockForNaviBack
            // 
            this.TextBlockForNaviBack.AutoSize = true;
            this.TextBlockForNaviBack.Font = new System.Drawing.Font("宋体", 12F);
            this.TextBlockForNaviBack.Location = new System.Drawing.Point(8, 12);
            this.TextBlockForNaviBack.Name = "TextBlockForNaviBack";
            this.TextBlockForNaviBack.Size = new System.Drawing.Size(40, 16);
            this.TextBlockForNaviBack.TabIndex = 0;
            this.TextBlockForNaviBack.Text = "Back";
            this.TextBlockForNaviBack.Click += new System.EventHandler(this.TextBlockForNaviBack_Click);
            this.TextBlockForNaviBack.MouseEnter += new System.EventHandler(this.TextBlockForNaviBack_MouseEnter);
            // 
            // BorderForNaviForward
            // 
            this.BorderForNaviForward.BackColor = System.Drawing.Color.Transparent;
            this.BorderForNaviForward.Controls.Add(this.TextBlockForNaviForward);
            this.BorderForNaviForward.Location = new System.Drawing.Point(80, 8);
            this.BorderForNaviForward.Name = "BorderForNaviForward";
            this.BorderForNaviForward.Size = new System.Drawing.Size(62, 54);
            this.BorderForNaviForward.TabIndex = 2;
            this.BorderForNaviForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderForNaviForward_MouseDown);
            this.BorderForNaviForward.MouseEnter += new System.EventHandler(this.BorderForButton_MouseEnter);
            this.BorderForNaviForward.MouseLeave += new System.EventHandler(this.BorderForButton_MouseLeave);
            // 
            // TextBlockForNaviForward
            // 
            this.TextBlockForNaviForward.AutoSize = true;
            this.TextBlockForNaviForward.Font = new System.Drawing.Font("宋体", 12F);
            this.TextBlockForNaviForward.Location = new System.Drawing.Point(8, 12);
            this.TextBlockForNaviForward.Name = "TextBlockForNaviForward";
            this.TextBlockForNaviForward.Size = new System.Drawing.Size(40, 16);
            this.TextBlockForNaviForward.TabIndex = 0;
            this.TextBlockForNaviForward.Text = "Forw";
            this.TextBlockForNaviForward.Click += new System.EventHandler(this.TextBlockForNaviForward_Click);
            this.TextBlockForNaviForward.MouseEnter += new System.EventHandler(this.TextBlockForNaviForward_MouseEnter);
            // 
            // BorderForNaviStop
            // 
            this.BorderForNaviStop.BackColor = System.Drawing.Color.Transparent;
            this.BorderForNaviStop.Controls.Add(this.BorderForNaviRefresh);
            this.BorderForNaviStop.Controls.Add(this.TextBlockForNaviStop);
            this.BorderForNaviStop.Location = new System.Drawing.Point(153, 8);
            this.BorderForNaviStop.Name = "BorderForNaviStop";
            this.BorderForNaviStop.Size = new System.Drawing.Size(62, 54);
            this.BorderForNaviStop.TabIndex = 3;
            this.BorderForNaviStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderForNaviStop_MouseDown);
            this.BorderForNaviStop.MouseEnter += new System.EventHandler(this.BorderForButton_MouseEnter);
            this.BorderForNaviStop.MouseLeave += new System.EventHandler(this.BorderForButton_MouseLeave);
            // 
            // TextBlockForNaviStop
            // 
            this.TextBlockForNaviStop.AutoSize = true;
            this.TextBlockForNaviStop.Font = new System.Drawing.Font("宋体", 12F);
            this.TextBlockForNaviStop.Location = new System.Drawing.Point(8, 12);
            this.TextBlockForNaviStop.Name = "TextBlockForNaviStop";
            this.TextBlockForNaviStop.Size = new System.Drawing.Size(40, 16);
            this.TextBlockForNaviStop.TabIndex = 0;
            this.TextBlockForNaviStop.Text = "Stop";
            this.TextBlockForNaviStop.Click += new System.EventHandler(this.TextBlockForNaviStop_Click);
            this.TextBlockForNaviStop.MouseEnter += new System.EventHandler(this.TextBlockForNaviStop_MouseEnter);
            // 
            // BorderForNaviRefresh
            // 
            this.BorderForNaviRefresh.BackColor = System.Drawing.Color.Transparent;
            this.BorderForNaviRefresh.Controls.Add(this.TextBlockForNaviRefresh);
            this.BorderForNaviRefresh.Location = new System.Drawing.Point(0, 0);
            this.BorderForNaviRefresh.Name = "BorderForNaviRefresh";
            this.BorderForNaviRefresh.Size = new System.Drawing.Size(62, 54);
            this.BorderForNaviRefresh.TabIndex = 4;
            this.BorderForNaviRefresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderForNaviRefresh_MouseDown);
            this.BorderForNaviRefresh.MouseEnter += new System.EventHandler(this.BorderForButton_MouseEnter);
            this.BorderForNaviRefresh.MouseLeave += new System.EventHandler(this.BorderForButton_MouseLeave);
            // 
            // TextBlockForNaviRefresh
            // 
            this.TextBlockForNaviRefresh.AutoSize = true;
            this.TextBlockForNaviRefresh.Font = new System.Drawing.Font("宋体", 12F);
            this.TextBlockForNaviRefresh.Location = new System.Drawing.Point(8, 12);
            this.TextBlockForNaviRefresh.Name = "TextBlockForNaviRefresh";
            this.TextBlockForNaviRefresh.Size = new System.Drawing.Size(40, 16);
            this.TextBlockForNaviRefresh.TabIndex = 0;
            this.TextBlockForNaviRefresh.Text = "Rere";
            this.TextBlockForNaviRefresh.Click += new System.EventHandler(this.TextBlockForNaviRefresh_Click);
            this.TextBlockForNaviRefresh.MouseEnter += new System.EventHandler(this.TextBlockForNaviRefresh_MouseEnter);
            // 
            // BorderForNaviHome
            // 
            this.BorderForNaviHome.BackColor = System.Drawing.Color.Transparent;
            this.BorderForNaviHome.Controls.Add(this.TextBlockForNaviHome);
            this.BorderForNaviHome.Location = new System.Drawing.Point(225, 8);
            this.BorderForNaviHome.Name = "BorderForNaviHome";
            this.BorderForNaviHome.Size = new System.Drawing.Size(62, 54);
            this.BorderForNaviHome.TabIndex = 5;
            this.BorderForNaviHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderForNaviBack_MouseDown);
            this.BorderForNaviHome.MouseEnter += new System.EventHandler(this.BorderForButton_MouseEnter);
            this.BorderForNaviHome.MouseLeave += new System.EventHandler(this.BorderForButton_MouseLeave);
            // 
            // TextBlockForNaviHome
            // 
            this.TextBlockForNaviHome.AutoSize = true;
            this.TextBlockForNaviHome.Font = new System.Drawing.Font("宋体", 12F);
            this.TextBlockForNaviHome.Location = new System.Drawing.Point(8, 12);
            this.TextBlockForNaviHome.Name = "TextBlockForNaviHome";
            this.TextBlockForNaviHome.Size = new System.Drawing.Size(40, 16);
            this.TextBlockForNaviHome.TabIndex = 0;
            this.TextBlockForNaviHome.Text = "Home";
            this.TextBlockForNaviHome.Click += new System.EventHandler(this.TextBlockForNaviHome_Click);
            this.TextBlockForNaviHome.MouseEnter += new System.EventHandler(this.TextBlockForNaviHome_MouseEnter);
            // 
            // TextBoxForNaviAddress
            // 
            this.TextBoxForNaviAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxForNaviAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxForNaviAddress.Font = new System.Drawing.Font("宋体", 24F);
            this.TextBoxForNaviAddress.Location = new System.Drawing.Point(8, 9);
            this.TextBoxForNaviAddress.Multiline = true;
            this.TextBoxForNaviAddress.Name = "TextBoxForNaviAddress";
            this.TextBoxForNaviAddress.Size = new System.Drawing.Size(961, 38);
            this.TextBoxForNaviAddress.TabIndex = 6;
            this.TextBoxForNaviAddress.Text = "321321";
            this.TextBoxForNaviAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxForNaviAddress_KeyDown);
            // 
            // BorderForNaviTarget
            // 
            this.BorderForNaviTarget.BackColor = System.Drawing.Color.Transparent;
            this.BorderForNaviTarget.Controls.Add(this.TextBlockForNaviTarget);
            this.BorderForNaviTarget.Location = new System.Drawing.Point(1280, 8);
            this.BorderForNaviTarget.Name = "BorderForNaviTarget";
            this.BorderForNaviTarget.Size = new System.Drawing.Size(62, 54);
            this.BorderForNaviTarget.TabIndex = 7;
            this.BorderForNaviTarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorderForNaviTarget_MouseDown);
            this.BorderForNaviTarget.MouseEnter += new System.EventHandler(this.BorderForButton_MouseEnter);
            this.BorderForNaviTarget.MouseLeave += new System.EventHandler(this.BorderForButton_MouseLeave);
            // 
            // TextBlockForNaviTarget
            // 
            this.TextBlockForNaviTarget.AutoSize = true;
            this.TextBlockForNaviTarget.Font = new System.Drawing.Font("宋体", 12F);
            this.TextBlockForNaviTarget.Location = new System.Drawing.Point(8, 12);
            this.TextBlockForNaviTarget.Name = "TextBlockForNaviTarget";
            this.TextBlockForNaviTarget.Size = new System.Drawing.Size(56, 16);
            this.TextBlockForNaviTarget.TabIndex = 0;
            this.TextBlockForNaviTarget.Text = "Target";
            this.TextBlockForNaviTarget.Click += new System.EventHandler(this.TextBlockForNaviTarget_Click);
            this.TextBlockForNaviTarget.MouseEnter += new System.EventHandler(this.TextBlockForNaviTarget_MouseEnter);
            // 
            // BorderForNaviAddress
            // 
            this.BorderForNaviAddress.BackColor = System.Drawing.Color.White;
            this.BorderForNaviAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderForNaviAddress.Controls.Add(this.TextBoxForNaviAddress);
            this.BorderForNaviAddress.Location = new System.Drawing.Point(293, 8);
            this.BorderForNaviAddress.Name = "BorderForNaviAddress";
            this.BorderForNaviAddress.Size = new System.Drawing.Size(982, 55);
            this.BorderForNaviAddress.TabIndex = 8;
            // 
            // GirdForProgress
            // 
            this.GirdForProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GirdForProgress.Location = new System.Drawing.Point(0, 68);
            this.GirdForProgress.Name = "GirdForProgress";
            this.GirdForProgress.Size = new System.Drawing.Size(1352, 1);
            this.GirdForProgress.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1351, 761);
            this.Controls.Add(this.GirdForProgress);
            this.Controls.Add(this.BorderForNaviAddress);
            this.Controls.Add(this.BorderForNaviTarget);
            this.Controls.Add(this.BorderForNaviHome);
            this.Controls.Add(this.BorderForNaviStop);
            this.Controls.Add(this.BorderForNaviForward);
            this.Controls.Add(this.BorderForNaviBack);
            this.Controls.Add(this.WebViewForMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniEdge";
            ((System.ComponentModel.ISupportInitialize)(this.WebViewForMain)).EndInit();
            this.BorderForNaviBack.ResumeLayout(false);
            this.BorderForNaviBack.PerformLayout();
            this.BorderForNaviForward.ResumeLayout(false);
            this.BorderForNaviForward.PerformLayout();
            this.BorderForNaviStop.ResumeLayout(false);
            this.BorderForNaviStop.PerformLayout();
            this.BorderForNaviRefresh.ResumeLayout(false);
            this.BorderForNaviRefresh.PerformLayout();
            this.BorderForNaviHome.ResumeLayout(false);
            this.BorderForNaviHome.PerformLayout();
            this.BorderForNaviTarget.ResumeLayout(false);
            this.BorderForNaviTarget.PerformLayout();
            this.BorderForNaviAddress.ResumeLayout(false);
            this.BorderForNaviAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 WebViewForMain;
        private System.Windows.Forms.Panel BorderForNaviBack;
        private System.Windows.Forms.Label TextBlockForNaviBack;
        private System.Windows.Forms.Panel BorderForNaviForward;
        private System.Windows.Forms.Label TextBlockForNaviForward;
        private System.Windows.Forms.Panel BorderForNaviStop;
        private System.Windows.Forms.Label TextBlockForNaviStop;
        private System.Windows.Forms.Panel BorderForNaviRefresh;
        private System.Windows.Forms.Label TextBlockForNaviRefresh;
        private System.Windows.Forms.Panel BorderForNaviHome;
        private System.Windows.Forms.Label TextBlockForNaviHome;
        private System.Windows.Forms.TextBox TextBoxForNaviAddress;
        private System.Windows.Forms.Panel BorderForNaviTarget;
        private System.Windows.Forms.Label TextBlockForNaviTarget;
        private System.Windows.Forms.Panel BorderForNaviAddress;
        private System.Windows.Forms.ProgressBar GirdForProgress;
    }
}

