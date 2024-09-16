using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zinsrechner
{
    internal class Zinsen
    {
        //Attribute, nur innerhalb der Klasse sichtbar
        float _Kapital;
        float _Zins; 
        float _Zinssatz;
        //Eigenschaften, die außerhalb der Klasse verwendet werden
        public float Kapital { get => _Kapital; set => _Kapital = value; }
        public float Zins { get => _Zins; set => _Zins = value; }
        public float Zinssatz { get => _Zinssatz; set => _Zinssatz = value; }

        //Konstruktor der Klasse Zinsen mit Aufrufparametern
        public Zinsen(float f_kapital, float f_zinssatz)
        {
            Kapital = f_kapital;
            Zinssatz = f_zinssatz;
        }
        //Funktion, die außerhalb der Klasse verwendet werden kann
        public float Zinsberechnung()
        {
            float Zinsen = Kapital / 100 * Zinssatz;
            return Zinsen;
        }
    }
}
