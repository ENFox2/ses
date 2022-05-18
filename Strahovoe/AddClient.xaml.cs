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

namespace Strahovoe
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Client_Name = nameTB.Text;
            client.Client_FName = fnameTB.Text;
            client.Client_Otchestvo = otchestvoTB.Text;
            client.Client_BDay = dateDP.SelectedDate;
            client.Client_Adres = adresTB.Text;
            client.Client_Passport = pasTB.Text;
            de9Entities1.GetContext().Client.Add(client);
            de9Entities1.GetContext().SaveChanges();
            this.Close();
        }
    }
}
