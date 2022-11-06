using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UnityEngine;

namespace HumanVirtualMaze.Model
{
    [XmlRoot("Tool")]
    public class MyOneClickToolExtension : MyOneClickTool
    {


        //Let's imagine we need some properties that we want to be savec in our Xml file...
        //We add an XmlAttribute attribute on any property (and property only)
        [XmlAttribute]
        public int MyIntValue { get; set; }

        //Let's use a bool value too
        [XmlAttribute]
        public bool MyBoolValue { get; set; }


        //Let's use another property, but this time, we do not want to save it
        //We just add a XmlIgnore attribute on this property
        [XmlIgnore]
        public List<GameObject> MyGameObjects { get; set; }

        [XmlIgnore]
        public int CallCount { get; set; }

        public MyOneClickToolExtension() : base()
        {
            Name = "My One click Tool Extension";
            ButtonColor = new Color(1f, 1f, 1f, 0.9f);
            ToolTip = "My One click tool extension Tooltip";

            //Assigning default value 
            MyIntValue = 5;
            MyBoolValue = true;
            CallCount = 0;

            
        }

        public override void ProcessTool()
        {
            Console.WriteLine("Starting My OneClickTool extension !");
            //Creating a new list if needed.
            if (MyGameObjects == null)
            {
                Console.WriteLine("Creating a new GameObject List");
                MyGameObjects = new List<GameObject>();
            }
                                  
                for (int i = 0; i < MyGameObjects.Count; i++)
                {
                    GameObject.Destroy(MyGameObjects[i]);
                }
                MyGameObjects.Clear();


            string info = "";
            for (int i = 0; i < MyIntValue; i++)
            {
                //Let's create some empty gameobjects for our test
                GameObject go = new GameObject();
                go.name = "MyCustomToolObject_" + i;
                go.transform.position = new Vector3(0, 0, i);

                MyGameObjects.Add(go);
                info += MyBoolValue ? go.name + "\n" : go.name + " " + go.transform.position.ToStringPrecision() + "\n";
            }

            

            //Updating Information panel text with erasing any other information texts.
            GetToolsGroupParent().UpdatePanelInfoText(info, true);

            //Tool process is finished so we must put its state to ToolState.Finished.
            //If not, ProcessTool() will be called next frame and next while State!=ToolState.Finished
            State = ToolState.Finished;

        }



    }
}
