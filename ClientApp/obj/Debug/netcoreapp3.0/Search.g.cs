﻿#pragma checksum "..\..\..\Search.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A773C53F7AE8D2B38D90A087DE57DDC1735076D6"
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
    /// Search
    /// </summary>
    public partial class Search : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enter_Button;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Choose_Box;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_Button;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bookings_Button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SingIn_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/ClientApp;component/search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Search.xaml"
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
            this.Enter_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Search.xaml"
            this.Enter_Button.Click += new System.Windows.RoutedEventHandler(this.Enter_Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Choose_Box = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Search.xaml"
            this.Choose_Box.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Choose_Box_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Search_Button = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Search.xaml"
            this.Search_Button.Click += new System.Windows.RoutedEventHandler(this.Search_Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Bookings_Button = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Search.xaml"
            this.Bookings_Button.Click += new System.Windows.RoutedEventHandler(this.Bookings_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SingIn_Button = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Search.xaml"
            this.SingIn_Button.Click += new System.Windows.RoutedEventHandler(this.SingIn_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
