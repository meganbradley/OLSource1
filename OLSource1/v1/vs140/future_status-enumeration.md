---
title: "future_status Enumeration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "future/std::future_status"
dev_langs: 
  - "C++"
ms.assetid: efd78076-0959-4e85-963f-c7f16fdff84a
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future_status Enumeration
Supplies symbolic names for the reasons that a timed wait function can return.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The *associated asynchronous state* holds a *deferred function* that's not running.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The associated asynchronous state is *ready*.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The time limit was reached.|  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std::future_status  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<future>](../vs140/-future-.md)