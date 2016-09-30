---
title: "Link UML model updates by using transactions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UML API, transactions"
ms.assetid: a1df6c38-a3d1-4a3f-82bc-c8f363ab916e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Link UML model updates by using transactions
When you define an extension to the UML designers in Visual Studio, you can group several changes into a single transaction called a *linked undo context*. To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../vs140/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
 By default, each modification that your code makes to a model can be separately undone by the user. For example, if you define a menu command that swaps the names of two UML classes, a user could invoke the command, and then perform a single undo. This would undo the change to one name, but not the other, leaving your model in an unintended state.  
  
 To avoid this, your code can perform a series of changes within a transaction. This makes the changes look like a single change to the user. A subsequent undo command will undo the whole series.  
  
 An additional benefit is that your code can undo a partially-complete set of changes by throwing an exception or by aborting the transaction.  
  
## To group changes into a single transaction  
 Ensure your project References include this .NET assembly:  
  
 **Microsoft.VisualStudio.Modeling.Sdk.[version].dll**  
  
 Inside your class, declare an imported property that has type \<xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement.ILinkedUndoContext*>:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 In a method that modifies the model, enclose your changes in a transaction:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 Notice the following:  
  
-   You must always include <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> at the end of the transaction. If a transaction is disposed without being committed, the transaction will be rolled back. That is, the model will be restored to its state at the start of the transaction.  
  
-   If an exception occurs that is not caught inside the transaction, the transaction will be rolled back. It is a frequent pattern to enclose the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block of the transaction inside a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block.  
  
-   You can nest transactions.  
  
-   You can provide any non-blank name to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
-   Only the UML Model Store is affected by these transactions. Modeling transactions do not affect: variables, external stores such as files and databases, layer diagrams, and code models.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Programming with the UML API](../vs140/programming-with-the-uml-api.md)   
 [How to Add Commands and Gestures to UML Diagrams](../vs140/define-a-menu-command-on-a-modeling-diagram.md)   
 [Extending Models and Diagrams](../vs140/extend-uml-models-and-diagrams.md)