﻿#pragma checksum "..\..\addNewMovie.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "95D25A547A55D4FD6134668774DD5D03"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// addNewMovie
    /// </summary>
    public partial class addNewMovie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxNaziv;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxYear;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxDuration;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxLanguage;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxCountry;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddMovie;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnd;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxDistributor;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\addNewMovie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddPath;
        
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
            System.Uri resourceLocater = new System.Uri("/evideoteka;component/addnewmovie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addNewMovie.xaml"
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
            this.txtBoxNaziv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtBoxYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtBoxDuration = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBoxLanguage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBoxCountry = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnAddMovie = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\addNewMovie.xaml"
            this.btnAddMovie.Click += new System.Windows.RoutedEventHandler(this.btnAddMovie_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnEnd = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.listBoxDistributor = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.btnAddPath = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\addNewMovie.xaml"
            this.btnAddPath.Click += new System.Windows.RoutedEventHandler(this.btnAddPath_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

