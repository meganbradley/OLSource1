---
title: "future::wait_for Method"
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
  - "future/std::future::wait_for"
dev_langs: 
  - "C++"
ms.assetid: ac5d40a4-cbbe-4ac0-bec9-bd7915e77a95
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future::wait_for Method
Blocks the current thread until the associated asynchronous state is *ready* or until a specified time interval has elapsed.  
  
## Syntax  
  
```cpp  
template<class Rep, class Period>  
   future_status wait_for(  
      const chrono::duration<Rep, Period>& Rel_time) const;  
```  
  
#### Parameters  
 `Rel_time`  
 A [chrono::duration](../vs140/duration-class.md) object that specifies a maximum time interval that the thread blocks.  
  
## Return Value  
 A [future_status](../vs140/future_status-enumeration.md) that indicates the reason for returning.  
  
## Remarks  
 An associated asynchronous state is ready only if its asynchronous provider has stored a return value or stored an exception.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [future Class](../vs140/future-class.md)   
 [\<future>](../vs140/-future-.md)