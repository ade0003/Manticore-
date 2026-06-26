
//int manticore = 10;
//int city = 15;
//int round = 1;
//bool play = true;

//Console.Write("Player 1 how far away from the city do you want to station the Manticore?");
//int station = Convert.ToInt32(Console.ReadLine());
//Console.Clear();
//Console.WriteLine("Player 2, it's your turn.");


//while (play)
//{

//    Console.WriteLine("-----------------------------------------------------------------------");
//    Console.WriteLine($"STATUS: Round {round} City: {city}/15 Manticore: {manticore}/10");
//    Console.WriteLine($"The cannon is expected to deal {Damage(round)} damage this round");
//    Console.Write("Enter desired cannon range: ");
//    int range  = Convert.ToInt32(Console.ReadLine());
//    if (range > station)
//    {
//        Console.WriteLine("That round OVERSHOT the target.");
//    }
//    else if (range == station)
//    {
//        manticore -= Damage(round);
//        Console.WriteLine("That round was a DIRECT HIT.");
//    }
//    else if (range < station) {

//        Console.WriteLine("That round FELL SHORT of the target");
//    }
//    Console.WriteLine("-------------------------------------------------------------------------");
//    if (manticore <= 0) {
//        Console.WriteLine("The Manticore has been destroyed! The Cirty of Consolas has been saved");
//        play = false;
//    }
//    if (city <= 0) { 
//           play = false; 
//   }

//    city--;
//    round++;


//}


//int Damage(int roundNumber) {

//    if (roundNumber % 3 == 0 && roundNumber % 5 == 0)
//    {

//        return 10;
//    }
//    else if (roundNumber % 3 == 0 || roundNumber % 5 == 0)
//    {

//        return 3;

//    }
//    else {
//        return 1;
//    }

//}

//Status currentStatus = Status.locked;

//while (true) {

//    Console.Write($"the chest is {currentStatus}, what would you like to do? " );
//    string action  = Console.ReadLine();

//    if (currentStatus == Status.locked && action == "unlock")
//    {

//        currentStatus = Status.closed;
//    }
//    else if (currentStatus == Status.closed)
//    {

//        if (action == "open")
//        {

//            currentStatus = Status.open;
//        }
//        else if (action == "lock")
//        {
//            currentStatus = Status.locked;
//        }
//        else
//        {

//            Console.WriteLine("Invalid Action");
//        }
//    }
//    else if (currentStatus == Status.open && action == "close")
//    {

//        currentStatus = Status.closed;

//    }

//    else {

//        Console.WriteLine("Invalid action");
//            }

//}


//enum Status { 



//open, 
//closed, 
//locked

//}

//int countDown(int number)
//{

//    Console.WriteLine(number);

//    if (number == 0) { 
//    return 0;
//}
//    else 
//    { 
//        return countDown(number - 1); }

//}
//countDown(10);


(string Name, int Points, int Level)[] highScores = { 

    (Name: "R2-D2", Points: 12420, Level: 15), 
    ("C-3P0", 8543, 9), 
    ("GONK", -1,1) };