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
    using System.IO; // lauj manipulet failus
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly object BuyListItemName;
        public ObservableCollection<string> BuyItemsList = new ObservableCollection<string>();
    
        public MainWindow()
        {
            

            this.BuyListItemName.Text = "Ludzu ievadiet pirkumu";
            this.BuyItemsList.Add("aboli");
            this.BuyItemsList.Add("Bumbieri");

            // pasakam BuyItemListControl, ka jaizmanto musu apraksts
           
            this.BuyItemsListControl.ItemsSource = this.BuyItemsList;
        }

        private void AddListItemButton_OnClick(object sender, RoutedEventArgs e)
        {
          string enteredItemToBuy = this.BuyListItemName.Text;
            BuyListItemName.Text = "";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            File.WriteAllLines(@"C:\Users\oleg\Desktop\Programeshana\Kalinuskins_R\mans_fails.txt", this.BuyItemsList);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var todosFromFile = File.ReadAllLines(@"C:\Users\oleg\Desktop\Programeshana\Kalinuskins_R\mans_fails.txt");
            for (int i = 0; i < todosFromFile.Length; i++)
            {
                var currentTodo = todosFromFile[i];
                this.BuyItemsList.Add(currentTodo);
            }

            MessageBox.Show("all items have been loaded");
        }

        private void BuyItemsListControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = this.BuyItemsListControl.SelectedItems[0] as string;
            // paraksta kodu
            this.BuyItemsList.Remove(selectedItem);
        }


        private void BuyListItemName_OnKeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
