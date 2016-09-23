---
title: "improper_scheduler_reference::improper_scheduler_reference Constructor"
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
  - concrt/concurrency::improper_scheduler_reference::improper_scheduler_reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - improper_scheduler_reference, constructor
ms.assetid: a6c02ce9-b8b7-468a-982d-41e55417a0cd
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# improper_scheduler_reference::improper_scheduler_reference Constructor
Constructs an `improper_scheduler_reference` object.  
  
## Syntax  
  
```  
explicit _CRTIMP improper_scheduler_reference(  
   _In_z_ const char* _Message  
) throw();  
  
improper_scheduler_reference() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [improper_scheduler_reference Class](../vs140/improper_scheduler_reference-class.md)