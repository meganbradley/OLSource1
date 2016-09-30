---
title: "shared_future::wait_until Method"
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
  - "future/std::shared_future::wait_until"
dev_langs: 
  - "C++"
ms.assetid: a4e37633-80bd-489e-999b-752e3b4c627f
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_future::wait_until Method
Blocks the current thread until the associated asynchronous state is *ready* or until after a specified time point.  
  
## Syntax  
  
```cpp  
template<class Clock, class Duration>  
   future_status wait_until(  
      const chrono::time_point<Clock, Duration>& Abs_time) const;  
```  
  
#### Parameters  
 `Abs_time`  
 A [chrono::time_point](../vs140/time_point-class.md) object that specifies a time after which the thread can unblock.  
  
## Return Value  
 A [future_status](../vs140/future_status-enumeration.md) that indicates the reason for returning.  
  
## Remarks  
 An associated asynchronous state is ready only if its asynchronous provider has stored a return value or stored an exception.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [shared_future Class](../vs140/shared_future-class.md)   
 [\<future>](../vs140/-future-.md)