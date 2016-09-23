---
title: "&#39;}&#39; expected"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc30370
  - bc30370
helpviewer_keywords: 
  - BC30370
ms.assetid: a4ce9be9-fc5d-46ec-a217-c3428bd0b97e
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;}&#39; expected
An array initializer or a constraint list has not been ended in a valid fashion.  
  
 The element values with which to initialize an array must be enclosed in braces (`{}`).  
  
```  
Dim demoArray() As Integer = New Integer() {1, 2, 3}   
```  
  
 Similarly, the constraints in a constraint list for a generic type parameter must be enclosed in braces.  
  
```  
Public Class dictionaryMaker(Of t As {IComparable, IDisposable, New})   
```  
  
 **Error ID:** BC30370  
  
### To correct this error  
  
-   Use "}" to end the array initializer or constraint list.  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [How to: Initialize an Array Variable](../vs140/how-to--initialize-an-array-variable-in-visual-basic.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)