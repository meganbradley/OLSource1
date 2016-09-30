---
title: "Add custom properties to layer diagrams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "layer diagrams, adding custom properties"
ms.assetid: 52b3ac25-d10b-4507-a1fe-209ccb4d2777
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Add custom properties to layer diagrams
When you write extension code for layer diagrams, you can store values with any element on a layer diagram. The values will persist when the diagram is saved and re-opened. You can also have these properties appear in the **Properties** window so that users can see and edit them. For example, you could let users specify a regular expression for each layer, and write validation code to verify that the names of classes in each layer conform to the pattern specified by the user.  
  
## Properties not visible to the user  
 If you just want your code to attach values to any element in a layer diagram, you don’t need to define a MEF component. There is a dictionary named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in \<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerElement*>. Simply add marshalable values to the dictionary of any layer element. They will be saved as part of the layer diagram. For more information, see [Navigating and Updating Layer Models](../vs140/navigate-and-update-layer-models-in-program-code.md).  
  
## Properties that the user can edit  
 **Initial preparation**  
  
> [!IMPORTANT]
>  To make properties appear, you must make the following change on each computer where you want layer properties to be visible.  
>   
>  1.  Run Notepad by using **Run as Administrator**. Open <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
> 2.  Inside the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element, add:  
>   
>     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
> 3.  Under the **Visual Studio Tools** section of the Visual Studio application start menu, open **Developer Command Prompt**.  
>   
>      Enter:  
>   
>      <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
>   
>      <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
> 4.  Restart Visual Studio.  
  
 **Make sure your code is in a VSIX project**  
  
 If your property is part of a command, gesture, or validation project, you don’t need to add anything. The code for your custom property should be defined in a Visual Studio Extensibility project defined as a MEF component. For more information, see [Commands for Layer Diagrams](../vs140/add-commands-and-gestures-to-layer-diagrams.md) or [Layer Validation](../vs140/add-custom-architecture-validation-to-layer-diagrams.md).  
  
 **Define the custom property**  
  
 To create a custom property, define a class like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can define properties on \<xref:Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.ILayerElement*> or any of its derived classes, which include:  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> - the model  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> - each layer  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> - the links between layers  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Example  
 The following code is a typical custom property descriptor. It defines a Boolean property on the layer model (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) that lets the user provide values for a custom validation method.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [API for Layer Diagrams](../vs140/extend-layer-diagrams.md)