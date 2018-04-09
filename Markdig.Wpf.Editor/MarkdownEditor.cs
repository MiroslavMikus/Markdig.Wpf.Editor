﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Markdig.Wpf.Editor
{
    public class MarkdownEditor : Control
    {
        static MarkdownEditor()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MarkdownEditor), new FrameworkPropertyMetadata(typeof(MarkdownEditor)));
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MarkdownEditor), new PropertyMetadata(default(string)));

        public bool AutoUpdate
        {
            get { return (bool)GetValue(AutoUpdateProperty); }
            set { SetValue(AutoUpdateProperty, value); }
        }
        public static readonly DependencyProperty AutoUpdateProperty =
            DependencyProperty.Register("AutoUpdate", typeof(bool), typeof(MarkdownEditor), new PropertyMetadata(true));


        public double AutoUpdateInterval
        {
            get { return (double)GetValue(AutoUpdateIntervalProperty); }
            set { SetValue(AutoUpdateIntervalProperty, value); }
        }
        public static readonly DependencyProperty AutoUpdateIntervalProperty =
            DependencyProperty.Register("AutoUpdateInterval", typeof(double), typeof(MarkdownEditor), new PropertyMetadata(default(double)));

        public double Progress
        {
            get { return (double)GetValue(ProgressProperty); }
            set { SetValue(ProgressProperty, value); }
        }
        public static readonly DependencyProperty ProgressProperty =
            DependencyProperty.Register("Progress", typeof(double), typeof(MarkdownEditor), new PropertyMetadata(default(double)));

        public FlowDocument MdDocument
        {
            get { return (FlowDocument)GetValue(MdDocumentProperty); }
            set { SetValue(MdDocumentProperty, value); }
        }
        public static readonly DependencyProperty MdDocumentProperty =
            DependencyProperty.Register("MdDocument", typeof(FlowDocument), typeof(MarkdownEditor), new PropertyMetadata(default(FlowDocument)));

        public ICommand Update
        {
            get { return (ICommand)GetValue(UpdateProperty); }
            set { SetValue(UpdateProperty, value); }
        }
        public static readonly DependencyProperty UpdateProperty =
            DependencyProperty.Register("Update", typeof(ICommand), typeof(MarkdownEditor), new PropertyMetadata(default(ICommand)));

        public Brush EditorBackground
        {
            get { return (Brush)GetValue(EditorBackgroundProperty); }
            set { SetValue(EditorBackgroundProperty, value); }
        }
        public static readonly DependencyProperty EditorBackgroundProperty =
            DependencyProperty.Register("EditorBackground", typeof(Brush), typeof(MarkdownEditor), new PropertyMetadata(default(Brush)));
    }
}
