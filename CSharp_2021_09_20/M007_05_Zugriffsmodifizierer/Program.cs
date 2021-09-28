using M007_05_ZugriffsmodifiziereLib;
using System;

namespace M007_05_Zugriffsmodifizierer
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeuge fahrzeuge = new Fahrzeuge();
            fahrzeuge.PublicGeschwindigkeit = 123; //von aussen können wir nur Public aufrufen 

        }
    }

    public class ElectroCar : Fahrzeuge
    {
        public void WhatWeCanUse()
        {
            this.PublicGeschwindigkeit = 123;
            this.ProtectedAntrieb = new object();
            this.ProtectedInternalKofferraum = new object();

            //this.InternalRadio = new object(); InternalRadio ist nur in der M007_05_ZugriffsmodifiziereLib möglich
            //this.PrivateProtectedLenkrad = new object();
            //Einzige was aussen vor ist -> Private 
        }
    }

    class DEF
    {

    }
}
