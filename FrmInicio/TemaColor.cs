using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrmInicio

{
    
    public static class TemaColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondColor { get; set; }
        public static List<string> colorList=new List<string>() {
                                                "#3F51B5",
                                                "#009688",
                                                "#FF5722",
                                                "#607D8B",
                                                "#FF9800",
                                                "#9C27B0",
                                                "#2196F3",
                                                "#EA676C",
                                                "#E41A4A",
                                                "#59788B",
                                                "#018790",
                                                "#0E3441",
                                                "#00B0AD",
                                                "#721D47",
                                                "#EA4833",
                                                "#EF937E",
                                                "#F37521",
                                                "#A12059",
                                                "#126881",
                                                "#8BC240",
                                                "#364D58",
                                                "#C7DC5B",
                                                "#0094BC",
                                                "#E4126B",
                                                "#43B76E",
                                                "#7BCFE9",
                                                "#B71C46"

        };
        public static Color cambiarBrilloColor(Color color, double correctionFactor)
        {
            double rojo = color.R;
            double verde = color.G;
            double azul = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                rojo *= correctionFactor;
                verde *= correctionFactor;
                azul *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                rojo = (255 - rojo) * correctionFactor + rojo;
                verde = (255 - verde) * correctionFactor + verde;
                azul = (255 - azul) * correctionFactor + azul;
            }
            return Color.FromArgb(color.A, (byte)rojo, (byte)verde, (byte)azul);
        }
    }
}
