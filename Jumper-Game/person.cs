class Person{

    string head;
    string torso;
    string legs;


public Person(){
    head = "   o";
    torso = "  /|\\";
    legs = "  / \\";
}

public void show_person(){
    Console.WriteLine($"{head}\n{torso}\n{legs}"); //Shows the "jumping man".
}

public string lose_head(){
    head = "   x";
    return head;
}
}