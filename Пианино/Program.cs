namespace Пианино
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами F4, F6 и F7");
            
           bool k = true;
           
              while (k == true)
              {
                Console.WriteLine("Для завершения программы нажмите esc");
                Console.WriteLine("Пожалуйста, выберите октаву: F4, F6 и F7");
                
                ConsoleKeyInfo key = Console.ReadKey(); 

                if (key.Key == ConsoleKey.F4)
                { 
                        fourthOctave();
                }
                 
               else if (key.Key == ConsoleKey.F6)
               {
                    sixthOctave();
                }

               else if (key.Key == ConsoleKey.F7)
               {
                        seventhOctave();
               }
               else if (key.Key == ConsoleKey.Escape)
               {
                        k = false;
                    Console.WriteLine("Дотвидания");
                    
               }
                else
                {
                    Console.WriteLine("Ошибка");
                }
                Console.Clear();

            } 
        }
        
        static void fourthOctave()
        {
           int[] fourthOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            Console.Clear();
            bool n = true;
            while (n == true) 
            {
                Console.WriteLine("Для воспроизведения звука наживайте на клавиши с 1 до 0 включительно, Q и W");
                Console.WriteLine("Для смены октав нажмите Enter");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Beep(fourthOctave[0], 1000);
                    
                } 

                else if (key.Key == ConsoleKey.D2)
                {
                    Console.Beep(fourthOctave[1], 1000);
                   
                }

                else if (key.Key == ConsoleKey.D3)
                {
                    Console.Beep(fourthOctave[2], 1000);
                  
                }

                else if (key.Key == ConsoleKey.D4)
                {
                    Console.Beep(fourthOctave[3], 1000);
                  
                }

                else if (key.Key == ConsoleKey.D5)
                {
                    Console.Beep(fourthOctave[4], 1000);
                  
                }

                else if (key.Key == ConsoleKey.D6)
                {
                    Console.Beep(fourthOctave[5], 1000);
                  
                }

                else if (key.Key == ConsoleKey.D7)
                {
                    Console.Beep(fourthOctave[6], 1000);
                  
                }

                else if (key.Key == ConsoleKey.D8)
                {
                    Console.Beep(fourthOctave[7], 1000);
                   
                }
                else if (key.Key == ConsoleKey.D9)
                {
                    Console.Beep(fourthOctave[8], 1000);
                  
                }

                else if (key.Key == ConsoleKey.D0)
                {
                    Console.Beep(fourthOctave[9], 1000);
                   
                }

                else if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(fourthOctave[10], 1000);
                   
                }

                else if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(fourthOctave[11], 1000);
                    
                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    n = false;
                }
                Console.Clear();

            } 
        }
        static void sixthOctave()
            {
                int[] sixthOctave = new int[] { 1047, 1109, 1175,  1245, 1319,  1397, 1480, 1568,  1661, 1760,  1865, 1976 };
            Console.Clear();

            bool l = true;
            while (l == true)
            {

                Console.WriteLine("Для воспроизведения звука наживайте на клавиши с 1 до 0 включительно, Q и W");
                Console.WriteLine("Для смены октав нажмите Enter");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Beep(sixthOctave[0], 1000);

                }

                else if (key.Key == ConsoleKey.D2)
                {
                    Console.Beep(sixthOctave[1], 1000);

                }

                else if (key.Key == ConsoleKey.D3)
                {
                    Console.Beep(sixthOctave[2], 1000);

                }

                else if (key.Key == ConsoleKey.D4)
                {
                    Console.Beep(sixthOctave[3], 1000);

                }

                else if (key.Key == ConsoleKey.D5)
                {
                    Console.Beep(sixthOctave[4], 1000);

                }

                else if (key.Key == ConsoleKey.D6)
                {
                    Console.Beep(sixthOctave[5], 1000);

                }

                else if (key.Key == ConsoleKey.D7)
                {
                    Console.Beep(sixthOctave[6], 1000);

                }

                else if (key.Key == ConsoleKey.D8)
                {
                    Console.Beep(sixthOctave[7], 1000);

                }
                else if (key.Key == ConsoleKey.D9)
                {
                    Console.Beep(sixthOctave[8], 1000);

                }

                else if (key.Key == ConsoleKey.D0)
                {
                    Console.Beep(sixthOctave[9], 1000);

                }

                else if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(sixthOctave[10], 1000);

                }

                else if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(sixthOctave[11], 1000);

                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    l = false;
                }
                Console.Clear();

            }

        }
            static void seventhOctave()
            {
            int[] seventhOctave = new int[] { 2093, 2217,  2349, 2489, 2637, 2794, 2960,  3136, 3322, 3520, 3729, 3951 };
            Console.Clear();

            bool y = true;
            while (y == true)
            {
                Console.WriteLine("Для воспроизведения звука наживайте на клавиши с 1 до 0 включительно, Q и W");
                Console.WriteLine("Для смены октав нажмите Enter");

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    Console.Beep(seventhOctave[0], 1000);

                }

                else if (key.Key == ConsoleKey.D2)
                {
                    Console.Beep(seventhOctave[1], 1000);

                }

                else if (key.Key == ConsoleKey.D3)
                {
                    Console.Beep(seventhOctave[2], 1000);

                }

                else if (key.Key == ConsoleKey.D4)
                {
                    Console.Beep(seventhOctave[3], 1000);

                }

                else if (key.Key == ConsoleKey.D5)
                {
                    Console.Beep(seventhOctave[4], 1000);

                }

                else if (key.Key == ConsoleKey.D6)
                {
                    Console.Beep(seventhOctave[5], 1000);

                }

                else if (key.Key == ConsoleKey.D7)
                {
                    Console.Beep(seventhOctave[6], 1000);

                }

                else if (key.Key == ConsoleKey.D8)
                {
                    Console.Beep(seventhOctave[7], 1000);

                }
                else if (key.Key == ConsoleKey.D9)
                {
                    Console.Beep(seventhOctave[8], 1000);

                }

                else if (key.Key == ConsoleKey.D0)
                {
                    Console.Beep(seventhOctave[9], 1000);

                }

                else if (key.Key == ConsoleKey.Q)
                {
                    Console.Beep(seventhOctave[10], 1000);

                }

                else if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(seventhOctave[11], 1000);

                }

                else if (key.Key == ConsoleKey.Enter)
                {
                   y = false;

                }
                Console.Clear();

            }
            }
    }
 }

