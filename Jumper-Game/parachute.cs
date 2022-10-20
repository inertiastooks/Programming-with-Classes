class Parachute
{   
    Person person = new Person();
    List<string> parachute_body;
    public bool is_alive = true;

public Parachute(){
    string parachute_level_1 = " _____";
    string parachute_level_2 = "/_____\\";
    string parachute_level_3 = "\\     /";
    string parachute_level_4 = " \\   /";

    parachute_body = new List<string> {parachute_level_1, parachute_level_2, parachute_level_3, parachute_level_4};
}



public void show_jumper(){
    foreach (var i in parachute_body)
        Console.WriteLine(i);
        person.show_person();
}

public List<string> break_chute(){
    parachute_body.RemoveAt(0);
    return parachute_body;
}

public void is_jumper_dead(){
    if (parachute_body.Count == 0){
        person.lose_head();
        is_alive = false;
    }
}
}


/*
while game is playing
    if guess is Right
        add letter
    elseif
        breakchute()
        print(breakchute)
    if breakchute is empty
        end game
*/