
namespace HalloweenLightsWFA
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.BtnStartAll = new System.Windows.Forms.Button();
			this.BtnStartLights = new System.Windows.Forms.Button();
			this.BtnStartCasting = new System.Windows.Forms.Button();
			this.BtnConnectToBridge = new System.Windows.Forms.Button();
			this.TxtBridgeIP = new System.Windows.Forms.TextBox();
			this.GroupConnect = new System.Windows.Forms.GroupBox();
			this.TxtBoxConnectFeedBack = new System.Windows.Forms.RichTextBox();
			this.LblBridgeConnectFeedBack = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnFinishConnecting = new System.Windows.Forms.Button();
			this.LblPressToConnect = new System.Windows.Forms.Label();
			this.LblBridgeIP = new System.Windows.Forms.Label();
			this.GroupConnect.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnStartAll
			// 
			this.BtnStartAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnStartAll.Location = new System.Drawing.Point(404, 709);
			this.BtnStartAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnStartAll.Name = "BtnStartAll";
			this.BtnStartAll.Size = new System.Drawing.Size(529, 99);
			this.BtnStartAll.TabIndex = 0;
			this.BtnStartAll.Text = "Start everything!";
			this.BtnStartAll.UseVisualStyleBackColor = true;
			// 
			// BtnStartLights
			// 
			this.BtnStartLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnStartLights.Location = new System.Drawing.Point(404, 614);
			this.BtnStartLights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnStartLights.Name = "BtnStartLights";
			this.BtnStartLights.Size = new System.Drawing.Size(256, 74);
			this.BtnStartLights.TabIndex = 1;
			this.BtnStartLights.Text = "Start light animations";
			this.BtnStartLights.UseVisualStyleBackColor = true;
			this.BtnStartLights.Click += new System.EventHandler(this.BtnStartLights_Click);
			// 
			// BtnStartCasting
			// 
			this.BtnStartCasting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnStartCasting.Location = new System.Drawing.Point(682, 614);
			this.BtnStartCasting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnStartCasting.Name = "BtnStartCasting";
			this.BtnStartCasting.Size = new System.Drawing.Size(251, 74);
			this.BtnStartCasting.TabIndex = 2;
			this.BtnStartCasting.Text = "Start Casting";
			this.BtnStartCasting.UseVisualStyleBackColor = true;
			this.BtnStartCasting.Click += new System.EventHandler(this.BtnStartCasting_Click);
			// 
			// BtnConnectToBridge
			// 
			this.BtnConnectToBridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnConnectToBridge.Location = new System.Drawing.Point(197, 88);
			this.BtnConnectToBridge.Name = "BtnConnectToBridge";
			this.BtnConnectToBridge.Size = new System.Drawing.Size(207, 60);
			this.BtnConnectToBridge.TabIndex = 3;
			this.BtnConnectToBridge.Text = "Start Connecting";
			this.BtnConnectToBridge.UseVisualStyleBackColor = true;
			this.BtnConnectToBridge.Click += new System.EventHandler(this.BtnConnectToBridge_Click);
			// 
			// TxtBridgeIP
			// 
			this.TxtBridgeIP.Location = new System.Drawing.Point(197, 46);
			this.TxtBridgeIP.Name = "TxtBridgeIP";
			this.TxtBridgeIP.Size = new System.Drawing.Size(207, 30);
			this.TxtBridgeIP.TabIndex = 4;
			this.TxtBridgeIP.Text = "192.168.X.X";
			// 
			// GroupConnect
			// 
			this.GroupConnect.Controls.Add(this.TxtBoxConnectFeedBack);
			this.GroupConnect.Controls.Add(this.LblBridgeConnectFeedBack);
			this.GroupConnect.Controls.Add(this.label1);
			this.GroupConnect.Controls.Add(this.BtnFinishConnecting);
			this.GroupConnect.Controls.Add(this.LblPressToConnect);
			this.GroupConnect.Controls.Add(this.LblBridgeIP);
			this.GroupConnect.Controls.Add(this.TxtBridgeIP);
			this.GroupConnect.Controls.Add(this.BtnConnectToBridge);
			this.GroupConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupConnect.Location = new System.Drawing.Point(885, 12);
			this.GroupConnect.Name = "GroupConnect";
			this.GroupConnect.Size = new System.Drawing.Size(423, 338);
			this.GroupConnect.TabIndex = 5;
			this.GroupConnect.TabStop = false;
			this.GroupConnect.Text = "Connect To Bridge";
			// 
			// TxtBoxConnectFeedBack
			// 
			this.TxtBoxConnectFeedBack.Enabled = false;
			this.TxtBoxConnectFeedBack.Location = new System.Drawing.Point(12, 226);
			this.TxtBoxConnectFeedBack.Name = "TxtBoxConnectFeedBack";
			this.TxtBoxConnectFeedBack.Size = new System.Drawing.Size(393, 94);
			this.TxtBoxConnectFeedBack.TabIndex = 9;
			this.TxtBoxConnectFeedBack.Text = "";
			// 
			// LblBridgeConnectFeedBack
			// 
			this.LblBridgeConnectFeedBack.AutoSize = true;
			this.LblBridgeConnectFeedBack.Location = new System.Drawing.Point(6, 217);
			this.LblBridgeConnectFeedBack.Name = "LblBridgeConnectFeedBack";
			this.LblBridgeConnectFeedBack.Size = new System.Drawing.Size(0, 25);
			this.LblBridgeConnectFeedBack.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 50);
			this.label1.TabIndex = 8;
			this.label1.Text = "Pressed button \r\non bridge:\r\n";
			// 
			// BtnFinishConnecting
			// 
			this.BtnFinishConnecting.Location = new System.Drawing.Point(197, 154);
			this.BtnFinishConnecting.Name = "BtnFinishConnecting";
			this.BtnFinishConnecting.Size = new System.Drawing.Size(207, 60);
			this.BtnFinishConnecting.TabIndex = 7;
			this.BtnFinishConnecting.Text = "Finish Connecting";
			this.BtnFinishConnecting.UseVisualStyleBackColor = true;
			this.BtnFinishConnecting.Click += new System.EventHandler(this.BtnFinishConnecting_Click);
			// 
			// LblPressToConnect
			// 
			this.LblPressToConnect.AutoSize = true;
			this.LblPressToConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPressToConnect.Location = new System.Drawing.Point(6, 106);
			this.LblPressToConnect.Name = "LblPressToConnect";
			this.LblPressToConnect.Size = new System.Drawing.Size(168, 25);
			this.LblPressToConnect.TabIndex = 6;
			this.LblPressToConnect.Text = "Press to Connect:";
			// 
			// LblBridgeIP
			// 
			this.LblBridgeIP.AutoSize = true;
			this.LblBridgeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblBridgeIP.Location = new System.Drawing.Point(6, 49);
			this.LblBridgeIP.Name = "LblBridgeIP";
			this.LblBridgeIP.Size = new System.Drawing.Size(144, 25);
			this.LblBridgeIP.TabIndex = 5;
			this.LblBridgeIP.Text = "Fill in bridge IP:";
			// 
			// frmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(1320, 1005);
			this.Controls.Add(this.GroupConnect);
			this.Controls.Add(this.BtnStartCasting);
			this.Controls.Add(this.BtnStartLights);
			this.Controls.Add(this.BtnStartAll);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmHome";
			this.Text = "frmHome";
			this.GroupConnect.ResumeLayout(false);
			this.GroupConnect.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button BtnStartAll;
		private System.Windows.Forms.Button BtnStartLights;
		private System.Windows.Forms.Button BtnStartCasting;
		private System.Windows.Forms.Button BtnConnectToBridge;
		private System.Windows.Forms.TextBox TxtBridgeIP;
		private System.Windows.Forms.GroupBox GroupConnect;
		private System.Windows.Forms.Label LblPressToConnect;
		private System.Windows.Forms.Label LblBridgeIP;
		private System.Windows.Forms.Label LblBridgeConnectFeedBack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnFinishConnecting;
		private System.Windows.Forms.RichTextBox TxtBoxConnectFeedBack;
	}
}