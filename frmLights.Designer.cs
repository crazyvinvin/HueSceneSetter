
namespace HalloweenLightsWFA
{
    partial class frmLights
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
			this.txtLightName = new System.Windows.Forms.TextBox();
			this.RValue = new System.Windows.Forms.TextBox();
			this.txtRepeat = new System.Windows.Forms.TextBox();
			this.txtTransitionTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddAnimation = new System.Windows.Forms.Button();
			this.AnimationTable = new System.Windows.Forms.DataGridView();
			this.LightNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RGBColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RepeatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransitionTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GValue = new System.Windows.Forms.TextBox();
			this.BValue = new System.Windows.Forms.TextBox();
			this.ListBoxLights = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.AnimationTable)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLightName
			// 
			this.txtLightName.Location = new System.Drawing.Point(153, 70);
			this.txtLightName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLightName.Name = "txtLightName";
			this.txtLightName.Size = new System.Drawing.Size(358, 26);
			this.txtLightName.TabIndex = 0;
			// 
			// RValue
			// 
			this.RValue.Location = new System.Drawing.Point(153, 111);
			this.RValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.RValue.Name = "RValue";
			this.RValue.Size = new System.Drawing.Size(64, 26);
			this.RValue.TabIndex = 1;
			this.RValue.Text = "255";
			// 
			// txtRepeat
			// 
			this.txtRepeat.Location = new System.Drawing.Point(153, 154);
			this.txtRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRepeat.Name = "txtRepeat";
			this.txtRepeat.Size = new System.Drawing.Size(205, 26);
			this.txtRepeat.TabIndex = 2;
			this.txtRepeat.Text = "50";
			// 
			// txtTransitionTime
			// 
			this.txtTransitionTime.Location = new System.Drawing.Point(153, 196);
			this.txtTransitionTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTransitionTime.Name = "txtTransitionTime";
			this.txtTransitionTime.Size = new System.Drawing.Size(205, 26);
			this.txtTransitionTime.TabIndex = 3;
			this.txtTransitionTime.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Light Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(93, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "RGB";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(75, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Repeat";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "TransitionTime";
			// 
			// btnAddAnimation
			// 
			this.btnAddAnimation.Location = new System.Drawing.Point(153, 252);
			this.btnAddAnimation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddAnimation.Name = "btnAddAnimation";
			this.btnAddAnimation.Size = new System.Drawing.Size(201, 51);
			this.btnAddAnimation.TabIndex = 8;
			this.btnAddAnimation.Text = "Add Animation";
			this.btnAddAnimation.UseVisualStyleBackColor = true;
			this.btnAddAnimation.Click += new System.EventHandler(this.btnAddAnimation_Click);
			// 
			// AnimationTable
			// 
			this.AnimationTable.AllowDrop = true;
			this.AnimationTable.AllowUserToAddRows = false;
			this.AnimationTable.AllowUserToDeleteRows = false;
			this.AnimationTable.AllowUserToOrderColumns = true;
			this.AnimationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AnimationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LightNameColumn,
            this.RGBColumn,
            this.RepeatColumn,
            this.TransitionTimeColumn});
			this.AnimationTable.Location = new System.Drawing.Point(547, 70);
			this.AnimationTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AnimationTable.Name = "AnimationTable";
			this.AnimationTable.ReadOnly = true;
			this.AnimationTable.RowHeadersWidth = 51;
			this.AnimationTable.RowTemplate.Height = 24;
			this.AnimationTable.Size = new System.Drawing.Size(719, 547);
			this.AnimationTable.TabIndex = 14;
			// 
			// LightNameColumn
			// 
			this.LightNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.LightNameColumn.HeaderText = "LightName";
			this.LightNameColumn.MinimumWidth = 6;
			this.LightNameColumn.Name = "LightNameColumn";
			this.LightNameColumn.ReadOnly = true;
			this.LightNameColumn.Width = 122;
			// 
			// RGBColumn
			// 
			this.RGBColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RGBColumn.HeaderText = "RGB";
			this.RGBColumn.MinimumWidth = 6;
			this.RGBColumn.Name = "RGBColumn";
			this.RGBColumn.ReadOnly = true;
			this.RGBColumn.Width = 81;
			// 
			// RepeatColumn
			// 
			this.RepeatColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.RepeatColumn.HeaderText = "Repeat";
			this.RepeatColumn.MinimumWidth = 6;
			this.RepeatColumn.Name = "RepeatColumn";
			this.RepeatColumn.ReadOnly = true;
			this.RepeatColumn.Width = 98;
			// 
			// TransitionTimeColumn
			// 
			this.TransitionTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TransitionTimeColumn.HeaderText = "T.Time";
			this.TransitionTimeColumn.MinimumWidth = 6;
			this.TransitionTimeColumn.Name = "TransitionTimeColumn";
			this.TransitionTimeColumn.ReadOnly = true;
			this.TransitionTimeColumn.Width = 92;
			// 
			// GValue
			// 
			this.GValue.Location = new System.Drawing.Point(224, 110);
			this.GValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GValue.Name = "GValue";
			this.GValue.Size = new System.Drawing.Size(64, 26);
			this.GValue.TabIndex = 15;
			this.GValue.Text = "255";
			// 
			// BValue
			// 
			this.BValue.Location = new System.Drawing.Point(295, 110);
			this.BValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BValue.Name = "BValue";
			this.BValue.Size = new System.Drawing.Size(64, 26);
			this.BValue.TabIndex = 16;
			this.BValue.Text = "255";
			// 
			// ListBoxLights
			// 
			this.ListBoxLights.FormattingEnabled = true;
			this.ListBoxLights.ItemHeight = 20;
			this.ListBoxLights.Location = new System.Drawing.Point(547, 648);
			this.ListBoxLights.Name = "ListBoxLights";
			this.ListBoxLights.Size = new System.Drawing.Size(719, 324);
			this.ListBoxLights.TabIndex = 17;
			// 
			// frmLights
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateGray;
			this.ClientSize = new System.Drawing.Size(1320, 1005);
			this.Controls.Add(this.ListBoxLights);
			this.Controls.Add(this.BValue);
			this.Controls.Add(this.GValue);
			this.Controls.Add(this.AnimationTable);
			this.Controls.Add(this.btnAddAnimation);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTransitionTime);
			this.Controls.Add(this.txtRepeat);
			this.Controls.Add(this.RValue);
			this.Controls.Add(this.txtLightName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmLights";
			this.Text = "frmLights";
			this.Load += new System.EventHandler(this.frmLights_Load);
			((System.ComponentModel.ISupportInitialize)(this.AnimationTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox txtLightName;
		private System.Windows.Forms.TextBox RValue;
		private System.Windows.Forms.TextBox txtRepeat;
		private System.Windows.Forms.TextBox txtTransitionTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddAnimation;
        private System.Windows.Forms.DataGridView AnimationTable;
        private System.Windows.Forms.TextBox GValue;
        private System.Windows.Forms.TextBox BValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn LightNameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RGBColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn RepeatColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransitionTimeColumn;
		private System.Windows.Forms.ListBox ListBoxLights;
	}
}