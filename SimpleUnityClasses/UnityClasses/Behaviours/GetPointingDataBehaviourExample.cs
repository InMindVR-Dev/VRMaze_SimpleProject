using HumanVirtualMaze.Core;
using UnityEngine;

namespace UnityClasses
{
    //Exemple de classe permettant d'obtenir les informations de pointage.
    //A partir de la version 2021.8.7.0000 il peut y avoir plusieurs système de pointage en même temps (ex. Deux manettes VR etc.)
    public class GetPointingDataBehaviourExample : MonoBehaviour
    {
        //2023 and above
        // LiveEventManagerDirectAccess.Singleton donne accès aux informations calculées par le gestionnaire l'évenements de vrmaze. Les informations sont mises à jour automatiquement a chaque frame.
        void Update()
        {
            LogRays();
            LogHits();
            LogObjects();
        }

        public void LogRays()
        {
            Debug.Log("Rays launched :" + LiveData.EventManager.Rays.Count);
            foreach (var item in LiveData.EventManager.Rays) 
                Debug.Log("Ray data:" + item.origin.ToString() + " " + item.direction);            
        }

        public void LogObjects()
        {
            Debug.Log("Objects hit :" + LiveData.EventManager.Objects.Count);
            foreach (var item in LiveData.EventManager.Objects)
                Debug.Log("Object info:" + item.name);
        }

        public void LogHits()
        {
            Debug.Log("Hits count :" + LiveData.EventManager.Hits.Count);
            foreach (var item in LiveData.EventManager.Hits)
                Debug.Log("Hit info:" + item.point.ToString());
        }

        //Méthode permettant d'afficher quelques informations.
        void OnGUI()
        {
            for(int i =0;i< LiveData.EventManager.Hits.Count;i++)
                GUI.Label(new Rect(0, i*50, 500, 50), "We hit something : " + LiveEventManagerDirectAccess.Singleton.Hits[i].point);
        }
    }
}
  