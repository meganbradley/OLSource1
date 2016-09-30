---
title: "Navigate relationships with the UML API"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML API"
ms.assetid: a4d11d45-b8c0-40f9-a597-363f07659610
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Navigate relationships with the UML API
A model consists of elements linked together by different kinds of relationships. This topic describes how to navigate the model in program code.  
  
## Traversing Relationships  
  
### Any relationship  
 Use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to find all the elements connected to a specified element. Either set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to traverse relationships of all kinds, or use a more specific type such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to traverse just that type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Use <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to find all the relationships connected to an element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Association  
 An Association is a relationship between two Properties, each of which belongs to a Classifier.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Generalization and Realization  
 Access opposite ends of generalization:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Dependency  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Activity Edge  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Connector (assembly and delegation)  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Messages and Lifelines  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Package Import  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Use case extend and include  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Enumerating Relationships  
 All properties of the UML model that return multiple values conform to the IEnumerable<> interface. This means that you can use [Linq Query Expressions](http://go.microsoft.com/fwlink/?LinkId=168834) and the extension methods defined in the **System.Linq** namespace.  
  
 For example:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)   
 [How to Access the Model and Context](../vs140/navigate-the-uml-model.md)