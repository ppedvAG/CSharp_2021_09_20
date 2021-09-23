using System;

using System.Reflection;

namespace M011_01_TaschenrechnerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dll wird in das Assembly-Object geladen
            Assembly geladeneDll = Assembly.LoadFrom("M011_01_TaschenrechnerLib.dll");

            Type taschenrechnerTyp = geladeneDll.GetType("M011_01_TaschenrechnerLib.Rechner");
            object tr = Activator.CreateInstance(taschenrechnerTyp);

            MethodInfo addInfo = taschenrechnerTyp.GetMethod("Add", new Type[] { typeof(Int32), typeof(Int32) });

            var result = addInfo.Invoke(tr, new object[] { 11, 22 });
            Console.WriteLine(result);
        }
    }
}
