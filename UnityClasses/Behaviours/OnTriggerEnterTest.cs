using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityClasses
{
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
