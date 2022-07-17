# VRMaze_SimpleProject
Project that enables Unity MonoBehaviour interaction with InMind-VR framework

This Visual Studio project only requires HumanVirtualMaze_Core.dll and UnityEngine.dll to compile. These dll is available and up to date inside VRMaze software installation folder.

Once builded, put the UnityClasses.dll inside Plugins folder from the VRmaze installation folder and in your Unity Project (Assets/Plugins) so that, on Asset Bundle build, all objects that are currently using components from UnityClasses.dll will work inside VRmaze too.
