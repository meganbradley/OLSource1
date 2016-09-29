---
title: "invalid_operation::invalid_operation Constructor"
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
  - "concrt/concurrency::invalid_operation::invalid_operation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_operation, constructor"
ms.assetid: 328c06d3-61a2-40e8-802f-05a00eaeb55b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_operation::invalid_operation Constructor
Constructs an `invalid_operation` object.  
  
## Syntax  
  
```  
explicit _CRTIMP invalid_operation(  
   _In_z_ const char * _Message  
) throw();  
  
invalid_operation() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [invalid_operation Class](../VS_csharp/invalid_operation-class.md)