---
title: "improper_lock::improper_lock Constructor"
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
  - "concrt/concurrency::improper_lock::improper_lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "improper_lock, constructor"
ms.assetid: 5f06b735-e3e6-421a-9c45-5ad5bdfefc2d
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# improper_lock::improper_lock Constructor
Constructs an `improper_lock exception`.  
  
## Syntax  
  
```  
explicit _CRTIMP improper_lock(  
   _In_z_ const char * _Message  
) throw();  
  
improper_lock() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [improper_lock Class](../vs140/improper_lock-class.md)