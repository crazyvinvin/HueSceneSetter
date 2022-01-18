
namespace HalloweenLightsWFA
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnExtraInfo = new System.Windows.Forms.Button();
            this.SelectionPanel = new System.Windows.Forms.Panel();
            this.btnCasting = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PanelLeftTop = new System.Windows.Forms.Panel();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MenuPanel.Controls.Add(this.btnExtraInfo);
            this.MenuPanel.Controls.Add(this.SelectionPanel);
            this.MenuPanel.Controls.Add(this.btnCasting);
            this.MenuPanel.Controls.Add(this.btnRooms);
            this.MenuPanel.Controls.Add(this.btnLights);
            this.MenuPanel.Controls.Add(this.btnHome);
            this.MenuPanel.Controls.Add(this.PanelLeftTop);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(313, 807);
            this.MenuPanel.TabIndex = 0;
            // 
            // btnExtraInfo
            // 
            this.btnExtraInfo.FlatAppearance.BorderSize = 0;
            this.btnExtraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraInfo.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExtraInfo.Location = new System.Drawing.Point(-3, 742);
            this.btnExtraInfo.Name = "btnExtraInfo";
            this.btnExtraInfo.Size = new System.Drawing.Size(313, 59);
            this.btnExtraInfo.TabIndex = 5;
            this.btnExtraInfo.Text = "About Me";
            this.btnExtraInfo.UseVisualStyleBackColor = true;
            this.btnExtraInfo.Click += new System.EventHandler(this.btnExtraInfo_Click);
            // 
            // SelectionPanel
            // 
            this.SelectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SelectionPanel.Location = new System.Drawing.Point(0, 189);
            this.SelectionPanel.Name = "SelectionPanel";
            this.SelectionPanel.Size = new System.Drawing.Size(5, 0);
            this.SelectionPanel.TabIndex = 4;
            // 
            // btnCasting
            // 
            this.btnCasting.FlatAppearance.BorderSize = 0;
            this.btnCasting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasting.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCasting.Location = new System.Drawing.Point(0, 319);
            this.btnCasting.Name = "btnCasting";
            this.btnCasting.Size = new System.Drawing.Size(313, 59);
            this.btnCasting.TabIndex = 3;
            this.btnCasting.Text = "Casting";
            this.btnCasting.UseVisualStyleBackColor = true;
            this.btnCasting.Click += new System.EventHandler(this.btnCasting_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnRooms.Location = new System.Drawing.Point(0, 384);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(313, 59);
            this.btnRooms.TabIndex = 2;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.UseVisualStyleBackColor = true;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // btnLights
            // 
            this.btnLights.FlatAppearance.BorderSize = 0;
            this.btnLights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLights.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLights.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLights.Location = new System.Drawing.Point(0, 254);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(313, 59);
            this.btnLights.TabIndex = 1;
            this.btnLights.Text = "Lights";
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Location = new System.Drawing.Point(0, 189);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(313, 59);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelLeftTop
            // 
            this.PanelLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.PanelLeftTop.Name = "PanelLeftTop";
            this.PanelLeftTop.Size = new System.Drawing.Size(313, 183);
            this.PanelLeftTop.TabIndex = 0;
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Location = new System.Drawing.Point(313, 2);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(1173, 804);
            this.pnlFormLoader.TabIndex = 1;
            // 
            // CrazySceneBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1487, 807);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrazySceneBuilder";
            this.Text = "CrazySceneBuilder";
            this.Load += new System.EventHandler(this.CrazySceneBuilder_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnCasting;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PanelLeftTop;
        private System.Windows.Forms.Panel SelectionPanel;
        private System.Windows.Forms.Button btnExtraInfo;
        private System.Windows.Forms.Panel pnlFormLoader;
    }
}

