---
title: "source_block::initialize_source Method"
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
  - "agents/concurrency::source_block::initialize_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initialize_source method"
ms.assetid: 601786c1-e831-4a19-8642-cb50ed25abca
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::initialize_source Method
Initializes the `message_propagator` within this `source_block`.  
  
## Syntax  
  
```  
void initialize_source(  
   _Inout_opt_ Scheduler * _PScheduler = NULL,  
   _Inout_opt_ ScheduleGroup * _PScheduleGroup = NULL  
);  
```  
  
#### Parameters  
 `_PScheduler`  
 The scheduler to be used for scheduling tasks.  
  
 `_PScheduleGroup`  
 The schedule group to be used for scheduling tasks.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)