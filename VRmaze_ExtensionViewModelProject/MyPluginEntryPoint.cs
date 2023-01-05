using HumanVirtualMaze.Plugin;
using HumanVirtualMaze.UI.Managers;
using System;
using System.Windows;

namespace HumanVirtualMaze.ViewModel
{
    public class MyPluginEntryPoint : IPlugin
    {


        public MyPluginEntryPoint()
        {
            Console.WriteLine("Creating new Plugin management node for My Plugin");

        }

        public void AddDataResourceDictionnary()
        {
            Console.WriteLine("Try to add dictionnary MyCustomPlugin");
            ResourceDictionary Dictionary = new ResourceDictionary
            {

                Source = new Uri(@"pack://application:,,,/VRmazeClasses_ViewModel;component/ResourceDictionary.xaml", UriKind.RelativeOrAbsolute)
            };


          
            ResourceDictionaryManager.GetResourceDictonary().MergedDictionaries.Add(Dictionary);
          

        }
    }
}
