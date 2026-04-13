using System.Windows;
using System.Windows.Controls;

namespace XvTPilotEditor.Views.Controls
{
    public partial class QuadBase : UserControl
    {
        public QuadBase()
        {
            InitializeComponent();
        }

        // Contents
        public static readonly DependencyProperty Column0ContentProperty =
            DependencyProperty.Register(nameof(Column0Content), typeof(object), typeof(QuadBase), new PropertyMetadata(null));
        public object? Column0Content { get => GetValue(Column0ContentProperty); set => SetValue(Column0ContentProperty, value); }

        public static readonly DependencyProperty Column1ContentProperty =
            DependencyProperty.Register(nameof(Column1Content), typeof(object), typeof(QuadBase), new PropertyMetadata(null));
        public object? Column1Content { get => GetValue(Column1ContentProperty); set => SetValue(Column1ContentProperty, value); }

        public static readonly DependencyProperty Column2ContentProperty =
            DependencyProperty.Register(nameof(Column2Content), typeof(object), typeof(QuadBase), new PropertyMetadata(null));
        public object? Column2Content { get => GetValue(Column2ContentProperty); set => SetValue(Column2ContentProperty, value); }

        public static readonly DependencyProperty Column3ContentProperty =
            DependencyProperty.Register(nameof(Column3Content), typeof(object), typeof(QuadBase), new PropertyMetadata(null));
        public object? Column3Content { get => GetValue(Column3ContentProperty); set => SetValue(Column3ContentProperty, value); }

        // Templates (optional)
        public static readonly DependencyProperty Column0ContentTemplateProperty =
            DependencyProperty.Register(nameof(Column0ContentTemplate), typeof(DataTemplate), typeof(QuadBase), new PropertyMetadata(null));
        public DataTemplate? Column0ContentTemplate { get => (DataTemplate?)GetValue(Column0ContentTemplateProperty); set => SetValue(Column0ContentTemplateProperty, value); }

        public static readonly DependencyProperty Column1ContentTemplateProperty =
            DependencyProperty.Register(nameof(Column1ContentTemplate), typeof(DataTemplate), typeof(QuadBase), new PropertyMetadata(null));
        public DataTemplate? Column1ContentTemplate { get => (DataTemplate?)GetValue(Column1ContentTemplateProperty); set => SetValue(Column1ContentTemplateProperty, value); }

        public static readonly DependencyProperty Column2ContentTemplateProperty =
            DependencyProperty.Register(nameof(Column2ContentTemplate), typeof(DataTemplate), typeof(QuadBase), new PropertyMetadata(null));
        public DataTemplate? Column2ContentTemplate { get => (DataTemplate?)GetValue(Column2ContentTemplateProperty); set => SetValue(Column2ContentTemplateProperty, value); }

        public static readonly DependencyProperty Column3ContentTemplateProperty =
            DependencyProperty.Register(nameof(Column3ContentTemplate), typeof(DataTemplate), typeof(QuadBase), new PropertyMetadata(null));
        public DataTemplate? Column3ContentTemplate { get => (DataTemplate?)GetValue(Column3ContentTemplateProperty); set => SetValue(Column3ContentTemplateProperty, value); }

        /*  In case in the future we want this to be customizable, though that defeats the purpose I'm originally making this for, i.e., a consistent layout over multiple, disconnected controls
        // Column widths
        public static readonly DependencyProperty Column0WidthProperty =
            DependencyProperty.Register(nameof(Column0Width), typeof(GridLength), typeof(QuadBase), new PropertyMetadata(new GridLength(200)));
        public GridLength Column0Width { get => (GridLength)GetValue(Column0WidthProperty); set => SetValue(Column0WidthProperty, value); }

        public static readonly DependencyProperty Column1WidthProperty =
            DependencyProperty.Register(nameof(Column1Width), typeof(GridLength), typeof(QuadBase), new PropertyMetadata(new GridLength(175)));
        public GridLength Column1Width { get => (GridLength)GetValue(Column1WidthProperty); set => SetValue(Column1WidthProperty, value); }

        public static readonly DependencyProperty Column2WidthProperty =
            DependencyProperty.Register(nameof(Column2Width), typeof(GridLength), typeof(QuadBase), new PropertyMetadata(new GridLength(175)));
        public GridLength Column2Width { get => (GridLength)GetValue(Column2WidthProperty); set => SetValue(Column2WidthProperty, value); }

        public static readonly DependencyProperty Column3WidthProperty =
            DependencyProperty.Register(nameof(Column3Width), typeof(GridLength), typeof(QuadBase), new PropertyMetadata(new GridLength(175)));
        public GridLength Column3Width { get => (GridLength)GetValue(Column3WidthProperty); set => SetValue(Column3WidthProperty, value); }
        */
    }
}
