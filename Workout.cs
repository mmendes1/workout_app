using System;
using System.IO;
using System.Threading.Tasks;

namespace workout_app
{
    class Workout
    {
        private String line;
        public Workout() { }

        Workout(string name, string type, int repNum) {
            workoutName = name;
            workoutType = type;
            workoutRepNum = repNum;
        }

        static async Task recordData(Workout workout) {
            using StreamWriter file = new("Workout_Data.txt", append: true);
            await file.WriteLineAsync(workout.ToString());
                file.Close();
        }

        public void printWorkouts () {
            using StreamReader file = new("Workout_Data.txt");
            do {
                line = file.ReadLine();
                Console.WriteLine(line);
            } while(line != null);
            
            file.Close();
        }

        string workoutName {get; set; }
        string workoutType {get; set; }
        int workoutRepNum {get; set; }

        public override string ToString() => workoutName + " " + workoutType + " " + workoutRepNum;
    }
}
