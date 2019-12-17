using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter {
    struct PlotParameters {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public float xMin { get; private set; }
        public float xMax { get; private set; }
        public float yMin { get; private set; }
        public float yMax { get; private set; }

        public PlotParameters(int width, int height, float xmin, float xmax, float ymin, float ymax) {
            if (width < 0 || height < 0 || xmin >= xmax || ymin >= ymax)
                throw new Exception("Range exception");
            Width = width;
            Height = height;
            xMin = xmin; xMax = xmax;
            yMin = ymin; yMax = ymax;
        }
    }
    class Converter {

        protected int Width { get; private set; }
        protected int Height { get; private set; }
        protected float xMin { get; private set; }
        protected float xMax { get; private set; }
        protected float yMin { get; private set; }
        protected float yMax { get; private set; }

        public Converter(int width, int height, float xmin, float xmax, float ymin, float ymax) {
            if (width < 0 || height < 0 || xmin >= xmax || ymin >= ymax)
                throw new Exception("Range exception");
            Width = width;
            Height = height;
            xMin = xmin; xMax = xmax;
            yMin = ymin; yMax = ymax;
        }

        public Converter(PlotParameters parameters) {
            Width = parameters.Width;
            Height = parameters.Height;
            xMax = parameters.xMax;
            xMin = parameters.xMin;
            yMin = parameters.yMin;
            yMax = parameters.yMax;
        }

        public int XConvertToPC(float x) {
            int result = Convert.ToInt32(Math.Round(Width / (xMax - xMin) * (x - xMin), 0));
            if (result < -Width) return -Width;
            if (result > 2 * Width) return 2 * Width;
            return result;
        }
        public int YConvertToPC(float y) {
            int result = Convert.ToInt32(Math.Round(Height / (yMax - yMin) * (yMax - y), 0));
            if (result < -Height) return -Height;
            if (result > 2 * Height) return 2 * Height;
            return result;
        }
        public float XConvertToDecart(int x) {
            
            return xMin + ((xMax - xMin) * (float)x / Width);
        }
        public float YConvertToDecart(int y) {
            
            return yMax - ((yMax - yMin) * (float)y / Height);
        }

        public static int XConvertToPC(float x, int width, float xmin, float xmax) {
            int result = Convert.ToInt32(Math.Round(width / (xmax - xmin) * (x - xmin), 0));
            if (result < -width) return -width;
            if (result > 2 * width) return 2 * width;
            return result;
        }
        public static int YConvertToPC(float y, int height, float ymin, float ymax) {
            int result = Convert.ToInt32(Math.Round(height / (ymax - ymin) * (ymax - y), 0));
            if (result < -height) return -height;
            if (result > 2 * height) return 2 * height;
            return result;
        }
        public static float XConvertToDecart(int x, int width, float xmin, float xmax) {
            
            return xmin + ((xmax - xmin) * (float)x / width);
        }
        public static float YBackConvert(int y, int height, float ymin, float ymax) {
            
            return ymax - ((ymax - ymin) * (float)y / height);
        }
        public static int XConvertToPC(float x, PlotParameters parameters) {
            int result = Convert.ToInt32(Math.Round(parameters.Width / (parameters.xMax - parameters.xMin) * (x - parameters.xMin), 0));
            if (result < -parameters.Width) return -parameters.Width;
            if (result > 2 * parameters.Width) return 2 * parameters.Width;
            return result;   
        }
        public static int YConvertToPC(float y, PlotParameters parameters) {
            int result = Convert.ToInt32(Math.Round(parameters.Height / (parameters.yMax - parameters.yMin) * (parameters.yMax - y), 0));
            if (result < -parameters.Height) return -parameters.Height;
            if (result > 2 * parameters.Height) return 2 * parameters.Height;
            return result;
            
        }
        public static float XConvertToDecart(int x, PlotParameters parameters) {
           
            return parameters.xMin + ((parameters.xMax - parameters.xMin) * (float)x / parameters.Width);
        }
        public static float YBackConvert(int y, PlotParameters parameters) {
           
            return parameters.yMax - ((parameters.yMax - parameters.yMin) * (float)y / parameters.Height);
        }



    }
}
