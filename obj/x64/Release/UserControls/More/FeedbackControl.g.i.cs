﻿#pragma checksum "..\..\..\..\..\UserControls\More\FeedbackControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5235B42108D6720E3DB0DE470AED5BFB2187043E903C7BF8F4DEC29ADA3B8705"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// FeedbackControl
    /// </summary>
    public partial class FeedbackControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeCB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTB;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleTBL;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTB;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionTBL;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTB;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnviarB;
        
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
            System.Uri resourceLocater = new System.Uri("/Financeiro;component/usercontrols/more/feedbackcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
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
            this.TypeCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.EmailTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TitleTBL = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TitleTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DescriptionTBL = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DescriptionTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EnviarB = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\UserControls\More\FeedbackControl.xaml"
            this.EnviarB.Click += new System.Windows.RoutedEventHandler(this.EnviarB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
