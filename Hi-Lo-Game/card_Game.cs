class CardGame{
static void Main(string[] args)
{
    Player player = new Player();
    Card card = new Card();
    int card_1 = card.draw_card();
    int card_2 = card.draw_card();
    Console.WriteLine("============== Instructions ==============");
    Console.WriteLine($"This is the game of High Low.\nA card will be drawn and you will guess whether the next card is higher or lower");
    Console.WriteLine("If you guess right, you get 100 points, if you guess wrong, you will lose 75.");
    Console.WriteLine("You start with 300. Good Luck!");
    Console.WriteLine($"The card that was drawn is {card_1}");
    Console.WriteLine($"Your guess is none");
    Console.WriteLine($"The new that was drawn is {card_2}");


    
    //player.score = player.score - 25;
    Console.WriteLine(player.score);
}





/*
        int score = 300;
        //string? player_guess = player.players_guess();

        if ((player_guess == "h") && (card_1 > card_2))
        {
            Console.WriteLine("Your card is Higher, +100 points");
            int new_score = score + 100; 
            Console.WriteLine($"The new score is {new_score}");
            return new_score;
        } 

        ||
        else if ((player_guess == "l") && (card_1 > card_2))
        {
            Console.WriteLine("New card is Lower, -75 points");
            int new_score = score - 75; 
            Console.WriteLine($"The new score is {new_score}");
            return new_score;
        }

        else return score;
*/



}