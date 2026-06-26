
int manticore = 10;
int city = 15;
int round = 1;
bool play = true;

Console.Write("Player 1 how far away from the city do you want to station the Manticore?");
int station = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Player 2, it's your turn.");


while (play)
{

    Console.WriteLine("-----------------------------------------------------------------------");
    Console.WriteLine($"STATUS: Round {round} City: {city}/15 Manticore: {manticore}/10");
    Console.WriteLine($"The cannon is expected to deal {Damage(round)} damage this round");
    Console.Write("Enter desired cannon range: ");
    int range  = Convert.ToInt32(Console.ReadLine());
    if (range > station)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (range == station)
    {
        manticore -= Damage(round);
        Console.WriteLine("That round was a DIRECT HIT.");
    }
    else if (range < station) {

        Console.WriteLine("That round FELL SHORT of the target");
    }
    Console.WriteLine("-------------------------------------------------------------------------");
    if (manticore <= 0) {
        Console.WriteLine("The Manticore has been destroyed! The Cirty of Consolas has been saved");
        play = false;
    }
    if (city <= 0) { 
           play = false; 
   }

    city--;
    round++;


}


int Damage(int roundNumber) {

    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
    {

        return 10;
    }
    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
    {

        return 3;

    }
    else {
        return 1;
    }

}


