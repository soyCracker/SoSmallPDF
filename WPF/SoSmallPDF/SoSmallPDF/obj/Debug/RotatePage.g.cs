﻿#pragma checksum "..\..\RotatePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A63F51FBB264C12AE4A25917D4D86A617D288FA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SoSmallPDF;
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


namespace SoSmallPDF {
    
    
    /// <summary>
    /// RotatePage
    /// </summary>
    public partial class RotatePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectFileButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectFileTextBlock;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageTextBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DegreeComboBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem right;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem half;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\RotatePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem left;
        
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
            System.Uri resourceLocater = new System.Uri("/SoSmallPDF;component/rotatepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RotatePage.xaml"
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
            this.SelectFileButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\RotatePage.xaml"
            this.SelectFileButton.Click += new System.Windows.RoutedEventHandler(this.SelectFileButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StartButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\RotatePage.xaml"
            this.StartButton.Click += new System.Windows.RoutedEventHandler(this.StartButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SelectFileTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.MessageTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.DegreeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.right = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 7:
            this.half = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.left = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

