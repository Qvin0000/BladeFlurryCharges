﻿using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BladeFlurryCharges
{
    public class BladeFlurryChargesSettings : SettingsBase
    {
        public BladeFlurryChargesSettings()
        {
            LeftClick = false;
            ReleaseRightClick = false;
        }


        [Menu("Use Left Click", 1)]
        public ToggleNode LeftClick { get; set; }

        [Menu("Release Right Click", 132, 1)]
        public ToggleNode ReleaseRightClick { get; set; }
    }
}