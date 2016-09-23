---
title: "future::wait Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - future/std::future::wait
dev_langs: 
  - C++
ms.assetid: accfd121-30b4-4b98-9bb7-34ffdc8cc777
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# future::wait Method
Blocks the current thread until the associated asynchronous state is *ready*.  
  
## Syntax  
  
```cpp  
void wait() const;  
```  
  
## Remarks  
 An associated asynchronous state is *ready* only if its asynchronous provider has stored a return value or stored an exception.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [future Class](../vs140/future-class.md)   
 [<future\>](../vs140/-future-.md)