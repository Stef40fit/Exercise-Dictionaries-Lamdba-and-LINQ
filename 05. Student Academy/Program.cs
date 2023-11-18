Dictionary<string, List<double>> students = new();

int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
        students.Add(student, new List<double>());
    }
    students[student].Add(grade);
}
var excellant = students.Where(st => st.Value.Average() >= 4.50);
foreach(var currentStudent in excellant)
{
    Console.WriteLine($"{currentStudent.Key} -> {currentStudent.Value.Average():f2}");
}