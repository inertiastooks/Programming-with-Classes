class CardGame{
static void Main(string[] args)
{
    Player player = new Player();
    Card card = new Card();
    Validator validator = new Validator();

    Console.WriteLine("============== Instructions ==============");
    Console.WriteLine($"This is the game of High Low.\nA card will be drawn and you will guess whether the next card is higher or lower");
    Console.WriteLine("If you guess right, you get 100 points, if you guess wrong, you will lose 75.");
    Console.WriteLine("You start with 300. Good Luck!\n");
    
    bool is_playing = true;

    while(is_playing){
        int card1 = card.draw_card(); //Draws the first card
        int card2 = card.draw_card(); //Draws the second Card

        Console.WriteLine($"The card that was drawn is {card1}"); //Shows user what the first card is

        string? high_or_low = validator.validate_players_guess(); //Checks whether the user inputed a valid Response

        Console.WriteLine($"The next card that was drawn is {card2}"); //

        if(high_or_low == "h" || high_or_low == "H"){
            if (card1 < card2){
                player.score = player.score + 100;
                Console.WriteLine($"+100 Pts! Your score is {player.score}");
            }
            else if (card1 > card2){
                player.score = player.score - 75;
                Console.WriteLine($"-75 Pts! Your score is {player.score}");
            }
            else{
                Console.WriteLine($"It was a tie! Your score is still {player.score}");
            }
        }

        else if(high_or_low == "l" || high_or_low == "L"){
            if (card1 > card2){
                player.score = player.score + 100;
                Console.WriteLine($"+100 Pts! Your score is {player.score}");
            }
            else if (card1 < card2){
                player.score = player.score - 75;
                Console.WriteLine($"-75Pts! Your score is {player.score}");
            }
            else{
                player.score = player.score -75;
                Console.WriteLine($"The cards were the same! Which means you were still wrong! -75 Pts! Your score is {player.score}");
            }
        }
        
        string? play_again = validator.validate_play_again();
        if (play_again == "Y" || play_again == "y")
        {
            Console.WriteLine("\n\n---New Game---");
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
            is_playing = false;
        }

    }

}
}