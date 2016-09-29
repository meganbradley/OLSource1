---
title: "agent_status Enumeration"
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
  - "agents/concurrency::agent_status"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "agent_status enumeration"
ms.assetid: 46fa9b51-7930-4706-ba9d-c94a5ccac6b1
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# agent_status Enumeration
The valid states for an `agent`.  
  
## Syntax  
  
```  
enum agent_status;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`agent_canceled`|The `agent` was canceled.|  
|`agent_created`|The `agent` has been created but not started.|  
|`agent_done`|The `agent` finished without being canceled.|  
|`agent_runnable`|The `agent` has been started, but not entered its `run` method.|  
|`agent_started`|The `agent` has started.|  
  
## Remarks  
 For more information, see [Asynchronous Agents](../vs140/asynchronous-agents.md).  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)