﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NgimuApi {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NgimuApi.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retry limit reached..
        /// </summary>
        internal static string AsyncProcess_RetryLimitReached {
            get {
                return ResourceManager.GetString("AsyncProcess_RetryLimitReached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for available serial ports..
        /// </summary>
        internal static string AutoConnect_CheckingSerial {
            get {
                return ResourceManager.GetString("AutoConnect_CheckingSerial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for available serial ports and network adapters..
        /// </summary>
        internal static string AutoConnect_CheckingSerialAndUdp {
            get {
                return ResourceManager.GetString("AutoConnect_CheckingSerialAndUdp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for available network adapters..
        /// </summary>
        internal static string AutoConnect_CheckingUdp {
            get {
                return ResourceManager.GetString("AutoConnect_CheckingUdp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found device on: &quot;{0}&quot;..
        /// </summary>
        internal static string AutoConnect_FoundDevice {
            get {
                return ResourceManager.GetString("AutoConnect_FoundDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found more than one device..
        /// </summary>
        internal static string AutoConnect_FoundMoreThanOneDevice {
            get {
                return ResourceManager.GetString("AutoConnect_FoundMoreThanOneDevice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searching for devices on: &quot;{0}&quot;..
        /// </summary>
        internal static string AutoConnect_SearchingForDevicesOn {
            get {
                return ResourceManager.GetString("AutoConnect_SearchingForDevicesOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings read process is already running..
        /// </summary>
        internal static string CommandProcess_AlreadyRunning {
            get {
                return ResourceManager.GetString("CommandProcess_AlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A communication error occurred while executing commands..
        /// </summary>
        internal static string CommandProcess_CommunicationError {
            get {
                return ResourceManager.GetString("CommandProcess_CommunicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not execute all commands..
        /// </summary>
        internal static string CommandProcess_CouldNotDoAll {
            get {
                return ResourceManager.GetString("CommandProcess_CouldNotDoAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrying {0} of {1} commands..
        /// </summary>
        internal static string CommandProcess_Retrying {
            get {
                return ResourceManager.GetString("CommandProcess_Retrying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing {0} commands..
        /// </summary>
        internal static string CommandProcess_Starting {
            get {
                return ResourceManager.GetString("CommandProcess_Starting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully executed {0} of {1} commands..
        /// </summary>
        internal static string CommandProcess_Successful {
            get {
                return ResourceManager.GetString("CommandProcess_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load IMU command addresses from XML..
        /// </summary>
        internal static string CommandXml_CouldNotLoad {
            get {
                return ResourceManager.GetString("CommandXml_CouldNotLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing root node..
        /// </summary>
        internal static string CommandXml_MissingRootNode {
            get {
                return ResourceManager.GetString("CommandXml_MissingRootNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not send OSC packet..
        /// </summary>
        internal static string Connection_CouldNotSendPacket {
            get {
                return ResourceManager.GetString("Connection_CouldNotSendPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disconnected from &quot;{0}&quot;..
        /// </summary>
        internal static string Connection_Disconnected {
            get {
                return ResourceManager.GetString("Connection_Disconnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while processing OSC packet..
        /// </summary>
        internal static string Connection_ErrorWhileProcessingPacket {
            get {
                return ResourceManager.GetString("Connection_ErrorWhileProcessingPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to connect to &quot;{0}&quot;..
        /// </summary>
        internal static string Connection_FailedToConnect {
            get {
                return ResourceManager.GetString("Connection_FailedToConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received corrupted OSC packet..
        /// </summary>
        internal static string Connection_ReceivedCorruptedPacket {
            get {
                return ResourceManager.GetString("Connection_ReceivedCorruptedPacket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Already connected..
        /// </summary>
        internal static string Data_AlreadyConnected {
            get {
                return ResourceManager.GetString("Data_AlreadyConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not connected..
        /// </summary>
        internal static string Data_NotConnected {
            get {
                return ResourceManager.GetString("Data_NotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array length must be 3..
        /// </summary>
        internal static string EulerAngles_ArrayLengthNot3 {
            get {
                return ResourceManager.GetString("EulerAngles_ArrayLengthNot3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown connection type..
        /// </summary>
        internal static string Exception_UnknownConnectionType {
            get {
                return ResourceManager.GetString("Exception_UnknownConnectionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while reading OSC..
        /// </summary>
        internal static string FileReadConnectionImplementation_ErrorReading {
            get {
                return ResourceManager.GetString("FileReadConnectionImplementation_ErrorReading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading file &quot;{0}&quot;..
        /// </summary>
        internal static string FileReadConnectionImplementation_Reading {
            get {
                return ResourceManager.GetString("FileReadConnectionImplementation_Reading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing to file &quot;{0}&quot;..
        /// </summary>
        internal static string FileWriteConnectionImplementation_Writing {
            get {
                return ResourceManager.GetString("FileWriteConnectionImplementation_Writing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array length must be 4..
        /// </summary>
        internal static string Quaternion_ArrayLengthNot4 {
            get {
                return ResourceManager.GetString("Quaternion_ArrayLengthNot4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported type &quot;{0}&quot;..
        /// </summary>
        internal static string RemoteVariableFactory_UnsupportedType {
            get {
                return ResourceManager.GetString("RemoteVariableFactory_UnsupportedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array length must be 9..
        /// </summary>
        internal static string RotationMatrix_ArrayLengthNot9 {
            get {
                return ResourceManager.GetString("RotationMatrix_ArrayLengthNot9", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to &quot;{0}&quot;..
        /// </summary>
        internal static string SerialConnectionImplementation_Connected {
            get {
                return ResourceManager.GetString("SerialConnectionImplementation_Connected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not load settings from XML..
        /// </summary>
        internal static string Settings_CouldNotLoad {
            get {
                return ResourceManager.GetString("Settings_CouldNotLoad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more setting does not have a &quot;Name&quot; attribute..
        /// </summary>
        internal static string Settings_MissingAttribute_Name {
            get {
                return ResourceManager.GetString("Settings_MissingAttribute_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more setting does not have a &quot;OscAddress&quot; attribute..
        /// </summary>
        internal static string Settings_MissingAttribute_OscAddress {
            get {
                return ResourceManager.GetString("Settings_MissingAttribute_OscAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing root node..
        /// </summary>
        internal static string Settings_MissingRootNode {
            get {
                return ResourceManager.GetString("Settings_MissingRootNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown setting type &quot;{0}&quot;..
        /// </summary>
        internal static string Settings_UnknownSettingType {
            get {
                return ResourceManager.GetString("Settings_UnknownSettingType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings {0} process is already running..
        /// </summary>
        internal static string SettingsProcess_ProcessAlreadyRunning {
            get {
                return ResourceManager.GetString("SettingsProcess_ProcessAlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings read process is already running..
        /// </summary>
        internal static string SettingsRead_AlreadyRunning {
            get {
                return ResourceManager.GetString("SettingsRead_AlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A communication error occurred while reading settings..
        /// </summary>
        internal static string SettingsRead_CommunicationError {
            get {
                return ResourceManager.GetString("SettingsRead_CommunicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not read all settings..
        /// </summary>
        internal static string SettingsRead_CouldNotDoAll {
            get {
                return ResourceManager.GetString("SettingsRead_CouldNotDoAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No settings to read..
        /// </summary>
        internal static string SettingsRead_NoValidSettings {
            get {
                return ResourceManager.GetString("SettingsRead_NoValidSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrying {0} of {1} settings..
        /// </summary>
        internal static string SettingsRead_Retrying {
            get {
                return ResourceManager.GetString("SettingsRead_Retrying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading {0} settings..
        /// </summary>
        internal static string SettingsRead_Starting {
            get {
                return ResourceManager.GetString("SettingsRead_Starting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully read {0} of {1} settings..
        /// </summary>
        internal static string SettingsRead_Successful {
            get {
                return ResourceManager.GetString("SettingsRead_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings write process is already running..
        /// </summary>
        internal static string SettingsWrite_AlreadyRunning {
            get {
                return ResourceManager.GetString("SettingsWrite_AlreadyRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A communication error occurred while writing settings..
        /// </summary>
        internal static string SettingsWrite_CommunicationError {
            get {
                return ResourceManager.GetString("SettingsWrite_CommunicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not confirm write of all settings..
        /// </summary>
        internal static string SettingsWrite_CouldNotDoAll {
            get {
                return ResourceManager.GetString("SettingsWrite_CouldNotDoAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write undefined setting values..
        /// </summary>
        internal static string SettingsWrite_NoValidSettings {
            get {
                return ResourceManager.GetString("SettingsWrite_NoValidSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrying {0} of {1} settings..
        /// </summary>
        internal static string SettingsWrite_Retrying {
            get {
                return ResourceManager.GetString("SettingsWrite_Retrying", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing {0} settings..
        /// </summary>
        internal static string SettingsWrite_Starting {
            get {
                return ResourceManager.GetString("SettingsWrite_Starting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully wrote {0} of {1} settings..
        /// </summary>
        internal static string SettingsWrite_Successful {
            get {
                return ResourceManager.GetString("SettingsWrite_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connected to &quot;{0}&quot;..
        /// </summary>
        internal static string UdpConnectionImplementation_Connected {
            get {
                return ResourceManager.GetString("UdpConnectionImplementation_Connected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while listening for OSC..
        /// </summary>
        internal static string UdpConnectionImplementation_ErrorReceiving {
            get {
                return ResourceManager.GetString("UdpConnectionImplementation_ErrorReceiving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to connect to &quot;{0}&quot;..
        /// </summary>
        internal static string UdpConnectionImplementation_FailedToConnect {
            get {
                return ResourceManager.GetString("UdpConnectionImplementation_FailedToConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adapter IP address changed..
        /// </summary>
        internal static string UdpConnectionImplementation_IPAddressChanged {
            get {
                return ResourceManager.GetString("UdpConnectionImplementation_IPAddressChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Send: {0}, {1}; Receive: {2}, {3}; {4}.
        /// </summary>
        internal static string UdpConnectionInfo_StringFormat {
            get {
                return ResourceManager.GetString("UdpConnectionInfo_StringFormat", resourceCulture);
            }
        }
    }
}
