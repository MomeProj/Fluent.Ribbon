﻿// ReSharper disable once CheckNamespace
namespace Fluent;

using System.Collections;
using System.Windows;
using Fluent.Helpers;

/// <summary>
/// Control for representing the left and right side of the start screen.
/// </summary>
/// <remarks>
/// To control some aspects of the left handed side of this control please use properties prefixed with "ItemsPanel*".
/// </remarks>
public class StartScreenTabControl : BackstageTabControl
{
    /// <summary>
    /// Left side panel content of the startscreen.
    /// </summary>
    public object? LeftContent
    {
        get => this.GetValue(LeftContentProperty);
        set => this.SetValue(LeftContentProperty, value);
    }

    /// <summary>Identifies the <see cref="LeftContent"/> dependency property.</summary>
    public static readonly DependencyProperty LeftContentProperty = DependencyProperty.Register(nameof(LeftContent), typeof(object), typeof(StartScreenTabControl), new PropertyMetadata(LogicalChildSupportHelper.OnLogicalChildPropertyChanged));

    /// <summary>
    /// Defines the margin for <see cref="LeftContent"/>
    /// </summary>
    public Thickness LeftContentMargin
    {
        get => (Thickness)this.GetValue(LeftContentMarginProperty);
        set => this.SetValue(LeftContentMarginProperty, value);
    }

    /// <summary>Identifies the <see cref="LeftContentMargin"/> dependency property.</summary>
    public static readonly DependencyProperty LeftContentMarginProperty =
        DependencyProperty.Register(nameof(LeftContentMargin), typeof(Thickness), typeof(StartScreenTabControl), new PropertyMetadata(default(Thickness)));

    /// <summary>
    /// Right side panel content of the startscreen.
    /// </summary>
    public object? RightContent
    {
        get => this.GetValue(RightContentProperty);
        set => this.SetValue(RightContentProperty, value);
    }

    /// <summary>Identifies the <see cref="RightContent"/> dependency property.</summary>
    public static readonly DependencyProperty RightContentProperty = DependencyProperty.Register(nameof(RightContent), typeof(object), typeof(StartScreenTabControl), new PropertyMetadata(LogicalChildSupportHelper.OnLogicalChildPropertyChanged));

    /// <summary>
    /// Static constructor.
    /// </summary>
    static StartScreenTabControl()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(StartScreenTabControl), new FrameworkPropertyMetadata(typeof(StartScreenTabControl)));

        ItemsPanelMinWidthProperty.OverrideMetadata(typeof(StartScreenTabControl), new PropertyMetadata(342d));
    }

    /// <inheritdoc />
    protected override IEnumerator LogicalChildren
    {
        get
        {
            var baseEnumerator = base.LogicalChildren;
            while (baseEnumerator?.MoveNext() == true)
            {
                yield return baseEnumerator.Current;
            }

            if (this.LeftContent is not null)
            {
                yield return this.LeftContent;
            }

            if (this.RightContent is not null)
            {
                yield return this.RightContent;
            }
        }
    }
}