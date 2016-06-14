﻿#pragma checksum "..\..\..\..\Views\RemoteView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB9DF6813EC48F7095BAEDE8188F9F7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.XmlBrowser;
using MetroDemo;
using MetroDemo.ExampleViews;
using MetroDemo.Models;
using Microsoft.OfficeProPlus.InstallGen.Presentation.Models;
using Microsoft.OfficeProPlus.InstallGen.Presentation.ValueConverter;
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
using WpfAnimatedGif;


namespace MetroDemo.ExampleViews {
    
    
    /// <summary>
    /// RemoteView
    /// </summary>
    public partial class RemoteView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 33 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Product;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl MainTabControl;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabItem OptionalTab;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RemoteMachineList;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddComputersButton;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportComputersButton;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveComputers;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeChannelOrVersion;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateRemote;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\..\Views\RemoteView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image WaitImage;
        
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
            System.Uri resourceLocater = new System.Uri("/OfficeProPlusInstallToolkit;component/views/remoteview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\RemoteView.xaml"
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
            
            #line 17 "..\..\..\..\Views\RemoteView.xaml"
            ((MetroDemo.ExampleViews.RemoteView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.RemoteView_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Product = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.MainTabControl = ((MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl)(target));
            
            #line 49 "..\..\..\..\Views\RemoteView.xaml"
            this.MainTabControl.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainTabControl_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OptionalTab = ((System.Windows.Controls.TabItem)(target));
            return;
            case 5:
            this.RemoteMachineList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.AddComputersButton = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\..\..\Views\RemoteView.xaml"
            this.AddComputersButton.Click += new System.Windows.RoutedEventHandler(this.AddComputersButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ImportComputersButton = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\..\..\Views\RemoteView.xaml"
            this.ImportComputersButton.Click += new System.Windows.RoutedEventHandler(this.ImportComputersButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRemoveComputers = ((System.Windows.Controls.Button)(target));
            
            #line 145 "..\..\..\..\Views\RemoteView.xaml"
            this.btnRemoveComputers.Click += new System.Windows.RoutedEventHandler(this.btnRemoveComputers_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnChangeChannelOrVersion = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\..\Views\RemoteView.xaml"
            this.btnChangeChannelOrVersion.Click += new System.Windows.RoutedEventHandler(this.btnChangeChannelOrVersion_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnUpdateRemote = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\..\Views\RemoteView.xaml"
            this.btnUpdateRemote.Click += new System.Windows.RoutedEventHandler(this.btnUpdateRemote_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.WaitImage = ((System.Windows.Controls.Image)(target));
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
            case 6:
            
            #line 76 "..\..\..\..\Views\RemoteView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Click += new System.Windows.RoutedEventHandler(this.chkAll_Click);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 116 "..\..\..\..\Views\RemoteView.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductChannel_SelectionChanged);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

