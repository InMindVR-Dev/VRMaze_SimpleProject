using HumanVirtualMaze.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanVirtualMaze.ViewModel
{


    //This class is an extension of MyOneClickToolViewModel
	//The BaseClassView Attribute on a ViewModel class allo to merge UI component with the parent Component and so on
	[BaseClassView(MergeWithParent =true)]
    public class MyOneClickToolExtensionViewModel : MyOneClickToolViewModel
    {

		//this time, we do not need to override DisplayedItem method nor GetCategoryMenuName because it is already setup in the parent class.

		//This time we need to declare some property in order to set them inside VRmaze


		// Property declaration
		// In order to manipulate custom properties in VRmaze UI, we need to declare the same properties with the same names as the mmodel class
		// We can't use directly Model class because Unity can't Handle MVVM pattern with extensive use of OnPropertyChanged calls.



		//We declare an int to match MyIntValue form model Class
		//We add an IntegerView Attribute in order to handle UI process
		//In this case, we can specify UI Min and Max, Default Value and Increment Step
		//We can bind custom associated UI text too, but here, we will use default binding names

		//in all cases, default binding follows the rule :
		// ClassName.PropertyName.Content.Text for the displayed text
		// ClassName.PropertyName.Tooltip.Title for the tooltip title text 
		// ClassName.PropertyName.Tooltip.Text  for the tooltip text

		// for this property, dictionnary should contains :
		// MyOneClickToolExtensionViewModel.MyIntValue.Content.Text
		// MyOneClickToolExtensionViewModel.MyIntValue.Tooltip.Title
		// MyOneClickToolExtensionViewModel.MyIntValue.ToolTip.Text

		[IntegerView (Min =0, Max =10, DefaultValue =5, IncrementStep =1)]
		public int MyIntValue
		{
			//when setting MyIntValue, we in fact set Model Property Value
			//Any ViewModel class has a Property named ObjectID that link to its own Model Instance linked in the ctor
			get => ((MyOneClickToolExtension)this.ObjectID).MyIntValue;
			set
			{
				//Handling undo-redo
				//These two lines 
				int v = value;
				UndoRedoManager.Push(() => ((MyOneClickToolExtension)this.ObjectID).MyIntValue = v);


				//On set will in fact set model property value
				((MyOneClickToolExtension)this.ObjectID).MyIntValue = value;

				//Handling MVVM update
				OnPropertyChanged("MyIntValue", ViewerUpdateState.OnlySend);
			}
		}

		//This BoolViewAttribute allows to display a check box controling the property
		[BoolView]
		public bool MyBoolValue
		{
			//when setting MyIntValue, we in fact set Model Property Value
			//Any ViewModel class has a Property named ObjectID that link to its own Model Instance linked in the ctor
			get => ((MyOneClickToolExtension)this.ObjectID).MyBoolValue;
			set
			{
				//Handling undo-redo
				//These two lines 
				bool v = value;
				UndoRedoManager.Push(() => ((MyOneClickToolExtension)this.ObjectID).MyBoolValue = v);


				//On set will in fact set model property value
				((MyOneClickToolExtension)this.ObjectID).MyBoolValue = value;

				//Handling MVVM update
				OnPropertyChanged("MyBoolValue", ViewerUpdateState.OnlySend);
			}
		}

		public MyOneClickToolExtensionViewModel(MyOneClickToolExtension my) : base(my) { }


    }
}
