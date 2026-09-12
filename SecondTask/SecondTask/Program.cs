using System.Text.Json;
using System;

class Student {
    string firstName, lastName, group, grade, jsonFile, jsontString, text;
    public List<string> studentInformation = new();
    public void FirstName() {
        Console.WriteLine("ADDITION");
        Console.Write("Enter the student’s Firstname: ");
        firstName = Console.ReadLine();
        studentInformation.Add(firstName);
    }

    public void LastName() {
        Console.Write("Enter the student’s Lastname: ");
        lastName = Console.ReadLine();
        studentInformation.Add(lastName);
    }

    public void Group()
    {
        Console.Write("Enter the student’s Group: ");
        group = Console.ReadLine();
        studentInformation.Add(group);
    }

    public void Grade() { 
        Console.Write("Enter the student’s Grade: ");
        grade = Console.ReadLine();
        studentInformation.Add(grade);

        jsontString = JsonSerializer.Serialize(studentInformation);
        File.WriteAllText("Student.json", jsontString);
    }

    public void Deserialization() {
        Console.WriteLine();
        Console.WriteLine("SEARCH");
        Console.Write("Enter the student’s group: ");
        Console.ReadLine();
        Console.Write("Enter the student’s grade: ");
        Console.ReadLine();
        text = File.ReadAllText("Student.json");

        if (studentInformation[2] == group && studentInformation[3] == grade ) {
            Console.WriteLine();
            Console.WriteLine($"Here: {text}");
        }
    }

    static void Main() {
        Student data = new Student();
        data.FirstName();
        data.LastName();
        data.Group();
        data.Grade();
        data.Deserialization();
    }
}
