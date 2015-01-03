﻿#pragma checksum "..\..\..\View\ApplicationView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63882B5D0FB53688C8342466DE202F87"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MyWMPv2.Model;
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


namespace MyWMPv2.View {
    
    
    /// <summary>
    /// ApplicationView
    /// </summary>
    public partial class ApplicationView : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 193 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement Media;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Progress;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListMusic;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListVideo;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListImage;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView TreePlaylist;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderMedia;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\View\ApplicationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderVolume;
        
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
            System.Uri resourceLocater = new System.Uri("/MyWMPv2;component/view/applicationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\ApplicationView.xaml"
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
            
            #line 118 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            
            #line 118 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 128 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            
            #line 128 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 130 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeTheme_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 137 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            
            #line 137 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 140 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Music_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 146 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Music_Directory);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 150 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Video_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 156 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Video_Directory);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 160 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Image_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 166 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Image_Directory);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 170 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Playlist_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 176 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Playlist_Add);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Media = ((System.Windows.Controls.MediaElement)(target));
            
            #line 193 "..\..\..\View\ApplicationView.xaml"
            this.Media.MediaOpened += new System.Windows.RoutedEventHandler(this.Media_MediaOpened);
            
            #line default
            #line hidden
            
            #line 193 "..\..\..\View\ApplicationView.xaml"
            this.Media.MediaEnded += new System.Windows.RoutedEventHandler(this.Media_MediaEnded);
            
            #line default
            #line hidden
            
            #line 194 "..\..\..\View\ApplicationView.xaml"
            this.Media.BufferingStarted += new System.Windows.RoutedEventHandler(this.Buffering_Started);
            
            #line default
            #line hidden
            
            #line 194 "..\..\..\View\ApplicationView.xaml"
            this.Media.BufferingEnded += new System.Windows.RoutedEventHandler(this.Buffering_Ended);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Progress = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.ListMusic = ((System.Windows.Controls.ListView)(target));
            
            #line 203 "..\..\..\View\ApplicationView.xaml"
            this.ListMusic.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ListMusic_Click));
            
            #line default
            #line hidden
            return;
            case 17:
            this.ListVideo = ((System.Windows.Controls.ListView)(target));
            
            #line 221 "..\..\..\View\ApplicationView.xaml"
            this.ListVideo.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ListVideo_Click));
            
            #line default
            #line hidden
            return;
            case 19:
            this.ListImage = ((System.Windows.Controls.ListView)(target));
            
            #line 238 "..\..\..\View\ApplicationView.xaml"
            this.ListImage.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ListImage_Click));
            
            #line default
            #line hidden
            return;
            case 21:
            this.TreePlaylist = ((System.Windows.Controls.TreeView)(target));
            return;
            case 24:
            this.SliderMedia = ((System.Windows.Controls.Slider)(target));
            
            #line 290 "..\..\..\View\ApplicationView.xaml"
            this.SliderMedia.AddHandler(System.Windows.Controls.Primitives.Thumb.DragStartedEvent, new System.Windows.Controls.Primitives.DragStartedEventHandler(this.SliderMedia_MouseDown));
            
            #line default
            #line hidden
            
            #line 290 "..\..\..\View\ApplicationView.xaml"
            this.SliderMedia.AddHandler(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent, new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.SliderMedia_MouseUp));
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 310 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_Youtube);
            
            #line default
            #line hidden
            return;
            case 26:
            this.SliderVolume = ((System.Windows.Controls.Slider)(target));
            
            #line 337 "..\..\..\View\ApplicationView.xaml"
            this.SliderVolume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SliderVolume_ValueChanged);
            
            #line default
            #line hidden
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
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 16:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 215 "..\..\..\View\ApplicationView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListMusic_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 18:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 232 "..\..\..\View\ApplicationView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListVideo_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 20:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 247 "..\..\..\View\ApplicationView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListImage_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 22:
            
            #line 259 "..\..\..\View\ApplicationView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Playlist_Start);
            
            #line default
            #line hidden
            break;
            case 23:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 281 "..\..\..\View\ApplicationView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.TreePlaylist_DoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

