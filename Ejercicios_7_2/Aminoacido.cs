using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_7_2
{
    class Aminoacido
    {
        public struct Aminoacido
        {
            private int _atomosC;
            private int _atomosN;
            private int _atomosH;
            private int _atomosO;
            private int _amomosS;
            private int _NAtomos;

            private string _nombre;
            private string _abreviaturaLarga;
            private string _abreviaturaCorta;

            private float _pesoMolecular;

            private bool _esEsencial;
            
            //Yo lo hubiera hecho en publico

            private int atomosC { get { return _atomosC; } }
            private int atomosN { get { return _atomosN; } }
            private int atomosH { get { return _atomosH; } }
            private int atomosO { get { return _atomosO; } }
            private int atomosS { get { return _amomosS; } }


            private string nombre { get { return _nombre; } }
            private string abreviaturaLarga { get { return _abreviaturaLarga; } }
            private string abreviaturaCorta { get { return _abreviaturaCorta; } }


            private float pesoMoleclar { get { return _pesoMolecular; } }


            

            private bool esEsencial { get { return _esEsencial; } }
            //ESENCIALES:
                //Valina (Val, V)
                //Leucina(Leu, L)
                //Treonina(Thr, T)
                //Lisina(Lys, K)
                //Triptófano(Trp, W)
                //Histidina(His, H)
                //Fenilalanina(Phe, F)
                //Isoleucina(Ile, I)
                //Arginina(Arg, R)
                //Metionina(Met, M)


        }
    }
}
