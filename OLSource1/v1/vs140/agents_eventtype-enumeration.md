---
title: "Agents_EventType Enumeration"
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
  - "concrt/concurrency::Agents_EventType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Agents_EventType enumeration"
ms.assetid: c986df30-da61-4705-bc87-a104c88f4ee9
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Agents_EventType Enumeration
The types of events that can be traced using the tracing functionality offered by the Agents Library  
  
## Syntax  
  
```  
enum Agents_EventType;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`AGENTS_EVENT_CREATE`|An event type that represents the creation of an object|  
|`AGENTS_EVENT_DESTROY`|An event type that represents the deletion of an object|  
|`AGENTS_EVENT_END`|An event type that represents the conclusion of some processing|  
|`AGENTS_EVENT_LINK`|An event type that represents the linking of message blocks|  
|`AGENTS_EVENT_NAME`|An event type that represents the name for an object|  
|`AGENTS_EVENT_SCHEDULE`|An event type that represents the scheduling of a process|  
|`AGENTS_EVENT_START`|An event type that represents the initiation of some processing|  
|`AGENTS_EVENT_UNLINK`|An event type that represents the unlinking of message blocks|  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)