﻿#pragma checksum "..\..\..\Win\RegDesk.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "02B00C0C17BB7F313B0256FF450AAD64BB9A8A07C403C7455D7D78BB9C3E1B54"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MedClinic.Win;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MedClinic.Win {
    
    
    /// <summary>
    /// RegDesk
    /// </summary>
    public partial class RegDesk : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Win\RegDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Win\RegDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DoctorsBtn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Win\RegDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PatientBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Win\RegDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AppointBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Win\RegDesk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MedClinic;component/win/regdesk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Win\RegDesk.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.DoctorsBtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Win\RegDesk.xaml"
            this.DoctorsBtn.Click += new System.Windows.RoutedEventHandler(this.DoctorsBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PatientBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Win\RegDesk.xaml"
            this.PatientBtn.Click += new System.Windows.RoutedEventHandler(this.PatientBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AppointBtn = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Win\RegDesk.xaml"
            this.AppointBtn.Click += new System.Windows.RoutedEventHandler(this.AppointBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\Win\RegDesk.xaml"
            this.ExitBtn.Click += new System.Windows.RoutedEventHandler(this.ExitBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

