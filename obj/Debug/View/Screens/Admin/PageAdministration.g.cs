﻿#pragma checksum "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BFE114B4C1C8420D6ED94ADF27BD13026374C98CB01FF703BAE7CABB80B0B13"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BeautyBrows.View.Screens.Admin;
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


namespace BeautyBrows.View.Screens.Admin {
    
    
    /// <summary>
    /// PageAdministration
    /// </summary>
    public partial class PageAdministration : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 23 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbServiceList;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbSearchQuery;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run RunRecordsFound;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridOfferService;
        
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
            System.Uri resourceLocater = new System.Uri("/BeautyBrows;component/view/screens/admin/pageadministration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
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
            this.CmbServiceList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
            this.CmbServiceList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbServiceList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbSearchQuery = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
            this.TbSearchQuery.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbSearchQuery_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RunRecordsFound = ((System.Windows.Documents.Run)(target));
            return;
            case 4:
            this.DataGridOfferService = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 5:
            
            #line 96 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditService_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 104 "..\..\..\..\..\View\Screens\Admin\PageAdministration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDeleteService_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

