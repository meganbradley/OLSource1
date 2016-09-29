---
title: "invalid_scheduler_policy_thread_specification::invalid_scheduler_policy_thread_specification Constructor"
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
  - "concrt/concurrency::invalid_scheduler_policy_thread_specification::invalid_scheduler_policy_thread_specification"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_scheduler_policy_thread_specification, constructor"
ms.assetid: eddb6012-41fb-44f7-9ce0-83a6be898be1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_scheduler_policy_thread_specification::invalid_scheduler_policy_thread_specification Constructor
Constructs an `invalid_scheduler_policy_value` object.  
  
## Syntax  
  
```  
explicit _CRTIMP invalid_scheduler_policy_thread_specification(  
   _In_z_ const char * _Message  
) throw();  
  
invalid_scheduler_policy_thread_specification() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [invalid_scheduler_policy_thread_specification Class](../vs140/invalid_scheduler_policy_thread_specification-class.md)