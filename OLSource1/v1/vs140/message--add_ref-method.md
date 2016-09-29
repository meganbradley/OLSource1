---
title: "message::add_ref Method"
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
  - "agents/concurrency::message::add_ref"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add_ref method"
ms.assetid: 69e94b53-ae6a-47ef-adc4-a729f3904b8a
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# message::add_ref Method
Adds to the reference count for the `message` object. Used for message blocks that need reference counting to determine message lifetimes.  
  
## Syntax  
  
```  
long add_ref();  
```  
  
## Return Value  
 The new value of the reference count.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [message Class](../vs140/message-class.md)