---
title: "agent::start Method"
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
  - "agents/concurrency::agent::start"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "start method"
ms.assetid: d2444e25-a9ed-4305-8cb1-cadcf8e3235c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::start Method
Moves an agent from the `agent_created` state to the `agent_runnable` state, and schedules it for execution.  
  
## Syntax  
  
```  
bool start();  
```  
  
## Return Value  
 `true` if the agent started correctly, `false` otherwise. An agent that has been canceled cannot be started.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)   
 [agent_status Enumeration](../vs140/agent_status-enumeration.md)