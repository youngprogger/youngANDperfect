﻿#pragma checksum "..\..\..\SignIn.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C81DF4FDC6AAEF0933644C0ABB0B4BA4196F278"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ClientApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ClientApp {
    
    
    /// <summary>
    /// SignIn
    /// </summary>
    public partial class SignIn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Registration_Button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_Button;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bookings_Button;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\SignIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignIn_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClientApp;component/signin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SignIn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.Registration_Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\SignIn.xaml"
            this.Registration_Button.Click += new System.Windows.RoutedEventHandler(this.Registration_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Search_Button = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\SignIn.xaml"
            this.Search_Button.Click += new System.Windows.RoutedEventHandler(this.Search_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Bookings_Button = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\SignIn.xaml"
            this.Bookings_Button.Click += new System.Windows.RoutedEventHandler(this.Bookings_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SignIn_Button = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\SignIn.xaml"
            this.SignIn_Button.Click += new System.Windows.RoutedEventHandler(this.SignIn_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

