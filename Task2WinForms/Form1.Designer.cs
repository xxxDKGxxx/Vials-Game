namespace Task2WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            surrenderToolStripMenuItem = new ToolStripMenuItem();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openSettingsToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            vialControl4 = new VialControl();
            vialControl3 = new VialControl();
            vialControl2 = new VialControl();
            vialControl1 = new VialControl();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, surrenderToolStripMenuItem, exitGameToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(132, 22);
            newGameToolStripMenuItem.Text = "New Game";
            // 
            // surrenderToolStripMenuItem
            // 
            surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            surrenderToolStripMenuItem.Size = new Size(132, 22);
            surrenderToolStripMenuItem.Text = "Surrender";
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(132, 22);
            exitGameToolStripMenuItem.Text = "Exit Game";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // openSettingsToolStripMenuItem
            // 
            openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            openSettingsToolStripMenuItem.Size = new Size(157, 22);
            openSettingsToolStripMenuItem.Text = "Open Settings...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(vialControl4, 3, 0);
            tableLayoutPanel1.Controls.Add(vialControl3, 2, 0);
            tableLayoutPanel1.Controls.Add(vialControl2, 1, 0);
            tableLayoutPanel1.Controls.Add(vialControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(784, 437);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // vialControl4
            // 
            vialControl4.AllowDrop = true;
            vialControl4.Anchor = AnchorStyles.None;
            vialControl4.InitSegmentCount = 3;
            vialControl4.Location = new Point(661, 143);
            vialControl4.MaxSegments = 4;
            vialControl4.Name = "vialControl4";
            vialControl4.Size = new Size(50, 150);
            vialControl4.TabIndex = 3;
            vialControl4.DragDrop += vialControl1_DragDrop;
            vialControl4.DragEnter += vialControl1_DragEnter;
            vialControl4.MouseClick += vialControl1_MouseClick;
            vialControl4.MouseDown += vialControl1_MouseDown;
            // 
            // vialControl3
            // 
            vialControl3.AllowDrop = true;
            vialControl3.Anchor = AnchorStyles.None;
            vialControl3.InitSegmentCount = 3;
            vialControl3.Location = new Point(465, 143);
            vialControl3.MaxSegments = 4;
            vialControl3.Name = "vialControl3";
            vialControl3.Size = new Size(50, 150);
            vialControl3.TabIndex = 2;
            vialControl3.DragDrop += vialControl1_DragDrop;
            vialControl3.DragEnter += vialControl1_DragEnter;
            vialControl3.MouseClick += vialControl1_MouseClick;
            vialControl3.MouseDown += vialControl1_MouseDown;
            // 
            // vialControl2
            // 
            vialControl2.AllowDrop = true;
            vialControl2.Anchor = AnchorStyles.None;
            vialControl2.InitSegmentCount = 3;
            vialControl2.Location = new Point(269, 143);
            vialControl2.MaxSegments = 4;
            vialControl2.Name = "vialControl2";
            vialControl2.Size = new Size(50, 150);
            vialControl2.TabIndex = 1;
            vialControl2.DragDrop += vialControl1_DragDrop;
            vialControl2.DragEnter += vialControl1_DragEnter;
            vialControl2.MouseClick += vialControl1_MouseClick;
            vialControl2.MouseDown += vialControl1_MouseDown;
            // 
            // vialControl1
            // 
            vialControl1.AllowDrop = true;
            vialControl1.Anchor = AnchorStyles.None;
            vialControl1.InitSegmentCount = 3;
            vialControl1.Location = new Point(73, 143);
            vialControl1.MaxSegments = 4;
            vialControl1.Name = "vialControl1";
            vialControl1.Size = new Size(50, 150);
            vialControl1.TabIndex = 0;
            vialControl1.DragDrop += vialControl1_DragDrop;
            vialControl1.DragEnter += vialControl1_DragEnter;
            vialControl1.MouseClick += vialControl1_MouseClick;
            vialControl1.MouseDown += vialControl1_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(500, 300);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem surrenderToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem openSettingsToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private VialControl vialControl4;
        private VialControl vialControl3;
        private VialControl vialControl2;
        private VialControl vialControl1;
    }
}
