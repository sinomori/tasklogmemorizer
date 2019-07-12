namespace tasklogmemorizer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.cmbTask1 = new System.Windows.Forms.ComboBox();
            this.cmbTask2 = new System.Windows.Forms.ComboBox();
            this.cmbTask3 = new System.Windows.Forms.ComboBox();
            this.txtTaskMemo1 = new System.Windows.Forms.TextBox();
            this.txtTaskMemo2 = new System.Windows.Forms.TextBox();
            this.txtTaskMemo3 = new System.Windows.Forms.TextBox();
            this.taskRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasklogmemorizerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasklogmemorizerDataSet = new tasklogmemorizer.tasklogmemorizerDataSet();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.taskRecordTableAdapter = new tasklogmemorizer.tasklogmemorizerDataSetTableAdapters.TaskRecordTableAdapter();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.btnTask5 = new System.Windows.Forms.Button();
            this.btnTask6 = new System.Windows.Forms.Button();
            this.pnlTaskLogItems = new System.Windows.Forms.Panel();
            this.txtTaskMemo6 = new System.Windows.Forms.TextBox();
            this.cmbTask6 = new System.Windows.Forms.ComboBox();
            this.txtTaskMemo5 = new System.Windows.Forms.TextBox();
            this.cmbTask5 = new System.Windows.Forms.ComboBox();
            this.txtTaskMemo4 = new System.Windows.Forms.TextBox();
            this.cmbTask4 = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.set6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.taskRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasklogmemorizerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasklogmemorizerDataSet)).BeginInit();
            this.pnlTaskLogItems.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(17, 16);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(75, 40);
            this.btnTask1.TabIndex = 0;
            this.btnTask1.Text = "Task1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(17, 67);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(75, 40);
            this.btnTask2.TabIndex = 1;
            this.btnTask2.Text = "Task2";
            this.btnTask2.UseVisualStyleBackColor = true;
            // 
            // btnTask3
            // 
            this.btnTask3.Location = new System.Drawing.Point(17, 120);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(75, 40);
            this.btnTask3.TabIndex = 2;
            this.btnTask3.Text = "Task3";
            this.btnTask3.UseVisualStyleBackColor = true;
            // 
            // cmbTask1
            // 
            this.cmbTask1.FormattingEnabled = true;
            this.cmbTask1.Items.AddRange(new object[] {
            "て",
            "てｓ１"});
            this.cmbTask1.Location = new System.Drawing.Point(98, 27);
            this.cmbTask1.Name = "cmbTask1";
            this.cmbTask1.Size = new System.Drawing.Size(121, 20);
            this.cmbTask1.TabIndex = 3;
            this.cmbTask1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // cmbTask2
            // 
            this.cmbTask2.FormattingEnabled = true;
            this.cmbTask2.Location = new System.Drawing.Point(98, 78);
            this.cmbTask2.Name = "cmbTask2";
            this.cmbTask2.Size = new System.Drawing.Size(121, 20);
            this.cmbTask2.TabIndex = 4;
            // 
            // cmbTask3
            // 
            this.cmbTask3.FormattingEnabled = true;
            this.cmbTask3.Location = new System.Drawing.Point(98, 129);
            this.cmbTask3.Name = "cmbTask3";
            this.cmbTask3.Size = new System.Drawing.Size(121, 20);
            this.cmbTask3.TabIndex = 5;
            // 
            // txtTaskMemo1
            // 
            this.txtTaskMemo1.Location = new System.Drawing.Point(225, 28);
            this.txtTaskMemo1.Name = "txtTaskMemo1";
            this.txtTaskMemo1.Size = new System.Drawing.Size(194, 19);
            this.txtTaskMemo1.TabIndex = 6;
            // 
            // txtTaskMemo2
            // 
            this.txtTaskMemo2.Location = new System.Drawing.Point(225, 79);
            this.txtTaskMemo2.Name = "txtTaskMemo2";
            this.txtTaskMemo2.Size = new System.Drawing.Size(194, 19);
            this.txtTaskMemo2.TabIndex = 7;
            // 
            // txtTaskMemo3
            // 
            this.txtTaskMemo3.Location = new System.Drawing.Point(225, 131);
            this.txtTaskMemo3.Name = "txtTaskMemo3";
            this.txtTaskMemo3.Size = new System.Drawing.Size(194, 19);
            this.txtTaskMemo3.TabIndex = 8;
            // 
            // taskRecordBindingSource
            // 
            this.taskRecordBindingSource.DataMember = "TaskRecord";
            this.taskRecordBindingSource.DataSource = this.tasklogmemorizerDataSetBindingSource;
            // 
            // tasklogmemorizerDataSetBindingSource
            // 
            this.tasklogmemorizerDataSetBindingSource.DataSource = this.tasklogmemorizerDataSet;
            this.tasklogmemorizerDataSetBindingSource.Position = 0;
            // 
            // tasklogmemorizerDataSet
            // 
            this.tasklogmemorizerDataSet.DataSetName = "tasklogmemorizerDataSet";
            this.tasklogmemorizerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHideForm
            // 
            this.btnHideForm.Location = new System.Drawing.Point(472, 67);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(105, 31);
            this.btnHideForm.TabIndex = 10;
            this.btnHideForm.Text = "Back To Tray";
            this.btnHideForm.UseVisualStyleBackColor = true;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(472, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(170, 19);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // taskRecordTableAdapter
            // 
            this.taskRecordTableAdapter.ClearBeforeFill = true;
            // 
            // btnTask4
            // 
            this.btnTask4.Location = new System.Drawing.Point(17, 175);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(75, 40);
            this.btnTask4.TabIndex = 12;
            this.btnTask4.Text = "Task4";
            this.btnTask4.UseVisualStyleBackColor = true;
            // 
            // btnTask5
            // 
            this.btnTask5.Location = new System.Drawing.Point(17, 232);
            this.btnTask5.Name = "btnTask5";
            this.btnTask5.Size = new System.Drawing.Size(75, 40);
            this.btnTask5.TabIndex = 13;
            this.btnTask5.Text = "Task5";
            this.btnTask5.UseVisualStyleBackColor = true;
            // 
            // btnTask6
            // 
            this.btnTask6.Location = new System.Drawing.Point(17, 287);
            this.btnTask6.Name = "btnTask6";
            this.btnTask6.Size = new System.Drawing.Size(75, 40);
            this.btnTask6.TabIndex = 15;
            this.btnTask6.Text = "Task6";
            this.btnTask6.UseVisualStyleBackColor = true;
            // 
            // pnlTaskLogItems
            // 
            this.pnlTaskLogItems.AutoScroll = true;
            this.pnlTaskLogItems.Controls.Add(this.txtTaskMemo6);
            this.pnlTaskLogItems.Controls.Add(this.cmbTask6);
            this.pnlTaskLogItems.Controls.Add(this.txtTaskMemo5);
            this.pnlTaskLogItems.Controls.Add(this.cmbTask5);
            this.pnlTaskLogItems.Controls.Add(this.txtTaskMemo4);
            this.pnlTaskLogItems.Controls.Add(this.cmbTask4);
            this.pnlTaskLogItems.Controls.Add(this.btnTask1);
            this.pnlTaskLogItems.Controls.Add(this.btnTask2);
            this.pnlTaskLogItems.Controls.Add(this.btnTask6);
            this.pnlTaskLogItems.Controls.Add(this.cmbTask1);
            this.pnlTaskLogItems.Controls.Add(this.btnTask5);
            this.pnlTaskLogItems.Controls.Add(this.cmbTask2);
            this.pnlTaskLogItems.Controls.Add(this.btnTask4);
            this.pnlTaskLogItems.Controls.Add(this.txtTaskMemo1);
            this.pnlTaskLogItems.Controls.Add(this.txtTaskMemo2);
            this.pnlTaskLogItems.Controls.Add(this.btnTask3);
            this.pnlTaskLogItems.Controls.Add(this.txtTaskMemo3);
            this.pnlTaskLogItems.Controls.Add(this.cmbTask3);
            this.pnlTaskLogItems.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskLogItems.Name = "pnlTaskLogItems";
            this.pnlTaskLogItems.Size = new System.Drawing.Size(453, 116);
            this.pnlTaskLogItems.TabIndex = 17;
            this.pnlTaskLogItems.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txtTaskMemo6
            // 
            this.txtTaskMemo6.Location = new System.Drawing.Point(225, 298);
            this.txtTaskMemo6.Name = "txtTaskMemo6";
            this.txtTaskMemo6.Size = new System.Drawing.Size(194, 19);
            this.txtTaskMemo6.TabIndex = 22;
            // 
            // cmbTask6
            // 
            this.cmbTask6.FormattingEnabled = true;
            this.cmbTask6.Location = new System.Drawing.Point(98, 297);
            this.cmbTask6.Name = "cmbTask6";
            this.cmbTask6.Size = new System.Drawing.Size(121, 20);
            this.cmbTask6.TabIndex = 21;
            // 
            // txtTaskMemo5
            // 
            this.txtTaskMemo5.Location = new System.Drawing.Point(225, 244);
            this.txtTaskMemo5.Name = "txtTaskMemo5";
            this.txtTaskMemo5.Size = new System.Drawing.Size(194, 19);
            this.txtTaskMemo5.TabIndex = 20;
            // 
            // cmbTask5
            // 
            this.cmbTask5.FormattingEnabled = true;
            this.cmbTask5.Location = new System.Drawing.Point(98, 242);
            this.cmbTask5.Name = "cmbTask5";
            this.cmbTask5.Size = new System.Drawing.Size(121, 20);
            this.cmbTask5.TabIndex = 19;
            // 
            // txtTaskMemo4
            // 
            this.txtTaskMemo4.Location = new System.Drawing.Point(225, 187);
            this.txtTaskMemo4.Name = "txtTaskMemo4";
            this.txtTaskMemo4.Size = new System.Drawing.Size(194, 19);
            this.txtTaskMemo4.TabIndex = 18;
            // 
            // cmbTask4
            // 
            this.cmbTask4.FormattingEnabled = true;
            this.cmbTask4.Location = new System.Drawing.Point(98, 186);
            this.cmbTask4.Name = "cmbTask4";
            this.cmbTask4.Size = new System.Drawing.Size(121, 20);
            this.cmbTask4.TabIndex = 17;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TaskLogMemorizer";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.loggingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.displayToolStripMenuItem.Text = "display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.DisplayToolStripMenuItem_Click);
            // 
            // loggingToolStripMenuItem
            // 
            this.loggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.set1ToolStripMenuItem,
            this.set2ToolStripMenuItem,
            this.set3ToolStripMenuItem,
            this.set4ToolStripMenuItem,
            this.set5ToolStripMenuItem,
            this.set6ToolStripMenuItem});
            this.loggingToolStripMenuItem.Name = "loggingToolStripMenuItem";
            this.loggingToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.loggingToolStripMenuItem.Text = "logging";
            // 
            // set1ToolStripMenuItem
            // 
            this.set1ToolStripMenuItem.Name = "set1ToolStripMenuItem";
            this.set1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D1)));
            this.set1ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.set1ToolStripMenuItem.Text = "set1";
            this.set1ToolStripMenuItem.Click += new System.EventHandler(this.Set1ToolStripMenuItem_Click);
            // 
            // set2ToolStripMenuItem
            // 
            this.set2ToolStripMenuItem.Name = "set2ToolStripMenuItem";
            this.set2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D2)));
            this.set2ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.set2ToolStripMenuItem.Text = "set2";
            // 
            // set3ToolStripMenuItem
            // 
            this.set3ToolStripMenuItem.Name = "set3ToolStripMenuItem";
            this.set3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D3)));
            this.set3ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.set3ToolStripMenuItem.Text = "set3";
            // 
            // set4ToolStripMenuItem
            // 
            this.set4ToolStripMenuItem.Name = "set4ToolStripMenuItem";
            this.set4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D4)));
            this.set4ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.set4ToolStripMenuItem.Text = "set4";
            // 
            // set5ToolStripMenuItem
            // 
            this.set5ToolStripMenuItem.Name = "set5ToolStripMenuItem";
            this.set5ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D5)));
            this.set5ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.set5ToolStripMenuItem.Text = "set5";
            // 
            // set6ToolStripMenuItem
            // 
            this.set6ToolStripMenuItem.Name = "set6ToolStripMenuItem";
            this.set6ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D6)));
            this.set6ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.set6ToolStripMenuItem.Text = "set6";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 122);
            this.Controls.Add(this.pnlTaskLogItems);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnHideForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "TaskLogMemorizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasklogmemorizerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasklogmemorizerDataSet)).EndInit();
            this.pnlTaskLogItems.ResumeLayout(false);
            this.pnlTaskLogItems.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.ComboBox cmbTask1;
        private System.Windows.Forms.ComboBox cmbTask2;
        private System.Windows.Forms.ComboBox cmbTask3;
        private System.Windows.Forms.TextBox txtTaskMemo1;
        private System.Windows.Forms.TextBox txtTaskMemo2;
        private System.Windows.Forms.TextBox txtTaskMemo3;
        private System.Windows.Forms.BindingSource tasklogmemorizerDataSetBindingSource;
        private tasklogmemorizerDataSet tasklogmemorizerDataSet;
        private System.Windows.Forms.BindingSource taskRecordBindingSource;
        private tasklogmemorizerDataSetTableAdapters.TaskRecordTableAdapter taskRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskcategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnTask4;
        private System.Windows.Forms.Button btnTask5;
        private System.Windows.Forms.Button btnTask6;
        private System.Windows.Forms.Panel pnlTaskLogItems;
        private System.Windows.Forms.TextBox txtTaskMemo6;
        private System.Windows.Forms.ComboBox cmbTask6;
        private System.Windows.Forms.TextBox txtTaskMemo5;
        private System.Windows.Forms.ComboBox cmbTask5;
        private System.Windows.Forms.TextBox txtTaskMemo4;
        private System.Windows.Forms.ComboBox cmbTask4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem set1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem set2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem set3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem set4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem set5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem set6ToolStripMenuItem;
    }
}

