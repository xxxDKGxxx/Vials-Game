namespace Task2WinForms
{
    partial class Settings_Dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SegmentCountnumericUpDown = new NumericUpDown();
            VialsCountnumericUpDown = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            darkRadioButton = new RadioButton();
            lightRadioButton = new RadioButton();
            difficultyComboBox = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            cancelButton = new Button();
            okButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SegmentCountnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VialsCountnumericUpDown).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(SegmentCountnumericUpDown, 1, 1);
            tableLayoutPanel1.Controls.Add(VialsCountnumericUpDown, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(difficultyComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel1.Location = new Point(-2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(390, 226);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Difficulty";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(32, 52);
            label2.Name = "label2";
            label2.Size = new Size(62, 30);
            label2.TabIndex = 1;
            label2.Text = "Segments Count";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(27, 105);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Vials Count";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(18, 150);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "Color Theme";
            // 
            // SegmentCountnumericUpDown
            // 
            SegmentCountnumericUpDown.Anchor = AnchorStyles.None;
            SegmentCountnumericUpDown.Location = new Point(143, 56);
            SegmentCountnumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            SegmentCountnumericUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            SegmentCountnumericUpDown.Name = "SegmentCountnumericUpDown";
            SegmentCountnumericUpDown.Size = new Size(200, 23);
            SegmentCountnumericUpDown.TabIndex = 5;
            SegmentCountnumericUpDown.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // VialsCountnumericUpDown
            // 
            VialsCountnumericUpDown.Anchor = AnchorStyles.None;
            VialsCountnumericUpDown.Location = new Point(143, 101);
            VialsCountnumericUpDown.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            VialsCountnumericUpDown.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            VialsCountnumericUpDown.Name = "VialsCountnumericUpDown";
            VialsCountnumericUpDown.Size = new Size(200, 23);
            VialsCountnumericUpDown.TabIndex = 6;
            VialsCountnumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            VialsCountnumericUpDown.ValueChanged += VialsCountnumericUpDown_ValueChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(darkRadioButton, 1, 0);
            tableLayoutPanel2.Controls.Add(lightRadioButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(100, 138);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(287, 39);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // darkRadioButton
            // 
            darkRadioButton.Anchor = AnchorStyles.Left;
            darkRadioButton.AutoSize = true;
            darkRadioButton.Location = new Point(146, 10);
            darkRadioButton.Name = "darkRadioButton";
            darkRadioButton.Size = new Size(49, 19);
            darkRadioButton.TabIndex = 1;
            darkRadioButton.TabStop = true;
            darkRadioButton.Text = "Dark";
            darkRadioButton.UseVisualStyleBackColor = true;
            // 
            // lightRadioButton
            // 
            lightRadioButton.Anchor = AnchorStyles.Right;
            lightRadioButton.AutoSize = true;
            lightRadioButton.Location = new Point(88, 10);
            lightRadioButton.Name = "lightRadioButton";
            lightRadioButton.Size = new Size(52, 19);
            lightRadioButton.TabIndex = 0;
            lightRadioButton.TabStop = true;
            lightRadioButton.Text = "Light";
            lightRadioButton.UseVisualStyleBackColor = true;
            // 
            // difficultyComboBox
            // 
            difficultyComboBox.Anchor = AnchorStyles.None;
            difficultyComboBox.FormattingEnabled = true;
            difficultyComboBox.Location = new Point(143, 11);
            difficultyComboBox.Name = "difficultyComboBox";
            difficultyComboBox.Size = new Size(200, 23);
            difficultyComboBox.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel3.Controls.Add(okButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(100, 183);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(287, 40);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(177, 8);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.None;
            okButton.Location = new Point(34, 8);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // Settings_Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 226);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings_Dialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SegmentCountnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)VialsCountnumericUpDown).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown SegmentCountnumericUpDown;
        private NumericUpDown VialsCountnumericUpDown;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton lightRadioButton;
        private RadioButton darkRadioButton;
        private ComboBox difficultyComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button cancelButton;
        private Button okButton;
    }
}