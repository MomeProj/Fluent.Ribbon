﻿// ReSharper disable once CheckNamespace
namespace Fluent;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Fluent.Internal.KnownBoxes;

/// <summary>
/// Represent logical container for toolbar items
/// </summary>
[ContentProperty(nameof(Items))]
public class RibbonToolBarControlGroup : ItemsControl
{
    #region Properties

    /// <summary>
    /// Gets whether the group is the fisrt control in the row
    /// </summary>
    public bool IsFirstInRow
    {
        get => (bool)this.GetValue(IsFirstInRowProperty);
        set => this.SetValue(IsFirstInRowProperty, BooleanBoxes.Box(value));
    }

    /// <summary>Identifies the <see cref="IsFirstInRow"/> dependency property.</summary>
    public static readonly DependencyProperty IsFirstInRowProperty =
        DependencyProperty.Register(nameof(IsFirstInRow), typeof(bool), typeof(RibbonToolBarControlGroup), new PropertyMetadata(BooleanBoxes.TrueBox));

    /// <summary>
    /// Gets whether the group is the last control in the row
    /// </summary>
    public bool IsLastInRow
    {
        get => (bool)this.GetValue(IsLastInRowProperty);
        set => this.SetValue(IsLastInRowProperty, BooleanBoxes.Box(value));
    }

    /// <summary>Identifies the <see cref="IsLastInRow"/> dependency property.</summary>
    public static readonly DependencyProperty IsLastInRowProperty =
        DependencyProperty.Register(nameof(IsLastInRow), typeof(bool), typeof(RibbonToolBarControlGroup), new PropertyMetadata(BooleanBoxes.TrueBox));

    #endregion

    static RibbonToolBarControlGroup()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(RibbonToolBarControlGroup), new FrameworkPropertyMetadata(typeof(RibbonToolBarControlGroup)));
    }
}