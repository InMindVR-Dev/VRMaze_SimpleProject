using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityClasses
{
	//Exemple de script qui permet le changement de couleur d'un objet lorsqu'on pointe dessus.
   public  class ChangeColorBehaviourExample : InteractionBehaviourExample
    {

		public Color original, onOver, onClick;

		void Start()
		{
			original = gameObject.GetComponent<MeshRenderer>().material.color;
		}

		public override void OnOver()
		{
			this.GetComponent<MeshRenderer>().material.color = onOver;
		}

		public override void OnExit()
		{

			this.GetComponent<MeshRenderer>().material.color = original;
		}

		public override void OnAction()
		{
			this.GetComponent<MeshRenderer>().material.color = onClick;
		}

	}
}
