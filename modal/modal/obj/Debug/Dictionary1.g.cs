﻿#pragma checksum "..\..\Dictionary1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9A1DB90CD1A5D8E7AA3A297B6916E275"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
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


namespace modal {
    
    
    /// <summary>
    /// Dictionary
    /// </summary>
    public partial class Dictionary : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/modal;component/dictionary1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dictionary1.xaml"
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
            
            #line 94 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.mouseenterLabel);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 95 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.mouseleaveLabel);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 188 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocustextPrimary);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 189 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.losttextFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 198 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocustextSuccess);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 199 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.losttextFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 4:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 208 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocustextDanger);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 209 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.losttextFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 5:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 217 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocustextWarning);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 218 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.losttextFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 6:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 226 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocustextDefault);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 227 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.losttextFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 7:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 253 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 254 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ButtonUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 255 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.ButtonEnter);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 256 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.ButtonLeave);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 8:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 323 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusPrimary);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 324 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 9:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 333 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusSuccess);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 334 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 10:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 343 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusDanger);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 344 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 11:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 352 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusWarning);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 353 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 12:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 361 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.gotFocusDefault);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 362 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.lostFocus);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

