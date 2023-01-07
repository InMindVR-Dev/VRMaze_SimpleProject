using HumanVirtualMaze.Core;
using System;
using UnityEngine;

namespace UnityClasses
{

    //This class show how to use LiveData.EventManager.InteractionData
    //Since it can use more than 1x pointing device, InteractionData is a list
    //Most of the time it contains only one child
    public class RetreiveInteractionDeviceDataBehaviourExample : MonoBehaviour
    {


        void Update()
        {
            Console.WriteLine("Retreiving Interaction devices Data !");
            foreach (var item in LiveData.EventManager.InteractionData)
            {
                

                Console.WriteLine(item.Identifier);


                //We can get Vector3 values (containing verctor2 sometimes)
                foreach (var axe in item.Axes)
                {
                    Console.WriteLine("Axis value : " + axe.ToString());
                }

                //We can get float values

                foreach (var analog in item.Analogs)
                {
                    Console.WriteLine("Analog value : " + analog.ToString());
                }

                //We can get bool values

                foreach (var digital in item.Digitals)
                {
                    Console.WriteLine("digital value : " + digital.ToString());
                }

            }
            

        }

    }
}
