﻿#pragma checksum "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "77D3DA26880D644A736579D4933E720F210DA36187929FE9CBF972AB2E577949"
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
using Financeiro.UserControls.More;
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


namespace Financeiro.UserControls.More {
    
    
    /// <summary>
    /// ImportFromDatabaseServer
    /// </summary>
    public partial class ImportFromDatabaseServer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ConsultasChB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ProcedimentosChB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ProcedimentosLaboratoriaisChB;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Financeiro.UserControls.DateInterval IntervalDI;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelB;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock LogTBL;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemsLB;
        
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
            System.Uri resourceLocater = new System.Uri("/Financeiro;component/usercontrols/more/importfromdatabaseserver.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
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
            this.ConsultasChB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.ProcedimentosChB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.ProcedimentosLaboratoriaisChB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.IntervalDI = ((Financeiro.UserControls.DateInterval)(target));
            return;
            case 5:
            this.CancelB = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
            this.CancelB.Click += new System.Windows.RoutedEventHandler(this.CancelB_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImportB = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\UserControls\More\ImportFromDatabaseServer.xaml"
            this.ImportB.Click += new System.Windows.RoutedEventHandler(this.ImportB_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LogTBL = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ItemsLB = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

