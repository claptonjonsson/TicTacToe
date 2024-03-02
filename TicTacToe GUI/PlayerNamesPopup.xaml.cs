using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

namespace TicTacToe_GUI
{
    /// <summary>
    /// Interaction logic for PlayerNamesPopup.xaml
    /// </summary>
    public partial class PlayerNamesPopup : Window
    {
        public PlayerNamesPopup()
        {
            InitializeComponent();
           
        }

        private void nameInputOK(object sender, RoutedEventArgs e)
        {

            HelperStatic.helperPlayerXName = PlayerXBox.Text;
            HelperStatic.helperPlayerOName = PlayerOBox.Text;

            if (HelperStatic.helperPlayerXName == "")
            {
                HelperStatic.helperPlayerXName = "Player X";
            }

            if (HelperStatic.helperPlayerOName == "")
            {
                HelperStatic.helperPlayerOName = "Player O";
            }


            DialogResult = true;
            
        }

    }
}
