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

namespace RoboThink {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      SelectedTab = "NSS";
    }
    public SolidColorBrush selected = new SolidColorBrush(Color.FromArgb((byte)100,(byte)221,(byte)221,(byte)221));
    public SolidColorBrush notSelected = new SolidColorBrush(Color.FromArgb((byte)255, (byte)100, (byte)100, (byte)100));
    
    public string SelectedTab;


    private void VIM_Click(object sender, RoutedEventArgs e) {
      changeTab(VIM);
    }

    private void changeTab(Button obj) {
      NSS.BorderBrush = notSelected;
      VIM.BorderBrush = notSelected;
      GIT.BorderBrush = notSelected;
      obj.BorderBrush = selected;
      SelectedTab = obj.Content.ToString();
    }

    private void NSS_Click(object sender, RoutedEventArgs e) {
      changeTab(NSS);
    }

    private void GIT_Click(object sender, RoutedEventArgs e) {
      changeTab(GIT);
    }
  }
}
