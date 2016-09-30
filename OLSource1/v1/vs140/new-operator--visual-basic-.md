---
title: "New Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.new"
  - "vb.NewConstraint"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "constraints, Visual Basic generic types"
  - "generics [Visual Basic], constraints"
  - "constraints, New keyword"
  - "New constraint"
  - "New keyword"
ms.assetid: d7d566d7-fe0e-4336-91f7-641a542de4d0
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# New Operator (Visual Basic)
Introduces a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause to create a new object instance, specifies a constructor constraint on a type parameter, or identifies a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure as a class constructor.  
  
## Remarks  
 In a declaration or assignment statement, a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause must specify a defined class from which the instance can be created. This means that the class must expose one or more constructors that the calling code can access.  
  
 You can use a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause in a declaration statement or an assignment statement. When the statement runs, it calls the appropriate constructor of the specified class, passing any arguments you have supplied. The following example demonstrates this by creating instances of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class that has two constructors, one that takes no parameters and one that takes a string parameter.  
  
 [!code[VbVbalrKeywords#11](../vs140/codesnippet/VisualBasic/new-operator--visual-basic-_1.vb)]  
  
 Since arrays are classes, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can create a new array instance, as shown in the following examples.  
  
 [!code[VbVbalrKeywords#12](../vs140/codesnippet/VisualBasic/new-operator--visual-basic-_2.vb)]  
  
 The common language runtime (CLR) throws an \<xref:System.OutOfMemoryException*> error if there is insufficient memory to create the new instance.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword is also used in type parameter lists to specify that the supplied type must expose an accessible parameterless constructor. For more information about type parameters and constraints, see [Type List](../vs140/type-list--visual-basic-.md).  
  
 To create a constructor procedure for a class, set the name of a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> procedure to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword. For more information, see [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md).  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword can be used in these contexts:  
  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)  
  
 [Of](../vs140/of-clause--visual-basic-.md)  
  
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)  
  
## See Also  
 \<xref:System.OutOfMemoryException*>   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Object Lifetime: How Objects Are Created and Destroyed](../vs140/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md)