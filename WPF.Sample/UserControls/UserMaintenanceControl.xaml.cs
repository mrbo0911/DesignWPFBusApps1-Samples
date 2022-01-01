using System.Windows.Controls;
using WPF.Sample.ViewModelLayer;

namespace WPF.Sample.UserControls
{
  public partial class UserMaintenanceControl : UserControl
  {
    public UserMaintenanceControl()
    {
      InitializeComponent();

      // Connect to instance of the view model created by the XAML
      _viewModel = (UserMaintenanceViewModel)this.Resources["viewModel"];
    }

    private UserMaintenanceViewModel _viewModel = null;

    private void CloseButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
      _viewModel.Close();
    }
  }
}
