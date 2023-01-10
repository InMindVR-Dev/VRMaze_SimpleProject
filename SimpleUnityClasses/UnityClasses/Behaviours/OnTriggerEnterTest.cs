using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityClasses
{    
    //Exemple de classe utilisant la methode OnTriggerEnter.
    //Dans VRmaze, il est possible d'ajouter une collision à n'importe quel objet de manière à pouvoir detecter son entrée dans une zone.
    public class OnTriggerEnterTest : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            Debug.Log("Something entered my zone !");
            if(other!=null)
            {
                Debug.Log(other.gameObject.name);
            }
        }
    }    
}
