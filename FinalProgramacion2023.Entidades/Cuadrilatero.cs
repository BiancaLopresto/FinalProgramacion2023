using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion2023.Entidades
{
    public class Cuadrilatero
    {
        private int LadoA;
        private int LadoB;


        private Borde borde;


        private Relleno relleno;



        public Borde Borde { get { return borde; } set { borde = value; } }
        public Relleno Relleno { get { return relleno; } set { relleno = value; } }



        public Cuadrilatero(int _medidaLadoA, int _medidaLadoB, Relleno relleno, Borde borde)
        {
            LadoA = _medidaLadoA;
            LadoB = _medidaLadoB;
            Relleno = relleno;
            Borde = borde;
        }

        public Cuadrilatero()
        {
        }




        public TipoDeCuadrilatero TipoCuadrilatero()
        {
            if (LadoA == LadoB)
            {
                return TipoDeCuadrilatero.Cuadrado;
            }
            else
            {
                return TipoDeCuadrilatero.Rectangulo;
            }
        }

        public enum TipoDeCuadrilatero
        {
            Cuadrado,
            Rectangulo
        }



        public double GetPerimetro() => 2 * LadoA + 2 * LadoB;
        public double GetArea() => LadoA * LadoB;



       
        public int GetLadoA() => LadoA;
        public int GetLadoB() => LadoB;

        public void SetLadoA(int medidaA)
        {
            if (medidaA > 0)
            {
                LadoA = medidaA;
            }
        }
        public void SetLadoB(int medidaB)
        {
            if (medidaB > 0)
            {
                LadoB = medidaB;
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    
    

}  

     
