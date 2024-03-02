using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    /// Interaction logic for WinPopup.xaml
    /// </summary>
    public partial class WinPopup : Window
    {
        public GameLogic GameLogicWinPopup { get; set; }
        public WinPopup()
        {
            InitializeComponent();

            GameLogic GameLogicWinPopup = new GameLogic();
            this.DataContext = GameLogicWinPopup;
            GameLogicWinPopup.WinMessage = HelperStatic.winMessage;
            
        }

        private void buttonPlayAgain(object sender, RoutedEventArgs e)
        {

            HelperStatic.playAgain = true;

            DialogResult = true;

        }

        private void buttonQuit(object sender, RoutedEventArgs e)
        {

            HelperStatic.playAgain = false;

            DialogResult = true;

        }

        private void buttonExportStandings(object sender, RoutedEventArgs e)
        {

            // Configure save file dialog box
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.FileName = "TicTacToe standings"; // Default file name
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            bool? result = dialog.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dialog.FileName;
                DateTime currentDateTime = DateTime.Now;
                string text = $"TIC TAC TOE by Clapton Jonsson\n\n\nSTANDINGS @ {currentDateTime}\n\n\n\n\n" +
                    $"{HelperStatic.helperPlayerXName} --- {HelperStatic.scorePlayerX.ToString()} WIN(S)\n\n" +
                    $"VS\n\n" +
                    $"{HelperStatic.helperPlayerOName} --- {HelperStatic.scorePlayerO.ToString()} WIN(S)\n\n";
                File.WriteAllText(filename, text);
            }


        }
    }
}
