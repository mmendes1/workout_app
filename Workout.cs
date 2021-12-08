using System;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace workout_app
{
    class Workout
    {
        private String line, workoutName, workoutType;
        private String[] splitLine = new String[3];
        private Boolean lineCountUpdate = false;
        private int workoutRepNum, lineNum, inc;
        public int lineCount = 0;
        public Workout() { }

        public Workout(string name, string type, int repNum) {
            workoutName = name;
            workoutType = type;
            workoutRepNum = repNum;
            lineNum = -1;
        }

        public async Task recordData() {
            lineNum = lineCount;
            using StreamWriter file = new("Workout_Data.txt", append: true);
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

        public async void changeReps(int lineNum, String newReps) {  
            inc = 0;  
            if(!lineCountUpdate) checkLineCount();

            String[] accesableData = new String[lineCount]; //Yucko temp fix
                using StreamReader lineReader = new StreamReader("Workout_Data.txt"); {
                   do{
                       line = lineReader.ReadLine();
                       accesableData[inc] = line;
                       Console.WriteLine(accesableData[inc]);
                        inc++;
                   } while(line != null);
                } lineReader.Close();

                splitLine = accesableData[lineNum - 1].Split(" ");
                splitLine[3] = newReps;

                String frankenstein = splitLine [0] + " " + splitLine[1] + " " + splitLine[2] + " " + splitLine[3];
                    accesableData[lineNum - 1] = frankenstein;
                using StreamWriter file = new StreamWriter("Workout_Data.txt"); 
                for(int i = 0; i < accesableData.Length - 1; i++) 
                {
                    await file.WriteLineAsync(accesableData[i]);
                }
                file.Close();
        }
        
        public void checkLineCount() 
        {
            lineCount = 0;
            using StreamReader file = new StreamReader("Workout_Data.txt");
            do {
                line = file.ReadLine();
                lineCount++;
            } while(line != null);
            file.Close();
            lineCountUpdate = true;
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

        public int getLineCount() { checkLineCount(); return lineCount; }

        public override string ToString() => lineNum + ") " + workoutName + " " + workoutType + " " + workoutRepNum;
    }
}
