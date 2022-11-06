# SimpleUnityClasses project
Project that enables Unity MonoBehaviour handling with InMind-VR framework interaction system

This Visual Studio project only requires HumanVirtualMaze_Core.dll and UnityEngine.dll to compile. These dll is available and up to date inside VRMaze software installation folder.

Once builded, put the UnityClasses.dll inside Plugins folder from the VRmaze installation folder and in your Unity Project (Assets/Plugins) so that, on Asset Bundle build, all objects that are currently using components from UnityClasses.dll will work inside VRmaze too.

## VRmaze Extension project

2 projects show basic usage of the VRmaze Framework in order to add nodes and create new features inside VRmaze. Since Unity cannot handle MVVM pattern and Windows libraries, we need two project, one used in VRmaze Designer UI and Unity Viewer and the second one exclusively inside VRmaze Designer. The first project show how to create some Model nodes and the second one acts as the ViewModel project (the view is automatised by C# property Attributes.

Once build, put the 2x .dll files inside Plugin folder from the VRmaze installation folder.
