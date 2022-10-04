public class Card
{
        public int draw_card()
        {
            Random rd = new Random();
            int random_card = rd.Next(1,10);
            return random_card;
        }
}