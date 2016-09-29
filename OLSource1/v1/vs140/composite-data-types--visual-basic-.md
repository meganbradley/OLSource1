---
title: "Composite Data Types (Visual Basic)"
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
  - "classes [Visual Basic], composite types"
  - "types [Visual Basic], composite"
ms.assetid: 62970f2e-52c0-4369-8963-613820f1f434
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Composite Data Types (Visual Basic)
In addition to the elementary data types [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] supplies, you can also assemble items of different types to create *composite data types* such as structures, arrays, and classes. You can build composite data types from elementary types and from other composite types. For example, you can define an array of structure elements, or a structure with array members.  
  
## Data Types  
 A composite type is different from the data type of any of its components. For example, an array of `Integer` elements is not of the `Integer` data type.  
  
 An array data type is normally represented using the element type, parentheses, and commas as necessary. For example, a one-dimensional array of `String` elements is represented as `String()`, and a two-dimensional array of `Boolean` elements is represented as `Boolean(,)`.  
  
## Structure Types  
 There is no single data type comprising all structures. Instead, each definition of a structure represents a unique data type, even if two structures define identical elements in the same order. However, if you create two or more instances of the same structure, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] considers them to be of the same data type.  
  
## Array Types  
 There is no single data type comprising all arrays. The data type of a particular instance of an array is determined by the following:  
  
-   The fact of being an array  
  
-   The rank (number of dimensions) of the array  
  
-   The element type of the array  
  
 In particular, the length of a given dimension is not part of the instance's data type. The following example illustrates this.  
  
```  
Dim arrayA( ) As Byte = New Byte(12) {}  
Dim arrayB( ) As Byte = New Byte(100) {}  
Dim arrayC( ) As Short = New Short(100) {}  
Dim arrayD( , ) As Short  
Dim arrayE( , ) As Short = New Short(4, 10) {}  
```  
  
 In the preceding example, array variables `arrayA` and `arrayB` are considered to be of the same data type — `Byte()` — even though they are initialized to different lengths. Variables `arrayB` and `arrayC` are not of the same type because their element types are different. Variables `arrayC` and `arrayD` are not of the same type because their ranks are different. Variables `arrayD` and `arrayE` have the same type — `Short(,)` — because their ranks and element types are the same, even though `arrayD` is not yet initialized.  
  
 For more information on arrays, see [Arrays](../vs140/arrays-in-visual-basic.md).  
  
## Class Types  
 There is no single data type comprising all classes. Although one class can inherit from another class, each is a separate data type. Multiple instances of the same class are of the same data type. If you assign one class instance variable to another, not only do they have the same data type, they point to the same class instance in memory.  
  
 For more information on classes, see [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md).  
  
## See Also  
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Elementary Data Types](../vs140/elementary-data-types--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Structures: Your Own Data Types](../vs140/structures--visual-basic-.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [How to: Hold More Than One Value in a Variable](../vs140/how-to--hold-more-than-one-value-in-a-variable--visual-basic-.md)