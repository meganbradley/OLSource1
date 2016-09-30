---
title: "Add commands and gestures to layer diagrams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "layer diagrams, adding custom commands"
  - "layer diagrams, adding custom gestures"
ms.assetid: ac9c417b-0b40-4a90-86f5-ee3cbdce030b
caps.latest.revision: 42
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Add commands and gestures to layer diagrams
You can define context menu commands and gesture handlers on layer diagrams in Visual Studio. You can package these extensions into a Visual Studio Integration Extension (VSIX) that you can distribute to other Visual Studio users.  
  
 You can define several command and gesture handlers in the same Visual Studio project if you want. You can also combine several such projects into one VSIX. For example, you could define a single VSIX that includes layer commands, a domain-specific language, and commands for UML diagrams.  
  
> [!NOTE]
>  You can also customize architecture validation, in which users’ source code is compared with layer diagrams. You should define architecture validation in a separate Visual Studio project. You can add it to the same VSIX as other extensions. For more information, see [Adding Custom Architecture Validation to Layer Diagrams](../vs140/add-custom-architecture-validation-to-layer-diagrams.md).  
  
## Requirements  
 See [Extend layer diagrams](../vs140/extend-layer-diagrams.md#prereqs).  
  
## Defining a Command or Gesture in a New VSIX  
 The quickest method of creating an extension is to use the project template. This places the code and the VSIX manifest into the same project.  
  
#### To define an extension by using a project template  
  
1.  Create a project in a new solution, by using the **New Project** command on the **File** menu.  
  
2.  In the **New Project** dialog box, under **Modeling Projects**, select either **Layer Designer Command Extension** or **Layer Designer Gesture Extension**.  
  
     The template creates a project that contains a small working example.  
  
3.  To test the extension, press **CTRL+F5** or **F5**.  
  
     An experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] starts. In this instance, create a layer diagram. Your command or gesture extension should work in this diagram.  
  
4.  Close the experimental instance and modify the sample code. For more information, see [Programming Layer Models](../vs140/navigate-and-update-layer-models-in-program-code.md).  
  
5.  You can add more command or gesture handlers to the same project. For more information, see one of the following sections:  
  
     [Defining a Menu Command](#command)  
  
     [Defining a Gesture Handler](#gesture)  
  
6.  To install the extension in the main instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], or on another computer, find the **.vsix** file in **bin\\\***. Copy it to the computer where you want to install it, and then double-click it. To uninstall it, use **Extensions and Updates** on the **Tools** menu.  
  
## Adding a Command or Gesture to a separate VSIX  
 If you want to create one VSIX that contains commands, layer validators, and other extensions, we recommend that you create one project to define the VSIX, and separate projects for the handlers. For information about other types of modeling extension, see [Extending UML Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md).  
  
#### To add layer extensions to a separate VSIX  
  
1.  Create a Class Library project in a new or existing Visual Studio solution. In the **New Project** dialog box, click **Visual C#** and then click **Class Library**. This project will contain command or gesture handler classes.  
  
    > [!NOTE]
    >  You can define more than one command or gesture handler class in one class library, but you should define layer validation classes in a separate class library.  
  
2.  Identify or create a VSIX project in your solution. A VSIX project contains a file that is named **source.extension.vsixmanifest**. To add a VSIX project:  
  
    1.  In the **New Project** dialog box, expand **Visual C#**, then click **Extensibility**, and then click **VSIX Project**.  
  
    2.  In Solution Explorer, right-click the VSIX project and then click **Set as Startup Project**.  
  
    3.  Click **Select Editions** and make sure that **Visual Studio** is checked.  
  
3.  In **source.extension.vsixmanifest**, under **Assets**, add the command or gesture handler project as a MEF component.  
  
    1.  In the **Assets**.tab, choose **New**.  
  
    2.  At **Type**, select **Microsoft.VisualStudio.MefComponent**.  
  
    3.  At **Source**, select **Project in current solution** and select the name of your command or gesture handler project.  
  
    4.  Save the file.  
  
4.  Return to the command or gesture handler project, and add the following project references.  
  
|**Reference**|**What this allows you to do**|  
|-------------------|------------------------------------|  
|Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\ExtensibilityRuntime\Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.dll|Create and edit layers|  
|Microsoft.VisualStudio.Uml.Interfaces|Create and edit layers|  
|Microsoft.VisualStudio.ArchitectureTools.Extensibility|Modify shapes on diagrams|  
|System.ComponentModel.Composition|Define components using Managed Extensibility Framework (MEF)|  
|Microsoft.VisualStudio.Modeling.Sdk.[version]|Define modeling extensions|  
|Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]|Update shapes and diagrams|  
  
1.  Edit the class file in the C# class library project to contain the code for your extension. For more information, see one of the following sections:  
  
     [Defining a Menu Command](#command)  
  
     [Defining a Gesture Handler](#gesture)  
  
     See also [Programming Layer Models](../vs140/navigate-and-update-layer-models-in-program-code.md).  
  
2.  To test the feature, press CTRL+F5 or F5. An experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] opens. In this instance, create or open a layer diagram.  
  
3.  To install the VSIX in the main instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], or on another computer, find the **.vsix** file in the **bin** directory of the VSIX project. Copy it to the computer where you want to install the VSIX. Double-click the VSIX file in Windows Explorer (File Explorer in Windows 8).  
  
     To uninstall it, use **Extensions and Updates** on the **Tools** menu.  
  
##  \<a name="command">\</a> Defining a Menu Command  
 You can add more menu command definitions to an existing gesture or command project. Each command is defined by a class that has the following characteristics:  
  
-   The class is declared as follows:  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  *MyLayerCommand*  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   The namespace and the name of the class are unimportant.  
  
-   The methods that implement <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are as follows:  
  
    -   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> - The label that appears in the menu.  
  
    -   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> - called when the user right-clicks the diagram, and determines whether the command should be visible and enabled for the user's current selection.  
  
    -   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> - called when the user selects the command.  
  
-   To determine the current selection, you can import <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 For more information, see [Programming Layer Models](../vs140/navigate-and-update-layer-models-in-program-code.md).  
  
 To add a new command, create a new code file that contains the following sample. Then test and edit it.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="gesture">\</a> Defining a Gesture Handler  
 A gesture handler responds when the user drags items onto the layer diagram, and when the user double-clicks anywhere in the diagram.  
  
 To your existing command or gesture handler VSIX project, you can add a code file that defines a gesture handler:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice the following points about gesture handlers:  
  
-   The members of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are as follows:  
  
     **OnDoubleClick** - called when the user double-clicks anywhere on the diagram.  
  
     **CanDragDrop** - called repeatedly as the user moves the mouse while dragging an item onto the diagram. It must work quickly.  
  
     **OnDragDrop** - called when the user drops an item onto the diagram.  
  
-   The first argument to each method is an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, from which you can get the layer element. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   Handlers for some types of dragged item are already defined. For example, the user can drag items from Solution Explorer onto a layer diagram. You cannot define a drag handler for these types of item. In these cases, your <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> methods will not be invoked.  
  
 For more information about how to decode other items when they are dragged onto the diagram, see [How to Define a Gesture Handler on a Modeling Diagram](../vs140/define-a-gesture-handler-on-a-modeling-diagram.md).  
  
## See Also  
 [Programming Layer Models](../vs140/navigate-and-update-layer-models-in-program-code.md)   
 [Adding Custom Architecture Validation to Layer Diagrams](../vs140/add-custom-architecture-validation-to-layer-diagrams.md)   
 [How to: Define and Install a Modeling Extension](../vs140/define-and-install-a-modeling-extension.md)