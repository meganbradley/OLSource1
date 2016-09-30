---
title: "Attach reference strings to UML model elements"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML - extending, reference strings"
ms.assetid: 15dbed99-efce-42fe-a768-714a5804e7d1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attach reference strings to UML model elements
You can write code to attach arbitrary strings to model elements. A string could be, for example, a URI, the cached result of a computation, or a ModelBus reference to an element in another model. Each string is contained in an IReference object. Any number of IReference objects can be attached to each model element.  
  
 Every IReference object has a Name. You could use this Name to indicate how the reference value should be interpreted. For example, you could set Name to "URI" to indicate that the Value should be interpreted as a URI. There are some predefined reference name values used by the modeling tools.  
  
## Attaching a Reference to an IElement  
 To use the following methods, you must add a reference to:  
  
 Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll  
  
 You should insert this directive in your code:  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
|Method call|Description|  
|-----------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Creates an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with the given name and value strings, and links it to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Returns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.\<br />\<br /> Throws an exception if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is false and there is already an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the same name attached to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Returns all the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects linked to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that have the given <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Deletes all the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects linked to element that have the given name.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Deletes this <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The value used to name work item references.|  
  
## See Also  
 [How to Define a Work Item Link Event Handler](../vs140/define-a-work-item-link-handler.md)   
 [How to Define and Install a Modeling Extension](../vs140/define-and-install-a-modeling-extension.md)   
 [Programming with the UML API](../vs140/programming-with-the-uml-api.md)