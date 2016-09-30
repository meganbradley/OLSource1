---
title: "How to: Intercept a Click on a Shape or Decorator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Domain-Specific Language, programming domain models"
ms.assetid: e2bc3124-c0c0-4104-9779-a5bf565d7f51
caps.latest.revision: 25
---
# How to: Intercept a Click on a Shape or Decorator
The following procedures demonstrate how to intercept a click on a shape or an icon decorator. You can intercept clicks, double-clicks, drags, and other gestures, and make the element respond.  
  
## To Intercept Clicks on Shapes  
 In the Dsl project, in a code file that is separate from the generated code files, write a partial class definition for the shape class. Override <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or one of the other methods that has a name beginning with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
> [!NOTE]
>  Set <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, unless you want the event to be passed to the containing shape or diagram.  
  
## To Intercept Clicks on Decorators  
 Image decorators are carried on an instance of ImageField class, which has an OnDoubleClick method. You can intercept the clicks if you write an ImageField subclass. The fields are set up in the InitializeShapeFields method. Therefore, you must change that method to instantiate your subclass instead of the regular ImageField. The InitializeShapeFields method is in the generated code of the shape class. You can override the shape class if you set its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> property as described in the following procedure.  
  
 Although InitializeShapeFields is an instance method, it is called only once for each class. Therefore, only one instance of ClickableImageField exists for each field in each class, not one instance for each shape in the diagram. When the user double-clicks an instance, you must identify which instance has been hit, as the code in the example demonstrates.  
  
#### To intercept a click on an icon decorator  
  
1.  Open or create a DSL solution.  
  
2.  Choose or create a shape that has an icon decorator, and map it to a domain class.  
  
3.  In a code file that is separate from the files in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> folder, create the new subclass of ImageField:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     You should set Handled to true if you do not want the event to be passed to the containing shape.  
  
4.  Override the InitializeShapeFields method in your shape classs by adding the following partial class definition.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
1.  Build and run the solution.  
  
2.  Double-click the icon on an instance of the shape. Your test message should appear.  
  
## Intercepting clicks and drags on CompartmentShape lists  
 The following sample allows users to re-order items in a compartment shape by dragging them. To run this code:  
  
1.  Create a new DSL solution by using the **Class Diagrams** solution template.  
  
     You can also work with a solution of your own that contains compartment shapes. This code assumes that there is an embedding relationship between the model elements represented by the shape, and the elements represented in the compartment list items.  
  
2.  Set the **Generates Double Derived** property of the compartment shape.  
  
3.  Add this code in a file in the **Dsl** project.  
  
4.  Adjust the domain class and shape names in this code to match your own DSL.  
  
 In summary, the code works as follows. In this example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the name of the compartment shape.  
  
-   A set of mouse event handlers is attached to each compartment instance when it is created.  
  
-   The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> event stores the current item.  
  
-   When the mouse moves out of the current item, an instance of MouseAction is created, which sets the cursor and captures the mouse until it is released.  
  
     To avoid interfering with other mouse actions, such as selecting the text of an item, the MouseAction is not created until the mouse has left the original item.  
  
     An alternative to creating a MouseAction would be simply to listen for MouseUp. However, this would not work properly if the user releases the mouse after dragging it outside the compartment. The MouseAction is able to perform the appropriate action no matter where the mouse is released.  
  
-   When the mouse is released, MouseAction.MouseUp rearranges the order of the links between the model elements.  
  
-   The change of role order fires a rule that updates the display. This behavior is already defined, and no additional code is required.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Responding to Changes in the Model](../vs140/responding-to-and-propagating-changes.md)   
 [Decorator (Domain-Specific Language Designer)](../vs140/properties-of-decorators.md)