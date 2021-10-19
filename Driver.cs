using System;

//Next: User input
namespace workout_app
{
    class Driver
    {
        static void Main()
        {
            Workout temp = new Workout();
            String userIn = "";

            Console.WriteLine("Hello, please select a function...");
            Console.WriteLine("   1. Print all workouts\n   2. Set a rep count.\n   3. Exit");
            do {
                    userIn = Console.ReadLine();
                        if(userIn == "1") { temp.printWorkouts(); Console.WriteLine(); }
                        else if (userIn == "2") { Console.WriteLine("To be implemented\n"); }
                        else if (userIn == "3") Console.WriteLine("Enjoy the workout!\n");
                        else Console.WriteLine("That is not a valid input, try again.\n");    
            } while(userIn != "3");
        }
    }
}
 /**
             Workout pushups = new Workout ("Push-ups", "Back", 24);
             Workout situps = new Workout ("Sit-ups", "Abs", 17);
             Workout curls = new Workout ("Curls", "Biceps", 26);
             Workout pullups = new Workout ("Pull-ups", "Shoulders", 19);
             Workout diamonds = new Workout ("Diamonds", "Triceps", 15);
             Workout squats = new Workout ("Squats", "Legs", 14);
             Workout burndown = new Workout ("Shoulder-press", "Shoulders", 27);

                //Console.WriteLine(curls.ToString());
                recordData(pushups);
                recordData(situps);
                recordData(curls);
                recordData(pullups);
                recordData(diamonds);
                recordData(squats);
                recordData(burndown);
                **/
