---
title: "Character Comparison"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "comparing characters"
  - "MBCS [C++], character comparison"
  - "characters [C++], comparing"
ms.assetid: 18846e44-3e6e-40c4-9b42-3153fb15db20
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Character Comparison
Use the following tips:  
  
-   Comparing a known lead byte with an ASCII character works correctly:  
  
    ```  
    if( *sz1 == 'A' )  
    ```  
  
-   Comparing two unknown characters requires the use of one of the macros defined in Mbstring.h:  
  
    ```  
    if( !_mbccmp( sz1, sz2) )  
    ```  
  
     This ensures that both bytes of a double-byte character are compared for equality.  
  
## See Also  
 [MBCS Programming Tips](../vs140/mbcs-programming-tips.md)   
 [Buffer Overflow](../vs140/buffer-overflow.md)