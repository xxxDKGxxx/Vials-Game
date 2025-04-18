using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Task2WinForms
{
    internal class ColorPresetFactory
    {
        public ColorPresetFactory() { }

        public ColorPreset CreatePreset(ColorTheme theme) => theme switch
        {
            ColorTheme.Light => new ColorPreset
            {
                background = Color.White,
                button = Color.FromKnownColor(KnownColor.Control),
                text = Color.Black,
                accent = Color.Pink
            },
            ColorTheme.Dark => new ColorPreset
            {
                background= Color.FromArgb(60, 60, 60),
                button= Color.FromArgb(100, 100, 100),
                text= Color.White,
                accent= Color.Pink
            }
        };
    }
}
