﻿#pragma checksum "D:\ss\StudentManager\StudentManagementProject\Presentation\UIs\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4054D1B990D6A4335DC985B4CA10DCDE"
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
using StudentManagementProject.Presentation.Customs.Drawer;
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid TitleBar;
        
        internal System.Windows.Controls.Image DrawerIcon;
        
        internal StudentManagementProject.Presentation.Customs.Drawer.DrawerLayout DrawerLayout;
        
        internal System.Windows.Controls.Grid ListFragment;
        
        internal System.Windows.Controls.Grid MenuIdentity;
        
        internal System.Windows.Controls.TextBlock FullName;
        
        internal System.Windows.Controls.Grid MenuActions;
        
        internal System.Windows.Controls.Grid ListStudent;
        
        internal System.Windows.Controls.Grid AddStudent;
        
        internal System.Windows.Controls.TextBlock CreateStudent;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/StudentManagementProject;component/Presentation/UIs/Pages/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitleBar = ((System.Windows.Controls.Grid)(this.FindName("TitleBar")));
            this.DrawerIcon = ((System.Windows.Controls.Image)(this.FindName("DrawerIcon")));
            this.DrawerLayout = ((StudentManagementProject.Presentation.Customs.Drawer.DrawerLayout)(this.FindName("DrawerLayout")));
            this.ListFragment = ((System.Windows.Controls.Grid)(this.FindName("ListFragment")));
            this.MenuIdentity = ((System.Windows.Controls.Grid)(this.FindName("MenuIdentity")));
            this.FullName = ((System.Windows.Controls.TextBlock)(this.FindName("FullName")));
            this.MenuActions = ((System.Windows.Controls.Grid)(this.FindName("MenuActions")));
            this.ListStudent = ((System.Windows.Controls.Grid)(this.FindName("ListStudent")));
            this.AddStudent = ((System.Windows.Controls.Grid)(this.FindName("AddStudent")));
            this.CreateStudent = ((System.Windows.Controls.TextBlock)(this.FindName("CreateStudent")));
        }
    }
}

