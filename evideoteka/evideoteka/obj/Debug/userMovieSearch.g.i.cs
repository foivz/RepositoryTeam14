﻿#pragma checksum "..\..\userMovieSearch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F1EF796DE22FC0206BCB1E8DFF96C6B"
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
    /// userMovieSearch
    /// </summary>
    public partial class userMovieSearch : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\userMovieSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\userMovieSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxSearchName;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\userMovieSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchName;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\userMovieSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxSearchActor;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\userMovieSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchActor;
        
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
            System.Uri resourceLocater = new System.Uri("/evideoteka;component/usermoviesearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\userMovieSearch.xaml"
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
            this.listBoxSearch = ((System.Windows.Controls.ListBox)(target));
            
            #line 9 "..\..\userMovieSearch.xaml"
            this.listBoxSearch.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listBoxSearch_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtBoxSearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\userMovieSearch.xaml"
            this.txtBoxSearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSearchName = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\userMovieSearch.xaml"
            this.btnSearchName.Click += new System.Windows.RoutedEventHandler(this.btnSearchName_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtBoxSearchActor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSearchActor = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\userMovieSearch.xaml"
            this.btnSearchActor.Click += new System.Windows.RoutedEventHandler(this.btnSearchActor_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

