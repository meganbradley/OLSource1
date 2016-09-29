---
title: "future_errc Enumeration"
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
  - "future/std::future_errc"
dev_langs: 
  - "C++"
ms.assetid: 783736d5-6eea-4187-8357-38c4039c56f1
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future_errc Enumeration
Supplies symbolic names for all of the errors that are reported by the [future_error](../vs140/future_error-class.md) class.  
  
## Syntax  
  
```  
enum class future_errc {  
   broken_promise,  
   future_already_retrieved,  
   promise_already_satisfied,  
   no_state  
};  
```  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std::future_errc  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<future\>](../vs140/-future-.md)