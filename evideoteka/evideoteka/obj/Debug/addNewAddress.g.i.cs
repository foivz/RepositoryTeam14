﻿#pragma checksum "..\..\addNewAddress.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF99D045BC2487C71663C4C785620967"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace evideoteka {
    
    
    /// <summary>
    /// addNewAddress
    /// </summary>
    public partial class addNewAddress : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\addNewAddress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxPostNumber;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\addNewAddress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxMjesto;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\addNewAddress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxUlica;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\addNewAddress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAddress;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\addNewAddress.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseAddress;
        
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
            System.Uri resourceLocater = new System.Uri("/evideoteka;component/addnewaddress.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addNewAddress.xaml"
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
            this.txtBoxPostNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\addNewAddress.xaml"
            this.txtBoxPostNumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBoxPostNumber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtBoxMjesto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtBoxUlica = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnAddAddress = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\addNewAddress.xaml"
            this.btnAddAddress.Click += new System.Windows.RoutedEventHandler(this.btnAddAddress_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCloseAddress = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\addNewAddress.xaml"
            this.btnCloseAddress.Click += new System.Windows.RoutedEventHandler(this.btnCloseAddress_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

