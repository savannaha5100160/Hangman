using Android.Net;

namespace HangmanAssignment
{
	public partial class HangmanGamePage : ContentPage
	{
		private HangMan _hangmanGame;

		public HangmanGamePage()
		{
			InitializeComponent();
			_hangmanGame = new HangMan();
			InitializeGame();
		}

		private void InitializeGame()
		{
			_hangmanGame = new HangMan();
	
		}

		private void OnGuessButtonClicked(object sender, EventArgs e)
        {


			if (_hangmanGame.GuessedLetter ) 
			{
               
				if (_hangmanGame.IsWin())
				{
					DisplayAlert("Congratulations!", "You`ve won!", "OK");
					InitializeGame();
				}
			}
			else
			{
				if (_hangmanGame.isGameOver())
				{
					DisplayAlert("Game Over", $"The word was:{_hangmanGame.GetWord()}", "OK");
					InitializeGame();
				}
			}
			
		}
		
	}	
}

   

