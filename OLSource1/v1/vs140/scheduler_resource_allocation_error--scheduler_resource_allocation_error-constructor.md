---
title: "scheduler_resource_allocation_error::scheduler_resource_allocation_error Constructor"
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
  - "concrt/concurrency::scheduler_resource_allocation_error::scheduler_resource_allocation_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scheduler_resource_allocation_error, constructor"
ms.assetid: cceca840-2bee-4cb3-974e-6b52b5cb14d3
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scheduler_resource_allocation_error::scheduler_resource_allocation_error Constructor
Constructs a `scheduler_resource_allocation_error` object.  
  
## Syntax  
  
```  
scheduler_resource_allocation_error(  
   _In_z_ const char * _Message,  
   HRESULT _Hresult  
) throw();  
  
explicit _CRTIMP scheduler_resource_allocation_error(  
   HRESULT _Hresult  
) throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
 `_Hresult`  
 The `HRESULT` value of the error that caused the exception.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [scheduler_resource_allocation_error Class](../vs140/scheduler_resource_allocation_error-class.md)