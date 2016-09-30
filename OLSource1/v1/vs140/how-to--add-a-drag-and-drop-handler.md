---
title: "How to: Add a Drag-and-Drop Handler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 39ee88a0-85c3-485e-8c0a-d9644c6b25d9
caps.latest.revision: 18
---
# How to: Add a Drag-and-Drop Handler
You can add handlers for drag-and-drop events to your DSL, so that users can drag items onto your diagram from other diagrams or from other parts of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. You can also add handlers for events such as double-clicks. Together, drag-and-drop and double-click handlers are known as *gesture handlers*.  
  
 This topic discusses drag-and-drop gestures that originate on other diagrams. For move and copy events within a single diagram, consider the alternative of defining a subclass of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. For more information, see [How to Customize Copy and Move](../vs140/customizing-copy-behavior.md). You might also be able to customize the DSL definition.  
  
## In this topic  
  
-   The first two sections describe alternative methods of defining a gesture handler:  
  
    -   [Defining Gesture Handlers by Overriding ShapeElement methods](#overrideShapeElement). <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and other methods can be overridden.  
  
    -   [Defining Gesture Handlers by using MEF](#MEF). Use this method if you want third-party developers to be able to define their own handlers to your DSL. Users can choose to install the third-party extensions after they have installed your DSL.  
  
-   [How to Decode the Dragged Item](#extracting). Elements can be dragged from any window or from the desktop, as well as from a DSL.  
  
-   [How to Get the Original Dragged Item](#getOriginal). If the dragged item is a DSL element, you can open the source model and access the element.  
  
-   [Using Mouse Actions: Dragging Compartment Items](#mouseActions). This sample demonstrates a lower-level handler that intercepts mouse actions on a shape’s fields. The example lets the user re-order the items in a compartment by dragging with the mouse.  
  
##  \<a name="overrideShapeElement">\</a> Defining Gesture Handlers by Overriding ShapeElement Methods  
 Add a new code file to your DSL project. For a gesture handler, you usually must have at least the following <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the new file, define a partial class for the shape or diagram class that should respond to the drag operation. Override the following methods:  
  
-   \<xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.OnDragOver*>- This method is called when the mouse pointer enters the shape during a drag operation. Your method should inspect the item that the user is dragging, and set the Effect property to indicate whether the user can drop the item on this shape. The Effect property determines the appearance of the cursor while it is over this shape, and also determines whether <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> will be called when the user releases the mouse button.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   \<xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.OnDragDrop*> – This method is called if the user releases the mouse button while the mouse pointer rests over this shape or diagram, if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> previously set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to a value other than <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   \<xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.OnDoubleClick*> – This method is called when the user double-clicks the shape or diagram.  
  
     For more information, see [How to intercept a click on a shape or decorator](../vs140/how-to--intercept-a-click-on-a-shape-or-decorator.md).  
  
 Define <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to determine whether the dragged item is acceptable, and ProcessDragDropItem(e) to update your model when the item is dropped. These methods must first extract the item from the event arguments. For information about how to do that, see [How to get a reference to the dragged item](#extracting).  
  
##  \<a name="MEF">\</a> Defining Gesture Handlers by using MEF  
 MEF (Managed Extensibility Framework) lets you define components that can be installed with minimal configuration. For more information, see [Managed Extensibility Framework Overview](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
#### To define a MEF gesture handler  
  
1.  Add to your **Dsl** and **DslPackage** projects the **MefExtension** files that are described in [Extend your DSL by using MEF](../vs140/extend-your-dsl-by-using-mef.md).  
  
2.  You can now define a gesture handler as a MEF component:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     You can create more than one gesture handler component, such as when you have different types of dragged objects.  
  
3.  Add partial class definitions for the target shape, connector or diagram classes, and define the methods <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. These methods must begin by extracting the dragged item from the event arguments. For more information, see [How to get a reference to the dragged item](#extracting).  
  
##  \<a name="extracting">\</a> How to decode the dragged item  
 When the user drags an item onto your diagram, or from one part of your diagram to another, information about the item that is being dragged is available in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. Because the drag operation could have started at any object on the screen, the data can be available in any one of a variety of formats. Your code must recognize the formats with which it is capable of dealing.  
  
 To discover the formats in which your drag source information is available, run your code in debugging mode, setting a breakpoint at the entry to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Inspect the values of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter. The information is provided in two forms:  
  
-   \<xref:System.Windows.Forms.IDataObject*>  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> – This property carries serialized versions of the source objects, usually in more than one format. Its most useful functions are:  
  
    -   diagramEventArgs.Data.GetDataFormats() – Lists the formats in which you can decode the dragged object. For example, if the user drags a file from the desktop, the available formats include the file name ("<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>").  
  
    -   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> – Decodes the dragged object in the specified format. Cast the object to the appropriate type. For example:  
  
         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
         You can also transmit objects such as model bus references from the source in your own custom format. For more information, see [How to Send Model Bus References in a Drag and Drop](#mbr).  
  
-   \<xref:Microsoft.VisualStudio.Modeling.ElementGroupPrototype*> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> – Use this property if you want users to drag items from a DSL or a UML model. An element group prototype contains one or more objects, links, and their property values. It is also used in paste operations and when you are adding an element from the toolbox. In a prototype, objects and their types are identified by Guid. For example, this code allows the user to drag class elements from a UML diagram or UML Model Explorer:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     To accept UML shapes, determine the Guids of the UML shape classes by experiment. Remember that there is usually more than one type of element on any diagram. Remember also that an object dragged from a DSL or UML diagram is the shape, not the model element.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> also has properties that indicate the current mouse pointer position and whether the user is pressing the CTRL, ALT, or SHIFT keys.  
  
##  \<a name="getOriginal">\</a> How to get the original of a dragged element  
 The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> properties of the event arguments contain only a reference to the dragged shape. Usually, if you want to create an object in the target DSL that is derived from the prototype in some way, you need to obtain access to the original, for example, reading the file contents, or navigating to the model element represented by a shape.  You can use Visual Studio Model Bus to help with this.  
  
### To prepare a DSL project for Model Bus  
  
1.  Make the source DSL accessible by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Model Bus:  
  
    1.  Download and install the Visual Studio Model Bus extension, if it is not already installed. For more information, see [Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=185579).  
  
    2.  Open the DSL definition file of the source DSL in DSL Designer. Right-click the design surface and then click **Enable Modelbus**. In the dialog box, choose one or both of the options.  Click **OK**. A new project "ModelBus" is added to the DSL solution.  
  
    3.  Click **Transform All Templates** and rebuild the solution.  
  
###  \<a name="mbr">\</a> To send an object from a source DSL  
  
1.  In your ElementOperations subclass, override <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> so that it encodes a Model Bus Reference (MBR) into the IDataObject. This method will be called when the user starts to drag from the source diagram. The encoded MBR will then be available in the IDataObject when the user drops in the target diagram.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### To receive a Model Bus Reference from a DSL in a target DSL or UML project  
  
1.  In the target DSL project, add project references to:  
  
    -   The source Dsl project.  
  
    -   The source ModelBus project.  
  
2.  In the gesture handler code file, add the following namespace references:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  The following sample illustrates how to get access to the source model element:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### To accept an element sourced from a UML model  
  
-   The following code sample accepts an object dropped from a UML diagram.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="mouseActions">\</a> Using Mouse Actions: Dragging Compartment Items  
 You can write a handler that intercepts mouse actions on a shape’s fields. The following example lets the user re-order the items in a compartment by dragging with the mouse.  
  
 To build this example, create a solution by using the **Class Diagrams** solution template. Add a code file and add the following code. Adjust the namespace to be the same as your own.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [How to customize copy](../vs140/customizing-copy-behavior.md)   
 [Deployment](../vs140/deploying-domain-specific-language-solutions.md)