﻿namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1,2,3,4)

            //1:degisken türü
            //2:degisken adi
            //3:In
            //4:Liste, koleksiyon, dizi

            //string[] cities = { "nilano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] nums = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //int[] nums = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach(int num in nums)
            //{
            //    if(num%2==0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}


            //int[] nums = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach(int i in nums)
            //{
            //    total += i;
            //}
            // Console.WriteLine(total);


            //List<int> nums = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            //string word = "Merhaba";
            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("--------------------------------------------");
            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();
            //    double
            //        totalExamResult = 0;

            //    //Her öğrenci için 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; //notları topluyoruz
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;

            //}

            ////sınav ortalamaları

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilerin ortalaması ve geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {                                   
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("------------------------------------------");
            //}

            #endregion


            Console.Read();
        }
    }
}
