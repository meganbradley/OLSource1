---
title: "Arrays declared as structure members cannot be declared with an initial size"
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
  - "vbc31043"
  - "bc31043"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC31043"
ms.assetid: 5bd90c71-1b78-444b-91e1-4789451ef085
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arrays declared as structure members cannot be declared with an initial size
An array in a structure is declared with an initial size. You cannot initialize any structure element, and declaring an array size is one form of initialization.  
  
 **Error ID:** BC31043  
  
### To correct this error  
  
1.  Define the array in your structure as dynamic (no initial size).  
  
2.  If you require a certain size of array, you can redimension a dynamic array with a [ReDim Statement (Visual Basic)](../vs140/redim-statement--visual-basic-.md) when your code is running. The following example illustrates this.  
  
    ```  
    Structure demoStruct  
        Public demoArray() As Integer  
    End Structure  
    Sub useStruct()  
        Dim struct As demoStruct  
        ReDim struct.demoArray(9)  
        Struct.demoArray(2) = 777  
    End Sub  
    ```  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [How to: Declare a Structure](../vs140/how-to--declare-a-structure--visual-basic-.md)