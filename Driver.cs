using System;
using System.IO;

//Next: User input
namespace workout_app
{
    class Driver
    {
        static void Main(string[] args)
        {
            Workout temp = new Workout();
            String userIn, line, newReps;
            StreamReader file = new("Workout_Data.txt");

            Console.WriteLine("Hello, please select a function...");
            Console.WriteLine("   1. Print all workouts\n   2. Set a rep count.\n   3. Add a new workout\n   0. Exit");
            do {
                    userIn = Console.ReadLine();
                        if(userIn == "1") { temp.printWorkouts(); Console.WriteLine(); }
                        else if (userIn == "2") 
                        { 
                            Console.WriteLine("Please enter the name of the workout.");
                            String workoutChoice = Console.ReadLine();
                            do {
                                line = file.ReadLine();
                                if(line.Contains(workoutChoice)) 
                                {
                                    Console.WriteLine("Enter the new rep count.");
                                    newReps = file.ReadLine();
                                    temp.changeReps(line, newReps);
                                }
                            } while (line != null);
                        }
                        else if (userIn == "3")
                        {
                            Console.WriteLine("HERE ADD FUNCTION FOR ADDING WORKOUT");
                        }
                        else if (userIn == "0") Console.WriteLine("Enjoy the workout!\n");
                        else Console.WriteLine("That is not a valid input, try again.\n");    
            } while(userIn != "0");
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

                pushups.recordData().Wait();
                    Console.WriteLine(pushups.LineNum);
                situps.recordData().Wait();
                    Console.WriteLine(situps.LineNum);
                curls.recordData().Wait();
                    Console.WriteLine(curls.LineNum);
                pullups.recordData().Wait();
                    Console.WriteLine(pullups.LineNum);
                diamonds.recordData().Wait();
                    Console.WriteLine(diamonds.LineNum);
                squats.recordData().Wait();
                    Console.WriteLine(squats.LineNum);
                burndown.recordData().Wait();
                    Console.WriteLine(burndown.LineNum);
     
 **/
