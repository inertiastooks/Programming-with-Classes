public class Validator
{
    public string? validate_players_guess()
    //This function will check whether the user inputs a valid response, only accepting upper/lowercase L and H.
    //It also will prompt them to try again if it doesn't recieve the input wanted.
    {

        Console.Write("Higher or Lower?: ");
        string? player_guess = Console.ReadLine();

        bool player_correct_guess = false;
        while(player_correct_guess == false){
            if(player_guess == "H" || player_guess == "h" || player_guess == "L" || player_guess == "l")
            {
                player_correct_guess = true;
            }
            else
            {
                Console.WriteLine("Error! : Please guess 'H' or 'L'!");
                Console.Write("Higher or Lower?: ");
                player_guess = Console.ReadLine();
            }
        }
            
        return player_guess;
    }

    public string? validate_play_again()
    //This function will check whether the user inputs a vaid response to playing again, only accepting upper/lowercase Y/N.
    //It also will prompt them to try again if it  doesn't recieve the input wanted.
    {
        Console.Write("Would you like to play again? Y/N: ");
        string? play_again = Console.ReadLine();

        bool player_correct_response = false;
        while(player_correct_response == false)
        {
            if (play_again == "Y" || play_again == "y" || play_again == "N" || play_again == "n")
            {
                player_correct_response = true;
            }
            else
            {
                Console.WriteLine("Error : Please Choose 'Y' or 'N' to play again or not!");
                Console.Write("Would you like to play again? Y/N: ");
                play_again = Console.ReadLine();
            }
        }
        return play_again;
    }

}