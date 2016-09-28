---
title: "promise::operator= Operator"
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
  - "future/std::promise::operator="
dev_langs: 
  - "C++"
ms.assetid: 19035ca4-ad6c-46d5-9ac2-4964b14aafeb
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# promise::operator= Operator
Transfers the *associated asynchronous state* from a specified `promise` object.  
  
## Syntax  
  
```  
promise& operator=(  
   promise&& Other  
) _NOEXCEPT;  
```  
  
#### Parameters  
 `Other`  
 A `promise` object.  
  
## Return Value  
 `*this`  
  
## Remarks  
 This operator transfers the associated asynchronous state from `Other`. After the transfer, `Other` is *empty*.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [promise Class](../vs140/promise-class.md)   
 [<future\>](../vs140/-future-.md)