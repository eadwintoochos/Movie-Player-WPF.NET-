﻿#pragma checksum "..\..\..\View\MediaController.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CED1621154271629FB3DD3FD440ED58C11F62125"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Common.ApplicationCommands;
using Common.Util;
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
using VideoPlayer;
using VirtualizingListView;


namespace VideoPlayer {
    
    
    /// <summary>
    /// MediaController
    /// </summary>
    public partial class MediaController : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VideoPlayer.MediaController mediaControl;
        
        #line default
        #line hidden
        
        
        #line 648 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel GroupControl;
        
        #line default
        #line hidden
        
        
        #line 652 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button repeatbtn;
        
        #line default
        #line hidden
        
        
        #line 699 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rewind;
        
        #line default
        #line hidden
        
        
        #line 749 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlNext;
        
        #line default
        #line hidden
        
        
        #line 848 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Previous;
        
        #line default
        #line hidden
        
        
        #line 896 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fastforward;
        
        #line default
        #line hidden
        
        
        #line 1004 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FulBtn;
        
        #line default
        #line hidden
        
        
        #line 1050 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VideoPlayer.VolumeControl volCtrl;
        
        #line default
        #line hidden
        
        
        #line 1057 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GroupSlider;
        
        #line default
        #line hidden
        
        
        #line 1062 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal VideoPlayer.MovieTitle_Tab MovieBoard;
        
        #line default
        #line hidden
        
        
        #line 1069 "..\..\..\View\MediaController.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider lcSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/VideoPlayer;component/view/mediacontroller.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MediaController.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.mediaControl = ((VideoPlayer.MediaController)(target));
            return;
            case 2:
            this.GroupControl = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            this.repeatbtn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.rewind = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.PlNext = ((System.Windows.Controls.Button)(target));
            
            #line 750 "..\..\..\View\MediaController.xaml"
            this.PlNext.ToolTipClosing += new System.Windows.Controls.ToolTipEventHandler(this.PlNext_ToolTipClosing);
            
            #line default
            #line hidden
            
            #line 751 "..\..\..\View\MediaController.xaml"
            this.PlNext.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PlNext_MouseEnter);
            
            #line default
            #line hidden
            
            #line 751 "..\..\..\View\MediaController.xaml"
            this.PlNext.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Previous_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Previous = ((System.Windows.Controls.Button)(target));
            
            #line 849 "..\..\..\View\MediaController.xaml"
            this.Previous.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Previous_MouseEnter);
            
            #line default
            #line hidden
            
            #line 849 "..\..\..\View\MediaController.xaml"
            this.Previous.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Previous_MouseLeave);
            
            #line default
            #line hidden
            
            #line 850 "..\..\..\View\MediaController.xaml"
            this.Previous.ToolTipClosing += new System.Windows.Controls.ToolTipEventHandler(this.PlNext_ToolTipClosing);
            
            #line default
            #line hidden
            return;
            case 7:
            this.fastforward = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.FulBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.volCtrl = ((VideoPlayer.VolumeControl)(target));
            return;
            case 10:
            this.GroupSlider = ((System.Windows.Controls.Grid)(target));
            return;
            case 11:
            this.MovieBoard = ((VideoPlayer.MovieTitle_Tab)(target));
            return;
            case 12:
            this.lcSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 1070 "..\..\..\View\MediaController.xaml"
            this.lcSlider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.PositionSlider_DragCompleted));
            
            #line default
            #line hidden
            
            #line 1071 "..\..\..\View\MediaController.xaml"
            this.lcSlider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.PositionSlider_DragStarted));
            
            #line default
            #line hidden
            
            #line 1072 "..\..\..\View\MediaController.xaml"
            this.lcSlider.AddHandler(System.Windows.Controls.Primitives.Thumb.DragDeltaEvent, new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.PositionSlider_DragDelta));
            
            #line default
            #line hidden
            
            #line 1073 "..\..\..\View\MediaController.xaml"
            this.lcSlider.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PositionSlider_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 1074 "..\..\..\View\MediaController.xaml"
            this.lcSlider.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.PositionSlider_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 1075 "..\..\..\View\MediaController.xaml"
            this.lcSlider.PreviewMouseUp += new System.Windows.Input.MouseButtonEventHandler(this.PositionSlider_MouseUp);
            
            #line default
            #line hidden
            
            #line 1076 "..\..\..\View\MediaController.xaml"
            this.lcSlider.MouseMove += new System.Windows.Input.MouseEventHandler(this.PositionSlider_MouseMove);
            
            #line default
            #line hidden
            
            #line 1077 "..\..\..\View\MediaController.xaml"
            this.lcSlider.MouseEnter += new System.Windows.Input.MouseEventHandler(this.PositionSlider_MouseEnter);
            
            #line default
            #line hidden
            
            #line 1078 "..\..\..\View\MediaController.xaml"
            this.lcSlider.MouseLeave += new System.Windows.Input.MouseEventHandler(this.PositionSlider_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

