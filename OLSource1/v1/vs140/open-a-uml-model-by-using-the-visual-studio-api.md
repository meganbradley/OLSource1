---
title: "Open a UML model by using the Visual Studio API"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML API, opening models in Visual Studio"
ms.assetid: 38423682-f2a7-4d2a-a2cd-fd680e9b4b4d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Open a UML model by using the Visual Studio API
You can also open models and diagrams in the Visual Studio user interface by using the API.  
  
 If you only want to read a model in program code without making it visible to the user, you can use the following methods:  
  
-   Visual Studio Model Bus allows you to access models and elements within them, and provides a standard method of making links between one model and another. For more information, see [How to Access UML Diagrams and Models using Model Bus](../vs140/integrate-uml-models-with-other-models-and-tools.md).  
  
-   You can open a model in read-only mode. For more information, see [How to Open a UML Model in Program Code](../vs140/read-a-uml-model-in-program-code.md).  
  
##  \<a name="Showing">\</a> Opening Models and Diagrams in Visual Studio  
 To open a model in the user interface, use the standard Visual Studio API <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. There are two useful casts that you can perform on modeling project items:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can be cast to and from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, if the project is a modeling project, and if the project is loaded in the current AppDomain.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be cast to and from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, if the item is a UML diagram.  
  
 For the following example, your project should import these references:  
  
-   EnvDTE  
  
-   Microsoft.VisualStudio.ArchitectureTools.Extensibility  
  
-   Microsoft.VisualStudio.Modeling.Sdk.[version]  
  
-   Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]  
  
-   Microsoft.VisualStudio.Shell.Immutable.[version]  
  
-   Microsoft.VisualStudio.Uml.Interfaces  
  
-   System.ComponentModel.Composition  
  
 This example opens a UML model in Visual Studio:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In a Visual Studio extension, you can make this declaration to obtain access to the host service provider:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In a method, you can access a project,  for example, the current project:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Programming with the UML API](../vs140/programming-with-the-uml-api.md)   
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)