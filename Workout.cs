using System;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace workout_app
{
    class Workout
    {
        private String line, workoutName, workoutType;
        private int lineCount = 0, workoutRepNum, lineNum;
        public Workout() { }

        public Workout(string name, string type, int repNum) {
            workoutName = name;
            workoutType = type;
            workoutRepNum = repNum;
            lineNum = -1;
        }

        public async Task recordData() {
            checkLineCount();
            lineNum = lineCount;
            
            using StreamWriter file = new("Workout_Data.txt", append: true);
            Console.WriteLine("Does it even this????");
            await file.WriteLineAsync(ToString());
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

        public void changeReps(String line, String target) {
            for(int i = 0; i < line.Length; i++) 
            {
                //String replaced = Regex.Replace()
                //Confusing, watch youtube about Regex
            }
        }
        
        public void checkLineCount() 
        {
            using StreamReader file = new StreamReader("Workout_Data.txt");
            do {
                line = file.ReadLine();
                lineCount++;
            } while(line != null);
            file.Close();
        }

        string WorkoutName {
            get{ return workoutName; } 
            set{ WorkoutName = value; }
        }
        string WorkoutType {
            get{ return workoutType; } 
            set{workoutType = value; } 
        }
        int WorkoutRepNum {
            get{ return workoutRepNum; } 
            set{ workoutRepNum = value; } 
        }
        public int LineNum {
           get{ return lineNum; }
           set{ lineNum = value; } 
        }

        public override string ToString() => lineNum + ") " + workoutName + " " + workoutType + " " + workoutRepNum;
    }
}
