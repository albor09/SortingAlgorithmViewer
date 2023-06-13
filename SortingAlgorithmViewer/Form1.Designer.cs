namespace SortingAlgorithmViewer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delayTrBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stepBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.arrLengthTrBar = new System.Windows.Forms.TrackBar();
            this.arrLengthV = new System.Windows.Forms.Label();
            this.delayV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delayTrBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrLengthTrBar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bubble Sort",
            "Heap Sort",
            "Insertion Sort",
            "Quick Sort",
            "Radix Sort"});
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorithm";
            // 
            // delayTrBar
            // 
            this.delayTrBar.LargeChange = 1;
            this.delayTrBar.Location = new System.Drawing.Point(12, 169);
            this.delayTrBar.Maximum = 20;
            this.delayTrBar.Minimum = 1;
            this.delayTrBar.Name = "delayTrBar";
            this.delayTrBar.Size = new System.Drawing.Size(141, 45);
            this.delayTrBar.TabIndex = 5;
            this.delayTrBar.Value = 10;
            this.delayTrBar.Scroll += new System.EventHandler(this.delayTrBar_Scroll);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delay (ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Array generation";
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Visible = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.refreshBtn.Image = global::SortingAlgorithmViewer.Properties.Resources.reload;
            this.refreshBtn.Location = new System.Drawing.Point(840, 418);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(32, 32);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stepBtn
            // 
            this.stepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stepBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stepBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stepBtn.Image = global::SortingAlgorithmViewer.Properties.Resources.next__1_;
            this.stepBtn.Location = new System.Drawing.Point(233, 418);
            this.stepBtn.Name = "stepBtn";
            this.stepBtn.Size = new System.Drawing.Size(32, 32);
            this.stepBtn.TabIndex = 9;
            this.stepBtn.UseVisualStyleBackColor = false;
            this.stepBtn.Click += new System.EventHandler(this.stepBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playBtn.Image = global::SortingAlgorithmViewer.Properties.Resources.stopred__1_;
            this.playBtn.Location = new System.Drawing.Point(195, 418);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(32, 32);
            this.playBtn.TabIndex = 3;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Image = global::SortingAlgorithmViewer.Properties.Resources.programming_code_signs;
            this.button3.Location = new System.Drawing.Point(12, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Array length";
            // 
            // arrLengthTrBar
            // 
            this.arrLengthTrBar.Location = new System.Drawing.Point(12, 236);
            this.arrLengthTrBar.Maximum = 100;
            this.arrLengthTrBar.Minimum = 10;
            this.arrLengthTrBar.Name = "arrLengthTrBar";
            this.arrLengthTrBar.Size = new System.Drawing.Size(141, 45);
            this.arrLengthTrBar.TabIndex = 14;
            this.arrLengthTrBar.TickFrequency = 5;
            this.arrLengthTrBar.Value = 100;
            this.arrLengthTrBar.Scroll += new System.EventHandler(this.arrLengthTrBar_Scroll);
            // 
            // arrLengthV
            // 
            this.arrLengthV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrLengthV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.arrLengthV.Location = new System.Drawing.Point(147, 236);
            this.arrLengthV.Name = "arrLengthV";
            this.arrLengthV.Size = new System.Drawing.Size(42, 45);
            this.arrLengthV.TabIndex = 15;
            this.arrLengthV.Text = "100";
            this.arrLengthV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // delayV
            // 
            this.delayV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delayV.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.delayV.Location = new System.Drawing.Point(147, 169);
            this.delayV.Name = "delayV";
            this.delayV.Size = new System.Drawing.Size(42, 45);
            this.delayV.TabIndex = 16;
            this.delayV.Text = "100";
            this.delayV.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.delayV);
            this.Controls.Add(this.arrLengthV);
            this.Controls.Add(this.arrLengthTrBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.stepBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.delayTrBar);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Sorting Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.delayTrBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrLengthTrBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.TrackBar delayTrBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button stepBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar arrLengthTrBar;
        private System.Windows.Forms.Label arrLengthV;
        private System.Windows.Forms.Label delayV;
    }
}

