---
title: "CurrentScheduler::GetPolicy Method"
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
  - concrt/concurrency::CurrentScheduler::GetPolicy
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPolicy method
ms.assetid: 890bd21e-8442-4d54-acf4-26c7da37a53b
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CurrentScheduler::GetPolicy Method
Returns a copy of the policy that the current scheduler was created with.  
  
## Syntax  
  
```  
static SchedulerPolicy __cdecl GetPolicy();  
```  
  
## Return Value  
 A copy of the policy that that the current scheduler was created with.  
  
## Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)