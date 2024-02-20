using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion2023.Entidades
{
    public class Cuadrilatero
    {
        public int LadoA;
        public int LadoB;
        private int _medidaLado;

        private Borde borde;

        private Relleno relleno;


        

        public Borde Borde { get { return borde; } set { borde = value; } }
        public Relleno Relleno { get { return relleno; } set { relleno = value; } }

        public Cuadrilatero(int ladoA, int ladoB, Borde borde, Relleno relleno)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            Borde = borde;
            Relleno = relleno;
           
        }

        public bool EsCuadrilatero(int ladoA, int ladoB)
        {

            if (LadoA > 0 && LadoB > 0)
            {

                return true;
                


            }
            else
            {
                throw new ArgumentException("Las Medidas de los Lados no forman un Cuadrilatero");

            }

        }

        public double GetPerimetro() => 2*LadoA+2*LadoB;
        public double GetArea() => LadoA * LadoB;
        public bool Validar()
        {
            return _medidaLado > 0;
        }
        public int GetLadoA() => _medidaLado;
        public int GetLadoB() => _medidaLado;

        public void SetLadoA(int medida)
        {
            if (medida > 0)
            {
                _medidaLado = medida;
            }
        }
        public void SetLadoB(int medida)
        {
            if (medida > 0)
            {
                _medidaLado = medida;
            }
        }

        

    }    
}
