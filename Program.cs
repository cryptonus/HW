using Grades;

var gradcalc = new gradecalc();

Console.Write("Enter the percentage : ");
var percent = Convert.ToInt32(Console.ReadLine());

var grade = gradcalc.GetGradePercentage(percent);

Console.WriteLine($"Student Grade : {grade}");