using System;

public static class HelperStatic
{
	public static string helperPlayerXName;
	public static string helperPlayerOName;
	public static int games;
    public static int scorePlayerX;
    public static int scorePlayerO;
    public static bool playAgain; //True as long as program running. Only when player chooses to quit that it turns false.
	public static string checkWin;

    //Reset every new game
    public static string scoreLabel;
    public static int turnCounter;
    public static string activity;
    public static bool currentPlayerIsX;
    public static bool alreadyClicked;
    public static string winMessage;

    //Squares - reset every new game
    public static string squareOne;
    public static string squareTwo;
    public static string squareThree;
    public static string squareFour;
    public static string squareFive;
    public static string squareSix;
    public static string squareSeven;
    public static string squareEight;
    public static string squareNine;

    static HelperStatic()
	{
		helperPlayerXName = null;
		helperPlayerOName = null;
		games = 0;
		winMessage = null;
		playAgain = true;
		checkWin = null;

        scorePlayerX = 0;
        scorePlayerO = 0;
        turnCounter = 0;
        currentPlayerIsX = true;
        alreadyClicked = false;

        squareOne = "1";
        squareTwo = "2";
        squareThree = "3";
        squareFour = "4";
        squareFive = "5";
        squareSix = "6";
        squareSeven = "7";
        squareEight = "8";
        squareNine = "9";

    }
}
