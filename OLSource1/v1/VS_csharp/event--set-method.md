---
title: "event::set Method"
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
  - "concrt/concurrency::event::set"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set method"
ms.assetid: 8555fca6-fed7-48d8-8136-311742c1fe3b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event::set Method
Signals the event.  
  
## Syntax  
  
```  
void set();  
```  
  
## Remarks  
 Signaling the event can cause an arbitrary number of contexts waiting on the event to become runnable.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [event Class](../VS_csharp/event-class.md)   
 [event::wait Method](../VS_csharp/event--wait-method.md)   
 [event::reset Method](../VS_csharp/event--reset-method.md)