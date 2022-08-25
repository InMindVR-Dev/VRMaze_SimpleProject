using HumanVirtualMaze.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityClasses
{
    //Exemple de classe permettant d'obtenir les informations de pointage.
    public class GetPointingDataBehaviourExample : MonoBehaviour
    {
        //Le mouseEventManagerBehaviour provient de HumanVirtualMaze_core.dll
        public MouseEventManagerBehaviour PointingManager { get; set; }
        void Start() {
            PointingManager = null;
        
        }

        void Update() {
            FindPointingManager();

            if (PointingManager != null)
            {
                Process();
            }
        
        }

        public virtual void Process()
        {
            if (PointingManager.Hit != null)
            {
                //On a un objet pointé, on affiche certaines informations
                Debug.Log("Processing Hit data :" + PointingManager.Hit.Value.point);
                Debug.Log("Processing Ray data :" + PointingManager.RayData.origin);
                Debug.Log("Processing Class info : " + PointingManager.GetType().FullName);
                Debug.Log("Processing GameObject info : " + PointingManager.gameObject.name);
            }
        }

        //Recherche du système de pointage de VRmaze.
        public  void FindPointingManager()
        {
            //Fonctionne aussi en éditeur, attention, cela alourdi un peu le traitement !
            //Si le système est trouvé, on sort instantanément.
            if (PointingManager != null) return;

            //Maintenant on cherche le gestionnaire de Pointage

            MouseEventManagerBehaviour[] objectList= UnityEngine.Object.FindObjectsOfType<MouseEventManagerBehaviour>(true);
            if (objectList.Length > 0)
            {
                //Attention, il est possible qu'il existe deux Gestionnaire de Pointage si l'option Use Default Event Manager est activé sur le système de caméra de rendu.

                Debug.Log("Pointing manager found!");
                PointingManager = objectList[0];


                for(int i = 0; i < objectList.Length; i++)
                {
                    Console.WriteLine("Debug Pointing Event Manager Instance : " + objectList[i].gameObject.name);
                }

            }
            else
            {
                Debug.Log("Pointing manager not found!");
                PointingManager = null;
            }

        }

        //Méthode permettant d'afficher quelques informations.
        void OnGUI()
        {
            if (PointingManager == null) return;
            if (PointingManager.Hit == null) return;

            GUI.Label(new Rect(0, 0, 500, 50), "We hit something : " + PointingManager.Hit.Value.point);

        }


    }
}
