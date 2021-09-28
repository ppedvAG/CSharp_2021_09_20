using System;

namespace M007_05_ZugriffsmodifiziereLib
{ 
    public class Fahrzeuge //Achtung Konventionen sind jetzt in der Form der Schreibweise nicht gerade korrekt
    {
        public int PublicGeschwindigkeit;

        private string PrivateFarbe; // Innerhalb einer Klasse

        internal object InternalRadio; //Innerhalb eines Assemblies (Dll) 

        protected object ProtectedAntrieb; // Innerhalb des Vererbungsbaumes 

        protected internal object ProtectedInternalKofferraum; 

        private protected object PrivateProtectedLenkrad;

        public void Lackiere()
        {
            //Private kann nur innerhalb der Klasse verwendet werden, die in dieser auch definiert ist. 
            this.PrivateFarbe = "Orange";
        }
    }

    public class ElectroCar : Fahrzeuge
    {
        public void WhatWeCanUse()
        {
            this.PublicGeschwindigkeit = 123;
            this.InternalRadio = new object();
            this.ProtectedAntrieb = new object();
            this.ProtectedInternalKofferraum = new object();
            this.PrivateProtectedLenkrad = new object();

            //Einzige was aussen vor ist -> Private 
        }
    }

    public class FahrzeugImplementierung
    {
        public void Test()
        {
            Fahrzeuge fahrzeuge = new Fahrzeuge();
            fahrzeuge.PublicGeschwindigkeit = 123;
            fahrzeuge.InternalRadio = new object();
            fahrzeuge.ProtectedInternalKofferraum = new object();
            
        }
    }


    class ABC //Internal
    {
        public void Hello()
        {

        }
    }
}
