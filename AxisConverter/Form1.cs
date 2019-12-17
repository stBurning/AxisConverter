using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private PlotParameters GetParameters() {
            int Width = int.Parse(WidthBox.Text);
            int Height = int.Parse(HeightBox.Text);
            float XMax = float.Parse(XMaxBox.Text);
            float XMin = float.Parse(XMinBox.Text);
            float YMax = float.Parse(YMaxBox.Text);
            float YMin = float.Parse(YMinBox.Text);

            PlotParameters parameters = new PlotParameters(Width, Height,XMin,XMax,YMin,YMax);
            return parameters;
      
       
        }
        private void InputXBox_TextChanged(object sender, EventArgs e) {
            try {
                PlotParameters parameters = GetParameters();
                OutputXBox.BackColor = Color.White;
                if (rbDecart.Checked) {
                    float x = float.Parse(InputXBox.Text);
                    OutputXBox.Text = Converter.XConvertToPC(x, parameters).ToString();
                } else {
                    int x = int.Parse(InputXBox.Text);
                    OutputXBox.Text = Converter.XConvertToDecart(x, parameters).ToString();
                }
                
            } catch (Exception) {
                OutputXBox.Text = "";
                OutputXBox.BackColor = Color.LightCoral;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void InputYBox_TextChanged(object sender, EventArgs e) {
            try {
                PlotParameters parameters = GetParameters();
                OutputYBox.BackColor = Color.White;
                if (rbDecart.Checked) {
                    float y = float.Parse(InputYBox.Text);
                    OutputYBox.Text = Converter.YConvertToPC(y, parameters).ToString();
                } else {
                    int y= int.Parse(InputYBox.Text);
                    OutputYBox.Text = Converter.YBackConvert(y, parameters).ToString();
                }

            } catch (Exception) {
                OutputYBox.Text = "";
                OutputYBox.BackColor = Color.LightCoral;
            }
        }

        private void Settings_TextChanged(object sender, EventArgs e) {
            InputXBox_TextChanged(sender, e);
            InputYBox_TextChanged(sender, e);
        }
    }
}
