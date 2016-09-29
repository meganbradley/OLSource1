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
Introduces a `New` clause to create a new object instance, specifies a constructor constraint on a type parameter, or identifies a `Sub` procedure as a class constructor.  
  
## Remarks  
 In a declaration or assignment statement, a `New` clause must specify a defined class from which the instance can be created. This means that the class must expose one or more constructors that the calling code can access.  
  
 You can use a `New` clause in a declaration statement or an assignment statement. When the statement runs, it calls the appropriate constructor of the specified class, passing any arguments you have supplied. The following example demonstrates this by creating instances of a `Customer` class that has two constructors, one that takes no parameters and one that takes a string parameter.  
  
 [!code[VbVbalrKeywords#11](../VS_csharp/codesnippet/VisualBasic/new-operator--visual-basic-_1.vb)]  
  
 Since arrays are classes, `New` can create a new array instance, as shown in the following examples.  
  
 [!code[VbVbalrKeywords#12](../VS_csharp/codesnippet/VisualBasic/new-operator--visual-basic-_2.vb)]  
  
 The common language runtime (CLR) throws an <xref:System.OutOfMemoryException*> error if there is insufficient memory to create the new instance.  
  
> [!NOTE]
>  The `New` keyword is also used in type parameter lists to specify that the supplied type must expose an accessible parameterless constructor. For more information about type parameters and constraints, see [Type List](../VS_csharp/type-list--visual-basic-.md).  
  
 To create a constructor procedure for a class, set the name of a `Sub` procedure to the `New` keyword. For more information, see [Object Lifetime: How Objects Are Created and Destroyed](../VS_csharp/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md).  
  
 The `New` keyword can be used in these contexts:  
  
 [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md)  
  
 [Of](../VS_csharp/of-clause--visual-basic-.md)  
  
 [Sub Statement (Visual Basic)](../VS_csharp/sub-statement--visual-basic-.md)  
  
## See Also  
 <xref:System.OutOfMemoryException*>   
 [Keywords (Visual Basic)](../VS_csharp/keywords--visual-basic-.md)   
 [Type List](../VS_csharp/type-list--visual-basic-.md)   
 [Generic Types in Visual Basic](../VS_csharp/generic-types-in-visual-basic--visual-basic-.md)   
 [Object Lifetime: How Objects Are Created and Destroyed](../VS_csharp/object-lifetime--how-objects-are-created-and-destroyed--visual-basic-.md)