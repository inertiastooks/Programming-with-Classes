public class Player
{
    public string players_guess(){

        Console.WriteLine("Please guess a number between 1-13: ");
        string? player_guess = Console.ReadLine();
        return player_guess;

    }
}
