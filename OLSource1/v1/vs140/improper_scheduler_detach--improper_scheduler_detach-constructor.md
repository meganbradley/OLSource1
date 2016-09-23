---
title: "improper_scheduler_detach::improper_scheduler_detach Constructor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrt/concurrency::improper_scheduler_detach::improper_scheduler_detach
dev_langs: 
  - C++
helpviewer_keywords: 
  - improper_scheduler_detach, constructor
ms.assetid: 5072e1b0-61d2-41c0-b7f4-3ad39e18a42f
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# improper_scheduler_detach::improper_scheduler_detach Constructor
Constructs an `improper_scheduler_detach` object.  
  
## Syntax  
  
```  
explicit _CRTIMP improper_scheduler_detach(  
   _In_z_ const char * _Message  
) throw();  
  
improper_scheduler_detach() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [improper_scheduler_detach Class](../vs140/improper_scheduler_detach-class.md)