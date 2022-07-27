namespace javahomechanger
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.ComboBox();
            this.log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 37);
            this.title.TabIndex = 0;
            this.title.Text = "JAVA_HOME Changer";
            // 
            // path
            // 
            this.path.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.path.Location = new System.Drawing.Point(19, 62);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(259, 23);
            this.path.TabIndex = 0;
            this.path.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(19, 156);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(250, 268);
            this.log.TabIndex = 1;
            this.log.Text = "LOG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.log);
            this.Controls.Add(this.path);
            this.Controls.Add(this.title);
            this.MaximumSize = new System.Drawing.Size(311, 497);
            this.MinimumSize = new System.Drawing.Size(311, 497);
            this.Name = "Form1";
            this.Text = "JAVA_HOME Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox path;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.Button button1;
    }
}

