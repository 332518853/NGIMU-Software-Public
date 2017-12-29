﻿using NgimuApi;
using NgimuForms.DialogsAndWindows;
using Rug.Osc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace NgimuSynchronisedNetworkManager.DialogsAndWindows
{
    public partial class DataForwardingDialog : BaseForm
    {
        private readonly Dictionary<string, string> namesLookup = new Dictionary<string, string>();
        private readonly object namesLock = new object();

        private bool prefixOscWithName;
        private OscSender sender;

        public IPAddress AdapterIPAddress { get; set; }
        public string AdapterName { get; set; }
        public NetworkInterface NetworkAdapter { get; set; }
        public bool OnlyIpV4 { get; set; }

        public IPAddress SendIPAddress { get; set; }

        public int SendPort { get; set; }

        public DataForwardingDialog()
        {
            OnlyIpV4 = true;

            InitializeComponent();
        }

        public void Connect()
        {
            Disconnect();

            sender = new OscSender(AdapterIPAddress, 0, SendIPAddress, SendPort);

            sender.Connect();

            DisableAllControls();
        }

        public void Disconnect()
        {   
            EnableAllControls();

            lock (namesLock)
            {
                namesLookup.Clear();
            }
            
            sender?.Dispose();

            sender = null;
        }

        public void OnMessage(Connection connection, OscMessage message)
        {
            string address;

            if (prefixOscWithName == true)
            {
                string unsanitizedName = connection.Settings.DeviceName.Value;

                if (namesLookup.TryGetValue(unsanitizedName, out string sainName) == false)
                {
                    sainName = SanitizeName(unsanitizedName);

                    lock (namesLock)
                    {
                        namesLookup[unsanitizedName] = sainName;
                    }
                }

                address = "/" + sainName + message.Address;
            }
            else
            {
                address = "/" + connection.Settings.SerialNumber.Value + message.Address;
            }

            sender?.Send(new OscMessage(address, message.ToArray()));
        }

        private void AdapterIPAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdapterIPAddress = null;
            NetworkAdapter = null;

            IntefaceInfo info = (IntefaceInfo)m_AdapterIPAddress.SelectedItem;

            AdapterIPAddress = info.IpAddress;
            AdapterName = info.InterfaceName;
            NetworkAdapter = info.NetworkInterface;
        }
        
        private void LocalHost_CheckedChanged(object sender, EventArgs e)
        {
            if (localHost.Checked == true)
            {
                m_SendIPAddress.Text = IPAddress.Loopback.ToString();
                m_SendIPAddress.Enabled = false;
            }
            else
            {
                m_SendIPAddress.Text = "";
                m_SendIPAddress.Enabled = true;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (ValidateValues() == false)
            {
                System.Media.SystemSounds.Exclamation.Play();

                FlashingDialogHelper.FlashWindowEx(this);

                return;
            }

            Connect();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void prefixName_CheckedChanged(object sender, EventArgs e)
        {
            prefixOscWithName = prefixName.Checked;
        }

        private string SanitizeName(string unsanitizedName)
        {
            return unsanitizedName
                .Replace('*', '_')
                .Replace('#', '_')
                .Replace(',', '_')
                .Replace('?', '_')
                .Replace('/', '_')
                .Replace('[', '_')
                .Replace(']', '_')
                .Replace('{', '_')
                .Replace('}', '_')
                .Replace(' ', '_')
                .Replace('\n', '_')
                .Replace('\r', '_')
                .Replace('\0', '_');
        }

        private void SendIPAddress_TextChanged(object sender, EventArgs e)
        {
            SendIPAddress = null;

            if (Helper.IsNullOrEmpty(m_SendIPAddress.Text) == true)
            {
                return;
            }

            if (IPAddress.TryParse(m_SendIPAddress.Text, out IPAddress address) == false ||
                address.AddressFamily == AddressFamily.InterNetworkV6)
            {
                m_SendIPAddress.HasError = true;
            }
            else
            {
                m_SendIPAddress.HasError = false;
                SendIPAddress = address;
            }
        }

        private void SendPort_TextChanged(object sender, EventArgs e)
        {
            SendPort = -1;
            
            if (Helper.IsNullOrEmpty(m_SendPort.Text) == true)
            {
                return;
            }

            if (ushort.TryParse(m_SendPort.Text, out ushort port) == false ||
                port == 0)
            {
                m_SendPort.HasError = true;
            }
            else
            {
                m_SendPort.HasError = false;
                SendPort = (int)port;
            }
        }

        private void UdpConnectionDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void EnableAllControls()
        {
            m_SendIPAddress.Enabled = localHost.Checked == false;
            m_SendPort.Enabled = true;
            m_AdapterIPAddress.Enabled = true;
            connectButton.Enabled = true;
            disconnectButton.Enabled = false;
            prefixName.Enabled = true;
            prefixSerialNumber.Enabled = true;

            prefixName.AutoCheck = true;
            prefixSerialNumber.AutoCheck = true; 

            localHost.Enabled = true; 
        }

        private void DisableAllControls()
        {
            m_SendIPAddress.Enabled = false;
            m_SendPort.Enabled = false;
            m_AdapterIPAddress.Enabled = false;
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;

            prefixName.AutoCheck = false;
            prefixSerialNumber.AutoCheck = false;

            prefixName.Enabled = false;
            prefixSerialNumber.Enabled = false;
            localHost.Enabled = false;
        }

        private void UdpConnectionDialog_Load(object sender, EventArgs e)
        {
            UdpConnectionInfo defaults = new UdpConnectionInfo();

            m_AdapterIPAddress.Items.Add(new IntefaceInfo() { NetworkInterface = defaults.NetworkAdapter, String = defaults.AdapterName, InterfaceName = defaults.AdapterName, IpAddress = defaults.AdapterIPAddress });

            if (OnlyIpV4 == false)
            {
                UdpConnectionInfo defaultsIPv6 = UdpConnectionInfo.DefaultIPv6;

                m_AdapterIPAddress.Items.Add(new IntefaceInfo() { NetworkInterface = defaultsIPv6.NetworkAdapter, String = defaultsIPv6.AdapterName, InterfaceName = defaultsIPv6.AdapterName, IpAddress = defaultsIPv6.AdapterIPAddress });
            }

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in interfaces)
            {
                var ipProps = adapter.GetIPProperties();

                foreach (var ip in ipProps.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == AddressFamily.InterNetwork ||
                        OnlyIpV4 == false && ip.Address.AddressFamily == AddressFamily.InterNetworkV6)
                    {
                        m_AdapterIPAddress.Items.Add(new IntefaceInfo() { NetworkInterface = adapter, String = adapter.Description + " (" + ip.Address + ")", InterfaceName = adapter.Description, IpAddress = ip.Address });
                    }
                }
            }

            m_AdapterIPAddress.SelectedIndex = 0;

            NetworkAdapter = null;

            prefixOscWithName = prefixName.Checked;

            LocalHost_CheckedChanged(this, EventArgs.Empty);
            SendIPAddress_TextChanged(this, EventArgs.Empty);
            SendPort_TextChanged(this, EventArgs.Empty);
        }

        private bool ValidateValues()
        {
            if (m_SendIPAddress.HasError == true ||
                m_SendPort.HasError == true)
            {
                return false;
            }

            if (SendIPAddress == null ||
                SendPort == -1)
            {
                return false;
            }

            return true;
        }

        private struct IntefaceInfo
        {
            public string InterfaceName;
            public IPAddress IpAddress;
            public NetworkInterface NetworkInterface;
            public string String;

            public override string ToString()
            {
                return String;
            }
        }
    }
}