﻿#pragma checksum "..\..\library.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "543DAD3C1349435A00DF0B017572F60E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace custom_template {
    
    
    /// <summary>
    /// library
    /// </summary>
    public partial class library : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/custom_template;component/library.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\library.xaml"
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
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 1:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 18 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.mouseenterProgressbar);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 47 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.previewmouseleftbuttondownPrimaryButton);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 48 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.previewmouseleftbuttonupPrimaryButton);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 78 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.previewmouseleftbuttondownToolbar);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 79 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.previewmouseleftbuttonupToolbar);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 80 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.mouseenterToolbar);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 81 "..\..\library.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.mouseleaveToolbar);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 4:
            
            #line 193 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusSuccess);
            
            #line default
            #line hidden
            
            #line 193 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 225 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusPrimary);
            
            #line default
            #line hidden
            
            #line 225 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 257 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusDanger);
            
            #line default
            #line hidden
            
            #line 257 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 289 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusWarning);
            
            #line default
            #line hidden
            
            #line 289 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 321 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusDefault);
            
            #line default
            #line hidden
            
            #line 321 "..\..\library.xaml"
            ((System.Windows.Controls.Border)(target)).LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

