using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Documents;

namespace TicTacToe_GUI
{
    public class GameLogic : INotifyPropertyChanged
    {
        public GameLogic GameLogicMain { get; set; }
        
        private string playerXName;
        private string playerOName;
        private string scoreLabel;
        private int scorePlayerX;
        private int scorePlayerO;
        private int turnCounter;
        private string activity;
        private bool currentPlayerIsX;
        private bool alreadyClicked;
        private string winMessage;

        //Square properties
        private string squareOne;
        private string squareTwo;
        private string squareThree;
        private string squareFour;
        private string squareFive;
        private string squareSix;
        private string squareSeven;
        private string squareEight;
        private string squareNine;

        public GameLogic()
        {
            this.playerXName = HelperStatic.helperPlayerXName;
            this.playerOName = HelperStatic.helperPlayerOName;
            this.scorePlayerX = HelperStatic.scorePlayerX;
            this.scorePlayerO = HelperStatic.scorePlayerO;
            this.turnCounter = HelperStatic.turnCounter;
            this.currentPlayerIsX = HelperStatic.currentPlayerIsX;
            this.alreadyClicked = HelperStatic.alreadyClicked;

            //Squares
            this.squareOne = HelperStatic.squareOne;
            this.squareTwo = HelperStatic.squareTwo;
            this.squareThree = HelperStatic.squareThree;
            this.squareFour = HelperStatic.squareFour;
            this.squareFive = HelperStatic.squareFive;
            this.squareSix = HelperStatic.squareSix;
            this.squareSeven = HelperStatic.squareSeven;
            this.squareEight = HelperStatic.squareEight;
            this.squareNine = HelperStatic.squareNine;

        }

        // GETTERS & SETTERS

        //Squares
        public string SquareOne { get { return squareOne; } set { squareOne = value; HelperStatic.squareOne = value; OnPropertyChanged("SquareOne"); } }
        public string SquareTwo { get { return squareTwo; } set { squareTwo = value; HelperStatic.squareTwo = value; OnPropertyChanged("SquareTwo"); } }
        public string SquareThree { get { return squareThree; } set { squareThree = value; HelperStatic.squareThree = value; OnPropertyChanged("SquareThree"); } }
        public string SquareFour { get { return squareFour; } set { squareFour = value; HelperStatic.squareFour = value; OnPropertyChanged("SquareFour"); } }
        public string SquareFive { get { return squareFive; } set { squareFive = value; HelperStatic.squareFive = value; OnPropertyChanged("SquareFive"); } }
        public string SquareSix { get { return squareSix; } set { squareSix = value; HelperStatic.squareSix = value; OnPropertyChanged("SquareSix"); } }
        public string SquareSeven { get { return squareSeven; } set { squareSeven = value; HelperStatic.squareSeven = value; OnPropertyChanged("SquareSeven"); } }
        public string SquareEight { get { return squareEight; } set { squareEight = value; HelperStatic.squareEight = value; OnPropertyChanged("SquareEight"); } }
        public string SquareNine { get { return squareNine; } set { squareNine = value; HelperStatic.squareNine = value; OnPropertyChanged("SquareNine"); } }

        // Score Label properties
        public string PlayerXName 
        { 
            get { return playerXName; } 
            set 
            { 
                playerXName = value;
                HelperStatic.helperPlayerXName = value;
                OnPropertyChanged("PlayerXName");
            } 
        }
        public string PlayerOName 
        { 
            get { return playerOName; } 
            set 
            { 
                playerOName = value;
                HelperStatic.helperPlayerOName = value;
                OnPropertyChanged("PlayerOName");
            } 
        }

        public int ScorePlayerX 
        { get { return scorePlayerX; } set { scorePlayerX = value; HelperStatic.scorePlayerX = value; } }

        public int ScorePlayerO
        { get { return scorePlayerO; } set { scorePlayerO = value; HelperStatic.scorePlayerO = value; } }

        public string ScoreLabel
        {
            get { return scoreLabel; }
            set
            {
                scoreLabel = value;
                HelperStatic.scoreLabel = value;
                OnPropertyChanged("ScoreLabel");
            }
        }

        // Turn counter & Activity & Current player & Already clicked & Current winner

        public int TurnCounter { get { return turnCounter; } set { turnCounter = value; HelperStatic.turnCounter = value; OnPropertyChanged("TurnCounter"); } }

        public string Activity { get { return activity; } set { activity = value; HelperStatic.activity = value; OnPropertyChanged("Activity"); } }

        public bool CurrentPlayerIsX { get { return currentPlayerIsX; } set { currentPlayerIsX = value; HelperStatic.currentPlayerIsX = value; } }
        public bool AlreadyClicked { get { return alreadyClicked; } set { alreadyClicked = value; HelperStatic.alreadyClicked = value; } }

        public string WinMessage { get { return winMessage; } set { winMessage = value; HelperStatic.winMessage = value; OnPropertyChanged("WinMessage"); } }


        //PROPERTY CHANGED EVENT HANDLER

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) 
            { 
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            } else { Console.WriteLine("propertychanged is null"); }
        }

        // METHODS

        public void ZeroingGame ()
        {
            this.TurnCounter = 0; HelperStatic.turnCounter = 0;
            this.Activity = null; HelperStatic.activity = null;
            this.CurrentPlayerIsX = true; HelperStatic.currentPlayerIsX = true;
            this.AlreadyClicked = false; HelperStatic.alreadyClicked = false;
            this.WinMessage = null; HelperStatic.winMessage = null;

            this.SquareOne = "1"; HelperStatic.squareOne = "1";
            this.SquareTwo = "2"; HelperStatic.squareTwo = "2";
            this.SquareThree = "3"; HelperStatic.squareThree = "3";
            this.SquareFour = "4"; HelperStatic.squareFour = "4";
            this.SquareFive = "5"; HelperStatic.squareFive = "5";
            this.SquareSix = "6"; HelperStatic.squareSix = "6";
            this.SquareSeven = "7"; HelperStatic.squareSeven = "7";
            this.SquareEight = "8"; HelperStatic.squareEight = "8";
            this.SquareNine = "9"; HelperStatic.squareNine = "9";
    }

        public void SquareButtonClick(int squareNum)
        {
            switch(squareNum)
            {
                case 1:
                    if (this.CurrentPlayerIsX)
                    {
                        if(this.SquareOne == "1")
                        {
                            this.SquareOne = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square one.";
                            Thread.Sleep (1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        } 
                        else 
                        { 
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square."; 
                        }
                    }
                    else
                    {
                        if (this.SquareOne == "1")
                        {
                            this.SquareOne = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square one.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 2:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareTwo == "2")
                        {
                            this.SquareTwo = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square two.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareTwo == "2")
                        {
                            this.SquareTwo = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square two.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 3:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareThree == "3")
                        {
                            this.SquareThree = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square three.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareThree == "3")
                        {
                            this.SquareThree = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square three.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 4:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareFour == "4")
                        {
                            this.SquareFour = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square three.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareFour == "4")
                        {
                            this.SquareFour = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square three.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 5:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareFive == "5")
                        {
                            this.SquareFive = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square five.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareFive == "5")
                        {
                            this.SquareFive = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square five.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 6:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareSix == "6")
                        {
                            this.SquareSix = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square six.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareSix == "6")
                        {
                            this.SquareSix = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square six.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 7:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareSeven == "7")
                        {
                            this.SquareSeven = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square seven.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareSeven == "7")
                        {
                            this.SquareSeven = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square seven.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 8:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareEight == "8")
                        {
                            this.SquareEight = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square eight.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareEight == "8")
                        {
                            this.SquareEight = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square eight.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;

                case 9:
                    if (this.CurrentPlayerIsX)
                    {
                        if (this.SquareNine == "9")
                        {
                            this.SquareNine = "X";
                            this.Activity = $"{this.PlayerXName} clicked on square nine.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = false;
                            this.Activity = $"Now it's {this.PlayerOName}'s turn.\nClick on a square not already taken.";
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerXName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    else
                    {
                        if (this.SquareNine == "9")
                        {
                            this.SquareNine = "O";
                            this.Activity = $"{this.PlayerOName} clicked on square nine.";
                            Thread.Sleep(1000);
                            HelperStatic.checkWin = this.CheckWinConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            HelperStatic.checkWin = this.CheckDrawConditions();
                            if (HelperStatic.checkWin == "playagain" || HelperStatic.checkWin == "quit") { return; }
                            this.CurrentPlayerIsX = true;
                            this.Activity = $"Now it's {this.PlayerXName}'s turn.\nClick on a square not already taken.";
                            this.TurnCounter++;
                        }
                        else
                        {
                            this.Activity = $"{this.PlayerOName}: You cannot click a square already taken. Click on another square.";
                        }
                    }
                    break;
            }
        }

        public string CheckWinConditions()
        {
            if (
                    (this.SquareOne == "X" && this.SquareTwo == "X" && this.SquareThree == "X") ||
                    (this.SquareOne == "X" && this.SquareFour == "X" && this.SquareSeven == "X") ||
                    (this.SquareOne == "X" && this.SquareFive == "X" && this.SquareNine == "X") ||
                    (this.SquareTwo == "X" && this.SquareFive == "X" && this.SquareEight == "X") ||
                    (this.SquareThree == "X" && this.SquareFive == "X" && this.SquareSeven == "X") ||
                    (this.SquareThree == "X" && this.SquareSix == "X" && this.SquareNine == "X") ||
                    (this.SquareFour == "X" && this.SquareFive == "X" && this.SquareSix == "X") ||
                    (this.SquareSeven == "X" && this.SquareEight == "X" && this.SquareNine == "X")
                )
            {
                //Player X won!
                this.ScorePlayerX++;
                this.Activity = $"{this.PlayerXName} won!";
                this.WinMessage = $"{this.PlayerXName} with {this.ScorePlayerX.ToString()} win(s)\nVS\n{this.PlayerOName} with {this.ScorePlayerO.ToString()} win(s)";
                

                //Popup asking if you want to play again, export score table, or quit game.
                WinPopup winPopup = new WinPopup();
                winPopup.ShowDialog();

                if (HelperStatic.playAgain == true)
                {
                    return "playagain";
                }
                else
                {
                    return "quit";
                }

            }

            if (
                    (this.SquareOne == "O" && this.SquareTwo == "O" && this.SquareThree == "O") ||
                    (this.SquareOne == "O" && this.SquareFour == "O" && this.SquareSeven == "O") ||
                    (this.SquareOne == "O" && this.SquareFive == "O" && this.SquareNine == "O") ||
                    (this.SquareTwo == "O" && this.SquareFive == "O" && this.SquareEight == "O") ||
                    (this.SquareThree == "O" && this.SquareFive == "O" && this.SquareSeven == "O") ||
                    (this.SquareThree == "O" && this.SquareSix == "O" && this.SquareNine == "O") ||
                    (this.SquareFour == "O" && this.SquareFive == "O" && this.SquareSix == "O") ||
                    (this.SquareSeven == "O" && this.SquareEight == "O" && this.SquareNine == "O")
                )
            {
                //Player O won!
                this.ScorePlayerO++;
                this.Activity = $"{this.PlayerOName} won!";
                this.WinMessage = $"{this.PlayerXName} with {this.ScorePlayerX.ToString()} win(s)\nVS\n{this.PlayerOName} with {this.ScorePlayerO.ToString()} win(s)";

                //Popup asking if you want to play again, export score table, or quit game.
                WinPopup winPopup = new WinPopup();
                winPopup.ShowDialog();

                if (HelperStatic.playAgain == true)
                {
                    return "playagain";
                }
                else
                {
                    return "quit";
                }
            } else { return null; }
        }

        public string CheckDrawConditions()
        {
            if (
                this.SquareOne != "1" && this.SquareTwo != "2" && this.SquareThree != "3" && this.SquareFour != "4" && this.SquareFive != "5" 
                && this.SquareSix != "6" && this.SquareSeven != "7" && this.SquareEight != "8" && this.SquareNine != "9"
               )
            {
                this.Activity = "It's a draw!";
                this.WinMessage = $"{this.PlayerXName} with {this.ScorePlayerX.ToString()} win(s)\nVS\n{this.PlayerOName} with {this.ScorePlayerO.ToString()} win(s)";

                //Popup asking if you want to play again, export score table, or quit game.
                WinPopup winPopup = new WinPopup();
                winPopup.ShowDialog();

                if (HelperStatic.playAgain == true)
                {
                    return "playagain";
                }
                else
                {
                    return "quit";
                }
            }
            else { return null; }
        }
        
    }
}
