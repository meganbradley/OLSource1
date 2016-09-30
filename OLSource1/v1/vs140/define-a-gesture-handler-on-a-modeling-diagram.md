---
title: "Define a gesture handler on a modeling diagram"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML - extending, double-click"
  - "UML - extending, drag and drop"
ms.assetid: e5e1d70a-3539-4321-a3b1-89e86e4d6430
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Define a gesture handler on a modeling diagram
In Visual Studio, you can define commands that are performed when the user double-clicks or drags items onto a UML diagram. You can package these extensions into a Visual Studio Integration Extension ([VSIX](http://go.microsoft.com/fwlink/?LinkId=160780)) and distribute it to other Visual Studio users.  
  
 If there is already a built-in behavior for the type of diagram and the type of element that you want to drag, you might not be able to add to or override this behavior.  
  
## Requirements  
 See [Extend UML models and diagrams](../vs140/extend-uml-models-and-diagrams.md#Requirements).  
  
 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
## Creating a Gesture Handler  
 To define a gesture handler for a UML designer, you must create a class that defines the behavior of the gesture handler, and embed that class in a Visual Studio Integration Extension (VSIX). The VSIX acts as a container that can install the handler. There are two alternative methods of defining a gesture handler:  
  
-   **Create a gesture handler in its own VSIX using a project template.** This is the quicker method. Use it if you do not want to combine your handler with other types of extension such as validation extensions, custom toolbox items, or menu commands.  
  
-   **Create separate gesture handler and VSIX projects.** Use this method if you want to combine several types of extension into the same VSIX. For example, if your gesture handler expects the model to observe specific constraints, you could embed it into the same VSIX as a validation method.  
  
#### To create a gesture handler in its own VSIX  
  
1.  In the **New Project** dialog box, under **Modeling Projects**, select **Gesture Extension**.  
  
2.  Open the **.cs** file in the new project and modify the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class to implement your gesture handler.  
  
     For more information, see [Implementing the Gesture Handler](#Implementing).  
  
3.  Test the gesture handler by pressing F5. For more information, see [Executing the Gesture Handler](#Executing).  
  
4.  Install the gesture handler on another computer by copying the file **bin\\\*\\\*.vsix** that is built by your project. For more information, see [Installing and uninstalling an extension](#Installing).  
  
 Here is the alternative procedure:  
  
#### To create a separate class library (DLL) project for the gesture handler  
  
1.  Create a Class Library project, either in a new [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] solution, or in an existing solution.  
  
    1.  On the **File** menu, choose **New**, **Project**.  
  
    2.  Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then in the middle column choose **Class Library**.  
  
2.  Add the following references to your project.  
  
     <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> – You need this only if you are extending Layer diagrams. For more information, see [Creating extensions for layer diagrams](../vs140/extend-layer-diagrams.md).  
  
3.  Add a class file to the project and set its content to the following code.  
  
    > [!NOTE]
    >  Change the namespace and class name according to your preference.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     For more information about what to put in the methods, see [Implementing the Gesture Handler](#Implementing).  
  
 You must add your menu command to a VSIX project, which acts as a container for installing the command. If you want, you can include other components in the same VSIX.  
  
#### To add a separate gesture handler to a VSIX project  
  
1.  You do not need this procedure if you have created the gesture handler with its own VSIX.  
  
2.  Create a VSIX project, unless your solution already has one.  
  
    1.  In **Solution Explorer**, on the shortcut menu of the solution, choose **Add**, **New Project**.  
  
    2.  Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then select **Extensibility**. In the middle column, choose **VSIX Project**.  
  
3.  Set the VSIX project as the startup project of the solution.  
  
    -   In Solution Explorer, in the shortcut menu of the VSIX project, choose **Set as StartUp project**.  
  
4.  In **source.extension.vsixmanifest**, add the gesture handler class library project as a MEF Component:  
  
    1.  On the **MetaData** tab, set a name for the VSIX.  
  
    2.  On the **Install Targets** tab, set the Visual Studio versions as the targets.  
  
    3.  On the **Assets** tab, choose a **New**, and in the dialog box, set:  
  
         **Type** = **MEF Component**  
  
         **Source** = **A project in current solution**  
  
         **Project** = *Your class library project*  
  
##  \<a name="Executing">\</a> Executing the Gesture Handler  
 For test purposes, execute your gesture handler in debug mode.  
  
#### To test the gesture handler  
  
1.  Press **F5**, or on the **Debug** menu, click **Start Debugging**.  
  
     An experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] starts.  
  
     **Troubleshooting**: If a new [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] does not start:  
  
    -   If you have more than one project, make sure that the VSIX project is set as the Startup project of the solution.  
  
    -   In Solution Explorer, on the shortcut menu of the startup or only project, choose Properties. In the project properties editor, choose the **Debug** tab. Make sure that the string in the **Start external program** field is the full pathname of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], typically:  
  
         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
2.  In the experimental [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], open or create a modeling project, and open or create a modeling diagram. Use a diagram that belongs to one of the types listed in the attributes of your gesture handler class.  
  
3.  Double-click anywhere on the diagram. Your double-click handler should be called.  
  
4.  Drag an element from UML Explorer onto the diagram. Your drag handler should be called.  
  
 **Troubleshooting**: If the gesture handler does not work, make sure that:  
  
-   The gesture handler project is listed as a MEF component in the **Assets** tab in **source.extensions.manifest** in the VSIX project.  
  
-   The parameters of all the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attributes are valid.  
  
-   The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method is not returning <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
-   The type of model diagram you are using (UML class, sequence, and so on) is listed as one of the gesture handler class attributes [ClassDesignerExtension], [SequenceDesignerExtension] and so on.  
  
-   There is no built-in functionality already defined for this type of target and dropped element.  
  
##  \<a name="Implementing">\</a> Implementing the Gesture Handler  
  
### The Gesture Handler Methods  
 The gesture handler class implements and exports \<xref:Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement.IGestureExtension*>. The methods you need to define are as follows:  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Return <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to allow the source element referenced in <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to be dropped on this target.\<br />\<br /> This method should not make changes to the model. It should work quickly, because it is used to determine the arrow state as the user moves the mouse.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Update the model based on the source object referenced in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, and the target.\<br />\<br /> Called when the user releases the mouse after dragging.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is the shape that the user double-clicked.|  
  
 You can write handlers that can accept not only UML also a wide variety of other items, such as files, nodes in a .NET class view, and so on. The user can drag any of these items onto a UML diagram, provided you write an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method that can decode the serialized form of the items. The decoding methods vary from one type of item to another.  
  
 The parameters of these methods are:  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. The shape or diagram onto which the user has dragged something.  
  
     <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is a class in the implementation that underlies the UML modeling tools. To reduce the risk of putting the UML model and diagrams into an inconsistent state, we recommend that you do not use the methods of this class directly. Instead, wrap the element in an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and then use the methods described in [How to: Display a Model on Diagrams](../vs140/display-a-uml-model-on-diagrams.md).  
  
    -   To obtain an <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
    -   To obtain the model element that is targeted by the drag or double-click operation:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
         You can cast this to a more specific type of element.  
  
    -   To obtain the UML model store that contains the UML model:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    -   To obtain access to the host and service provider:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. This parameter carries the serialized form of the source object of a drag operation:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     You can drag elements of many different kinds onto a diagram, from different parts of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], or from the Windows desktop. Different types of element are encoded in different ways in <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. To extract the elements from it, refer to the documentation for the appropriate type of object.  
  
     If your source object is a UML element dragged from UML Model Explorer or from another UML diagram, refer to [How to: Obtain UML Elements from IDataObject](../vs140/get-uml-model-elements-from-idataobject.md).  
  
### Writing the code of the methods  
 For more information about writing the code to read and update the model, see [Programming with the UML API](../vs140/programming-with-the-uml-api.md).  
  
 For information about accessing model information in a drag operation, see [How to: Get UML Model Elements from IDataObject](../vs140/get-uml-model-elements-from-idataobject.md).  
  
 If you are dealing with a sequence diagram, see also [Programming Interactions](../vs140/edit-uml-sequence-diagrams-by-using-the-uml-api.md).  
  
 In addition to the parameters of the methods, you can also declare an imported property in your class that provides access to the current diagram and model.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The declaration of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> allows you to write code in your methods that accesses the diagram, current selection, and model:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 For more information, see [How to: Navigate the UML Model](../vs140/navigate-the-uml-model.md).  
  
##  \<a name="Installing">\</a> Installing and uninstalling an extension  
 You can install a [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] extension both on your own computer and on other computers.  
  
#### To install an extension  
  
1.  In your computer, find the **.vsix** file that was built by your VSIX project.  
  
    1.  In **Solution Explorer**, on the shortcut menu of the VSIX project, choose **Open Folder in Windows Explorer**.  
  
    2.  Locate the file **bin\\\*\\***YourProject***.vsix**  
  
2.  Copy the **.vsix** file to the target computer on which you want to install the extension. This can be your own computer or another one.  
  
     The target computer must have one of the editions of [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] that you specified in **source.extension.vsixmanifest**.  
  
3.  On the target computer, open the **.vsix** file.  
  
     **Visual Studio Extension Installer** opens and installs the extension.  
  
4.  Start or restart [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)].  
  
#### To uninstall an extension  
  
1.  On the **Tools** menu, choose **Extensions and Updates**.  
  
2.  Expand **Installed Extensions**.  
  
3.  Select the extension, and then choose **Uninstall**.  
  
 Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from:  
  
 *%LocalAppData%* **\Local\Microsoft\VisualStudio\\[version]\Extensions**  
  
##  \<a name="DragExample">\</a> Example  
 The following sample shows how to create lifelines in a sequence diagram, based on the parts and ports of a component, dragged from a component diagram.  
  
 To test it, press F5. An experimental instance of Visual Studio opens. In this instance, open a UML model and create a component on a component diagram. Add to this component some interfaces and internal component parts. Select the interfaces and parts. Then drag the interfaces and parts onto a sequence diagram. (Drag from the component diagram up to the tab for the sequence diagram, and then down into the sequence diagram.) A lifeline will appear for each interface and part.  
  
 For more information about binding interactions to sequence diagrams, see [How to Edit Interactions using the UML API](../vs140/edit-uml-sequence-diagrams-by-using-the-uml-api.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The code of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is described in [How to: Get UML Elements from IDataObject](../vs140/get-uml-model-elements-from-idataobject.md).  
  
## See Also  
 [How to: Define and Install a Modeling Extension](../vs140/define-and-install-a-modeling-extension.md)   
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [How to Define a Menu Command on a Modeling Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md)   
 [How to use validation constraints](../vs140/define-validation-constraints-for-uml-models.md)   
 [Programming with the UML API](../vs140/programming-with-the-uml-api.md)