using System;
using System.Collections.Generic;

class StudentManager
 {
     static Dictionary<int, string> students = new Dictionary<int, string>();

//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("\nChoose an option:");
//             Console.WriteLine("1. Add Student");
//             Console.WriteLine("2. Delete Student");
//             Console.WriteLine("3. View Students");
//             Console.WriteLine("4. Update Student");
//             Console.WriteLine("5. Exit");

//             Console.Write("Enter your choice: ");
//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.Write("Enter Student ID: ");
//                     int id = Convert.ToInt32(Console.ReadLine());
//                     Console.Write("Enter Student Name: ");
//                     string name = Console.ReadLine();
//                     students[id] = name;
//                     Console.WriteLine("Student added successfully.");
//                     break;

//                 case 2:
//                     Console.Write("Enter Student ID to delete: ");
//                     int deleteId = Convert.ToInt32(Console.ReadLine());
//                     if (students.Remove(deleteId))
//                         Console.WriteLine("Student deleted.");
//                     else
//                         Console.WriteLine("Student not found.");
//                     break;

//                 case 3:
//                     Console.WriteLine("Student Details:");
//                     foreach (var student in students)
//                         Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
//                     break;

//                 case 4:
//                     Console.Write("Enter Student ID to update: ");
//                     int updateId = Convert.ToInt32(Console.ReadLine());
//                     if (students.ContainsKey(updateId))
//                     {
//                         Console.Write("Enter new name: ");
//                         string newName = Console.ReadLine();
//                         students[updateId] = newName;
//                         Console.WriteLine("Student updated.");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Student not found.");
//                     }
//                     break;

//                 case 5:
//                     return;

//                 default:
//                     Console.WriteLine("Invalid choice. Try again.");
//                     break;
//             }
//         }
//     }
}