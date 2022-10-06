public class Validator
{
    public string? validate_players_guess()
    {
        bool player_correct_guess = false;
            Console.Write("Higher or Lower?: ");
            string? player_guess = Console.ReadLine();
            if(player_guess != "H" || player_guess != "h" || player_guess != "L" ||player_guess != "l")
            {
                Console.WriteLine("Error! : Please guess 'H' or 'L'!");
                
            }
            else
            {
                player_correct_guess = true;
            }
            
            return player_guess;
        }
    }


}

/*    public string? players_guess(){

        Console.Write("Higher or lower?: ");
        string? player_guess = Console.ReadLine();
        
        return player_guess;

    }*/