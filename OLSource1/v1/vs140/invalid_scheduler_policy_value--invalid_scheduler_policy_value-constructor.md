---
title: "invalid_scheduler_policy_value::invalid_scheduler_policy_value Constructor"
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
  - "concrt/concurrency::invalid_scheduler_policy_value::invalid_scheduler_policy_value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_scheduler_policy_value, constructor"
ms.assetid: 12953b51-2175-463a-9e70-df67261518c4
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_scheduler_policy_value::invalid_scheduler_policy_value Constructor
Constructs an `invalid_scheduler_policy_value` object.  
  
## Syntax  
  
```  
explicit _CRTIMP invalid_scheduler_policy_value(  
   _In_z_ const char * _Message  
) throw();  
  
invalid_scheduler_policy_value() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [invalid_scheduler_policy_value Class](../vs140/invalid_scheduler_policy_value-class.md)