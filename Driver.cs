using System;
//Next: User input
namespace workout_app
{
    class Driver
    {
        static async void Main()
        {
            /**int userIn = 0;
            while(userIn != 3) {
                Console.WriteLine("Hello, please select a function...");
                Console.WriteLine("   1. Print all workouts\n   2. Set a rep count.\n   3. Exit");
                    userIn =Convert.ToInt32(Console.ReadLine());
                        if(userIn == 1) {}
                        else if (userIn == 2) {}
                        else if (userIn == 3) Console.WriteLine("Enjoy the workout!");
                        else Console.WriteLine("That is not a valid input, try again.");      **/
             Workout pushups = new Workout ("Push-ups", "Back", 24);
             Workout situps = new Workout ("Sit-ups", "Abs", 17);
             Workout curls = new Workout ("Curls", "Biceps", 26);
             Workout pullups = new Workout ("Pull-ups", "Shoulders", 19);
             Workout diamonds = new Workout ("Diamonds", "Triceps", 15);
             Workout squats = new Workout ("Squats", "Legs", 14);
             Workout burndown = new Workout ("Shoulder-press", "Shoulders", 27);

                //Console.WriteLine(curls.ToString());
                 Workout.writeToFile(pushups);
                Workout.writeToFile(situps);
                Workout.writeToFile(curls);
                Workout.writeToFile(pullups);
                Workout.writeToFile(diamonds);
                Workout.writeToFile(squats);
               await Workout.writeToFile(burndown);
            }
        }
    }
