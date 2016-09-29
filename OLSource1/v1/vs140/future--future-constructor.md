---
title: "future::future Constructor"
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
  - "future/std::future::future"
dev_langs: 
  - "C++"
ms.assetid: dcb3422a-7566-4a58-8b16-a7606e5808f1
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future::future Constructor
Constructs a `future` object.  
  
## Syntax  
  
```  
future() _NOEXCEPT;  
future(  
   future&& Other  
) _NOEXCEPT;  
  
```  
  
#### Parameters  
 `Other`  
 A `future` object.  
  
## Remarks  
 The first constructor constructs a `future` object that has no associated asynchronous state.  
  
 The second constructor constructs a `future` object and transfers the associated asynchronous state from `Other`. `Other` no longer has an associated asynchronous state.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [future Class](../vs140/future-class.md)   
 [\<future>](../vs140/-future-.md)