---
title: "agent::~agent Destructor"
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
  - "agents/concurrency::agent::~agent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~agent, destructor"
ms.assetid: b99ee6df-4d91-49a8-9f1a-2f83c9484332
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent::~agent Destructor
Destroys the agent.  
  
## Syntax  
  
```  
virtual ~agent();  
```  
  
## Remarks  
 It is an error to destroy an agent that is not in a terminal state (either `agent_done` or `agent_canceled`). This can be avoided by waiting for the agent to reach a terminal state in the destructor of a class that inherits from the `agent` class.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [agent Class](../vs140/agent-class.md)