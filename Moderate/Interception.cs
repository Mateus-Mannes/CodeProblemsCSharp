using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moderate
{
    public class Coordenada{
        public decimal X { get; set; }
        public decimal Y { get; set; }
    }

    public class Reta{
        public decimal? A { get; set; }
        public decimal? CortaY { get; set; } 
        public Reta(Coordenada inicial, Coordenada final){
            decimal detaY = final.Y - inicial.Y;
            decimal deltaX = final.X - inicial.X;
            if(deltaX == 0){
                A = null;
                CortaY = null;
            }
        }
    }

    public static class Interception
    {
        public static Coordenada Run(Coordenada inicial1, Coordenada final1, Coordenada inicial2, Coordenada final2){
            if(inicial1.X > final1.X) Swap(inicial1, final1);
            if(inicial2.X > final2.X) Swap(inicial2, final2);
            if(inicial1.X > inicial2.X){
                Swap(inicial1, inicial2);
                Swap(final1, final2);
            }

            Reta reta1 = new Reta(inicial1, final1);
            Reta reta2 = new Reta(inicial2, final2);

            if(reta1.A == reta2.A){
                if(reta1.CortaY == reta2.CortaY && Contido(inicial1, inicial2, final1)){
                    return inicial1;
                }
                return null;
            }

            decimal x = (reta2.CortaY - reta1.CortaY) / (reta1.A - reta2.A);
            decimal y = reta1.A * x + reta1.CortaY;
            Coordenada interc = new Coordenada() { X = x, Y = y };

            if(Contido(reta1.Inicial, interc, reta1.Final) 
            && Contido(reta2.Inicial, interc, reta2.Final)){
                return interc;
            }

            return null;
        } 

        public static void Swap(Coordenada c1, Coordenada c2){
            decimal x = c1.X;
            decimal y = c1.Y;
            c1.X = c2.X;
            c1.Y = c2.Y;
            c2.X = x;
            c2.Y = y;
        }

        public static bool Contido(Coordenada inicial, Coordenada meio, Coordenada final){
            return Contido(inicial.X, meio.X, final.X) 
            && Contido(inicial.Y, meio.Y, final.Y);
        } 

        public static bool Contido(decimal inicial, decimal meio, decimal final){
            if(inicial > final){
                return final <= meio && meio <= inicial;
            }
            return inicial <= meio && meio <= final;
        }
    }
}