using PluginBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AppWithPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1 && args[0] == "/d")
                {
                    Console.WriteLine("Waiting for any key...");
                    Console.ReadLine();
                }

                
                //Verwende ein eigenes Plugin-Verzeichnis
                //kopiere alle Dlls rein
                //Lese Verzeichnis aus Dicretory.GetFiles mit Filter auf *.dll

                string[] pluginPaths = new string[]
                {
                    @"CSharpAdvancedPlugin\bin\Debug\netcoreapp3.0\CSharpAdvancedPlugin.dll",
                    @"PPEDVPlugIn\bin\Debug\netcoreapp2.1\PPEDVPlugIn.dll",
                    @"HelloPlugin\bin\Debug\netcoreapp3.0\HelloPlugin.dll",
                    @"JsonPlugin\bin\Debug\netcoreapp3.0\JsonPlugin.dll",
                    @"XcopyablePlugin\bin\Debug\netcoreapp3.0\XcopyablePlugin.dll",
                    @"OldJsonPlugin\bin\Debug\netcoreapp2.1\OldJsonPlugin.dll",
                    @"FrenchPlugin\bin\Debug\netcoreapp2.1\FrenchPlugin.dll",
                    @"UVPlugin\bin\Debug\netcoreapp2.1\UVPlugin.dll",
                };


                //Achtung Select Many macht eine Schleife
                IEnumerable<ICommand> commands = pluginPaths.SelectMany(pluginPath =>
                {
                    Assembly pluginAssembly = LoadPlugin(pluginPath);
                    return CreateCommands(pluginAssembly); //Prüfung ob Plugin-Zu meiner Application gehört -> Prüfung auf PluginBase.ICommand
                }).ToList();

                if (args.Length == 0)
                {
                    Console.WriteLine("Commands: ");
                    foreach (ICommand command in commands)
                    {
                        Console.WriteLine($"{command.Name}\t - {command.Description}");
                        command.Execute();
                    }
                }
                else
                {
                    foreach (string commandName in args)
                    {
                        Console.WriteLine($"-- {commandName} --");
                        ICommand command = commands.FirstOrDefault(c => c.Name == commandName);
                        if (command == null)
                        {
                            Console.WriteLine("No such command is known.");
                            return;
                        }

                        command.Execute();
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static Assembly LoadPlugin(string relativePath)
        {
            // Navigate up to the solution root
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location)))))));


            //Absoluter Pfad zur Dll -> Geht eigentlich smarter (wenn ein DLLVerzeichnis Verwendet wird + Verzeichnisangabe in appsetting.json
            string pluginLocation = Path.GetFullPath(Path.Combine(root, relativePath.Replace('\\', Path.DirectorySeparatorChar)));
            //Console.WriteLine($"Loading commands from: {pluginLocation}");
            PluginLoadContext loadContext = new PluginLoadContext(pluginLocation); //DLL von Plugin.
            return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(pluginLocation)));
        }

        static IEnumerable<ICommand> CreateCommands(Assembly assembly)
        {
            int count = 0;

            //Gehe alle imlementierten Typen innerhalb der geladenen Dll (AssemblyObj) durch. 
            foreach (Type type in assembly.GetTypes())
            {
                //Hier wird geprüft, ob die Dll zu meinem Programm gehört -< bzw ob die Dll von PluginBase.ICommand abgeleitet ist.
                if (type.GetInterfaces().Contains(typeof(PluginBase.ICommand)))
                {
                    ICommand result = Activator.CreateInstance(type) as ICommand;

                    
                    if (result != null)
                    {
                        count++;
                        yield return result;
                    }
                }
                //if (typeof(ICommand).IsAssignableFrom(type))
                //{
                //    ICommand result = Activator.CreateInstance(type) as ICommand;
                //    if (result != null)
                //    {
                //        count++;
                //        yield return result;
                //    }
                //}
            }

            if (count == 0)
            {
                string availableTypes = string.Join(",", assembly.GetTypes().Select(t => t.FullName));
                throw new ApplicationException(
                    $"Can't find any type which implements ICommand in {assembly} from {assembly.Location}.\n" +
                    $"Available types: {availableTypes}");
            }
        }
    }
}
