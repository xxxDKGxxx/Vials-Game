using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2WinForms
{
    internal class ColorPreset: ProfessionalColorTable
    {
        public override Color MenuItemSelected => accent;
        public override Color MenuStripGradientBegin => background;
        public override Color MenuStripGradientEnd => background;
        public override Color MenuItemSelectedGradientBegin => accent;
        public override Color MenuItemSelectedGradientEnd => accent;
        public override Color MenuBorder => text;
        public override Color MenuItemBorder => text;
        public override Color MenuItemPressedGradientBegin => accent;
        public override Color MenuItemPressedGradientEnd => accent;
        public override Color MenuItemPressedGradientMiddle => accent;

        public Color background;
        public Color button;
        public Color text;
        public Color accent;
    }
}
