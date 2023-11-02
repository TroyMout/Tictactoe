using System.Diagnostics.Metrics;
// Name: Troy Mouton.
// Date: 2023-10-11.
// Description: Create a form that allows 2 users to play tiktaktoe.

namespace Assignment2
{

    public partial class Form1 : Form
    {
        // Initialize global variables for round counter, player points, and round winner.
        int roundCounter = 0;
        int player1points = 0;
        int player2points = 0;
        string roundWinner = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // Runs ResetForm() function on form load.
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Resets form completely.
        private void ResetForm()
        {
            Button[] tiktaktoeButtons = {buttonTopLeft, buttonTopCenter, buttonTopRight, buttonCenterLeft,
            buttonCenter, buttonCenterRight, buttonBottomLeft, buttonBottomCenter, buttonBottomRight};

            // This loop disables all game buttons and removes player symbols.
            for (int i = 0; i < tiktaktoeButtons.Length; i++)
            {
                tiktaktoeButtons[i].Text = string.Empty;
                tiktaktoeButtons[i].Enabled = false;
            }

            // Empties all text boxes.
            textBoxName1.Text = string.Empty;
            textBoxName2.Text = string.Empty;
            textBoxSymbol1.Text = string.Empty;
            textBoxSymbol2.Text = string.Empty;
            textBoxNextTurn.Text = string.Empty;
            textBoxWinner.Text = string.Empty;
            textBoxStats.Text = string.Empty;

            // Resets start and continue buttons.
            buttonContinue.Enabled = false;
            buttonStart.Enabled = true;

            // Enables all Game Setup text boxes.
            textBoxName1.Enabled = true;
            textBoxName2.Enabled = true;
            textBoxSymbol1.Enabled = true;
            textBoxSymbol2.Enabled = true;

            // Empties round winner text box.
            roundWinner = string.Empty;

            // Resets round counter.
            roundCounter = 0;

        }

        // This function resets the game area group-box.
        private void resetGameArea()
        {
            // Resets all variables and text boxes to their default states post start press.
            enableGameButtons();
            roundWinner = string.Empty;
            roundCounter = 0;
            textBoxWinner.Text = string.Empty;
            textBoxNextTurn.Text = textBoxName2.Text;

            // loop that enables all game buttons.
            Button[] buttonArray = {buttonTopLeft, buttonTopCenter, buttonTopRight, buttonCenterLeft,
                buttonCenter, buttonCenterRight, buttonBottomLeft, buttonBottomCenter, buttonBottomRight};

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Text = string.Empty;
            }
        }

        private void WinnerCheck()
        {
            // Sets playerSymbol variables as related text box data.
            string player1Symbol = textBoxSymbol1.Text;
            string player2Symbol = textBoxSymbol2.Text;

            // Initializes 2d array of tiktaktoe buttons
            Button[,] tiktaktoeButtons = new Button[3, 3];
            tiktaktoeButtons[0, 0] = buttonTopLeft;
            tiktaktoeButtons[0, 1] = buttonTopCenter;
            tiktaktoeButtons[0, 2] = buttonTopRight;
            tiktaktoeButtons[1, 0] = buttonCenterLeft;
            tiktaktoeButtons[1, 1] = buttonCenter;
            tiktaktoeButtons[1, 2] = buttonCenterRight;
            tiktaktoeButtons[2, 0] = buttonBottomLeft;
            tiktaktoeButtons[2, 1] = buttonBottomCenter;
            tiktaktoeButtons[2, 2] = buttonBottomRight;

            // Loop that checks rows for winner.
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (tiktaktoeButtons[row, column].Text == player1Symbol)
                    {
                        // Increases point and checks for win in row.
                        player1points++;
                        if (player1points == 3)
                        {
                            roundWinner = textBoxName1.Text;
                        }
                    }
                    if (tiktaktoeButtons[row, column].Text == player2Symbol)
                    {
                        // Increases point and checks for win in row.
                        player2points++;
                        if (player2points == 3)
                        {
                            roundWinner = textBoxName2.Text;
                        }
                    }
                }
                // Resets counter after row is checked.
                player1points = 0;
                player2points = 0;

            }

            // Loop that checks columns for winner.
            for (int column = 0; column < 3; column++)
            {
                for (int row = 0; row < 3; row++)
                {
                    if (tiktaktoeButtons[row, column].Text == player1Symbol)
                    {
                        player1points++;
                        if (player1points == 3)
                        {
                            roundWinner = textBoxName1.Text;
                        }
                    }
                    if (tiktaktoeButtons[row, column].Text == player2Symbol)
                    {
                        player2points++;
                        if (player2points == 3)
                        {
                            roundWinner = textBoxName2.Text;
                        }
                    }
                }
                // Resets counter after column is checked.
                player1points = 0;
                player2points = 0;


            }

            // Hardcoded calculation of diagonal win conditions for player 1.
            if (tiktaktoeButtons[0, 0].Text == player1Symbol && tiktaktoeButtons[1, 1].Text == player1Symbol &&
                tiktaktoeButtons[2, 2].Text == player1Symbol)
            {
                roundWinner = textBoxName1.Text;
            }
            else if (tiktaktoeButtons[0, 2].Text == player1Symbol && tiktaktoeButtons[1, 1].Text == player1Symbol &&
                tiktaktoeButtons[2, 0].Text == player1Symbol)
            {
                roundWinner = textBoxName1.Text;
            }

            // Hardcoded calculation of diagonal win conditions for player 2.
            if (tiktaktoeButtons[0, 0].Text == player2Symbol && tiktaktoeButtons[1, 1].Text == player2Symbol &&
                tiktaktoeButtons[2, 2].Text == player2Symbol)
            {
                roundWinner = textBoxName2.Text;
            }
            else if (tiktaktoeButtons[0, 2].Text == player2Symbol && tiktaktoeButtons[1, 1].Text == player2Symbol &&
                tiktaktoeButtons[2, 0].Text == player2Symbol)
            {
                roundWinner = textBoxName2.Text;
            }

            // Declares round winner variable as whatever is in the winner text box
            textBoxWinner.Text = roundWinner;

            // Checks whether Round end condition is tie or draw and sends result to Stats Text Box
            if (textBoxWinner.Text != string.Empty)
            {
                disableGameButtons();
                buttonContinue.Enabled = true;
                textBoxStats.AppendText("Winner: " + roundWinner + "\r\n");
            }
            else if (roundCounter == 9 && textBoxWinner.Text == string.Empty)
            {
                disableGameButtons();
                buttonContinue.Enabled = true;
                textBoxStats.AppendText("Draw");
            }

            // Resets player points so future rounds don't automatically default the winner to the first round winner
            player1points = 0;
            player2points = 0;

        }

        // This function runs a loop that enables all tiktaktoe buttons.
        private void enableGameButtons()
        {
            Button[] buttonArray = {buttonTopLeft, buttonTopCenter, buttonTopRight, buttonCenterLeft,
                buttonCenter, buttonCenterRight, buttonBottomLeft, buttonBottomCenter, buttonBottomRight};

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = true;
            }
        }

        // This function runs a loop that disables all tiktaktoe buttons.
        private void disableGameButtons()
        {
            Button[] buttonArray = {buttonTopLeft, buttonTopCenter, buttonTopRight, buttonCenterLeft,
                buttonCenter, buttonCenterRight, buttonBottomLeft, buttonBottomCenter, buttonBottomRight};

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i].Enabled = false;
            }
        }

        // This function runs whenever a tiktaktoe button is clicked.
        private void gameButtonClick(Button sender)
        {
            // Checks who the next player is and sets the clicked button to the opposite player's symbol.
            if (textBoxNextTurn.Text == textBoxName1.Text)
            {
                // Makes the text of the button clicked the symbol of the current player.
                sender.Text = textBoxSymbol2.Text;
                textBoxNextTurn.Text = textBoxName2.Text;
                sender.Enabled = false;
            }
            else
            {
                // Makes the text of the button clicked the symbol of the current player.
                sender.Text = textBoxSymbol1.Text;
                textBoxNextTurn.Text = textBoxName1.Text;
                sender.Enabled = false;
            }

            roundCounter++;

        }

        // This function validates that all player information is valid.
        private Boolean PlayerValidation(string name1, string name2, string symbol1, string symbol2)
        {
            // Validates that name text boxes aren't empty.
            if (textBoxName1.Text != string.Empty && textBoxName2.Text != string.Empty)
            {
                // Validates that name text boxes don't have the same data.
                if (textBoxName1.Text != textBoxName2.Text)
                {
                    // Validates that symbol text boxes aren't empty.
                    if (textBoxSymbol1.Text != string.Empty && textBoxSymbol2.Text != string.Empty)
                    {
                        // Validates that symbol text boxes don't have the same data.
                        if (textBoxSymbol1.Text != textBoxSymbol2.Text)
                        {
                            // Only returns true if all validations pass.
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            resetGameArea();
            buttonContinue.Enabled = false;
        }

        // Sets gamestate to play mode (All text boxes in the Game setup group-box are disabled, the tik tak toe
        // buttons are enabled, and the first player is allowed to click a box).
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Set name and symbol variables from text boxes
            string name1 = textBoxName1.Text;
            string name2 = textBoxName2.Text;
            string symbol1 = textBoxSymbol1.Text;
            string symbol2 = textBoxSymbol2.Text;

            /* Runs names and symbols through the validation function and enables play mode if the function returns
               true.
             */
            if (PlayerValidation(name1, name2, symbol1, symbol2))
            {
                textBoxName1.Enabled = false;
                textBoxName2.Enabled = false;
                textBoxSymbol1.Enabled = false;
                textBoxSymbol2.Enabled = false;
                buttonStart.Enabled = false;
                textBoxNextTurn.Text = textBoxName2.Text;

                // Enables play mode.
                enableGameButtons();

            }
        }

        private void buttonTopLeft_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonTopCenter_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonTopRight_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonCenterLeft_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonCenterRight_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonBottomLeft_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonBottomCenter_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

        private void buttonBottomRight_Click(object sender, EventArgs e)
        {
            gameButtonClick((Button)sender);
            WinnerCheck();
        }

    }
}