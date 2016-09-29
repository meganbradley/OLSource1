---
title: "agent::done Method"
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
  - "agents/concurrency::agent::done"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "done method"
ms.assetid: 557df23a-bd24-48ac-a336-5f12d9cdc542
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::done Method
Moves an agent into the `agent_done` state, indicating that the agent has completed.  
  
## Syntax  
  
```  
bool done();  
```  
  
## Return Value  
 `true` if the agent is moved to the `agent_done` state, `false` otherwise. An agent that has been canceled cannot be moved to the `agent_done` state.  
  
## Remarks  
 This method should be called at the end of the `run` method, when you know the execution of your agent has completed.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../VS_csharp/agent-class.md)   
 [agent_status Enumeration](../VS_csharp/agent_status-enumeration.md)