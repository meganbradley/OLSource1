---
title: "CurrentScheduler::RegisterShutdownEvent Method"
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
  - "concrt/concurrency::CurrentScheduler::RegisterShutdownEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterShutdownEvent method"
ms.assetid: 52858816-a19f-4820-ae5b-aa169cf7eaf9
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::RegisterShutdownEvent Method
Causes the Windows event handle passed in the `_ShutdownEvent` parameter to be signaled when the scheduler associated with the current context shuts down and destroys itself. At the time the event is signaled, all work that had been scheduled to the scheduler is complete. Multiple shutdown events can be registered through this method.  
  
## Syntax  
  
```  
static void __cdecl RegisterShutdownEvent(  
   HANDLE _ShutdownEvent  
);  
```  
  
#### Parameters  
 `_ShutdownEvent`  
 A handle to a Windows event object which will be signaled by the runtime when the scheduler associated with the current context shuts down and destroys itself.  
  
## Remarks  
 If there is no scheduler attached to the calling context, calling this method will result in a [scheduler_not_attached](../vs140/scheduler_not_attached-class.md) exception being thrown.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)