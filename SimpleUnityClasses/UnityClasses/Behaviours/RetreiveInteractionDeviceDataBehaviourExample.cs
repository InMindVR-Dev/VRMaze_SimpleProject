using HumanVirtualMaze.Core;
using System;
using UnityEngine;

namespace UnityClasses
{
    public class RetreiveInteractionDeviceDataBehaviourExample : MonoBehaviour
    {


        void Update()
        {
            Console.WriteLine("Retreiving Interaction devices Data !");
            foreach (var item in LiveData.EventManager.InteractionData)
            {
                //on a des valeurs d'axes genre joystick

                foreach (var axe in item.Axes)
                {
                    Console.WriteLine("Axis value : " + axe.ToString());
                }

                //On peut avoir des valeurs analogiques genre gachette

                foreach (var analog in item.Analogs)
                {
                    Console.WriteLine("Analog value : " + analog.ToString());
                }

                //On peut avoir des valeurs booleennes genre boutons

                foreach (var digital in item.Digitals)
                {
                    Console.WriteLine("Analog value : " + digital.ToString());
                }

            }
            

        }

    }
}
