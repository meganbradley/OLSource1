---
title: "ConcRT_EventType Enumeration"
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
  - "concrt/concurrency::ConcRT_EventType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConcRT_EventType enumeration"
ms.assetid: f593d554-ce66-4f72-bd33-00dd1a0cf52e
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ConcRT_EventType Enumeration
The types of events that can be traced using the tracing functionality offered by the Concurrency Runtime.  
  
## Syntax  
  
```  
enum ConcRT_EventType;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`CONCRT_EVENT_ATTACH`|An event type that represents the act of a attaching to a scheduler.|  
|`CONCRT_EVENT_BLOCK`|An event type that represents the act of a context blocking.|  
|`CONCRT_EVENT_DETACH`|An event type that represents the act of a detaching from a scheduler.|  
|`CONCRT_EVENT_END`|An event type that marks the beginning of a start/end event pair.|  
|`CONCRT_EVENT_GENERIC`|An event type used for miscellaneous events.|  
|`CONCRT_EVENT_IDLE`|An event type that represents the act of a context becoming idle.|  
|`CONCRT_EVENT_START`|An event type that marks the beginning of a start/end event pair.|  
|`CONCRT_EVENT_UNBLOCK`|An event type that represents the act of unblocking a context.|  
|`CONCRT_EVENT_YIELD`|An event type that represents the act of a context yielding.|  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)