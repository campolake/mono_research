﻿#pragma checksum "D:\Dev\NUnit\nunitlite\silverlight\src\framework\Runner\Silverlight\TestPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F6202F16BB641581768BCB53F5200C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NUnitLite.Runner.Silverlight {
    
    
    public partial class TestPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock Total;
        
        internal System.Windows.Controls.TextBlock Passed;
        
        internal System.Windows.Controls.TextBlock Failures;
        
        internal System.Windows.Controls.TextBlock Errors;
        
        internal System.Windows.Controls.TextBlock Inconclusive;
        
        internal System.Windows.Controls.TextBlock NotRun;
        
        internal System.Windows.Controls.TextBlock ScratchArea;
        
        internal System.Windows.Controls.TextBlock Notice;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/nunitlite;component/Runner/Silverlight/TestPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Total = ((System.Windows.Controls.TextBlock)(this.FindName("Total")));
            this.Passed = ((System.Windows.Controls.TextBlock)(this.FindName("Passed")));
            this.Failures = ((System.Windows.Controls.TextBlock)(this.FindName("Failures")));
            this.Errors = ((System.Windows.Controls.TextBlock)(this.FindName("Errors")));
            this.Inconclusive = ((System.Windows.Controls.TextBlock)(this.FindName("Inconclusive")));
            this.NotRun = ((System.Windows.Controls.TextBlock)(this.FindName("NotRun")));
            this.ScratchArea = ((System.Windows.Controls.TextBlock)(this.FindName("ScratchArea")));
            this.Notice = ((System.Windows.Controls.TextBlock)(this.FindName("Notice")));
        }
    }
}

