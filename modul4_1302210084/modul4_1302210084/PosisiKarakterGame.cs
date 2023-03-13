using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210084
{
    internal class PosisiKarakterGame
    {
        enum posisi { Jongkok, Berdiri, Tengkurap, Terbang, Exit }
        public void movement()
        {
            string[] tombol = { "TombolW", "TombolS", "TombolX", "Exit" };
            posisi state = posisi.Berdiri;
            while (state != posisi.Exit)
            {
                string todo = Console.ReadLine();
                switch (state)
                {
                    case posisi.Jongkok:
                        if(todo == "TombolW")
                        {
                            Console.WriteLine("tombol arah atas ditekan");
                            state = posisi.Berdiri;
                        }else if (todo == "TombolS")
                        {
                            Console.WriteLine("tombol arah bawah ditekan");
                            state = posisi.Tengkurap;
                        }else if (todo == "Exit")
                        {
                            state = posisi.Exit;
                        }
                        break;
                    case posisi.Berdiri:
                        if (todo == "TombolS")
                        {
                            Console.WriteLine("tombol arah bawah ditekan");
                            state = posisi.Jongkok;
                        }else if(todo == "TombolW")
                        {
                            Console.WriteLine("tombol arah atas ditekan");
                            state= posisi.Terbang;
                        }else if (todo == "Exit")
                        {
                            state = posisi.Exit;
                        }
                        break;
                    case posisi.Terbang:
                        if (todo == "TombolX")
                        {
                            state = posisi.Jongkok;
                        }else if(todo == "TombolS")
                        {
                            Console.WriteLine("tombol arah bawah ditekan");
                            state = posisi.Berdiri; 
                        }
                        else if (todo == "Exit")
                        {
                            state = posisi.Exit;
                        }
                        break;
                    case posisi.Tengkurap:
                        if(todo == "TombolW")
                        {
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        else if (todo == "Exit")
                        {
                            state = posisi.Exit;
                        }
                        break;
                }
            }
        }
    }
}
