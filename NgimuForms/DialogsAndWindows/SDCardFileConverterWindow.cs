﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using NgimuApi;
using NgimuApi.Logging;
using NgimuForms.Controls;
using NgimuForms.DialogsAndWindows;
using Rug.Osc;

namespace NgimuGui.DialogsAndWindows
{
    public partial class SDCardFileConverterWindow : BaseForm
    {
        public static string ID = "ConvertSDCardFileDialog";

        private ProgressDialog m_Progress = new ProgressDialog();

        private Connection m_Connection;
        private SessionLogger m_Logger;

        private Thread m_Thread;

        private long m_TotalMaximumBytes = 0;
        private long m_TotalProgressBytes = 0;

        private long m_MaximumBytes = 0;
        private long m_ProgressBytes = 0;

        //private string m_LastMessage = String.Empty; 
        private string m_CurrentFile = String.Empty;

        private bool convertAndCloseAutomatically;

        public string DestinationFolder { get; set; }

        public string[] SDCardFilePaths { get; set; } = new string[0];

        public SDCardFileConverterWindow() : base(ID)
        {
            InitializeComponent();

            AssemblyName name = Assembly.GetEntryAssembly().GetName();

            this.Text = name.Name + " v" + name.Version.Major + "." + name.Version.Minor;
        }

        private void SDCardReaderDialog_Load(object sender, EventArgs e)
        {
            m_CurrentFile = String.Empty;
            directorySelector.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            m_Progress.Style = ProgressBarStyle.Continuous;
            m_Progress.Text = "Converting SD Card File";
            m_Progress.CancelButtonEnabled = true;
            m_Progress.OnCancel += new FormClosingEventHandler(Progress_OnCancel);

            convertAndCloseAutomatically = false;

            if (string.IsNullOrEmpty(DestinationFolder) == false)
            {
                directorySelector.SelectedPath = DestinationFolder;
                convertAndCloseAutomatically = true;
            }

            if (SDCardFilePaths.Length > 0)
            {
                sdCardFilePathSelector.SelectedPath = string.Join(";", SDCardFilePaths);
                convertAndCloseAutomatically = true;
            }

            if (convertAndCloseAutomatically == true)
            {
                m_StartButton.PerformClick();
            }
        }

        private string[] GetPaths()
        {
            string[] paths = sdCardFilePathSelector.SelectedPath.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> resolvedPaths = new List<string>();

            foreach (string path in paths)
            {
                resolvedPaths.Add(path.TrimEnd(new char[] { ';', ' ' }));
            }

            return resolvedPaths.ToArray();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            m_Progress.ProgressMessage = String.Empty;

            timer1.Enabled = true;

            string[] paths = GetPaths();

            m_CurrentFile = String.Empty;

            m_TotalMaximumBytes = 0;
            m_TotalProgressBytes = 0;

            m_MaximumBytes = 0;
            m_ProgressBytes = 0;

            foreach (string path in paths)
            {
                if (File.Exists(path) == true)
                {
                    continue;
                }

                this.ShowError("The source file does not exist." + Environment.NewLine + path);

                return;
            }

            m_Thread = new Thread(ReadThread) { Name = "SD Card Converter" };
            m_Thread.Start();

            m_Progress.ShowDialog(this);
        }

        private void Progress_OnCancel(object sender, FormClosingEventArgs e)
        {
            if (m_Thread != null && m_Thread.IsAlive == true)
            {
                m_Thread.Join();
            }
        }

        private void ReadThread()
        {
            try
            {
                string[] paths = GetPaths();

                m_TotalMaximumBytes = 0;
                m_TotalProgressBytes = 0;

                m_MaximumBytes = 0;
                m_ProgressBytes = 0;

                foreach (string path in paths)
                {
                    m_TotalMaximumBytes += new FileInfo(path).Length;
                }

                foreach (string path in paths)
                {
                    try
                    {
                        FileInfo info = new FileInfo(path);

                        m_TotalProgressBytes += m_ProgressBytes;

                        m_CurrentFile = info.Name;

                        m_MaximumBytes = info.Length;
                        m_ProgressBytes = 0;

                        string directory = directorySelector.SelectedPath;

                        using (m_Connection = new Connection(new SDCardFileConnectionInfo() { FilePath = path }))
                        using (m_Logger = new SessionLogger(SessionSettings.CreateForFileAndPath(directory, info), m_Connection))
                        {
                            m_Logger.Start();

                            m_Connection.Message += new MessageEvent(m_Connection_Message);
                            m_Connection.Connect();

                            m_Logger.Stop();
                        }
                    }
                    catch (Exception ex)
                    {
                        this.InvokeShowError(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                this.InvokeShowError(ex.Message);
            }
            finally
            {
                //IsRunning = false;
                this.Invoke(new Action(Done));
            }
        }

        private void OnInfo(string message)
        {
            m_Progress.ProgressMessage = message;
        }

        private void Done()
        {
            // we have to hide the dialog first otherwise it will stick around until the auto connect has completed
            m_Progress.Hide();
            m_Progress.Close();

            if (convertAndCloseAutomatically == true)
            {
                Close();
            }
        }

        void m_Connection_Message(Connection source, MessageDirection direction, OscMessage message)
        {
            m_ProgressBytes = source.CommunicationStatistics.BytesReceived.Total;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                int kbTotal = (int)(m_TotalMaximumBytes >> 10);
                int kbDone = (int)((m_TotalProgressBytes + m_ProgressBytes) >> 10);

                m_Progress.ProgressMaximum = kbTotal;
                m_Progress.Progress = kbDone;
            }

            {
                int kbTotal = (int)(m_MaximumBytes >> 10);
                int kbDone = (int)((m_ProgressBytes) >> 10);

                m_Progress.ProgressMessage = "Converting " + m_CurrentFile + " " + kbDone.ToString() + " KB of " + kbTotal.ToString() + " KB";
            }
        }
    }
}
