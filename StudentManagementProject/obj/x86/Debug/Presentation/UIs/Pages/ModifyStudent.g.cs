﻿#pragma checksum "D:\projects\mobile\wp\StudentManager\StudentManagementProject\Presentation\UIs\Pages\ModifyStudent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EFDE83F333A0700E4B65CF915193F1BE"
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
    
    
    public partial class ModifyStudent : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image btnBack;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel StudentInfo;
        
        internal System.Windows.Controls.Image StudentImage;
        
        internal Microsoft.Phone.Controls.PhoneTextBox txtFullName;
        
        internal Microsoft.Phone.Controls.PhoneTextBox txtEmail;
        
        internal Microsoft.Phone.Controls.PhoneTextBox txtAddress;
        
        internal Microsoft.Phone.Controls.ListPicker dropClass;
        
        internal Microsoft.Phone.Controls.WrapPanel radioSex;
        
        internal System.Windows.Controls.RadioButton radioMale;
        
        internal System.Windows.Controls.RadioButton radioFemale;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/StudentManagementProject;component/Presentation/UIs/Pages/ModifyStudent.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnBack = ((System.Windows.Controls.Image)(this.FindName("btnBack")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.StudentInfo = ((System.Windows.Controls.StackPanel)(this.FindName("StudentInfo")));
            this.StudentImage = ((System.Windows.Controls.Image)(this.FindName("StudentImage")));
            this.txtFullName = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("txtFullName")));
            this.txtEmail = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("txtEmail")));
            this.txtAddress = ((Microsoft.Phone.Controls.PhoneTextBox)(this.FindName("txtAddress")));
            this.dropClass = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("dropClass")));
            this.radioSex = ((Microsoft.Phone.Controls.WrapPanel)(this.FindName("radioSex")));
            this.radioMale = ((System.Windows.Controls.RadioButton)(this.FindName("radioMale")));
            this.radioFemale = ((System.Windows.Controls.RadioButton)(this.FindName("radioFemale")));
        }
    }
}

