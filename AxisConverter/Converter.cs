using System;

namespace AxicConverter{
    struct PlotParameters{
        public int Width { get; private set; }
        public int Height { get; private  set; }
        public float xMin { get; private  set; }
        public float xMax { get; private  set; }
        public float yMin { get; private set; }
        public float yMax { get; private set; }

        public PlotParameters(int width, int height, float xmin, float xmax, float ymin, float ymax){
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

        public Converter(int width, int height, float xmin, float xmax, float ymin, float ymax){
            if (width < 0 || height < 0 || xmin >= xmax || ymin >= ymax)
                throw new Exception("Range exception");
            Width = width;
            Height = height;
            xMin = xmin; xMax = xmax;
            yMin = ymin; yMax = ymax;
        }

        public Converter(PlotParameters parameters){
            Width = parameters.Width;
            Height = parameters.Height;
            xMax = parameters.xMax;
            xMin = parameters.xMin;
            yMin = parameters.yMin;
            yMax = parameters.yMax;
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

        public static int XConvert(float x,int width, float xmin, float xmax){
            return Convert.ToInt32(Math.Round(width / (xmax - xmin) * (x - xmin), 0));
        }
        public static int YConvert(float y, int height, float ymin, float ymax){
            return Convert.ToInt32(Math.Round(height / (ymax - ymin) * (ymax - y), 0));
        }
        public static float XBackConvert(int x,int width, float xmin, float xmax) {
            return xmin + ((xmax - xmin) * (float)x / width);
        }
        public static float YBackConvert(int y, int height, float ymin, float ymax) {
            return ymax - ((ymax - ymin) * (float)y / height);
        }
        public static int XConvert(float x, PlotParameters parameters){
            return Convert.ToInt32(Math.Round(parameters.Width / (parameters.xMax - parameters.xMin) * (x - parameters.xMin), 0));
        }
        public static int YConvert(float y, PlotParameters parameters){
            return Convert.ToInt32(Math.Round(parameters.Height / (parameters.yMax - parameters.yMin) * (parameters.yMax - y), 0));
        }
        public static float XBackConvert(int x,PlotParameters parameters) {
            return parameters.xMin + ((parameters.xMax - parameters.xMin) * (float)x / parameters.Width);
        }
        public static float YBackConvert(int y, PlotParameters parameters) {
            return parameters.yMax - ((parameters.yMax - parameters.yMin) * (float)y / parameters.Height);
        }
        


    }
}