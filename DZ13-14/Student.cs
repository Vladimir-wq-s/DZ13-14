using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentManagement
{
    //Класс, представляющий студента
    public class Student
    {
        //Свойство для имени студента
        public string Name { get; set; }

        //Свойство для возврата студента
        public int Age { get; set; }

        //Свойство для среднего балла студента
        public double AverageScore { get; set; }

        //Конструктор класса студента
        public Student(string name, int age, double averageScore)
        {
        Name = name;
            Age = age;
            AverageScore = averageScore;

}


    }
}
