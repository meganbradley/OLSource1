---
title: "CurrentScheduler::GetNumberOfVirtualProcessors Method"
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
  - "concrt/concurrency::CurrentScheduler::GetNumberOfVirtualProcessors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNumberOfVirtualProcessors method"
ms.assetid: 49b05629-68f1-4483-adc6-e371464db5c9
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::GetNumberOfVirtualProcessors Method
Returns the current number of virtual processors for the scheduler associated with the calling context.  
  
## Syntax  
  
```  
static unsigned int __cdecl GetNumberOfVirtualProcessors();  
```  
  
## Return Value  
 If a scheduler is associated with the calling context, the current number of virtual processors for that scheduler; otherwise, the value `-1`.  
  
## Remarks  
 This method will not result in scheduler attachment if the calling context is not already associated with a scheduler.  
  
 The return value from this method is an instantaneous sampling of the number of virtual processors for the scheduler associated with the calling context. This value can be stale the moment it is returned.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)