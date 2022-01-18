using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace HalloweenLightsWFA
{
    public partial class frmHome : Form
    {
        public MasterForm MasterForm { get; set; }
        public List<LightAnimation> LightAnimations { get; set; }
        SceneController sceneController = new SceneController();

        public frmHome()
        {
            InitializeComponent();
        }

        private void BtnConnectToBridge_Click(object sender, EventArgs e)
        {
            GiveBridgeConnectFeedback("PressButton");
            sceneController.IP = TxtBridgeIP.Text;
            new Task(sceneController.StartConnectToBridge).Start();
        }

        private async void BtnFinishConnecting_Click(object sender, EventArgs e)
        {
            await sceneController.FinishConnectToBridge();
			if (sceneController.IsRegistered()) { GiveBridgeConnectFeedback("Connected"); }
            else { GiveBridgeConnectFeedback("PressButton"); }
        }

        private void BtnStartLights_Click(object sender, EventArgs e)
        {
            sceneController.StartLights(LightAnimations);
        }

        private void BtnStartCasting_Click(object sender, EventArgs e)
        {

        }

        public void GiveBridgeConnectFeedback(string situation, int wait = 0)
		{
			switch (situation)
			{
				case "PressButton":
                    TxtBoxConnectFeedBack.Text = "Press button on bridge!";
                    break;
                case "NotPressed":
                    TxtBoxConnectFeedBack.Text = "It seems like you didn't press the button on your bridge, try again.";
                    break;
                case "Connected":
                    TxtBoxConnectFeedBack.Text = "Bridge Connected";
                    break;
                default:
                    break;
			}
		}
	}
}
