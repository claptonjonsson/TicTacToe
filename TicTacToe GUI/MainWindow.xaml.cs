using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Initialization(); //Runs only at startup in case "player names" dialog is closed via the X button.

            PlayerNamesPopup playerNamesPopup = new PlayerNamesPopup();
            playerNamesPopup.ShowDialog();

            StartGame();

        }

        //METHODS

        public void Initialization()
        {
            GameLogic InitialGameLogic = new GameLogic();
            this.DataContext = InitialGameLogic;

            InitialGameLogic.PlayerXName = "Player X";
            InitialGameLogic.PlayerOName = "Player O";

            InitialGameLogic.SquareOne = "1"; HelperStatic.squareOne = "1";
            InitialGameLogic.SquareTwo = "2"; HelperStatic.squareTwo = "2";
            InitialGameLogic.SquareThree = "3"; HelperStatic.squareThree = "3";
            InitialGameLogic.SquareFour = "4"; HelperStatic.squareFour = "4";
            InitialGameLogic.SquareFive = "5"; HelperStatic.squareFive = "5";
            InitialGameLogic.SquareSix = "6"; HelperStatic.squareSix = "6";
            InitialGameLogic.SquareSeven = "7"; HelperStatic.squareSeven = "7";
            InitialGameLogic.SquareEight = "8"; HelperStatic.squareEight = "8";
            InitialGameLogic.SquareNine = "9"; HelperStatic.squareNine = "9";

        }
        public void StartGame()
        {
            if (HelperStatic.helperPlayerXName != null && HelperStatic.helperPlayerOName != null)
            {
                GameLogic GameLogicMain = new GameLogic();
                this.DataContext = GameLogicMain;
                GameLogicMain.ZeroingGame();
                GameLogicMain.PlayerXName = HelperStatic.helperPlayerXName;
                GameLogicMain.PlayerOName = HelperStatic.helperPlayerOName;
                GameLogicMain.ScoreLabel = $"{GameLogicMain.PlayerXName} {GameLogicMain.ScorePlayerX.ToString()} | {GameLogicMain.ScorePlayerO.ToString()} {GameLogicMain.PlayerOName}";
                GameLogicMain.TurnCounter = +1;
                GameLogicMain.Activity = $"It's {GameLogicMain.PlayerXName}'s turn. \nClick a square that is not already taken.";
            }
        }

        //Square buttons
        private void SquareOneButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;
            
            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";
            
            GameLogicSquare.SquareButtonClick(1);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareTwoButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;
            
            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(2);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareThreeButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(3);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareFourButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(4);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareFiveButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(5);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareSixButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(6);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareSevenButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(7);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareEightButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(8);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

        private void SquareNineButton(object sender, RoutedEventArgs e)
        {
            GameLogic GameLogicSquare = new GameLogic();
            this.DataContext = GameLogicSquare;

            GameLogicSquare.ScoreLabel = $"{GameLogicSquare.PlayerXName} {GameLogicSquare.ScorePlayerX.ToString()} | {GameLogicSquare.ScorePlayerO.ToString()} {GameLogicSquare.PlayerOName}";

            GameLogicSquare.SquareButtonClick(9);

            if (HelperStatic.checkWin == "playagain")
            {
                HelperStatic.checkWin = null;
                StartGame();
            }
            else if (HelperStatic.checkWin == "quit")
            {
                HelperStatic.checkWin = null;
                Application.Current.Shutdown();
            }
        }

    }
}