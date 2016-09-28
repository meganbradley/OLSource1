---
title: "scheduler_not_attached::scheduler_not_attached Constructor"
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
  - "concrt/concurrency::scheduler_not_attached::scheduler_not_attached"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scheduler_not_attached, constructor"
ms.assetid: 67b1881c-5272-40b0-9fd8-6fb3fb3b99e8
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scheduler_not_attached::scheduler_not_attached Constructor
Constructs a `scheduler_not_attached` object.  
  
## Syntax  
  
```  
explicit _CRTIMP scheduler_not_attached(  
   _In_z_ const char * _Message  
) throw();  
  
scheduler_not_attached() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [scheduler_not_attached Class](../vs140/scheduler_not_attached-class.md)