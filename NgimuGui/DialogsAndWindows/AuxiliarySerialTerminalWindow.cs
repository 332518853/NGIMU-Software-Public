﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Rug.Osc;

namespace NgimuGui.DialogsAndWindows
{
    public partial class AuxiliarySerialTerminalWindow : BaseForm
    {
        private bool m_CtsValue;
        private OscCommunicationStatistics CommunicationStatistics = new OscCommunicationStatistics();

        public static readonly string ID = "AuxiliarySerialTerminal";

        public event OscPacketEvent PacketRecived;

        [Browsable(false)]
        public bool CtsValue
        {
            get
            {
                return m_CtsValue;
            }
            set
            {
                m_CtsValue = value;

                if (InvokeRequired == true)
                {
                    Invoke(new Action(CheckCtsState));
                }
                else
                {
                    CheckCtsState();
                }

            }
        }

        public AuxiliarySerialTerminalWindow()
        {
            InitializeComponent();

            this.Disposed += AuxiliarySerialTerminal_Disposed;

            CommunicationStatistics.Start();
        }

        void AuxiliarySerialTerminal_Disposed(object sender, EventArgs e)
        {
            CommunicationStatistics.Stop();
        }

        private void AuxiliarySerialTerminal_Load(object sender, EventArgs e)
        {
            if (Options.Windows[ID].Bounds != Rectangle.Empty)
            {
                this.DesktopBounds = Options.Windows[ID].Bounds;
            }

            WindowState = Options.Windows[ID].WindowState;

            Options.Windows[ID].IsOpen = true;

            serialTerminal1.PacketRecived += new OscPacketEvent(serialTerminal1_PacketRecived);
        }

        void serialTerminal1_PacketRecived(OscPacket packet)
        {
            if (PacketRecived != null)
            {
                if ((packet as OscMessage).Address == "/auxserial")
                {
                    CommunicationStatistics.BytesSent.Increment(((packet as OscMessage)[0] as byte[]).Length);
                }

                PacketRecived(packet);
            }
        }

        public void OnMessage(OscMessage message)
        {
            serialTerminal1.OnMessage(message);
        }

        public void OnData(byte[] data)
        {
            CommunicationStatistics.BytesReceived.Increment(data.Length);

            serialTerminal1.OnData(data);
        }

        public void OnData(string data)
        {
            CommunicationStatistics.BytesReceived.Increment(data.Length);

            serialTerminal1.OnData(data);
        }

        private void CheckCtsState()
        {
            CtsHigh.Checked = m_CtsValue;
            CtsLow.Checked = !m_CtsValue;
        }

        #region Window Resize / Move Events

        private void Form_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void Form_ResizeEnd(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Options.Windows[ID].Bounds = this.DesktopBounds;
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                Options.Windows[ID].WindowState = WindowState;
            }
        }

        #endregion

        private void AuxiliarySerialTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.None)
            {
                Options.Windows[ID].IsOpen = false;
            }
        }

        private void RtsHigh_Click(object sender, EventArgs e)
        {
            serialTerminal1_PacketRecived(new OscMessage("/auxserial/rts", true));
        }

        private void RtsLow_Click(object sender, EventArgs e)
        {
            serialTerminal1_PacketRecived(new OscMessage("/auxserial/rts", false));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            long totalReceived = 0;
            float receiveRate = 0;

            long totalSent = 0;
            float sendRate = 0;

            {
                totalReceived = CommunicationStatistics.BytesReceived.Total;
                receiveRate = CommunicationStatistics.BytesReceived.Rate;

                totalSent = CommunicationStatistics.BytesSent.Total;
                sendRate = CommunicationStatistics.BytesSent.Rate;
            }

            m_TotalReceived.Text = String.Format((string)m_TotalReceived.Tag, totalReceived.ToString(CultureInfo.InvariantCulture));
            m_ReceiveRate.Text = String.Format((string)m_ReceiveRate.Tag, receiveRate.ToString("F0", CultureInfo.InvariantCulture));

            m_TotalSent.Text = String.Format((string)m_TotalSent.Tag, totalSent.ToString(CultureInfo.InvariantCulture));
            m_SendRate.Text = String.Format((string)m_SendRate.Tag, sendRate.ToString("F0", CultureInfo.InvariantCulture));
        }
    }
}
