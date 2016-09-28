---
title: "agent::wait Method"
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
  - "agents/concurrency::agent::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: 5c77ec10-a13e-4f1d-a24c-ff2f440b64ce
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::wait Method
Waits for an agent to complete its task.  
  
## Syntax  
  
```  
static agent_status __cdecl wait(  
   _Inout_ agent * _PAgent,  
   unsigned int _Timeout = COOPERATIVE_TIMEOUT_INFINITE  
);  
```  
  
#### Parameters  
 `_PAgent`  
 A pointer to the agent to wait for.  
  
 `_Timeout`  
 The maximum time for which to wait, in milliseconds.  
  
## Return Value  
 The `agent_status` of the agent when the wait completes. This can either be `agent_canceled` or `agent_done`.  
  
## Remarks  
 An agent task is completed when the agent enters the `agent_canceled` or `agent_done` states.  
  
 If the parameter `_Timeout` has a value other than the constant `COOPERATIVE_TIMEOUT_INFINITE`, the exception [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before the agent has completed its task.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [agent::wait_for_all Method](../vs140/agent--wait_for_all-method.md)   
 [agent::wait_for_one Method](../vs140/agent--wait_for_one-method.md)   
 [agent_status Enumeration](../vs140/agent_status-enumeration.md)