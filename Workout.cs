using System;
using System.IO;
using System.Threading.Tasks;

namespace workout_app
{
    public class Workout
    {
        public Workout() { }

        public Workout(string name, string type, int repNum) {
            workoutName = name;
            workoutType = type;
            workoutRepNum = repNum;
        }

        public static async Task writeToFile(Workout workout) {
            using StreamWriter file = new("Workout_Data.txt", append: true);
            await file.WriteLineAsync(workout.ToString());
        }

        public string workoutName {get; set; }
        public string workoutType {get; set; }
        public int workoutRepNum {get; set; }

        public override string ToString() => workoutName + " " + workoutType + " " + workoutRepNum;
    }
}
