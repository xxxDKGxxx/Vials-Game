using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;

namespace Task2WinForms
{
    public partial class Form1 : Form
    {
        private const int CONTROL_WIDTH = 50;
        private const int CONTORL_HEIGHT = 500;
        private const int maxVialsinRow = 7;
        private const string bestScoreFileName = "score.json";


        private int vialCount = 8;
        private int _undosLeft;
        private int undosLeft
        {
            get => _undosLeft;
            set
            {
                if (_undosLeft != value)
                {
                    _undosLeft = value;
                    undosChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(undosLeft)));
                }
            }
        }

        private int _score = -1;
        private int score
        {
            get => _score;
            set
            {
                if (score != value)
                {
                    _score = value;
                    scoreChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(score)));
                }
            }
        }

        private int _bestScore = -1;
        private int bestScore
        {
            get => _bestScore;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(bestScore), bestScore, "Tried setting bestScore a negative Value"); ;
                }
                if (bestScore != value)
                {
                    _bestScore = value;
                    bestScoreChanged?.Invoke(this, new PropertyChangedEventArgs($"{nameof(bestScore)}"));
                }
            }
        }

        private bool _hasWon = true;
        private bool hasWon
        {
            get => _hasWon;
            set
            {
                if (value != _hasWon)
                {
                    _hasWon = value;
                    hasWonChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(hasWon)));
                }
            }
        }

        private event PropertyChangedEventHandler undosChanged;
        private event PropertyChangedEventHandler scoreChanged;
        private event PropertyChangedEventHandler hasWonChanged;
        private event PropertyChangedEventHandler bestScoreChanged;

        TableLayoutPanel tableLayoutPanel;
        List<VialControl> vials;
        AppSettings appSettings;
        public Form1()
        {
            InitializeComponent();
            undosChanged += Form1_undosChanged;
            scoreChanged += Form1_scoreChanged;
            hasWonChanged += Form1_hasWonChanged;
            bestScoreChanged += Form1_bestScoreChanged;
            validateSettings();
            initSettings();
            initBestScore();
            appSettings.KeySettingsChanged += AppSettings_KeySettingsChanged;
            appSettings.colorThemeChanged += AppSettings_colorThemeChanged;
            InitGame();
            score = 0;
            applyColor();
        }


        private void validateSettings()
        {
            Settings_Dialog dlg = new Settings_Dialog();
            if(Properties.Settings.Default.difficultyType < 0 || Properties.Settings.Default.difficultyType > 2 ||
                Properties.Settings.Default.colorTheme < 0 || Properties.Settings.Default.colorTheme > 1 ||
                Properties.Settings.Default.vialsCount < dlg.MinVialsCount || Properties.Settings.Default.vialsCount > dlg.MaxVialsCount ||
                Properties.Settings.Default.segmentsCount < dlg.MinSegmentCount || Properties.Settings.Default.segmentsCount > dlg.MaxSegmentCount)
            {
                Properties.Settings.Default.Reset();
            }
        }

        private void applyColor()
        {
            var factory = new ColorPresetFactory();
            var preset = factory.CreatePreset(appSettings.colorTheme);
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(preset);
            applyColorToControlAndChildren(this, preset);
        }

        private void applyColorToControlAndChildren(Control control, ColorPreset preset)
        {
            control.BackColor = preset.background;
            control.ForeColor = preset.text;
            if(control is Button)
            {
                control.BackColor = preset.button;
            }
            if (control is MenuStrip m)
            {
                foreach (ToolStripMenuItem item in m.Items)
                {
                    item.BackColor = preset.background;
                    item.ForeColor = preset.text;
                    foreach (ToolStripItem subitem in item.DropDownItems)
                    {
                        subitem.BackColor = preset.background;
                        subitem.ForeColor = preset.text;
                    }
                }
            }
            else
            {
                if (!control.HasChildren) return;
                foreach (var child in control.Controls)
                {
                    applyColorToControlAndChildren((Control)child, preset);
                }
            }
        }

        private void initBestScore()
        {
            try
            {
                var serialized = File.ReadAllText(bestScoreFileName);
                bestScore = (int ?)JsonSerializer.Deserialize(serialized, typeof(int)) ?? 0;
            }
            catch(FileNotFoundException)
            {
                bestScore = 0;
                return;
            }
        }

        private void Form1_bestScoreChanged(object? sender, PropertyChangedEventArgs e)
        {
            bestScoreLabel.Text = $"Best score: {bestScore}";
            var serialized = JsonSerializer.Serialize(bestScore, typeof(int));
            File.WriteAllText(bestScoreFileName, serialized);
        }

        private void Form1_hasWonChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (hasWon == true)
            {
                // MessageBox.Show("hasWon Invoked");
                foreach (var vial in vials)
                {
                    vial.AllowDrop = false;
                }
                winLabel.Text = "Congratulations! You won!";
                nextGameButton.Enabled = true;
                score += (4 - ((int)appSettings.difficultyType)) * (appSettings.SegmentsCount) * (appSettings.VialsCount - appSettings.Empty);
            }
            else
            {
                winLabel.Text = "";
                nextGameButton.Enabled = false;
            }
        }

        private void AppSettings_colorThemeChanged(object? sender, PropertyChangedEventArgs e)
        {
            appSettings.SaveColorTheme();
            applyColor();
        }

        private void AppSettings_KeySettingsChanged(object? sender, PropertyChangedEventArgs e)
        {
            appSettings.SaveKeySettings();
            InitGame();
            this.score = 0;
        }

        private void InitGame(bool keepUndos = false)
        {
            hasWon = false;
            if (!keepUndos) ResetUndos();
            hasWonChanged -= Form1_hasWonChanged;
            do
            {
                initLayout();
                initColors();
                if (appSettings.VialsCount - appSettings.Empty == 1) break;
            } while (hasWon == true);
            UndoManager.Instance.Reset();
            hasWonChanged += Form1_hasWonChanged;
        }

        private void Form1_scoreChanged(object? sender, PropertyChangedEventArgs e)
        {
            scoreLabel.Text = $"Score: {score}";
        }

        private void Form1_undosChanged(object? sender, PropertyChangedEventArgs e)
        {
            undosLeftLabel.Text = $"(Undos left: {undosLeft})";
            if (undosLeft == 0)
            {
                undoButton.Enabled = false;
            }
            else
            {
                undoButton.Enabled = true;
            }
        }

        private void initSettings()
        {
            appSettings = new AppSettings();
        }

        private void ResetUndos()
        {
            undosLeft = appSettings.Undo;
        }

        public static Color FromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            return hi switch
            {
                0 => Color.FromArgb(255, v, t, p),
                1 => Color.FromArgb(255, q, v, p),
                2 => Color.FromArgb(255, p, v, t),
                3 => Color.FromArgb(255, p, q, v),
                4 => Color.FromArgb(255, t, p, v),
                _ => Color.FromArgb(255, v, p, q),
            };
        }


        private void initColors()
        {
            List<Color> colors = new();
            for (int i = 0; i < appSettings.VialsCount - appSettings.Empty; i++)
            {
                for (int j = 0; j < appSettings.SegmentsCount; j++)
                {
                    var color = FromHSV(360f / (appSettings.VialsCount - appSettings.Empty) * i, 0.9f, 0.9f);
                    colors.Add(color);
                }

            }
            foreach (var vial in vials)
            {
                vial.pickColors(colors);
                vial.Refresh();
            }
        }

        private void initLayout()
        {
            gameAreapanel.Controls.Remove(tableLayoutPanel);
            vials = new();
            tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = maxVialsinRow;
            tableLayoutPanel.RowCount = (int)Math.Ceiling(appSettings.VialsCount * 1.0f / (maxVialsinRow));
            tableLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tableLayoutPanel.RowCount));
            }

            for (int j = 0; j < appSettings.VialsCount; j++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f / appSettings.VialsCount));
                var newVial = new VialControl();
                InitVial(newVial);
                vials.Add(newVial);
                tableLayoutPanel.Controls.Add(newVial);
            }
            gameAreapanel.Controls.Add(tableLayoutPanel);
        }

        private void InitVial(VialControl newVial)
        {
            newVial.MaxSegments = appSettings.SegmentsCount;
            newVial.InitSegmentCount = appSettings.SegmentsCount;
            newVial.Anchor = AnchorStyles.None;
            newVial.Dock = DockStyle.None;
            newVial.Padding = new Padding(0);
            newVial.Segments.ListChanged += Segments_ListChanged;
            newVial.DragDropOccured += NewVial_DragDropOccured;
            newVial.AllowDrop = true;
        }

        private void NewVial_DragDropOccured(object sender, DragDropOccuredEventArgs e)
        {
            if (sender is VialControl v)
            {
                UndoManager.Instance.AddMove(e.from, e.to, e.amount);
            }
        }

        private void Segments_ListChanged(object? sender, ListChangedEventArgs e)
        {
            foreach (var v in vials)
            {
                if (v.Segments.Count == 0) continue;

                var sameColored = v.Segments.Where((seg) => seg.Color == v.Segments.First().Color);
                if (sameColored.Count() != v.MaxSegments)
                {
                    hasWon = false;
                    return;
                }
            }
            hasWon = true;
        }

        private void vialControl1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void vialControl1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void vialControl1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void vialControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (hasWon) return;
            if (undosLeft > 0)
            {
                if (!UndoManager.Instance.Undo()) return;
            }
            undosLeft = Math.Max(undosLeft - 1, 0);
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings_Dialog settings_Dialog = new Settings_Dialog();
            settings_Dialog.difficulty = appSettings.difficultyType;
            settings_Dialog.SegmentCount = appSettings.SegmentsCount;
            settings_Dialog.VialsCount = appSettings.VialsCount;
            settings_Dialog.theme = appSettings.colorTheme;
            var factory = new ColorPresetFactory();
            applyColorToControlAndChildren(settings_Dialog, factory.CreatePreset(appSettings.colorTheme));
            settings_Dialog.ShowDialog();
            if (settings_Dialog.DialogResult == DialogResult.OK)
            {
                appSettings.SetValues(settings_Dialog.difficulty, settings_Dialog.theme, settings_Dialog.VialsCount, settings_Dialog.SegmentCount);
            }
        }

        private void nextGameButton_Click(object sender, EventArgs e)
        {
            InitGame(true);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitGame();
            this.score = 0;
        }

        private void surrenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(score > bestScore)
            {
                bestScore = score;
            }
            int winscore = score;
            hasWon = true;
            winLabel.Text = "Game ended!";
            nextGameButton.Enabled = false;
            score = winscore;
        }
    }
}
