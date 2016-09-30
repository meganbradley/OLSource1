---
title: "propagator_block::initialize_source_and_target Method"
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
  - "agents/concurrency::propagator_block::initialize_source_and_target"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "initialize_source_and_target method"
ms.assetid: 277f45e2-7428-4a89-8513-226f049a20a4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# propagator_block::initialize_source_and_target Method
Initializes the base object. Specifically, the `message_processor` object needs to be initialized.  
  
## Syntax  
  
```  
void initialize_source_and_target(  
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
 [propagator_block Class](../vs140/propagator_block-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)