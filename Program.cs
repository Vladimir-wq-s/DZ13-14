using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание списка студентов
            List<Student> students = new List<Student>
            {
                new Student ("Alice", 22,3.8),
                new Student ("Vladimir", 19,3.2),
                 new Student ("Sergey", 23,3.6),
                  new Student ("Sasha", 21,4.0),
                   new Student ("Alexey", 20,3.4),

            };
            // LINQ для фильтрации студентов
            var filterStudents = from student in students
                                 where student.Age > 20 && student.AverageScore > 3.5

                                 select student;
            // Вывод этих отфильтрованных студентов
            Console.WriteLine("Студенты старше 20 лет с средним баллом выше 3.5");
            foreach (var student in filterStudents) 
            {
                Console.WriteLine($"{student.Name}, Возвраст: {student.Age}, Средний балл: {student.AverageScore}");
            }


        }
    }
}
