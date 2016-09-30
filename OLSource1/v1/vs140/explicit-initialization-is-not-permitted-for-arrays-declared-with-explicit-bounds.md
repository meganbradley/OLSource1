---
title: "Explicit initialization is not permitted for arrays declared with explicit bounds"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30672"
  - "vbc30672"
helpviewer_keywords: 
  - "BC30672"
ms.assetid: 4b525e8d-bde5-4408-8c10-7605ca039f0e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit initialization is not permitted for arrays declared with explicit bounds
Arrays cannot be initialized if they are declared to be a specific size.  
  
 **Error ID:** BC30672  
  
### To correct this error  
  
-   Declare the array, and then initialize it separately.  
  
-   Declare and initialize as a dynamic array, and use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if necessary; for example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)