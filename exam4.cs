using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            float x, y, dx, dy, step;
            int i;

            Console.Write("Input X1 : "); // เห็นให้รับค่าเลยกำหนดให้มันรับค่าค่ะ
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Input Y1 : ");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("Input X2 : ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("Input Y2 : ");
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy)) // สังเกตุจากflowchartเห็นใช้if เลยใช้ค่ะมูแง่
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;

                x = x1;
                y = y1;

                for (i = 1; i <= step; i++) //มองแล้วforloopแน่นอนเลยใช้ค่ะแง่555
                {

                    Console.Write("{0},{1}", x, y); // แสดงค่า x , y

                    y += dy;
                    x += dx;
                }
                
            }

            else 
            {
                step = Math.Abs(dy); // ทำเหมือนเดิมจ้าแค่เปลี่ยนเป็นdy
                dx /= step;
                dy /= step;

                x = x1; 
                y = y1;
                for (i = 1; i <= step; i++)
                {

                    Console.Write("{0},{1}", x, y);

                    y += dy;
                    x += dx;
                }
               
            }


        }
    }
}
