using System;
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

namespace WpfApplication2
{
    /// <summary>
    /// ChartButton.xaml 的交互逻辑
    /// </summary>
    public partial class ChartButton : UserControl
    {
        public ChartButton()
        {
            InitializeComponent();
        }
        #region 属性
        /// <summary>
        /// 工具提示
        /// </summary>
        public string ToolTip
        {
            get { return (string)GetValue(ToolTipProperty); }
            set { SetValue(ToolTipProperty, value); }
        }
        public static readonly DependencyProperty ToolTipProperty = DependencyProperty.Register("ToolTip",
        typeof(string), typeof(ChartButton), new PropertyMetadata());
        /// <summary>
        /// 按钮内容
        /// </summary>
        public string Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }
        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register("Content",
        typeof(string), typeof(ChartButton), new PropertyMetadata("按钮"));
        /// <summary>
        /// 图标
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon",
        typeof(ImageSource), typeof(ChartButton), new PropertyMetadata());
        /// <summary>
        /// 图标高度
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register("IconHeight",
        typeof(double), typeof(ChartButton), new PropertyMetadata(25.0));
        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register("IconWidth",
        typeof(double), typeof(ChartButton), new PropertyMetadata(25.0));
        /// <summary>
        /// 高度
        /// </summary>
        public double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }
        public static readonly DependencyProperty HeightProperty = DependencyProperty.Register("Height",
        typeof(double), typeof(ChartButton), new PropertyMetadata(46.0));
        /// <summary>
        /// 宽度
        /// </summary>
        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }
        public static readonly DependencyProperty WidthProperty = DependencyProperty.Register("Width",
        typeof(double), typeof(ChartButton), new PropertyMetadata(170.0));
        #endregion

        private void ChartButton_OnLoaded(object sender, RoutedEventArgs e)
        {
            MyButton.ToolTip = ToolTip;
            MyButton.Content = Content;
            MyButton.Width = Width;
            MyButton.Height = Height;
            if (Icon != null)
            {
                MyButton.DataContext = new ChartButtonModel()
                {
                    Icon = Icon,
                    IconHeight = IconHeight,
                    IconWidth = IconWidth
                };
            }
        }
    }

    public class ChartButtonModel
    {
        public ImageSource Icon { get; set; }
        public double IconHeight { get; set; }
        public double IconWidth { get; set; }
    }
}
