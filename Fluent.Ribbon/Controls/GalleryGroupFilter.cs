﻿// ReSharper disable once CheckNamespace
namespace Fluent;

using System.Windows;
using Fluent.Internal.KnownBoxes;

/// <summary>
/// Represents gallery group filter definition.
/// </summary>
public class GalleryGroupFilter : DependencyObject
{
    /// <summary>
    /// Gets or sets title of filter.
    /// </summary>
    public string Title
    {
        get => (string)this.GetValue(TitleProperty);
        set => this.SetValue(TitleProperty, value);
    }

    /// <summary>Identifies the <see cref="Title"/> dependency property.</summary>
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(GalleryGroupFilter), new PropertyMetadata("GalleryGroupFilter"));

    /// <summary>
    /// Gets or sets list of groups separated by comma.
    /// </summary>
    public string Groups
    {
        get => (string)this.GetValue(GroupsProperty);
        set => this.SetValue(GroupsProperty, value);
    }

#pragma warning disable WPF0010 // Default value type must match registered type.
    /// <summary>Identifies the <see cref="Groups"/> dependency property.</summary>
    public static readonly DependencyProperty GroupsProperty = DependencyProperty.Register(nameof(Groups), typeof(string), typeof(GalleryGroupFilter), new PropertyMetadata(StringBoxes.Empty));
#pragma warning restore WPF0010 // Default value type must match registered type.
}