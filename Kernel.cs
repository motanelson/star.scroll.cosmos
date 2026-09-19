using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Cosmosstars
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static int[] starx=new int[500];
        
        public static int[] stary=new int[500];

        

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Random r= new Random();
            while (true)
            {
                for (int i = 0; i < 500; i++) 
                {

                    graf.starx[i] = r.Next(1024 * 4);
                    graf.stary[i] = r.Next(800 * 4);

                }
                graf.starts();

                while (true)
                {
                    Thread.Sleep(1);

                    tests.mainLoop();



                    ;

                }
            }


        }
    }





    class tests



    {


        public static void mainLoop()
        {
            //

            int xxx = 0;
            int yyy = 0;
            Pen p = new Pen(Color.Black, 4);
            graf.canvas.Clear(Color.White);
            if ((int)Sys.MouseManager.Y >= 0 && (int)Sys.MouseManager.X >= 0 && (int)Sys.MouseManager.Y < 800 && (int)Sys.MouseManager.X < 1024)
            {
                for (int a = 0; a < 500; a++)
                {
                    xxx = graf.starx[a] - (1024) - (int)Sys.MouseManager.X;
                    yyy = graf.stary[a] - (800) - (int)Sys.MouseManager.Y;
                    if (yyy > 0 && yyy < 7980 && xxx > 0 && xxx < 1020)
                    {
                        graf.canvas.DrawLine(p, new Sys.Graphics.Point(xxx, yyy), new Sys.Graphics.Point(xxx + 4, yyy + 4));


                    }


                }
            }
            graf.displays();

        }

    }





}
