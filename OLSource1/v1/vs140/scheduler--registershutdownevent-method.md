---
title: "Scheduler::RegisterShutdownEvent Method"
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
  - "concrt/concurrency::Scheduler::RegisterShutdownEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RegisterShutdownEvent method"
ms.assetid: 9b5f6bd7-4bd3-4a43-99e6-706d8eeb854a
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::RegisterShutdownEvent Method
Causes the Windows event handle passed in the `_Event` parameter to be signaled when the scheduler shuts down and destroys itself. At the time the event is signaled, all work that had been scheduled to the scheduler is complete. Multiple shutdown events can be registered through this method.  
  
## Syntax  
  
```  
virtual void RegisterShutdownEvent(  
   HANDLE _Event  
) =0;  
```  
  
#### Parameters  
 `_Event`  
 A handle to a Windows event object which will be signaled by the runtime when the scheduler shuts down and destroys itself.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)