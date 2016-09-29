---
title: "Array bounds cannot appear in type specifiers"
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
  - "vbc30638"
  - "bc30638"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30638"
ms.assetid: 93b654f4-70fa-4a48-baed-ffae42075550
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array bounds cannot appear in type specifiers
Array sizes cannot be declared as part of a data type specifier.  
  
 **Error ID:** BC30638  
  
### To correct this error  
  
-   Specify the size of the array immediately following the variable name instead of placing the array size after the type, as shown in the following example.  
  
    ```  
    Dim Array(8) As Integer   
    ```  
  
-   Define an array and initialize it with the desired number of elements, as shown in the following example.  
  
    ```  
    Dim Array2() As Integer = New Integer(8) {}  
    ```  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)