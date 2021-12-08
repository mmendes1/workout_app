using System;
using System.IO;

/**
Notes
________________
Can expand using statements and remove some of the file closing nonsense
**/
namespace workout_app
{
    class Driver
    {
        static void Main(string[] args)
        {
            Workout temp = new Workout();
            String choice, line, userIn;
            String[] userInSplit;

            Console.WriteLine("Hello, please select a function...");
            do {
                Console.WriteLine("   1. Print all workouts\n   2. Set a rep count.\n   3. Add a new workout\n   4. Generate a random workout\n   0. Exit");
                    choice = Console.ReadLine();
                        if(choice == "1") { temp.printWorkouts(); Console.WriteLine(); }
                        else if (choice == "2") 
                        { 
                            using StreamReader file = new("Workout_Data.txt");
                            Console.WriteLine("Please enter the name of the workout.");
                            String workoutChoice = Console.ReadLine();
                            do {
                                line = file.ReadLine();
                                int lineNum = int.Parse(line.Substring(0,1));
                                if(line.Contains(workoutChoice)) 
                                {
                                    file.Close();
                                    Console.WriteLine("Enter the new rep count.");
                                    userIn = Console.ReadLine();
                                    temp.changeReps(lineNum, userIn);
                                        break;
                                }
                            } while (line != null);
                            file.Close();
                        }
                        else if (choice == "3")
                        {
                            using StreamReader file = new("Workout_Data.txt");
                            Console.WriteLine("Please enter the workout in the following format...\nName Of Workout:Muscle Group:Reps");
                            userIn = Console.ReadLine();
                                file.Close();
                            userInSplit = userIn.Split(':');
                                Workout newWorkout = new Workout(userInSplit[0], userInSplit[1], int.Parse(userInSplit[2]));
                                newWorkout.recordData().Wait();
                            file.Close();
                        }
                        else if (choice == "4") 
                        {
                            String[] workouts = new String[temp.getLineCount() - 1];

                            int pos = 0;
                            using StreamReader file = new("Workout_Data.txt"); {
                                do {
                                    line = file.ReadLine();
                                    workouts[pos] = line;
                                    pos++;
                                }   while(line != null && pos < workouts.Length); 
                            }
                            for(int i = workouts.Length - 1; i > 0; i--) 
                            {
                                Random rand = new Random();
                                pos = rand.Next(0, i + 1);
                               
                                String swap = workouts[i];
                                    workouts[i] = workouts[pos];
                                    workouts[pos] = swap;
                            }
                            for(int i = 0; i < workouts.Length; i++) { Console.WriteLine(workouts[i]); }
                            Console.WriteLine("\n");
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
