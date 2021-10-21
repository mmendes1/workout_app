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
            String choice, line, userIn;
            String[] userInSplit;
            StreamReader file = new("Workout_Data.txt");

            Console.WriteLine("Hello, please select a function...");
            do {
                Console.WriteLine("   1. Print all workouts\n   2. Set a rep count.\n   3. Add a new workout\n   0. Exit");
                    choice = Console.ReadLine();
                        if(choice == "1") { temp.printWorkouts(); Console.WriteLine(); }
                        else if (choice == "2") 
                        { 
                            Console.WriteLine("Please enter the name of the workout.");
                            String workoutChoice = Console.ReadLine();
                            do {
                                line = file.ReadLine();
                                if(line.Contains(workoutChoice)) 
                                {
                                    Console.WriteLine("Enter the new rep count.");
                                    userIn = file.ReadLine();
                                    temp.changeReps(line, userIn);
                                }
                            } while (line != null);
                            file.Close();
                        }
                        else if (choice == "3")
                        {
                            Console.WriteLine("Please enter the workout in the following format...\nName Of Workout:Muscle Group:Reps");
                            userIn = Console.ReadLine();
                                file.Close();
                            userInSplit = userIn.Split(':');
                                Workout newWorkout = new Workout(userInSplit[0], userInSplit[1], int.Parse(userInSplit[2]));
                                newWorkout.recordData().Wait();
                            file.Close();
                        }
                        else if (choice == "0") Console.WriteLine("Enjoy the workout!\n");
                        else Console.WriteLine("That is not a valid input, try again.\n");    
            } while(choice != "0");
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
