﻿#pragma checksum "..\..\..\UserControls\EntityControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5BF774FACEC36AF351B8F7B7BEB3277E39B6486E2445507EA70419DDA15A3D5F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Financeiro.UserControls;
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


namespace Financeiro.UserControls {
    
    
    /// <summary>
    /// EntityControl
    /// </summary>
    public partial class EntityControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\UserControls\EntityControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControls\EntityControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PesquisarB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UserControls\EntityControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ResultDG;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserControls\EntityControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InserirB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UserControls\EntityControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditarB;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\UserControls\EntityControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoverB;
        
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
            System.Uri resourceLocater = new System.Uri("/Financeiro;component/usercontrols/entitycontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\EntityControl.xaml"
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
            this.NameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PesquisarB = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UserControls\EntityControl.xaml"
            this.PesquisarB.Click += new System.Windows.RoutedEventHandler(this.PesquisarB_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ResultDG = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\..\UserControls\EntityControl.xaml"
            this.ResultDG.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ResultDG_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.InserirB = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\UserControls\EntityControl.xaml"
            this.InserirB.Click += new System.Windows.RoutedEventHandler(this.InserirB_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditarB = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\UserControls\EntityControl.xaml"
            this.EditarB.Click += new System.Windows.RoutedEventHandler(this.EditarB_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemoverB = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\UserControls\EntityControl.xaml"
            this.RemoverB.Click += new System.Windows.RoutedEventHandler(this.RemoverB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

