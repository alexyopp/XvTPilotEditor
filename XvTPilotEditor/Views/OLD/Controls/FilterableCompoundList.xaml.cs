using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace XvTPilotEditor.Views.Controls
{
    public partial class FilterableCompoundList : UserControl
    {
        public FilterableCompoundList()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(object), typeof(FilterableCompoundList),
                new PropertyMetadata(null, OnItemsSourceChanged));

        public object ItemsSource
        {
            get => GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register(nameof(ItemTemplate), typeof(DataTemplate), typeof(FilterableCompoundList), new PropertyMetadata(null));

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        private static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctl = (FilterableCompoundList)d;
            ctl.AttachCollectionView(e.NewValue);
        }

        private ICollectionView? _view;

        private void AttachCollectionView(object? itemsSource)
        {
            if (_view != null)
            {
                _view.Filter = null;
                _view = null;
            }

            if (itemsSource == null) return;

            _view = CollectionViewSource.GetDefaultView(itemsSource);
            if (_view != null)
            {
                _view.Filter = FilterPredicate;
                PART_ItemsControl.ItemsSource = _view;
                _view.Refresh();
            }
        }

        private bool FilterPredicate(object obj)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text)) return true;

            var search = SearchBox.Text.Trim().ToLowerInvariant();

            // Typical items are view-models exposing Label/Value/Metadata properties.
            // Use reflection to keep control generic.
            try
            {
                var type = obj.GetType();

                string? label = type.GetProperty("Label")?.GetValue(obj)?.ToString();
                string? value = type.GetProperty("Value")?.GetValue(obj)?.ToString();
                string? metadata = type.GetProperty("Metadata")?.GetValue(obj)?.ToString();

                if (!string.IsNullOrEmpty(label) && label.ToLowerInvariant().Contains(search)) return true;
                if (!string.IsNullOrEmpty(value) && value.ToLowerInvariant().Contains(search)) return true;
                if (!string.IsNullOrEmpty(metadata) && metadata.ToLowerInvariant().Contains(search)) return true;
            }
            catch
            {
                // If reflection fails, don't filter out the item.
                return true;
            }

            return false;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            _view?.Refresh();
        }
    }
}