using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Strahovoe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public de9Entities1 db = new de9Entities1();
        public ObservableCollection<Client> client_List;
        public ObservableCollection<Ychet_Polisov> polis_List;
        public MainWindow()
        {
            InitializeComponent();
            client_List = new ObservableCollection<Client>();
            polis_List = new ObservableCollection<Ychet_Polisov>();
            refresh_client();
            refresh_polis();
        }
        public void refresh_client()
        {

            client_List = new ObservableCollection<Client>(de9Entities1.GetContext().Client.ToList());
            ClientList.ItemsSource = client_List;
        }
        public void refresh_polis()
        {
            polis_List = new ObservableCollection<Ychet_Polisov>(de9Entities1.GetContext().Ychet_Polisov.ToList());
            PolisList.ItemsSource = polis_List;
        }

        private void addPolisButton_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.ShowDialog();
            refresh_client();
        }

        private void delPolisButton_Click(object sender, RoutedEventArgs e)
        {
            Client listViewItem = (Client)ClientList.SelectedItem;
            if (listViewItem == null)
            {
                MessageBox.Show("Не выбран элемент для редактирования", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Client client = de9Entities1.GetContext().Client.Find(listViewItem.Client_ID);
                de9Entities1.GetContext().Client.Remove(client);
                de9Entities1.GetContext().SaveChanges();
                refresh_client();
                MessageBox.Show("Объект удален");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var searchWorkers = workers_List.ToList();
            if (textBoxSearchWorkers.Text != "")
            {
                searchWorkers = searchWorkers.Where(p => p.worker_FIO.ToLower().Contains(textBoxSearchWorkers.Text.ToLower())).ToList();
                workersList.ItemsSource = searchWorkers;
            }
            else
            {
                workersList.ItemsSource = workers_List;
            }
        }
    }
}
