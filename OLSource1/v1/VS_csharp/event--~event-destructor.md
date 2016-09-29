---
title: "event::~event Destructor"
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
  - "concrt/concurrency::event::~event"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "~event, destructor"
ms.assetid: 4e5fd092-983d-4cee-a3f7-a5f6056f977a
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event::~event Destructor
Destroys an event.  
  
## Syntax  
  
```  
~event();  
```  
  
## Remarks  
 It is expected that there are no threads waiting on the event when the destructor runs. Allowing the event to destruct with threads still waiting on it results in undefined behavior.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [event Class](../VS_csharp/event-class.md)