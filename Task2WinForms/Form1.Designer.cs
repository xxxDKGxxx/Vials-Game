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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            surrenderToolStripMenuItem = new ToolStripMenuItem();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            openSettingsToolStripMenuItem = new ToolStripMenuItem();
            gameAreapanel = new Panel();
            bottomPanel = new Panel();
            winLabel = new Label();
            scoreLabel = new Label();
            bestScoreLabel = new Label();
            undosLeftLabel = new Label();
            nextGameButton = new Button();
            undoButton = new Button();
            menuStrip1.SuspendLayout();
            bottomPanel.SuspendLayout();
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
            newGameToolStripMenuItem.Size = new Size(180, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // surrenderToolStripMenuItem
            // 
            surrenderToolStripMenuItem.Name = "surrenderToolStripMenuItem";
            surrenderToolStripMenuItem.Size = new Size(180, 22);
            surrenderToolStripMenuItem.Text = "End Game";
            surrenderToolStripMenuItem.Click += surrenderToolStripMenuItem_Click;
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(180, 22);
            exitGameToolStripMenuItem.Text = "Exit Game";
            exitGameToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
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
            openSettingsToolStripMenuItem.Click += openSettingsToolStripMenuItem_Click;
            // 
            // gameAreapanel
            // 
            gameAreapanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameAreapanel.Location = new Point(3, 21);
            gameAreapanel.Name = "gameAreapanel";
            gameAreapanel.Size = new Size(781, 353);
            gameAreapanel.TabIndex = 1;
            // 
            // bottomPanel
            // 
            bottomPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bottomPanel.Controls.Add(winLabel);
            bottomPanel.Controls.Add(scoreLabel);
            bottomPanel.Controls.Add(bestScoreLabel);
            bottomPanel.Controls.Add(undosLeftLabel);
            bottomPanel.Controls.Add(nextGameButton);
            bottomPanel.Controls.Add(undoButton);
            bottomPanel.Location = new Point(3, 380);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(781, 80);
            bottomPanel.TabIndex = 2;
            // 
            // winLabel
            // 
            winLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            winLabel.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            winLabel.Location = new Point(551, 30);
            winLabel.Name = "winLabel";
            winLabel.Size = new Size(137, 42);
            winLabel.TabIndex = 5;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(159, 50);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(38, 15);
            scoreLabel.TabIndex = 4;
            scoreLabel.Text = "label2";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(159, 9);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(38, 15);
            bestScoreLabel.TabIndex = 3;
            bestScoreLabel.Text = "label1";
            // 
            // undosLeftLabel
            // 
            undosLeftLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            undosLeftLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            undosLeftLabel.Location = new Point(18, 52);
            undosLeftLabel.Name = "undosLeftLabel";
            undosLeftLabel.Size = new Size(75, 28);
            undosLeftLabel.TabIndex = 2;
            undosLeftLabel.Text = "label1";
            undosLeftLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nextGameButton
            // 
            nextGameButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextGameButton.Location = new Point(694, 30);
            nextGameButton.Name = "nextGameButton";
            nextGameButton.Size = new Size(75, 23);
            nextGameButton.TabIndex = 1;
            nextGameButton.Text = "Next Game";
            nextGameButton.UseVisualStyleBackColor = true;
            nextGameButton.Click += nextGameButton_Click;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            undoButton.Location = new Point(18, 26);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(75, 23);
            undoButton.TabIndex = 0;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(bottomPanel);
            Controls.Add(gameAreapanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(500, 300);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion Master";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
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
        private Panel gameAreapanel;
        private Panel bottomPanel;
        private Button undoButton;
        private Button nextGameButton;
        private Label undosLeftLabel;
        private Label scoreLabel;
        private Label bestScoreLabel;
        private Label winLabel;
    }
}
