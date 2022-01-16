using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloweenLightsWFA
{
    public partial class frmLights : Form
    {
        //Determines the color of the RGB values' text in the Animation Table, ranges from 0 - 100,
        const int ChangeRGBtextColor = 5;
        readonly List<LightAnimation> lightAnimations = new List<LightAnimation>();
        public frmLights()
        {
            InitializeComponent();
        }

        private LightAnimation CreateNewAnimation()
		{
            LightAnimation Animation = new LightAnimation(lightAnimations.Count)
            {
                LightName = txtLightName.Text,
                RGB = new int[3] { Convert.ToInt16(RValue.Text), Convert.ToInt16(GValue.Text), Convert.ToInt16(BValue.Text) },
                Repeat = Convert.ToInt16(txtRepeat.Text),
                TransitionTime = Convert.ToInt16(txtTransitionTime.Text)
            };
            if (Animation.CheckLightNameUniqueness(lightAnimations))
            {
                return Animation;
            }
            return null;
        }

        private void btnAddAnimation_Click(object sender, EventArgs e)
		{
            if(CreateNewAnimation() != null)
			{
                LightAnimation Animation = CreateNewAnimation();
                lightAnimations.Add(Animation);
                ShowInTable(Animation, ChangeRGBtextColor);
            }
        }

        private void ShowInTable(LightAnimation _Animation, int ValueChangeColor)
        {
            Color RGBTextColor = new Color();
            string rgb = _Animation.RGB[0] + ", " + _Animation.RGB[1] + ", " + _Animation.RGB[2];

            if (_Animation.RGB[0] * _Animation.RGB[1] * _Animation.RGB[2] < ValueChangeColor * 165813.75)
            {
                RGBTextColor = Color.White;
            }
            else { RGBTextColor = Color.Black; }

            AnimationTable.Rows.Add(_Animation.LightName, rgb, _Animation.Repeat, _Animation.TransitionTime);
            AnimationTable.Rows[AnimationTable.Rows.Count - 1].Cells[1].Style.ForeColor = RGBTextColor;
            AnimationTable.Rows[AnimationTable.Rows.Count - 1].Cells[1].Style.BackColor = Color.FromArgb(_Animation.RGB[0], _Animation.RGB[1], _Animation.RGB[2]);
        }
    }
}