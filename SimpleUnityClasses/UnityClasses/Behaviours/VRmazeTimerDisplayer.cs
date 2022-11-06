using HumanVirtualMaze.Model;
using UnityEngine;

namespace UnityClasses
{
    public class VRmazeTimerDisplayer : MonoBehaviour
    {
        void OnGUI()
        {
            GUI.Label(new Rect(5, 20, 200, 20), "Current Unity time:"+ Time.time.ToString());
            GUI.Label(new Rect(5, 40, 200, 20), "Current VRmaze time:" + LiveData.Timer.CurrentTimer.ToString());
            GUI.Label(new Rect(5, 60, 200, 20), "Current Experiment time:" + LiveData.Timer.CurrentExperimentTimer.ToString());
            GUI.Label(new Rect(5, 80, 200, 20), "Current Trial time:" + LiveData.Timer.CurrentTrialTimer.ToString());
        }
    }
}
