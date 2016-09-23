﻿namespace NgimuGui.DialogsAndWindows
{
    partial class DataLoggerWindow
	{
		/// <summary>
		/// Required designer command.
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

		#region m_Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.m_StopButton = new System.Windows.Forms.Button();
            this.m_StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.m_FileNameLabel = new System.Windows.Forms.Label();
            this.m_LoggingPeriodLabel = new System.Windows.Forms.Label();
            this.m_LoggingPeriodUnits = new System.Windows.Forms.Label();
            this.m_LoggingPeriodBox = new NgimuGui.Controls.TextBoxWithHelpText();
            this.m_ClockPanel = new NgimuGui.Panels.ClockPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_SessionNameBox = new NgimuGui.Controls.TextBoxWithHelpText();
            this.pathSelector = new NgimuGui.Controls.PathSelector();
            this.SuspendLayout();
            // 
            // m_StopButton
            // 
            this.m_StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_StopButton.Location = new System.Drawing.Point(498, 186);
            this.m_StopButton.Name = "m_StopButton";
            this.m_StopButton.Size = new System.Drawing.Size(75, 23);
            this.m_StopButton.TabIndex = 5;
            this.m_StopButton.Text = "Stop";
            this.m_StopButton.UseVisualStyleBackColor = true;
            this.m_StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // m_StartButton
            // 
            this.m_StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_StartButton.Location = new System.Drawing.Point(416, 186);
            this.m_StartButton.Name = "m_StartButton";
            this.m_StartButton.Size = new System.Drawing.Size(75, 23);
            this.m_StartButton.TabIndex = 4;
            this.m_StartButton.Text = "Start";
            this.m_StartButton.UseVisualStyleBackColor = true;
            this.m_StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // m_FileNameLabel
            // 
            this.m_FileNameLabel.AutoSize = true;
            this.m_FileNameLabel.Location = new System.Drawing.Point(9, 15);
            this.m_FileNameLabel.Name = "m_FileNameLabel";
            this.m_FileNameLabel.Size = new System.Drawing.Size(52, 13);
            this.m_FileNameLabel.TabIndex = 8;
            this.m_FileNameLabel.Text = "Directory:";
            // 
            // m_LoggingPeriodLabel
            // 
            this.m_LoggingPeriodLabel.AutoSize = true;
            this.m_LoggingPeriodLabel.Location = new System.Drawing.Point(251, 41);
            this.m_LoggingPeriodLabel.Name = "m_LoggingPeriodLabel";
            this.m_LoggingPeriodLabel.Size = new System.Drawing.Size(81, 13);
            this.m_LoggingPeriodLabel.TabIndex = 9;
            this.m_LoggingPeriodLabel.Text = "Logging Period:";
            // 
            // m_LoggingPeriodUnits
            // 
            this.m_LoggingPeriodUnits.AutoSize = true;
            this.m_LoggingPeriodUnits.Location = new System.Drawing.Point(444, 41);
            this.m_LoggingPeriodUnits.Name = "m_LoggingPeriodUnits";
            this.m_LoggingPeriodUnits.Size = new System.Drawing.Size(49, 13);
            this.m_LoggingPeriodUnits.TabIndex = 10;
            this.m_LoggingPeriodUnits.Text = "Seconds";
            // 
            // m_LoggingPeriodBox
            // 
            this.m_LoggingPeriodBox.HelpText = "Unlimited";
            this.m_LoggingPeriodBox.HelpTextColor = System.Drawing.Color.Gray;
            this.m_LoggingPeriodBox.Location = new System.Drawing.Point(338, 38);
            this.m_LoggingPeriodBox.Name = "m_LoggingPeriodBox";
            this.m_LoggingPeriodBox.Size = new System.Drawing.Size(100, 20);
            this.m_LoggingPeriodBox.TabIndex = 3;
            // 
            // m_ClockPanel
            // 
            this.m_ClockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ClockPanel.BackColor = System.Drawing.Color.Black;
            this.m_ClockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_ClockPanel.CurrentTime = System.TimeSpan.Parse("00:00:00");
            this.m_ClockPanel.Location = new System.Drawing.Point(12, 76);
            this.m_ClockPanel.Margin = new System.Windows.Forms.Padding(4);
            this.m_ClockPanel.Name = "m_ClockPanel";
            this.m_ClockPanel.Size = new System.Drawing.Size(560, 97);
            this.m_ClockPanel.TabIndex = 0;
            this.m_ClockPanel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Session Name:";
            // 
            // m_SessionNameBox
            // 
            this.m_SessionNameBox.HelpText = "Enter session name";
            this.m_SessionNameBox.HelpTextColor = System.Drawing.Color.Gray;
            this.m_SessionNameBox.Location = new System.Drawing.Point(96, 38);
            this.m_SessionNameBox.Name = "m_SessionNameBox";
            this.m_SessionNameBox.Size = new System.Drawing.Size(121, 20);
            this.m_SessionNameBox.TabIndex = 2;
            this.m_SessionNameBox.TextChanged += new System.EventHandler(this.SessionNameBox_TextChanged);
            // 
            // pathSelector
            // 
            this.pathSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathSelector.DialogTitle = "Please select a directory to log to.";
            this.pathSelector.HelpText = "Select directory";
            this.pathSelector.HelpTextColor = System.Drawing.Color.Gray;
            this.pathSelector.Location = new System.Drawing.Point(96, 9);
            this.pathSelector.Margin = new System.Windows.Forms.Padding(0);
            this.pathSelector.Name = "pathSelector";
            this.pathSelector.SelectedPath = "";
            this.pathSelector.SelectorType = NgimuGui.Controls.PathSelector.PathSelectorType.SelectDirectory;
            this.pathSelector.Size = new System.Drawing.Size(476, 23);
            this.pathSelector.TabIndex = 13;
            // 
            // DataLoggerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_SessionNameBox);
            this.Controls.Add(this.m_LoggingPeriodUnits);
            this.Controls.Add(this.m_LoggingPeriodLabel);
            this.Controls.Add(this.m_FileNameLabel);
            this.Controls.Add(this.m_LoggingPeriodBox);
            this.Controls.Add(this.m_ClockPanel);
            this.Controls.Add(this.m_StartButton);
            this.Controls.Add(this.m_StopButton);
            this.Controls.Add(this.pathSelector);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(290, 179);
            this.Name = "DataLoggerWindow";
            this.Text = "Data Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CsvLoggerWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CsvLoggerWindow_FormClosed);
            this.Load += new System.EventHandler(this.DataLoggerWindow_Load);
            this.ResizeBegin += new System.EventHandler(this.Form_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_StopButton;
		private System.Windows.Forms.Button m_StartButton;
		private NgimuGui.Panels.ClockPanel m_ClockPanel;
        private NgimuGui.Controls.TextBoxWithHelpText m_LoggingPeriodBox;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label m_FileNameLabel;
		private System.Windows.Forms.Label m_LoggingPeriodLabel;
        private System.Windows.Forms.Label m_LoggingPeriodUnits;
        private System.Windows.Forms.Label label1;
        private Controls.TextBoxWithHelpText m_SessionNameBox;
        private Controls.PathSelector pathSelector;
    }
}