using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.GUI
{
    public static class ConfigApp
    {

        public static MaterialSkin.MaterialSkinManager.Themes Themes = MaterialSkinManager.Themes.LIGHT;

        public static MaterialSkin.Primary Primary = Primary.Blue600;
        public static MaterialSkin.Primary DarkPrimary = Primary.BlueGrey900;
        public static MaterialSkin.Primary LightPrimary = Primary.DeepPurple100;
        public static MaterialSkin.Accent Accent = Accent.Cyan700;
        public static MaterialSkin.TextShade TextShade = TextShade.WHITE;

    }
}
