---
title: "How to: Hold More Than One Value in a Variable (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "classes [Visual Basic], composite data types"
  - "composite types"
  - "composite data types"
  - "data types [Visual Basic], composite"
  - "arrays [Visual Basic], composite data types"
  - "structures, composite data types"
  - "arrays [Visual Basic], compilation errors"
  - "types [Visual Basic], composite"
ms.assetid: 5fe0e558-aac2-4a40-b7f2-7cfea7336917
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Hold More Than One Value in a Variable (Visual Basic)
A variable holds more than one value if you declare it to be of a *composite data type*.  
  
 [Composite Data Types](../VS_csharp/composite-data-types--visual-basic-.md) include structures, arrays, and classes. A variable of a composite data type can hold a combination of elementary data types and other composite types. Structures and classes can hold code as well as data.  
  
### To hold more than one value in a variable  
  
1.  Determine what composite data type you want to use for your variable.  
  
2.  If the composite data type is not already defined, define it so that your variable can use it.  
  
    -   Define a structure with a [Structure Statement](../VS_csharp/structure-statement.md).  
  
    -   Define an array with a [Dim Statement (Visual Basic)](../VS_csharp/dim-statement--visual-basic-.md).  
  
    -   Define a class with a [Class Statement (Visual Basic)](../VS_csharp/class-statement--visual-basic-.md).  
  
3.  Declare your variable with a `Dim` statement.  
  
4.  Follow the variable name with an `As` clause.  
  
5.  Follow the `As` keyword with the name of the appropriate composite data type.  
  
## See Also  
 [Data Type Summary (Visual Basic)](../VS_csharp/data-type-summary--visual-basic-.md)   
 [Type Characters](../VS_csharp/type-characters--visual-basic-.md)   
 [Composite Data Types](../VS_csharp/composite-data-types--visual-basic-.md)   
 [Structures](../VS_csharp/structures--visual-basic-.md)   
 [Arrays](../VS_csharp/arrays-in-visual-basic.md)   
 [Objects and Classes in Visual Basic](../VS_csharp/objects-and-classes-in-visual-basic.md)   
 [Value Types and Reference Types](../VS_csharp/value-types-and-reference-types.md)