using HumanVirtualMaze.Model;
using UnityEngine;

namespace UnityClasses
{

    //IEventListener est une interface dont les méthodes seront appelée par VRmaze losque l'utilisateur pointe sur l'objet parent.
    public class InteractionBehaviourExample : MonoBehaviour, IEventListener
    {

        //Exemple d'une variable de classe exposée dans l'éditeur Unity
        public int TotalCount = 1;

        //Cette fonction est exectuée lorsque l'utilisateur clique sur l'objet qui dispose de ce script.
        //Cette fonction peut etre laissée vide si besoin.
        public virtual void OnAction()
        {
            for (int i = 0; i < TotalCount; i++)
                Debug.Log("We click on it ! " + this.gameObject.name);
        }

        //Cette fonction est exectuée lorsque l'utilisateur clique avec n'importe quel bouton sur l'objet qui dispose de ce script.
        //Cette fonction peut etre laissée vide si besoin. 
        //L'adresse du bouton est affectée a buttonIndex, ce qui permet de dissocier les actions.
        public void OnAction(int buttonIndex)
        {
            for (int i = 0; i < TotalCount; i++)
                Debug.Log("We click on it ! " + this.gameObject.name + " Button index : " + buttonIndex );
        }

        //Cette fonction est exectuée lorsque l'utilisateur survole l'objet avec son pointeur.
        //Cette fonction peut etre laissée vide si besoin.
        public virtual void OnEnter() // N'est jamais sollicité !!! voir pkoi !
        {
            for (int i = 0; i < TotalCount; i++)
                Debug.Log("We entered it ! " + this.gameObject.name);
        }

        //Cette fonction est exectuée lorsque l'utilisateur sort de l'objet qui dispose de ce script.
        //Cette fonction peut etre laissée vide si besoin.
        public virtual void OnExit()
        {
            for (int i = 0; i < TotalCount; i++)
                Debug.Log("We exited it ! " + this.gameObject.name);
        }

        //Cette fonction est exectuée lorsque l'utilisateur survole l'objet avec son pointeur.
        //Cette fonction peut etre laissée vide   
        public virtual void OnOver()
        {
            for (int i = 0; i < TotalCount; i++)
                Debug.Log("We are on it ! " + this.gameObject.name);
        }

        //Method Start de Unity, on fait ce que l'on veut ici

        void Start()
        {
            for (int i = 0; i < TotalCount; i++)
                Debug.Log("Starting my Behaviour");
        }

        //Method Update de Unity, on fait ce que l'on veut ici
        void Update()
        {
        }
    }
}
