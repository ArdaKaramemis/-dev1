using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {
            try
            {
                Console.WriteLine("Kaç öğrenci kaydetmek istiyorsunuz? ");
                int numStudents = int.Parse(Console.ReadLine());

                List<Student> students = new List<Student>();

                for (int i = 0; i < numStudents; i++)
                {
                    Console.WriteLine($"{i + 1}.Öğrencinin Bilgileri:");

                    Console.WriteLine("Numara:");
                    decimal number = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Adı:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Soyadı:");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Vize Notu:");
                    int midtermGrade = int.Parse(Console.ReadLine());
                    while (midtermGrade < 0 || midtermGrade > 100)
                    {
                        Console.WriteLine("Vize Notu 0-100 aralığında olmalıdır. Lütfen tekrar girin:");
                        midtermGrade = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Final Notu:");
                    int finalGrade = int.Parse(Console.ReadLine());
                    while (finalGrade < 0 || finalGrade > 100)
                    {
                        Console.WriteLine("Final Notu 0-100 aralığında olmalıdır. Lütfen tekrar girin:");
                        finalGrade = int.Parse(Console.ReadLine());
                    }

                    students.Add(new Student
                    {
                        Number = number,
                        Name = name,
                        Surname = surname,
                        MidtermGrade = midtermGrade,
                        FinalGrade = finalGrade
                    });
                }

                Console.WriteLine("\nSonuçlar:");
                Console.WriteLine("Numara\tAdı\tSoyadı\tVize Notu\tFinal Notu\tOrtalama\tHarf Notu");

                double totalAverage = 0;
                int lowestGrade = 101, highestGrade = -1;

                foreach (var student in students)
                {
                    double average = (student.MidtermGrade * 0.4) + (student.FinalGrade * 0.6);
                    string letterGrade = GetLetterGrade(average);

                    Console.WriteLine($"{student.Number}\t{student.Name}\t{student.Surname}\t{student.MidtermGrade}\t{student.FinalGrade}\t{average:F2}\t{letterGrade}");

                    totalAverage += average;

                    if (student.FinalGrade < lowestGrade)
                        lowestGrade = student.FinalGrade;
                    if (student.FinalGrade > highestGrade)
                        highestGrade = student.FinalGrade;
                }

                double classAverage = totalAverage / students.Count;
                Console.WriteLine($"\nSınıf Ortalaması: {classAverage:F2}");
                Console.WriteLine($"En Düşük Not: {lowestGrade}");
                Console.WriteLine($"En Yüksek Not: {highestGrade}");
            break;
            }
            
        catch (OverflowException)
        {
                Console.WriteLine("Lütfen değer aralığına uyunuz.");
            }
        catch (FormatException)
        {
                Console.WriteLine("Lütfen uygun formatta değer giriniz.");
            }
        }

        static string GetLetterGrade(double average)
        {
            if (average >= 85)
                return "AA";
            else if (average >= 75)
                return "BA";
            else if (average >= 60)
                return "BB";
            else if (average >= 50)
                return "CB";
            else if (average >= 40)
                return "CC";
            else if (average >= 30)
                return "DC";
            else if (average >= 20)
                return "DD";
            else if (average >= 10)
                return "FD";
            else
                return "FF";
        }
    }

    class Student
    {
        public decimal Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MidtermGrade { get; set; }
        public int FinalGrade { get; set; }
    }
}