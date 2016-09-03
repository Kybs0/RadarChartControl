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
    /// RadarChartTitleList.xaml 的交互逻辑
    /// </summary>
    public partial class RadarChartTitleList : UserControl
    {
        public RadarChartTitleList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 数据
        /// </summary>
        public List<ChartItem> ItemSoure
        {
            get { return (List<ChartItem>)GetValue(ItemSoureProperty); }
            set { SetValue(ItemSoureProperty, value); }
        }

        public static readonly DependencyProperty ItemSoureProperty = DependencyProperty.Register("ItemSoure", typeof(List<ChartItem>),
        typeof(RadarChartControl), new PropertyMetadata(new List<ChartItem>()));

        private void RadarChartTitleList_OnLoaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = ItemSoure;
        }
    }
}
