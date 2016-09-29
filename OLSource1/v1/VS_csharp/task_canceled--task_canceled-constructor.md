---
title: "task_canceled::task_canceled Constructor"
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
  - "concrt/concurrency::task_canceled::task_canceled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task_canceled, constructor"
ms.assetid: cba7b785-efe9-4e4a-8994-ce30323dbf9e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_canceled::task_canceled Constructor
Constructs a `task_canceled` object.  
  
## Syntax  
  
```  
explicit _CRTIMP task_canceled(  
   _In_z_ const char * _Message  
) throw();  
  
task_canceled() throw();  
```  
  
#### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_canceled Class](../VS_csharp/task_canceled-class.md)