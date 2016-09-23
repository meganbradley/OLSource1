---
title: "target_block::initialize_target Method"
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
  - agents/concurrency::target_block::initialize_target
dev_langs: 
  - C++
helpviewer_keywords: 
  - initialize_target method
ms.assetid: aed92a56-da54-4ec6-8ce5-d4a01cd807b9
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# target_block::initialize_target Method
Initializes the base object. Specifically, the `message_processor` object needs to be initialized.  
  
## Syntax  
  
```  
void initialize_target(  
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
 [target_block Class](../vs140/target_block-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)