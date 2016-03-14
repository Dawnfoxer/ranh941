namespace twefourpoint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaishiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zantingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jiluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nanquanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "Find a Solution";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.find);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(260, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 26);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Refesh);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ops0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(258, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ops1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(407, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ops2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(547, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ops3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(45, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter an experssion:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(260, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 26);
            this.textBox2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(488, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Verify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Verify);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(304, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 20);
            this.label7.TabIndex = 0;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaishiToolStripMenuItem,
            this.zantingToolStripMenuItem,
            this.jiluToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // kaishiToolStripMenuItem
            // 
            this.kaishiToolStripMenuItem.Name = "kaishiToolStripMenuItem";
            this.kaishiToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.kaishiToolStripMenuItem.Text = "开始";
            this.kaishiToolStripMenuItem.Click += new System.EventHandler(this.startGame);
            // 
            // zantingToolStripMenuItem
            // 
            this.zantingToolStripMenuItem.Enabled = false;
            this.zantingToolStripMenuItem.Name = "zantingToolStripMenuItem";
            this.zantingToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.zantingToolStripMenuItem.Text = "停止";
            this.zantingToolStripMenuItem.Click += new System.EventHandler(this.stopGame);
            // 
            // jiluToolStripMenuItem
            // 
            this.jiluToolStripMenuItem.Name = "jiluToolStripMenuItem";
            this.jiluToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.jiluToolStripMenuItem.Text = "记录";
            this.jiluToolStripMenuItem.Click += new System.EventHandler(this.viewRecord);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.nanquanToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.帮助ToolStripMenuItem1.Text = "玩法";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.paly);
            // 
            // nanquanToolStripMenuItem
            // 
            this.nanquanToolStripMenuItem.Name = "nanquanToolStripMenuItem";
            this.nanquanToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.nanquanToolStripMenuItem.Text = "版权";
            this.nanquanToolStripMenuItem.Click += new System.EventHandler(this.version);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "24-Point Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaishiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zantingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem jiluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nanquanToolStripMenuItem;
    }
}

