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
using WpfApplication1.Properties;

namespace WpfApplication1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
    {

    }

    private void headerThumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
    {
      Left = Left + e.HorizontalChange;
      Top = Top + e.VerticalChange;
    }

    private void buttonSavePosition_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        Settings.Default.Width = int.Parse(textWidth.Text);
        Settings.Default.Top = Top;
        Settings.Default.Left = Left;
        Settings.Default.Save();
      }
      catch (Exception ex)
      {
      }
    }

    private void buttonLoadPosition_Click(object sender, RoutedEventArgs e)
    {
      Top = Settings.Default.Top;
      Left = Settings.Default.Left;
      textWidth.Text = Settings.Default.Width.ToString();
    }
  }
}
