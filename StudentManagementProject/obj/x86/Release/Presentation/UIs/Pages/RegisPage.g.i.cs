﻿#pragma checksum "D:\projects\mobile\wp\StudentManagementProject\StudentManagementProject\Presentation\UIs\Pages\RegisPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3C8C098D1205596FE9F0C2B13FDBC63A"
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
    
    
    public partial class RegisPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid TitlePanel;
        
        internal System.Windows.Controls.TextBlock loginTitle;
        
        internal System.Windows.Controls.TextBox txtUserNameRegis;
        
        internal System.Windows.Controls.TextBox txtPasswordRegis;
        
        internal System.Windows.Controls.TextBox txtRePasswordRegis;
        
        internal System.Windows.Controls.Button btnRegister;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/StudentManagementProject;component/Presentation/UIs/Pages/RegisPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.Grid)(this.FindName("TitlePanel")));
            this.loginTitle = ((System.Windows.Controls.TextBlock)(this.FindName("loginTitle")));
            this.txtUserNameRegis = ((System.Windows.Controls.TextBox)(this.FindName("txtUserNameRegis")));
            this.txtPasswordRegis = ((System.Windows.Controls.TextBox)(this.FindName("txtPasswordRegis")));
            this.txtRePasswordRegis = ((System.Windows.Controls.TextBox)(this.FindName("txtRePasswordRegis")));
            this.btnRegister = ((System.Windows.Controls.Button)(this.FindName("btnRegister")));
        }
    }
}

