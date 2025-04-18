using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinForms
{
    public partial class Settings_Dialog : Form
    {

        public DifficultyType difficulty
        {
            get => (DifficultyType)difficultyComboBox.SelectedItem;
            set => difficultyComboBox.SelectedItem = value;
        }

        public int SegmentCount
        {
            get => (int)SegmentCountnumericUpDown.Value;
            set => SegmentCountnumericUpDown.Value = value;
        }

        public int VialsCount
        {
            get => (int)VialsCountnumericUpDown.Value;
            set => VialsCountnumericUpDown.Value = value;
        }


        public int MinSegmentCount
        {
            get => (int)SegmentCountnumericUpDown.Minimum;
        }
        public int MaxSegmentCount
        {
            get => (int)SegmentCountnumericUpDown.Maximum;
        }
        public int MinVialsCount
        {
            get => (int)VialsCountnumericUpDown.Minimum;
        }
        public int MaxVialsCount
        {
            get => (int)VialsCountnumericUpDown.Maximum;
        }
        public ColorTheme theme
        {
            get
            {
                if (lightRadioButton.Checked)
                {
                    return ColorTheme.Light;
                }
                else if (darkRadioButton.Checked)
                {
                    return ColorTheme.Dark;
                }
                else return ColorTheme.Light;
            }
            set
            {
                switch (value)
                {
                    case ColorTheme.Light:
                        lightRadioButton.Checked = true;
                        break;
                    case ColorTheme.Dark:
                        darkRadioButton.Checked = true;
                        break;
                }
            }
        }
        public Settings_Dialog()
        {
            InitializeComponent();
            difficultyComboBox.Items.Clear();
            difficultyComboBox.Items.Add(DifficultyType.Easy);
            difficultyComboBox.Items.Add(DifficultyType.Medium);
            difficultyComboBox.Items.Add(DifficultyType.Hard);

        }

        private void VialsCountnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
