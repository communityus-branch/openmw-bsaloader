namespace BSALoader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.browseButtonM = new System.Windows.Forms.Button();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBrowseO = new System.Windows.Forms.Button();
            this.textBoxO = new System.Windows.Forms.TextBox();
            this.labelM = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.browserM = new System.Windows.Forms.FolderBrowserDialog();
            this.browserO = new System.Windows.Forms.FolderBrowserDialog();
            this.updateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelO, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.browseButtonM, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxM, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(414, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // browseButtonM
            // 
            this.browseButtonM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.browseButtonM.Location = new System.Drawing.Point(354, 3);
            this.browseButtonM.Name = "browseButtonM";
            this.browseButtonM.Size = new System.Drawing.Size(57, 22);
            this.browseButtonM.TabIndex = 0;
            this.browseButtonM.Text = "Обзор...";
            this.browseButtonM.UseVisualStyleBackColor = true;
            this.browseButtonM.Click += new System.EventHandler(this.browseButtonM_Click);
            // 
            // textBoxM
            // 
            this.textBoxM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxM.Location = new System.Drawing.Point(3, 4);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(345, 20);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.buttonBrowseO, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxO, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 84);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(414, 28);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonBrowseO
            // 
            this.buttonBrowseO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBrowseO.Location = new System.Drawing.Point(354, 4);
            this.buttonBrowseO.Name = "buttonBrowseO";
            this.buttonBrowseO.Size = new System.Drawing.Size(57, 20);
            this.buttonBrowseO.TabIndex = 0;
            this.buttonBrowseO.Text = "Обзор...";
            this.buttonBrowseO.UseVisualStyleBackColor = true;
            this.buttonBrowseO.Click += new System.EventHandler(this.buttonBrowseO_Click);
            // 
            // textBoxO
            // 
            this.textBoxO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxO.Location = new System.Drawing.Point(3, 4);
            this.textBoxO.Name = "textBoxO";
            this.textBoxO.Size = new System.Drawing.Size(345, 20);
            this.textBoxO.TabIndex = 1;
            this.textBoxO.TextChanged += new System.EventHandler(this.textBoxO_TextChanged);
            // 
            // labelM
            // 
            this.labelM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(133, 7);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(147, 13);
            this.labelM.TabIndex = 3;
            this.labelM.Text = "Напишите путь к Morrowind:";
            // 
            // labelO
            // 
            this.labelO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelO.AutoSize = true;
            this.labelO.Location = new System.Drawing.Point(135, 63);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(144, 13);
            this.labelO.TabIndex = 4;
            this.labelO.Text = "Напишите путь к OpenMW:";
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Location = new System.Drawing.Point(174, 115);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(66, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "BSALoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button browseButtonM;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonBrowseO;
        private System.Windows.Forms.TextBox textBoxO;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.FolderBrowserDialog browserM;
        private System.Windows.Forms.FolderBrowserDialog browserO;
        private System.Windows.Forms.Button updateButton;
    }
}

