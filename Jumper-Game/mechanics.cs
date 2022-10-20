//DISPLAY
//ALL MECHANICS

class Mechanics{
static void Main(string[] args){

    Parachute parachute = new Parachute();
    while (parachute.is_alive == true){
        parachute.show_jumper();
        //parachute.break_chute();
        //parachute.print_chute();

        Console.Write("Guess a letter (a-z): ");
        string? answer = Console.ReadLine();
        parachute.is_jumper_dead();

        if(answer == "lose"){
            parachute.break_chute();
            parachute.is_jumper_dead();
        }

        else{
            parachute.is_jumper_dead();
        }

    } // end of loop
    parachute.show_jumper();
    Console.WriteLine("Game Over, He's dead");


}
}
