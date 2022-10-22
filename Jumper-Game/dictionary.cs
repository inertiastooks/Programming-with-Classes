public class Dictionary{

    private List<string> words_List;
    private List<char> word;
    private string chosen_word;
        
public Dictionary()
{
    this.words_List = new List<string>();   //List for the words in the words.txt file
    this.word = new List<char>();           //List of characters for the chosen word from words.txt file
    this.chosen_word = "";                  //had to declare.
    string words_file = "words.txt";        // assigns the txt file where the words are being taken from 
    words_List = File.ReadLines(words_file).ToList(); // 
}


//creates the "_" depending on how many characters in chosen word. To use right before the parachute writeline.
private void Random_Word(){ 
    Random random = new Random();
    this.chosen_word = words_List[random.Next(0, words_List.Count)];
    foreach (char c in this.chosen_word) 
    {
        word.Add('_');
    }
}

// this will count the ammount of letters in the random word, use to check how many attempts left before finishing game.
public int Count_Letters(){
    int letter_qty = word.Count;
    return letter_qty;
}

// bool to finish game if no attempts to guess the word are left.
public bool End_Game(){
    for(int i = 0; i < word.Count; i++)
    {
        if(word[i] != chosen_word[i])
        {
            return false;
        }
    }
    return true;
}
    

}
