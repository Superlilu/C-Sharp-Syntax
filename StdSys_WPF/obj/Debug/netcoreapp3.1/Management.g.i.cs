// Updated by XamlIntelliSenseFileGenerator 1/5/2021 5:33:16 PM
#pragma checksum "..\..\..\Management.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A384F0380762F8DA780D609156FFED87FABF8E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StdSys_WPF;
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


namespace StdSys_WPF
{


    /// <summary>
    /// Management
    /// </summary>
    public partial class Management : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StdSys_WPF;V1.0.0.0;component/management.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Management.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.TextBox_Student = ((System.Windows.Controls.TextBox)(target));

#line 20 "..\..\..\Management.xaml"
                    this.TextBox_Student.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);

#line default
#line hidden
                    return;
                case 2:
                    this.TextBox_Name = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.TextBox_ClassNo = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.TextBox_Credits = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.ListBox_SelectedCourses = ((System.Windows.Controls.ListBox)(target));

#line 27 "..\..\..\Management.xaml"
                    this.ListBox_SelectedCourses.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectedCourses_SelectionChanged);

#line default
#line hidden
                    return;
                case 6:
                    this.ComboBox_AvailableCourse = ((System.Windows.Controls.ComboBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
