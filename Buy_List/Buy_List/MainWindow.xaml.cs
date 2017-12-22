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

namespace Buy_List
{
    using System.Collections.ObjectModel;
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
    
        public MainWindow()
        {
            InitializeComponent();

            this.BuyListItemName.Text = "Ludzu ievadiet pirkumu";
            this.BuyItemsList.Add("aboli");
            this.BuyItemsList.Add("Bumbieri");

            // pasakam BuyItemListControl, ka jaizmanto musu apraksts
           
            this.BuyItemsListControl.ItemsSource = this.BuyItemsList;
        }

        private void AddListItemButton_OnClick(object sender, RoutedEventArgs e)
        {
          string enteredItemToBuy = this.BuyListItemName.Text;
          this.BuyListItemName.Text = " ";

        // ierakstam ieguto vertibu texta bloka
          this.BuyListItemName.add(enteredItemToBuy);
        }

        private void BuyListItemName_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }
    }
}
