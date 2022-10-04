
public class Player
{
    public int players_guess(){

        Console.WriteLine("Please guess a number between 1-13: ");
        string? player_guess_string = Console.ReadLine();

        int player_guess = Convert.ToInt32(player_guess_string);

        return player_guess;

    }
}
