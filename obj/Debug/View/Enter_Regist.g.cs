﻿#pragma checksum "..\..\..\View\Enter_Regist.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "967134276758F839D7C5D2A8EFB92F657AE8F860"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Student_Assist.View;
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


namespace Student_Assist.View {
    
    
    /// <summary>
    /// Enter_Regist
    /// </summary>
    public partial class Enter_Regist : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\View\Enter_Regist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Check_Pass;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\Enter_Regist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox RememberAcc;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\Enter_Regist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HaveAccount;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\View\Enter_Regist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BLogin;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\Enter_Regist.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BRegist;
        
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
            System.Uri resourceLocater = new System.Uri("/Student_Assist;component/view/enter_regist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Enter_Regist.xaml"
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
            
            #line 12 "..\..\..\View\Enter_Regist.xaml"
            ((Student_Assist.View.Enter_Regist)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\View\Enter_Regist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_Regist);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Check_Pass = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.RememberAcc = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.HaveAccount = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\View\Enter_Regist.xaml"
            this.HaveAccount.Click += new System.Windows.RoutedEventHandler(this.HaveAcc);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BLogin = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.BRegist = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            
            #line 60 "..\..\..\View\Enter_Regist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_vk);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 63 "..\..\..\View\Enter_Regist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_linkedin);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 66 "..\..\..\View\Enter_Regist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_telegram);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 76 "..\..\..\View\Enter_Regist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Quit);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 82 "..\..\..\View\Enter_Regist.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Minimize);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

