---
title: "Customizing Text and Image Fields"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a7259fc0-5afa-4356-b27e-5641e01628a9
caps.latest.revision: 6
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Customizing Text and Image Fields
When you define a text decorator in a shape, it is represented by a TextField. For examples of the initialization of TextFields and other ShapeFields, inspect Dsl\GeneratedCode\Shapes.cs in your DSL solution.  
  
 A TextField is an object that manages an area within a shape, such as the space assigned to a label. One TextField instance is shared between many shapes of the same class. The TextField instance does not store the text of the label separately for each instance: instead, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method takes the shape as a parameter, and can look up the text dependent on the current state of the shape and its model element.  
  
## How the appearance of a text field is determined  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method is called to displays the field on the screen. You can either override the default <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or you can override some of the methods that it calls. The following simplified version of the default methods can help you understand how to override the default behavior:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 There are several other pairs of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> methods and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> properties, such as <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. You can assign a value to the Default property to change the value for all instances of the shape field. To make the value vary from one shape instance to another, or dependent on the state of the shape or its model element, override the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method.  
  
## Static customizations  
 If you want to change every instance of this shape field, first find out whether you can set the property in the DSL Definition. For example, you can set font size and style in the Properties window.  
  
 If not, then override the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method of your shape class, and assign a value to the appropriate <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property of the text field.  
  
> [!WARNING]
>  To override <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you must set the **Generates Double Derived** property of the shape class to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the DSL Definition.  
  
 In this example, a shape has a text field that will be used for user comments. We want to use the standard comment font. Because it is a standard font from the style set, we can set the default font id:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Dynamic customizations  
 To make the appearance vary dependent on the state of a shape or its model element, derive your own subclass of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and override one or more <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> methods. You must also override your shape’s InitializeShapeFields method, and replace the instance of the TextField with an instance of your own class.  
  
 The following example makes the font of a text field dependent on the state of a Boolean domain property of the shape’s model element.  
  
 To run this example code, create a new DSL solution using the Minimal Language template. Add a Boolean domain property <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to the ExampleElement domain class. Add an icon decorator to the ExampleShape class, and set its image to a bitmap file. Click **Transform All Templates**. Add a new code file in the DSL project, and insert the following code.  
  
 To test the code, press F5 and, in the debugging solution, open a sample diagram. The default state of the icon should appear. Select the shape and in the Properties window, change the value of the **AlternateState** property. The font of the element name should change.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Style sets  
 The preceding example shows how you can change the text field to any font that is available. However, a preferable method is to change it to one of a set of styles that is associated with the shape or with the application. To do this, you override \<xref:Microsoft.VisualStudio.Modeling.Diagrams.TextField.GetFontId*> or GetTextBrushId().  
  
 Alternatively, consider changing the style set of your shape by overriding \<xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.InitializeResources*>. This has the effect of changing the fonts and brushes for all of the shape fields.  
  
## Customizing Image Fields  
 When you define an image decorator in a shape, and when you define an image shape, the area in which the shape is displayed is managed by an ImageField. For examples of the initialization of ImageFields and other ShapeFields, inspect Dsl\GeneratedCode\Shapes.cs in your DSL solution.  
  
 An ImageField is an object that manages an area within a shape, such as the space assigned to a decorator. One ImageField instance is shared between many shapes of the same shape class. The ImageField instance does not store a separate image for each shape: instead, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method takes the shape as a parameter, and can look up the image dependent on the current state of the shape and its model element.  
  
 If you want special behavior such as a variable image, you can create your own class derived from ImageField.  
  
#### To create a subclass of ImageField  
  
1.  Set the **Generates Double Derived** property of the parent shape class in your DSL Definition.  
  
2.  Override the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method of your shape class.  
  
    -   Create a new code file in the DSL project, and write a partial class definition for the shape class. Override the method definition there.  
  
3.  Inspect the code of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in DSL\GeneratedCode\Shapes.cs.  
  
     In your override method, call the base method and then create an instance of your own image field class. Use this to replace the regular image field in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> list.  
  
## Dynamic icons  
 This example makes an icon change dependent on the state of the shape’s model element.  
  
> [!WARNING]
>  This example demonstrates how to make a dynamic image decorator. But if you only want to switch between one or two images depending on the state of a model variable, it is simpler to create several image decorators, locate them in the same position on the shape, and then set the Visibility filter to depend on specific values of the model variable. To set this filter, select the shape map in the DSL Definition, open the DSL Details window, and click the Decorators tab.  
  
 To run this example code, create a new DSL solution using the Minimal Language template. Add a Boolean domain property <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to the ExampleElement domain class. Add an icon decorator to the ExampleShape class, and set its image to a bitmap file. Click **Transform All Templates**. Add a new code file in the DSL project, and insert the following code.  
  
 To test the code, press F5 and, in the debugging solution, open a sample diagram. The default state of the icon should appear. Select the shape and in the Properties window, change the value of the **AlternateState** property. The icon should then appear rotated through 90 degrees, on that shape.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [How to Display Shapes with Image and Text Fields](../vs140/defining-shapes-and-connectors.md)   
 [Setting a Background Image on a Diagram](../vs140/setting-a-background-image-on-a-diagram.md)   
 [Navigating and Updating a Model](../vs140/navigating-and-updating-a-model-in-program-code.md)   
 [Writing Code to Customize a Domain-Specific Language](../vs140/writing-code-to-customise-a-domain-specific-language.md)