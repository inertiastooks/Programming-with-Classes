class CardGame{
static void Main(string[] args)
{
    Card card = new Card();
    Player player = new Player();

    Console.WriteLine($"The card that was drawn is {card.draw_card()}");

    Console.WriteLine($"Your guess is {player.players_guess()}");

}











}