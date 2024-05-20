using Grades;

var Gradecalc = new Gradecalc();

Console.Write("Enter the percentage : ");
var percent = Convert.ToInt32(Console.ReadLine());

var grades = Gradecalc.GetGradePercentage(percent);

Console.WriteLine($"Student Grade : {grades}");