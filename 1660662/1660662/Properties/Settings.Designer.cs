﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1660662.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataDPOAccess" +
            "\\QLHS.mdf;Integrated Security=True")]
        public string QLHSConnectionString {
            get {
                return ((string)(this["QLHSConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-H6J9M44\\QTCSDL;Initial Catalog=\"E:\\DEADLINE\\LẬP TRÌNH ỨNG DỤN" +
            "G QUẢN LÍ 1\\TUẦN 03\\1660662\\1660662\\DATADPOACCESS\\QLHS.MDF\";Integrated Security=" +
            "True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string E__DEADLINE_LẬP_TRÌNH_ỨNG_DỤNG_QUẢN_LÍ_1_TUẦN_03_1660662_1660662_DATADPOACCESS_QLHS_MDFConnectionString {
            get {
                return ((string)(this["E__DEADLINE_LẬP_TRÌNH_ỨNG_DỤNG_QUẢN_LÍ_1_TUẦN_03_1660662_1660662_DATADPOACCESS_QL" +
                    "HS_MDFConnectionString"]));
            }
        }
    }
}
