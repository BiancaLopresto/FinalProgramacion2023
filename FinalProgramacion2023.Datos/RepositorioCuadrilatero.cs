using FinalProgramacion2023.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion2023.Datos
{
    public class RepositorioCuadrilatero
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrilatero.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Cuadrilatero.bak";

        private List<Cuadrilatero> listaCuadrilateros;

        public RepositorioCuadrilatero()
        {
            listaCuadrilateros = new List<Cuadrilatero>();
            LeerDatos();
        }
        public List<Cuadrilatero> GetLista()
        {
            return listaCuadrilateros;
        }
        private void LeerDatos()
        {
            if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                    string lineaLeida = lector.ReadLine();
                    string[] valores = lineaLeida.Split(' ');
                    double ladoA = double.Parse(valores[0]);
                    double ladoB = double.Parse(valores[1]);

                    Cuadrilatero cuadrilatero=ConstruirCuadrilatero(lineaLeida);
            

                    listaCuadrilateros.Add(cuadrilatero);
                }
                lector.Close();
            }
        }

       
        
           private Cuadrilatero ConstruirCuadrilatero(string? lineaLeida)
            {
                
                var campos = lineaLeida.Split('|');
                int ladoA = int.Parse(campos[0]);
                int LadoB = int.Parse(campos[1]);
                Borde borde = (Borde)int.Parse(campos[2]);
                Relleno color = (Relleno)int.Parse(campos[3]);
                Cuadrilatero c = new Cuadrilatero(LadoB,ladoA, borde, color);
                return c;

            }
        private string ConstruirLinea(Cuadrilatero cuadrilatero)
        {
            return $"{cuadrilatero.GetLadoA()}|{cuadrilatero.GetLadoB()}|{cuadrilatero.Borde.GetHashCode()}|{cuadrilatero.Relleno.GetHashCode()}";
        }

        public bool Existe(Cuadrilatero cuadrilatero)
        {
            
                listaCuadrilateros.Clear();
                LeerDatos();
                foreach (var itemCuadrilatero in listaCuadrilateros)
                {
                    if (itemCuadrilatero.GetLadoA() == cuadrilatero.GetLadoA() &&
                        itemCuadrilatero.GetLadoB()==cuadrilatero.GetLadoB() &&
                        itemCuadrilatero.Relleno == cuadrilatero.Relleno &&
                        itemCuadrilatero.Borde == cuadrilatero.Borde)
                    {
                        return true;
                    }
                }
                return false;
            
        }

        public void Agregar(Cuadrilatero cuadrilatero)
        {
            var escritor = new StreamWriter(_archivo, true);

            string lineaEscribir = ConstruirLinea(cuadrilatero);
            escritor.WriteLine(lineaEscribir);
            escritor.Close();


            listaCuadrilateros.Add(cuadrilatero);
        }

        public object GetCantidad(int valorFiltro=0)
        {
            if (valorFiltro > 0)
            {
                return listaCuadrilateros
                    .Count(c => c.GetLadoA() >= valorFiltro);
                
            }
            return listaCuadrilateros.Count;
        }
    }

}
