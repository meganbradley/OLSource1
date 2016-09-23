---
title: "agent::agent Constructor"
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
  - agents/concurrency::agent::agent
dev_langs: 
  - C++
helpviewer_keywords: 
  - agent, constructor
ms.assetid: d13a380a-e3fb-4932-8785-09b4cdb1f0e6
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# agent::agent Constructor
Constructs an agent.  
  
## Syntax  
  
```  
agent();  
  
agent(  
   Scheduler& _PScheduler  
);  
  
agent(  
   ScheduleGroup& _PGroup  
);  
```  
  
#### Parameters  
 `_PScheduler`  
 The `Scheduler` object within which the execution task of the agent is scheduled.  
  
 `_PGroup`  
 The `ScheduleGroup` object within which the execution task of the agent is scheduled. The `Scheduler` object used is implied by the schedule group.  
  
## Remarks  
 The runtime uses the default scheduler if you do not specify the `_PScheduler` or `_PGroup` parameters.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [ScheduleGroup Class](../vs140/schedulegroup-class.md)