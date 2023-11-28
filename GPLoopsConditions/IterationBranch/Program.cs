using System;

//To free you from saying things like System.Console.WriteLine();

// initialize variables - graded assignments 
int examAssignments = 5;
// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

//int[] sophiaScores = new int[5];
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
/*int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;*/

int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89,89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };  

/*int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;*/
int[] studentScores = new int[10];
 
decimal sophiaSum = 0;
decimal andrewSum = 0;
decimal emmaSum = 0;
decimal loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;
decimal beckyScore;
decimal chrisScore;
decimal ericScore;
decimal gregorScore;


Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
   string currentStudent = name;

if (currentStudent == "Sophia")
    studentScores = sophiaScores;
else if (currentStudent == "Andrew")
    studentScores = andrewScores;
else if (currentStudent == "Emma")
    studentScores = emmaScores;
else if (currentStudent == "Logan")
    studentScores = loganScores;
else if (currentStudent == "Becky")
    studentScores = beckyScores;
else if (currentStudent == "Chris")
    studentScores = chrisScores;
else if (currentStudent == "Eric")
    studentScores = ericScores;
else if (currentStudent == "Gregor")
    studentScores = gregorScores;
else
    continue;

    decimal sumAssignmentScores = 0.0M;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;
    string currentStudentGradeLetter = null;

foreach(int score in studentScores)
        {
            gradedAssignments += 1;
           
            if(gradedAssignments <= examAssignments){
               sumAssignmentScores += score;
            }
            else {
                 sumAssignmentScores =  sumAssignmentScores + (decimal)0.1*score;
            }
        }
    
 currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
 currentStudentGradeLetter = GetGrade(currentStudentGrade);

Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentGradeLetter}");

}

//Need to be refactored, lower decimal points?

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();

static string GetGrade(decimal score)
{
    if (score >= 97)
        return "A+";
    else if (score >= 93)
        return "A";
    else if (score >= 90)
        return "A-";
    else if (score >= 87)
        return "B+";
    else if (score >= 83)
        return "B";
    else if (score >= 80)
        return "B-";
    else if (score >= 77)
        return "C+";
    else if (score >= 73)
        return "C";
    else if (score >= 70)
        return "C-";
    else if (score >= 67)
        return "D+";
    else if (score >= 63)
        return "D";
    else if (score >= 60)
        return "D-";
    else
        return "F";
}