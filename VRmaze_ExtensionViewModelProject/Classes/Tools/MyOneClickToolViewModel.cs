using HumanVirtualMaze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Warning, here we wait for the default namespace HumanVirtualMaze.ViewModel
//This project and all its classes are only loaded in VRmaze Designer UI, not inside Unity Viewer.

namespace HumanVirtualMaze.ViewModel
{


    //These classes are so optimized so that we only need few declarations to make it work inside VRmaze.
    //Vrmaze will associate a model classe to its ViewModel class by searching baseclassname+"ViewModel" in all available type names
    //So this class must have the same name as its associated Model class with the token "ViewModel" at the end.
    public class MyOneClickToolViewModel : SimpleButtonToolViewModel
    {

        //First, we want the tool to be displayed and addable in all cases, so DisplayedItem() should return true always.
        public override bool DisplayedItem() => true;


        //Now we setup Context Menu texts by setup tool category name
        //Use | to setup sub categories
       public override string GetCategoryMenuName() => "My Custom Tools";


        //Ctor is just an empty declaration
        public MyOneClickToolViewModel(MyOneClickTool my) : base(my)
        {}


    }
}
