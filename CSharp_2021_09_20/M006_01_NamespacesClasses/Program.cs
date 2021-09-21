using System;
//Alias
using First = M006_01_NamespacesClasses.ErstesNamespace;
using Second = M006_01_NamespacesClasses.ZweitesNamespace;

//So kennen wir es normalerweise
using M006_01_NamespacesClasses.DrittesNamespace;
namespace M006_01_NamespacesClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Absolute Angabe: Namespace + Klassennamen erlange ich eine Eindeutigkeit
            M006_01_NamespacesClasses.ErstesNamespace.MeineKlasse myClass1 = new ErstesNamespace.MeineKlasse();
            M006_01_NamespacesClasses.ZweitesNamespace.MeineKlasse myClass2 = new ZweitesNamespace.MeineKlasse();

            //Beispiel mit Aliase
            First.MeineKlasse class1 = new First.MeineKlasse();
            Second.MeineKlasse class2 = new Second.MeineKlasse();


            //wegen using M006_01_NamespacesClasses.DrittesNamespace; -> kann man die Klasse direkt instanziieren (ohne Namespaceangabe) 
            MeineKlasse meineKlasse = new MeineKlasse(); //MeineKlasse aus  dritten Namespace wird instanzziert
        }
    }
}
