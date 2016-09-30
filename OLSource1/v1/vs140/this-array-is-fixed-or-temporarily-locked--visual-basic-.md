---
title: "This array is fixed or temporarily locked (Visual Basic)"
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
  - "vbrID10"
dev_langs: 
  - "VB"
ms.assetid: de6713a6-51d7-4edb-8515-d5fb544e2091
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# This array is fixed or temporarily locked (Visual Basic)
This error has the following possible causes:  
  
-   Using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to change the number of elements of a fixed-size array.  
  
-   Redimensioning a module-level dynamic array, in which one element has been passed as an argument to a procedure. If an element is passed, the array is locked to prevent deallocating memory for the reference parameter within the procedure.  
  
-   Attempting to assign a value to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable containing an array, but the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is currently locked.  
  
### To correct this error  
  
1.  Make the original array dynamic rather than fixed by declaring it with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (if the array is declared within a procedure), or by declaring it without specifying the number of elements (if the array is declared at the module level.  
  
2.  Determine whether you really need to pass the element, since it is visible within all procedures in the module.  
  
3.  Determine what is locking the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and remedy it.  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)