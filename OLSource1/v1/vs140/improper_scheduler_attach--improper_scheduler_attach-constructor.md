---
title: "improper_scheduler_attach::improper_scheduler_attach Constructor"
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
  - concrt/concurrency::improper_scheduler_attach::improper_scheduler_attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - improper_scheduler_attach, constructor
ms.assetid: 907d3842-3a3b-45c5-830d-a5d2d2b1c530
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# improper_scheduler_attach::improper_scheduler_attach Constructor
Constructs an `improper_scheduler_attach` object.  
  
## Syntax  
  
```  
explicit _CRTIMP improper_scheduler_attach(  
   _In_z_ const char * _Message  
) throw();  
  
improper_scheduler_attach() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [improper_scheduler_attach Class](../vs140/improper_scheduler_attach-class.md)