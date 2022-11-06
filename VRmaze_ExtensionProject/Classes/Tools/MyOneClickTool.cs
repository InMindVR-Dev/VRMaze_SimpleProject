using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UnityEngine;

namespace HumanVirtualMaze.Model
{


    /// <summary>
    /// This simple class create a new tool that run ProcessTool() method on click.
    /// ProcessTool() method can use any Unity calls
    /// ctor and other methods are called as well by VRmaze Designer UI so it can't handle any Unity calls.
    /// To allow node save, we must declare a XmlRoot attribute on the class, and use "Tool" as Xml element name.
    /// </summary>

    [XmlRoot("Tool")]
    public class MyOneClickTool : SimpleButtonTool
    {

        //ctor is used by VRmaze Designer UI, so it can't handle any Unity Calls
        public MyOneClickTool() : base()
        {
            Name = "My One click Tool";
            ButtonColor = new Color(1f, 1f, 1f, 0.9f);
            ToolTip = "My One click tool Tooltip";
            SourceImage = "Tool_screenshot.png";
        }



        //This method is called only using Uniity Viewer, so it can use any Unity commands !
        public override void ProcessTool()
        {
            Console.WriteLine("Starting My OneClickTool");

            Debug.Log("My OneClick to can call Unity Method !");

            //Updating Information panel text without erasing any other information texts.
            GetToolsGroupParent().UpdatePanelInfoText("My One Click tool finished ", false);
            
            //Tool process is finished so we must put its state to ToolState.Finished.
            //If not, ProcessTool() will be called next frame and next while State!=ToolState.Finished
            State = ToolState.Finished;

        }

        //Here is an example using unity embed screen capture function
        /*       

         //This method is called only using Uniity Viewer, so it can use any Unity commands !
        public override void ProcessTool()
        {
            Console.WriteLine("Creating screenshot from current view");

            if (!Directory.Exists(StaticFunctions.GetVRmazePersonnalFolder() + "/ScreenShots/"))
            {
                Directory.CreateDirectory(StaticFunctions.GetVRmazePersonnalFolder() + "/ScreenShots/");
            }

            string endFilename = DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss") + ".png";
            ScreenCapture.CaptureScreenshot(StaticFunctions.GetVRmazePersonnalFolder() + "/ScreenShots/" + endFilename);
            GetToolsGroupParent().UpdatePanelInfoText("ScreenShot : " + endFilename, false);

            State = ToolState.Finished;

        }



        */






    }
}
