﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neurophotometrics.Design
{
    public partial class TriggerModeView : UserControl
    {
        const int LabelOffset = 10;
        const int StateWidth = 200;
        const int StateHeight = 50;
        const int StateSpacer = 40;
        static readonly Brush L410 = new SolidBrush(ColorTranslator.FromHtml("#7E00DB"));
        static readonly Brush L470 = new SolidBrush(ColorTranslator.FromHtml("#00A9FF"));
        static readonly Brush L560 = new SolidBrush(ColorTranslator.FromHtml("#C3FF00"));
        static readonly Brush LExt = new SolidBrush(ColorTranslator.FromHtml("#808080"));
        TriggerMode triggerMode;

        public TriggerModeView()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TriggerMode TriggerMode
        {
            get { return triggerMode; }
            set
            {
                triggerMode = value;
                triggerPanel.Invalidate();
            }
        }

        float FillFragment(Graphics graphics, string label, Brush brush, float offsetX, float offsetY, float fragmentWidth, float fragmentHeight)
        {
            graphics.FillRectangle(brush, offsetX, offsetY, fragmentWidth, fragmentHeight);
            if (!string.IsNullOrEmpty(label))
            {
                var labelSize = graphics.MeasureString(label, Font);
                graphics.DrawString(label, Font, Brushes.Black, offsetX, offsetY + fragmentHeight);
            }
            return offsetX + fragmentWidth;
        }

        private void triggerPanel_Paint(object sender, PaintEventArgs e)
        {
            if (triggerMode != TriggerMode.UserSpecified)
            {
                var triggerState = TriggerHelper.ToTriggerState(triggerMode);
                var triggerStateLength = TriggerHelper.GetTriggerStateLength(triggerMode);

                var totalHeight = triggerStateLength * (StateHeight + StateSpacer);
                var offsetY = (triggerPanel.Height - totalHeight) / 2f;
                for (int i = 0; i < triggerStateLength; i++)
                {
                    var offsetX = (triggerPanel.Width - StateWidth) / 2f;
                    var label = (i + 1).ToString();
                    var labelSize = e.Graphics.MeasureString(label, Font);
                    e.Graphics.DrawString(
                        label, Font,
                        Brushes.Black,
                        offsetX - labelSize.Width - LabelOffset,
                        offsetY + (StateHeight - labelSize.Height) / 2);

                    var led410 = triggerState[i] >> 0 & 0x1;
                    var led470 = triggerState[i] >> 1 & 0x1;
                    var led560 = triggerState[i] >> 2 & 0x1;
                    var ledExt = triggerState[i] >> 3 & 0x1;
                    var ledCount = led410 + led470 + led560 + ledExt;
                    if (ledCount == 0)
                    {
                        FillFragment(e.Graphics, string.Empty, Brushes.Black, offsetX, offsetY, StateWidth, StateHeight);
                    }
                    else
                    {
                        var fragmentWidth = StateWidth / ledCount;
                        if (led410 != 0) offsetX = FillFragment(e.Graphics, "410nm", L410, offsetX, offsetY, fragmentWidth, StateHeight);
                        if (led470 != 0) offsetX = FillFragment(e.Graphics, "470nm", L470, offsetX, offsetY, fragmentWidth, StateHeight);
                        if (led560 != 0) offsetX = FillFragment(e.Graphics, "560nm", L560, offsetX, offsetY, fragmentWidth, StateHeight);
                        if (ledExt != 0) offsetX = FillFragment(e.Graphics, "Ext.", LExt, offsetX, offsetY, fragmentWidth, StateHeight);
                    }

                    offsetY += StateHeight + StateSpacer;
                }
            }
        }
    }
}
