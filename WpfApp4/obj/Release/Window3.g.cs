﻿#pragma checksum "..\..\Window3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20CF7E485DFDA2EBB7C381DF0513CB8CC165921F"
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
    /// Window3
    /// </summary>
    public partial class Window3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Receipt;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Steak;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salmon;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox notesbox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chicken_Caesar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chicken;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Burger;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChickenSand;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chicken_fingers;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SandS;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox currentOrder;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Window3.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WpfApp4;component/window3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window3.xaml"
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
            this.Steak = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Window3.xaml"
            this.Steak.Click += new System.Windows.RoutedEventHandler(this.Steak_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Salmon = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Window3.xaml"
            this.Salmon.Click += new System.Windows.RoutedEventHandler(this.Salmon_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.notesbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Chicken_Caesar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Window3.xaml"
            this.Chicken_Caesar.Click += new System.Windows.RoutedEventHandler(this.Chicken_Caesar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Chicken = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Window3.xaml"
            this.Chicken.Click += new System.Windows.RoutedEventHandler(this.Chicken_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Burger = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Window3.xaml"
            this.Burger.Click += new System.Windows.RoutedEventHandler(this.Burger_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ChickenSand = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Window3.xaml"
            this.ChickenSand.Click += new System.Windows.RoutedEventHandler(this.ChickenSand_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Chicken_fingers = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Window3.xaml"
            this.Chicken_fingers.Click += new System.Windows.RoutedEventHandler(this.Chicken_fingers_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SandS = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Window3.xaml"
            this.SandS.Click += new System.Windows.RoutedEventHandler(this.SandS_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.currentOrder = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Window3.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.done = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Window3.xaml"
            this.done.Click += new System.Windows.RoutedEventHandler(this.done_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

