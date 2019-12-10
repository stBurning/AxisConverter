using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisConverter {

    class AxisConverter {

            protected int Width { get; private set; }
            protected int Height { get; private set; }
            protected float xMin { get; private set; }
            protected float xMax { get; private set; }
            protected float yMin { get; private set; }
            protected float yMax { get; private set; }

            public AxisConverter(int width, int height, float xmin, float xmax, float ymin, float ymax) {
                //TODO Добавить проверку корректности
                Width = width;
                Height = height;
                xMin = xmin; xMax = xmax;
                yMin = ymin; yMax = ymax;
            }

            public int XConvert(float x) {
                return Convert.ToInt32(Math.Round(Width / (xMax - xMin) * (x - xMin), 0));
            }
            public int YConvert(float y) {
                return Convert.ToInt32(Math.Round(Height / (yMax - yMin) * (yMax - y), 0));
            }
            public float XBackConvert(int x) {
                return xMin + ((xMax - xMin) * (float)x / Width);
            }
            public float YBackConvert(int y) {
                return yMax - ((yMax - yMin) * (float)y / Height);
            }


    }


    class Program {
        static void Main(string[] args) {
            AxisConverter axisConverter = new AxisConverter(600, 400, -1, 5, -1, 3);
            Console.WriteLine(axisConverter.XConvert(3));
            Console.WriteLine(axisConverter.YConvert(2));
            Console.WriteLine(axisConverter.YBackConvert(100));
            Console.ReadKey();
        }
        
    }
}
