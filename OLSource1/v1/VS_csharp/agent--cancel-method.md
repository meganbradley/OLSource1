---
title: "agent::cancel Method"
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
  - "agents/concurrency::agent::cancel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cancel method"
ms.assetid: 5a39a1f0-aef3-4e47-9e36-cea1ff5c4079
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::cancel Method
Moves an agent from either the `agent_created` or `agent_runnable` states to the `agent_canceled` state.  
  
## Syntax  
  
```  
bool cancel();  
```  
  
## Return Value  
 `true` if the agent was canceled, `false` otherwise. An agent cannot be canceled if it has already started running or has already completed.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../VS_csharp/agent-class.md)   
 [agent_status Enumeration](../VS_csharp/agent_status-enumeration.md)