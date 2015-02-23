namespace EthSwitcher {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nicList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingList = new System.Windows.Forms.ListBox();
            this.addListBtn = new System.Windows.Forms.Button();
            this.setNowBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.addNowBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ipaddrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gatewayBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dns1Box = new System.Windows.Forms.TextBox();
            this.dns2Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ipaddrView = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskView = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gatewayView = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dns1view = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dns2View = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.macView = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(468, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "ファイル";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "終了";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nicList
            // 
            this.nicList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicList.FormattingEnabled = true;
            this.nicList.Location = new System.Drawing.Point(105, 27);
            this.nicList.Name = "nicList";
            this.nicList.Size = new System.Drawing.Size(351, 20);
            this.nicList.TabIndex = 2;
            this.nicList.SelectedIndexChanged += new System.EventHandler(this.nicList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "NetworkAdapter";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.macView);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dns2View);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dns1view);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.gatewayView);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.maskView);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ipaddrView);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NowSetting";
            // 
            // settingList
            // 
            this.settingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingList.FormattingEnabled = true;
            this.settingList.ItemHeight = 12;
            this.settingList.Location = new System.Drawing.Point(14, 160);
            this.settingList.Name = "settingList";
            this.settingList.Size = new System.Drawing.Size(202, 160);
            this.settingList.TabIndex = 5;
            this.settingList.SelectedIndexChanged += new System.EventHandler(this.settingList_SelectedIndexChanged);
            // 
            // addListBtn
            // 
            this.addListBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addListBtn.Location = new System.Drawing.Point(72, 174);
            this.addListBtn.Name = "addListBtn";
            this.addListBtn.Size = new System.Drawing.Size(75, 23);
            this.addListBtn.TabIndex = 6;
            this.addListBtn.Text = "Add List";
            this.addListBtn.UseVisualStyleBackColor = true;
            this.addListBtn.Click += new System.EventHandler(this.addListBtn_Click);
            // 
            // setNowBtn
            // 
            this.setNowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.setNowBtn.Location = new System.Drawing.Point(153, 174);
            this.setNowBtn.Name = "setNowBtn";
            this.setNowBtn.Size = new System.Drawing.Size(75, 23);
            this.setNowBtn.TabIndex = 7;
            this.setNowBtn.Text = "Set Now";
            this.setNowBtn.UseVisualStyleBackColor = true;
            this.setNowBtn.Click += new System.EventHandler(this.setNowBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dns2Box);
            this.groupBox2.Controls.Add(this.dns1Box);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gatewayBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maskBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ipaddrBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addListBtn);
            this.groupBox2.Controls.Add(this.setNowBtn);
            this.groupBox2.Location = new System.Drawing.Point(222, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(132, 335);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 9;
            this.delBtn.Text = "Del";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addNowBtn
            // 
            this.addNowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNowBtn.Location = new System.Drawing.Point(14, 334);
            this.addNowBtn.Name = "addNowBtn";
            this.addNowBtn.Size = new System.Drawing.Size(112, 23);
            this.addNowBtn.TabIndex = 10;
            this.addNowBtn.Text = "Add Now Setting";
            this.addNowBtn.UseVisualStyleBackColor = true;
            this.addNowBtn.Click += new System.EventHandler(this.addNowBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "IPAddress";
            // 
            // ipaddrBox
            // 
            this.ipaddrBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipaddrBox.Location = new System.Drawing.Point(96, 23);
            this.ipaddrBox.Name = "ipaddrBox";
            this.ipaddrBox.Size = new System.Drawing.Size(132, 19);
            this.ipaddrBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "SubnetMask";
            // 
            // maskBox
            // 
            this.maskBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskBox.Location = new System.Drawing.Point(96, 48);
            this.maskBox.Name = "maskBox";
            this.maskBox.Size = new System.Drawing.Size(132, 19);
            this.maskBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "DefaultGateway";
            // 
            // gatewayBox
            // 
            this.gatewayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gatewayBox.Location = new System.Drawing.Point(96, 73);
            this.gatewayBox.Name = "gatewayBox";
            this.gatewayBox.Size = new System.Drawing.Size(132, 19);
            this.gatewayBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "DNS1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "DNS2";
            // 
            // dns1Box
            // 
            this.dns1Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dns1Box.Location = new System.Drawing.Point(96, 98);
            this.dns1Box.Name = "dns1Box";
            this.dns1Box.Size = new System.Drawing.Size(132, 19);
            this.dns1Box.TabIndex = 16;
            // 
            // dns2Box
            // 
            this.dns2Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dns2Box.Location = new System.Drawing.Point(96, 123);
            this.dns2Box.Name = "dns2Box";
            this.dns2Box.Size = new System.Drawing.Size(132, 19);
            this.dns2Box.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(96, 149);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 19);
            this.nameBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "IPAddress:";
            // 
            // ipaddrView
            // 
            this.ipaddrView.AutoSize = true;
            this.ipaddrView.Location = new System.Drawing.Point(79, 24);
            this.ipaddrView.Name = "ipaddrView";
            this.ipaddrView.Size = new System.Drawing.Size(83, 12);
            this.ipaddrView.TabIndex = 1;
            this.ipaddrView.Text = "255.255.255.255";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "SubnetMask:";
            // 
            // maskView
            // 
            this.maskView.AutoSize = true;
            this.maskView.Location = new System.Drawing.Point(79, 46);
            this.maskView.Name = "maskView";
            this.maskView.Size = new System.Drawing.Size(83, 12);
            this.maskView.TabIndex = 3;
            this.maskView.Text = "255.255.255.255";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Gateway:";
            // 
            // gatewayView
            // 
            this.gatewayView.AutoSize = true;
            this.gatewayView.Location = new System.Drawing.Point(79, 68);
            this.gatewayView.Name = "gatewayView";
            this.gatewayView.Size = new System.Drawing.Size(83, 12);
            this.gatewayView.TabIndex = 5;
            this.gatewayView.Text = "255.255.255.255";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(260, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 12);
            this.label14.TabIndex = 6;
            this.label14.Text = "DNS1:";
            // 
            // dns1view
            // 
            this.dns1view.AutoSize = true;
            this.dns1view.Location = new System.Drawing.Point(302, 24);
            this.dns1view.Name = "dns1view";
            this.dns1view.Size = new System.Drawing.Size(83, 12);
            this.dns1view.TabIndex = 7;
            this.dns1view.Text = "255.255.255.255";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(260, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 12);
            this.label16.TabIndex = 8;
            this.label16.Text = "DNS2:";
            // 
            // dns2View
            // 
            this.dns2View.AutoSize = true;
            this.dns2View.Location = new System.Drawing.Point(302, 46);
            this.dns2View.Name = "dns2View";
            this.dns2View.Size = new System.Drawing.Size(83, 12);
            this.dns2View.TabIndex = 9;
            this.dns2View.Text = "255.255.255.255";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(268, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 12);
            this.label18.TabIndex = 10;
            this.label18.Text = "Mac:";
            // 
            // macView
            // 
            this.macView.AutoSize = true;
            this.macView.Location = new System.Drawing.Point(302, 68);
            this.macView.Name = "macView";
            this.macView.Size = new System.Drawing.Size(99, 12);
            this.macView.TabIndex = 11;
            this.macView.Text = "FF:FF:FF:FF:FF:FF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 389);
            this.Controls.Add(this.addNowBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.settingList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nicList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(484, 428);
            this.Name = "Form1";
            this.Text = "EthSwitcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox nicList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox settingList;
        private System.Windows.Forms.Button addListBtn;
        private System.Windows.Forms.Button setNowBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addNowBtn;
        private System.Windows.Forms.TextBox dns2Box;
        private System.Windows.Forms.TextBox dns1Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gatewayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maskBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipaddrBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dns2View;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label dns1view;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label gatewayView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label maskView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ipaddrView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label macView;
        private System.Windows.Forms.Label label18;
    }
}

