﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace JustLib.Controls
{   
    internal static class RegionHelper
    {
        public static void CreateRegion(Control control, Rectangle rect)
        {
            using (GraphicsPath path =
                GraphicsPathHelper.CreatePath(rect, 8, RoundStyle.All, false))
            {
                if (control.Region != null)
                {
                    control.Region.Dispose();
                }
                control.Region = new Region(path);
            }
        }
    }
}
