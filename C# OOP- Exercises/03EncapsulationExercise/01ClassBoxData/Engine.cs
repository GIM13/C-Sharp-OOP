using System;

namespace _01ClassBoxData
{
    public class Engine
    {
        public static void NewBox()
        {
            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                var box = new Box(length, width, height);

                Console.WriteLine($"Surface Area - {box.Area():f2}"
                                  + Environment.NewLine +
                                  $"Lateral Surface Area - {box.LateralSurface():f2}"
                                  + Environment.NewLine +
                                  $"Volume - {box.Volume():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
