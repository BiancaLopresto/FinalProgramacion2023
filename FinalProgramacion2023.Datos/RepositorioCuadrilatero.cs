using FinalProgramacion2023.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProgramacion2023.Datos
{
    public class RepositorioCuadrilatero
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrilateros.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Cuadrilateros.bak";

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
              
                {
                    string lineaLeida = lector.ReadLine();
                    Cuadrilatero cuadrilatero = ConstruirCuadrilatero(lineaLeida);
                    if (cuadrilatero != null)
                    {
                        listaCuadrilateros.Add(cuadrilatero);
                    }
                }
                lector.Close();
            }
        }

       

        public void Editar(Cuadrilatero cuadrilateroEnArchivo, Cuadrilatero cuadrilateroEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Cuadrilatero cuadrilatero = ConstruirCuadrilatero(lineaLeida);
                        if (cuadrilateroEnArchivo.GetLadoA() != cuadrilatero.GetLadoA())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else if (cuadrilateroEnArchivo.GetLadoB() != cuadrilatero.GetLadoB())
                        {
                            escritor.WriteLine(lineaLeida);
                        }else
                        {
                            lineaLeida = ConstruirLinea(cuadrilateroEditar);
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }

        private Cuadrilatero ConstruirCuadrilatero(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            int ladoA = int.Parse(campos[0]);
            int ladoB = int.Parse(campos[1]);
            Relleno relleno = (Relleno)int.Parse(campos[2]);
            Borde borde = (Borde)int.Parse(campos[3]); 
            Cuadrilatero c= new Cuadrilatero(ladoA,ladoB, relleno, borde);
            return c;
        }

        public void Agregar (Cuadrilatero cuadrilatero)
        {

            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstruirLinea(cuadrilatero);
                escritor.WriteLine(lineaEscribir);
                
            }
           listaCuadrilateros.Add(cuadrilatero);
           
           
            


        }
      
        
        private string ConstruirLinea(Cuadrilatero cuadrilatero)
        {
           return $"{cuadrilatero.GetLadoA()}|{cuadrilatero.GetLadoB()}|{cuadrilatero.Relleno.GetHashCode()}|{cuadrilatero.Borde.GetHashCode()}|{cuadrilatero.TipoCuadrilatero}";
        }
        public object GetCantidad(int valorFiltro=0)
        {
            if (valorFiltro > 0)
            {
                return listaCuadrilateros.Count(c => c.GetLadoA() >= valorFiltro);
                
                
            } else if (valorFiltro > 0)
            {
                return listaCuadrilateros.Count(c => c.GetLadoB() >= valorFiltro);
            }
            return listaCuadrilateros.Count;
        }
        public void Borrar(Cuadrilatero cuadrilateroBorrar)
        {
            using (var lector=new StreamReader(_archivo))
            {
                using (var escritor=new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string linealeida = lector.ReadLine();
                        Cuadrilatero cuadrilateroLeido = ConstruirCuadrilatero(linealeida);
                        if (cuadrilateroBorrar.GetLadoA() != cuadrilateroLeido.GetLadoA())
                        {
                            escritor.WriteLine(linealeida);

                        }else if (cuadrilateroBorrar.GetLadoB()!= cuadrilateroLeido.GetLadoB())
                        {
                            escritor.WriteLine(linealeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaCuadrilateros.Remove(cuadrilateroBorrar);
        }



        public List<Cuadrilatero> Filtrar(int intValor)
        {
           
            
          return listaCuadrilateros.Where(c => c.GetLadoA() >= intValor && c.GetLadoB() >=intValor).ToList();

            
        }



        public bool Existe(Cuadrilatero cuadrilatero)
        {
            
                listaCuadrilateros.Clear();
                LeerDatos();
                foreach (var itemCuadrilatero in listaCuadrilateros)
                {
                if (itemCuadrilatero.GetLadoA() == cuadrilatero.GetLadoA() &&
                    itemCuadrilatero.GetLadoB() == cuadrilatero.GetLadoB() &&
                    itemCuadrilatero.Relleno == cuadrilatero.Relleno &&
                    itemCuadrilatero.Borde == cuadrilatero.Borde)
                       
                    {
                        return true;
                    }
                }
                return false;
            
        }

       

       
    }

}
