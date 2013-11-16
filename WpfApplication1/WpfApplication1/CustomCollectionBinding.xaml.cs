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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for CustomCollectionBinding.xaml
    /// </summary>
    public partial class CustomCollectionBinding : Window
    {
        private ObservableCollection<User> _users = new ObservableCollection<User>();

        public CustomCollectionBinding()
        {
            InitializeComponent();

            _users.Add(new User { FirstName = "Steve", LastName = "Durko" });
            _users.Add(new User { FirstName = "Meghan", LastName = "Durko" });

            //this.DataContext = _users;

            this.lbFirstName.ItemsSource = _users;

            this.lbLastName.ItemsSource = _users;
        }

        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            _users.Add(new User() {FirstName="Greg", LastName="Durko"});
        }

        private void Delete_Click_1(object sender, RoutedEventArgs e)
        {
            if (lbFirstName.SelectedItem != null)
            {
                _users.Remove(lbFirstName.SelectedItem as User);
            }

            if (lbLastName.SelectedItem != null)
            {
                _users.Remove(lbLastName.SelectedItem as User);
            }

        }

        private void Edit_Click_1(object sender, RoutedEventArgs e)
        {
            if (lbFirstName.SelectedItem != null)
            {
                EditUser(lbFirstName.SelectedItem as User);
            }

            if (lbLastName.SelectedItem != null)
            {
                EditUser(lbLastName.SelectedItem as User);
            }
        }

        private void EditUser(User user)
        {
            user.FirstName = "Jack-Christian";
            user.LastName = "Elee Fontaine";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
