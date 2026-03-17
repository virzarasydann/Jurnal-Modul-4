using System;
using System.Collections.Generic;
using System.Text;

namespace JurnalModul4_103082400034
{
    internal class PosisiKarakterGame
    {
        enum State { BERDIRI, JONGKOK, TENGKURAP, TERBANG, EXIT };

        public static void AutomataDriven()
        {
            
            State state = State.BERDIRI;

            while (state != State.EXIT)
            {
                Console.WriteLine("Kondisi saat ini: " + state);
                Console.Write("Input Command (TombolW/TombolS/TombolX) : ");

                string command = Console.ReadLine();

                switch (state)
                {
                    case State.BERDIRI:
                        if (command == "S")
                        {
                            state = State.JONGKOK;
                        }
                        else if (command == "W")
                        {
                            state = State.TERBANG;
                        }
                        else
                        {
                            state = State.EXIT;
                        }
                        break;

                    case State.JONGKOK:
                        if (command == "W")
                        {
                            state = State.BERDIRI;
                           
                            Console.WriteLine("posisi standby");
                        }
                        else if (command == "S")
                        {
                            state = State.TENGKURAP;
                            
                            Console.WriteLine("posisi istirahat");
                        }
                        else
                        {
                            state = State.EXIT;
                        }
                        break;

                    case State.TENGKURAP:
                        if (command == "lW")
                        {
                            state = State.JONGKOK;
                        }
                        else
                        {
                            state = State.EXIT;
                        }
                        break;

                    case State.TERBANG:
                        if (command == "S")
                        {
                            state = State.BERDIRI;
                            
                            Console.WriteLine("posisi standby");
                        }
                        else if (command == "X")
                        {
                            state = State.JONGKOK;
                        }
                        else
                        {
                            state = State.EXIT;
                        }
                        break;
                }

                
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("EXIT SCREEN");
        }
    }
}

