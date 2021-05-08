namespace treeViewDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tree_Role = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.cname = new System.Windows.Forms.TextBox();
            this.flevel = new System.Windows.Forms.TextBox();
            this.clevel = new System.Windows.Forms.TextBox();
            this.baocun = new System.Windows.Forms.Button();
            this.baocun2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.choseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tree_Role
            // 
            this.tree_Role.Location = new System.Drawing.Point(12, 12);
            this.tree_Role.Name = "tree_Role";
            this.tree_Role.Size = new System.Drawing.Size(311, 552);
            this.tree_Role.TabIndex = 0;
            this.tree_Role.DoubleClick += new System.EventHandler(this.tree_Role_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "添加子节点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "添加父节点";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "级别";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(499, 149);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(206, 42);
            this.fname.TabIndex = 6;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(499, 287);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(206, 42);
            this.cname.TabIndex = 7;
            // 
            // flevel
            // 
            this.flevel.Location = new System.Drawing.Point(742, 149);
            this.flevel.Name = "flevel";
            this.flevel.Size = new System.Drawing.Size(91, 42);
            this.flevel.TabIndex = 8;
            // 
            // clevel
            // 
            this.clevel.Location = new System.Drawing.Point(742, 287);
            this.clevel.Name = "clevel";
            this.clevel.Size = new System.Drawing.Size(91, 42);
            this.clevel.TabIndex = 9;
            // 
            // baocun
            // 
            this.baocun.Location = new System.Drawing.Point(863, 142);
            this.baocun.Name = "baocun";
            this.baocun.Size = new System.Drawing.Size(114, 51);
            this.baocun.TabIndex = 10;
            this.baocun.Text = "保存";
            this.baocun.UseVisualStyleBackColor = true;
            this.baocun.Click += new System.EventHandler(this.baocun_Click);
            // 
            // baocun2
            // 
            this.baocun2.Location = new System.Drawing.Point(863, 287);
            this.baocun2.Name = "baocun2";
            this.baocun2.Size = new System.Drawing.Size(116, 51);
            this.baocun2.TabIndex = 11;
            this.baocun2.Text = "保存";
            this.baocun2.UseVisualStyleBackColor = true;
            this.baocun2.Click += new System.EventHandler(this.baocun2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "选中的节点名称";
            // 
            // choseName
            // 
            this.choseName.Location = new System.Drawing.Point(571, 484);
            this.choseName.Name = "choseName";
            this.choseName.Size = new System.Drawing.Size(206, 42);
            this.choseName.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 576);
            this.Controls.Add(this.choseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.baocun2);
            this.Controls.Add(this.baocun);
            this.Controls.Add(this.clevel);
            this.Controls.Add(this.flevel);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree_Role);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "树形菜单-从数据库加载数据";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox flevel;
        private System.Windows.Forms.TextBox clevel;
        private System.Windows.Forms.Button baocun;
        private System.Windows.Forms.Button baocun2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox choseName;
    }
}

