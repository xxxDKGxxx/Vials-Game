using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2WinForms.Properties;

namespace Task2WinForms
{

    public enum DifficultyType
    {
        Easy,
        Medium,
        Hard,
    }

    public enum ColorTheme
    {
        Light,
        Dark
    }
    public class AppSettings
    {

        private DifficultyType _difficultyType;
        public DifficultyType difficultyType
        {
            get => _difficultyType;
            private set
            {
                if(_difficultyType != value)
                {
                    _difficultyType = value;
                    keySettingsChanged = true;
                }
            }
        }

        private ColorTheme _colorTheme;
        public ColorTheme colorTheme
        {
            get => _colorTheme;
            private set
            {
                if (_colorTheme != value)
                {
                    _colorTheme = value;
                    colorThemeChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(colorTheme)));
                }
            }
        }

        private int _vialsCount;
        public int VialsCount
        {
            get => _vialsCount;
            private set
            {
                if(_vialsCount != value)
                {
                    _vialsCount = value;
                    keySettingsChanged = true;
                }
            }
        }

        private int _segmentsCount;
        public int SegmentsCount
        {
            get => _segmentsCount;
            private set
            {
                if( _segmentsCount != value)
                {
                    _segmentsCount = value;
                    keySettingsChanged = true;
                }
            }
        }
        bool keySettingsChanged = false;

        public event PropertyChangedEventHandler? KeySettingsChanged;
        public event PropertyChangedEventHandler? colorThemeChanged;
        public int Empty
        {
            get
            {
                switch (difficultyType)
                {
                    case DifficultyType.Easy:
                        return 3;
                    case DifficultyType.Medium:
                        return 2;
                    case DifficultyType.Hard:
                        return 1;
                    default:
                        return 3;
                }
            }
        }

        public int Undo
        {
            get
            {
                switch (difficultyType)
                {
                    case DifficultyType.Easy:
                        return 3;
                    case DifficultyType.Medium:
                        return 2;
                    case DifficultyType.Hard:
                        return 1;
                    default:
                        return 3;
                }
            }
        }

        public AppSettings(DifficultyType difficultyType, ColorTheme colorTheme, int vialsCount, int segmentsCount)
        {
            SetValues(difficultyType, colorTheme, vialsCount, segmentsCount);
        }
        
        public AppSettings()
        {
            SetValues((DifficultyType)Properties.Settings.Default.difficultyType, (ColorTheme)Properties.Settings.Default.colorTheme, Properties.Settings.Default.vialsCount, Properties.Settings.Default.segmentsCount);
        }

        public void SetValues(DifficultyType difficultyType, ColorTheme colorTheme, int vialsCount, int segmentsCount)
        {
            keySettingsChanged = false;
            this.difficultyType = difficultyType;
            this.colorTheme = colorTheme;
            VialsCount = vialsCount;
            SegmentsCount = segmentsCount;
            if(keySettingsChanged)
            {
                KeySettingsChanged?.Invoke(this, new PropertyChangedEventArgs(""));
            }
        }

        public void SaveKeySettings()
        {
            Properties.Settings.Default.difficultyType = ((int)this.difficultyType);
            Properties.Settings.Default.segmentsCount = this.SegmentsCount;
            Properties.Settings.Default.vialsCount = this.VialsCount;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            // MessageBox.Show($"Zapisano, wartości: {Properties.Settings.Default.difficultyType}{Properties.Settings.Default.colorTheme}{Properties.Settings.Default.vialsCount}{Properties.Settings.Default.segmentsCount}");
        }

        public void SaveColorTheme()
        {
            Properties.Settings.Default.colorTheme = ((int)this.colorTheme);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            // MessageBox.Show($"Zapisano, wartości: {Properties.Settings.Default.difficultyType}{Properties.Settings.Default.colorTheme}{Properties.Settings.Default.vialsCount}{Properties.Settings.Default.segmentsCount}");
        }

        public void Save()
        {
            SaveKeySettings();
            SaveColorTheme();
        }
    }
}
