#pragma checksum "..\..\AddClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6034186A3A161A6120D065B6FE6DA0CB0FE7C1EF26C25CDA5F328D57E08D3AC4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Strahovoe;
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


namespace Strahovoe {
    
    
    /// <summary>
    /// AddClient
    /// </summary>
    public partial class AddClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fnameTB;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameTB;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox otchestvoTB;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox adresTB;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pasTB;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateDP;
        
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
            System.Uri resourceLocater = new System.Uri("/Strahovoe;component/addclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddClient.xaml"
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
            
            #line 10 "..\..\AddClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fnameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.otchestvoTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.adresTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.pasTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dateDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

