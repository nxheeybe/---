using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        int[][] octaves = new int[][]
        {
            new int[] { 261, 293, 329, 349, 392, 440, 493 },  // Октава 1
            new int[] { 523, 587, 659, 698, 784, 880, 988 },  // Октава 2
            
        };

        int currentOctave = 0;  // Текущая октава

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Воспроизвести звук");
            Console.WriteLine("2. Изменить октаву");
            Console.WriteLine("3. Выйти");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlaySound(octaves[currentOctave]);
                    break;
                case 2:
                    currentOctave = ChangeOctave();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Неправильно,попробуйте еще раз.");
                    break;
            }
        }
    }

   
    static void PlaySound(int[] octave)
    {
        Console.WriteLine("Выберите ноту от 0 до 6:");
        int note = Convert.ToInt32(Console.ReadLine());

        Console.Beep(octave[note], 500);
    }

  
    static int ChangeOctave()
    {
        Console.WriteLine("Выберите октаву от 0 до 1:");
        int newOctave = Convert.ToInt32(Console.ReadLine());

        return newOctave;
    }
}