---
title: "Array declared as for loop control variable cannot be declared with an initial size"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc32039
  - bc32039
dev_langs: 
  - VB
helpviewer_keywords: 
  - BC32039
ms.assetid: 1d8b6560-c9eb-4b71-a038-24c6f5a5ce46
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array declared as for loop control variable cannot be declared with an initial size
A `For Each` loop uses an array as its *element* iteration variable but initializes that array.  
  
 The following statements show how this error can be generated.  
  
```  
Dim arrayList As New List(Of Integer())  
For Each listElement() As Integer In arrayList  
For Each listElement(1) As Integer In arrayList  
```  
  
 The first `For Each` statement is the correct way to access elements of `arrayList`. The second `For Each` statement generates this error.  
  
 **Error ID:** BC32039  
  
### To correct this error  
  
-   Remove the initialization from the declaration of the *element* iteration variable.  
  
## See Also  
 [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)   
 [Collections (C# and Visual Basic)](../vs140/collections--csharp-and-visual-basic-.md)