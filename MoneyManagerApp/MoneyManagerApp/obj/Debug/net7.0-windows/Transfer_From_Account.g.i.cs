﻿#pragma checksum "..\..\..\Transfer_From_Account.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DEF096EEF71D55EE6D08D0A56F666E4E34F8B507"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MoneyManagerApp.Presentation;
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


namespace MoneyManagerApp.Presentation {
    
    
    /// <summary>
    /// Transfer_From_Account
    /// </summary>
    public partial class Transfer_From_Account : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\..\Transfer_From_Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FromAccountComboBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Transfer_From_Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Transfer_From_Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SumTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MoneyManagerApp.Presentation;component/transfer_from_account.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Transfer_From_Account.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 37 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.HomeLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 38 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.AccountsLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 39 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MyGoalsLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 40 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StatisticLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 41 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MyProfileLabel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 45 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FromAccountComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.SumTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Transfer_From_Account.xaml"
            this.SumTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.SumTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 52 "..\..\..\Transfer_From_Account.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Add_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

