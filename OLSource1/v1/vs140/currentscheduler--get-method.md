---
title: "CurrentScheduler::Get Method"
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
  - "concrt/concurrency::CurrentScheduler::Get"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Get method"
ms.assetid: 6623a6e5-11b0-45fd-92ac-0000a0769f79
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::Get Method
Returns a pointer to the scheduler associated with the calling context, also referred to as the current scheduler.  
  
## Syntax  
  
```  
static Scheduler * __cdecl Get();  
```  
  
## Return Value  
 A pointer to the scheduler associated with the calling context (the current scheduler).  
  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context. No additional reference is placed on the `Scheduler` object returned by this method.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)