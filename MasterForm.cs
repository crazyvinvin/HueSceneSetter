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
    public partial class MasterForm : Form
    {
        public static frmHome HomeForm { get; set; }
        public static frmLights LightsForm { get; set; }
        public MasterForm()
        {
            InitializeComponent();
        }

        private void CrazySceneBuilder_Load(object sender, EventArgs e)
        {
            HomeForm = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };

            LightsForm = new frmLights()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectionPanel.Height = btnHome.Height;
            SelectionPanel.Location = btnHome.Location;
            pnlFormLoader.Controls.Clear();
            pnlFormLoader.Controls.Add(HomeForm);
            HomeForm.MasterForm = this;
            HomeForm.Show();
        }

        private void btnLights_Click(object sender, EventArgs e)
        {
            SelectionPanel.Height = btnLights.Height;
            SelectionPanel.Location = btnLights.Location;
            pnlFormLoader.Controls.Clear();
            pnlFormLoader.Controls.Add(LightsForm);
            LightsForm.MasterForm = this;
            LightsForm.Show();
        }

        private void btnCasting_Click(object sender, EventArgs e)
        {
            SelectionPanel.Height = btnLights.Height;
            SelectionPanel.Location = btnCasting.Location;
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            SelectionPanel.Height = btnRooms.Height;
            SelectionPanel.Location = btnRooms.Location;
        }

        private void btnExtraInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/vincent-vermeire-127ab0205/");
        }
    }
}
