---
title: "IThreadProxy::YieldToSystem Method"
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
  - concrtrm/concurrency::IThreadProxy::YieldToSystem
dev_langs: 
  - C++
helpviewer_keywords: 
  - YieldToSystem method
ms.assetid: f0da8837-72a2-4d56-9576-21fa7765e37f
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IThreadProxy::YieldToSystem Method
Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the next thread to be executed.  
  
## Syntax  
  
```  
virtual void YieldToSystem() = 0;  
```  
  
## Remarks  
 When called by a thread proxy backed by a regular Windows thread, `YieldToSystem` behaves exactly like the Windows function `SwitchToThread`. However, when called from user-mode schedulable (UMS) threads, the `SwitchToThread` function delegates the task of picking the next thread to run to the user mode scheduler, not the operating system. To achieve the desired effect of switching to a different ready thread in the system, use `YieldToSystem`.  
  
 `YieldToSystem` must be called on the `IThreadProxy` interface that represents the currently executing thread or the results are undefined.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IThreadProxy Structure](../vs140/ithreadproxy-structure.md)