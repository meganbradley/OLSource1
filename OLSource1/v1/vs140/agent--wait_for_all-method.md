---
title: "agent::wait_for_all Method"
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
  - "agents/concurrency::agent::wait_for_all"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait_for_all method"
ms.assetid: d6fd19c0-2bee-4926-8748-53f81594bd91
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::wait_for_all Method
Waits for all of the specified agents to complete their tasks.  
  
## Syntax  
  
```  
static void __cdecl wait_for_all(  
   size_t _Count,  
   _In_reads_(_Count) agent ** _PAgents,  
   _Out_writes_opt_(_Count) agent_status * _PStatus = NULL,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
```  
  
#### Parameters  
 `_Count`  
 The number of agent pointers present in the array `_PAgents`.  
  
 `_PAgents`  
 An array of pointers to the agents to wait for.  
  
 `_PStatus`  
 A pointer to an array of agent statuses. Each status value will represent the status of the corresponding agent when the method returns.  
  
 `_Timeout`  
 The maximum time for which to wait, in milliseconds.  
  
## Remarks  
 An agent task is completed when the agent enters the `agent_canceled` or `agent_done` states.  
  
 If the parameter `_Timeout` has a value other than the constant `COOPERATIVE_TIMEOUT_INFINITE`, the exception [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before the agent has completed its task.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [agent::wait Method](../vs140/agent--wait-method.md)   
 [agent::wait_for_one Method](../vs140/agent--wait_for_one-method.md)   
 [agent_status Enumeration](../vs140/agent_status-enumeration.md)