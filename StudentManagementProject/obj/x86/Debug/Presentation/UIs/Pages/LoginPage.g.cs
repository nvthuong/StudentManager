﻿#pragma checksum "D:\ss\StudentManager\StudentManagementProject\Presentation\UIs\Pages\LoginPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B010FF71C2AC91070D0A003727D1D019"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace StudentManagementProject.Presentation.UIs.Pages {
    
    
    public partial class LoginPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid TitlePanel;
        
        internal System.Windows.Controls.TextBlock loginTitle;
        
        internal System.Windows.Controls.TextBox txtUserName;
        
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        internal System.Windows.Controls.Button btnLogin;
        
        internal System.Windows.Controls.TextBlock navRegis;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/StudentManagementProject;component/Presentation/UIs/Pages/LoginPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.Grid)(this.FindName("TitlePanel")));
            this.loginTitle = ((System.Windows.Controls.TextBlock)(this.FindName("loginTitle")));
            this.txtUserName = ((System.Windows.Controls.TextBox)(this.FindName("txtUserName")));
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(this.FindName("txtPassword")));
            this.btnLogin = ((System.Windows.Controls.Button)(this.FindName("btnLogin")));
            this.navRegis = ((System.Windows.Controls.TextBlock)(this.FindName("navRegis")));
        }
    }
}

