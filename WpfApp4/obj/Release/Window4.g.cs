﻿#pragma checksum "..\..\Window4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45020922401E04148F75DA3D8BCFBF32A9EE627F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WpfApp4;


namespace WpfApp4 {
    
    
    /// <summary>
    /// Window4
    /// </summary>
    public partial class Window4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Receipt;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox notesbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pancakes;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Waffles;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Crepes;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Omellette;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox currentOrder;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button done;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/window4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window4.xaml"
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
            this.Receipt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.notesbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Pancakes = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Window4.xaml"
            this.Pancakes.Click += new System.Windows.RoutedEventHandler(this.Pancakes_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Waffles = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Window4.xaml"
            this.Waffles.Click += new System.Windows.RoutedEventHandler(this.Waffles_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Crepes = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Window4.xaml"
            this.Crepes.Click += new System.Windows.RoutedEventHandler(this.Crepes_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Omellette = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Window4.xaml"
            this.Omellette.Click += new System.Windows.RoutedEventHandler(this.Omellette_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.currentOrder = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Window4.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.done = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Window4.xaml"
            this.done.Click += new System.Windows.RoutedEventHandler(this.done_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

