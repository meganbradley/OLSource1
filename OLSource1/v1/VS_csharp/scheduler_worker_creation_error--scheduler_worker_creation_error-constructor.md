---
title: "scheduler_worker_creation_error::scheduler_worker_creation_error Constructor"
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
  - "concrt/concurrency::scheduler_worker_creation_error::scheduler_worker_creation_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scheduler_worker_creation_error, constructor"
ms.assetid: f30f3931-18e5-4985-abe2-a9c1a42a718b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scheduler_worker_creation_error::scheduler_worker_creation_error Constructor
Constructs a `scheduler_worker_creation_error` object.  
  
## Syntax  
  
```  
scheduler_worker_creation_error(  
   _In_z_ const char * _Message,  
   HRESULT _Hresult  
) throw();  
  
explicit _CRTIMP scheduler_worker_creation_error(  
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
 [scheduler_worker_creation_error Class](../VS_csharp/scheduler_worker_creation_error-class.md)