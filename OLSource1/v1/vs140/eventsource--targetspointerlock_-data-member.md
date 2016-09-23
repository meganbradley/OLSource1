---
title: "EventSource::targetsPointerLock_ Data Member"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - event/Microsoft::WRL::EventSource::targetsPointerLock_
dev_langs: 
  - C++
helpviewer_keywords: 
  - targetsPointerLock_ data member
ms.assetid: 8f08409f-5262-4be7-9cf1-2ed15f19684a
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# EventSource::targetsPointerLock_ Data Member
Synchronizes access to internal data members even while event handlers for this EventSource are being added, removed, or invoked.  
  
## Syntax  
  
```  
Wrappers::SRWLock targetsPointerLock_;  
```  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [EventSource Class](../vs140/eventsource-class.md)