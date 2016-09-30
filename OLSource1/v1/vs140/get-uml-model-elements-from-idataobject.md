---
title: "Get UML model elements from IDataObject"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML API, copy and paste"
ms.assetid: e0b9cec8-3b93-4a24-8bd3-3e086501d387
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Get UML model elements from IDataObject
When the user drags elements from any source onto a diagram, the dragged elements are encoded in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The encoding depends on the type of source object. The following fragment demonstrates how to retrieve the elements when the source is a UML diagram.  
  
> [!NOTE]
>  Most of the operations that you have to do on UML models can be performed by using the types in defined in the assemblies **Microsoft.VisualStudio.Uml.Interfaces** and **Microsoft.VisualStudio.ArchitectureTools.Extensibility**. But for this purpose, you have to use some classes that are part of the implementation of the UML modeling tools. For example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in this fragment is not the same as the UML <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. To reduce the risk of putting the UML model and diagrams into an inconsistent state, it is better to avoid using the methods on these implementation classes, except where there is no alternative.  
  
## Code Sample  
 Your project must reference the following [!INCLUDE[TLA2#tla_net](../vs140/includes/tla2sharptla_net_md.md)] assemblies:  
  
 **Microsoft.VisualStudio.Modeling.Sdk.[version]**  
  
 **Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]**  
  
 **System.Windows.Forms**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information about <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in which the UML modeling tools are implemented, see [Domain-Specific Languages](../vs140/modeling-sdk-for-visual-studio---domain-specific-languages.md).  
  
## See Also  
 [Programming with the UML API](../vs140/programming-with-the-uml-api.md)   
 [How to: Define a Gesture Handler on a UML Diagram](../vs140/define-a-menu-command-on-a-modeling-diagram.md)