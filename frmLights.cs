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
        public MasterForm MasterForm { get; set; }

        public frmLights()
        {
            InitializeComponent();
        }

        private async void frmLights_Load(object sender, EventArgs e)
        {
            SceneController sceneController = new SceneController();
            IEnumerable<Q42.HueApi.Light> lights = await sceneController.getLights();
            foreach (Q42.HueApi.Light light in lights)
			{
                ListBoxLights.Items.Add(light.Id + " - " + light.Name);
            }
        }

        private LightAnimation CreateNewAnimation()
		{
            LightAnimation Animation = new LightAnimation(lightAnimations.Count)
            {
                LightName = txtLightName.Text,
                RGB = new int[3] { Convert.ToInt16(RValue.Text), Convert.ToInt16(GValue.Text), Convert.ToInt16(BValue.Text) },
                Repeat = Convert.ToInt16(txtRepeat.Text),
                TransitionTime = TimeSpan.FromSeconds(Convert.ToDouble(txtTransitionTime.Text))
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
                MasterForm.HomeForm.LightAnimations = lightAnimations;
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