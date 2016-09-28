---
title: "Anonymous type must contain at least one member"
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
  - "bc36574"
  - "vbc36574"
helpviewer_keywords: 
  - "BC36574"
ms.assetid: fdc8dd47-ea38-49e8-8dd5-676f726cd101
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Anonymous type must contain at least one member
The initializer list in an anonymous type declaration cannot be empty.  
  
```  
' Not valid.  
' Dim anonInstance = New With {}  
```  
  
 **Error ID:** BC36574  
  
### To correct this error  
  
-   Declare a member within the braces, as shown in the following code.  
  
    ```  
    Dim anonInstance = New With {.MemberName = "value"}  
    ```  
  
## See Also  
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)