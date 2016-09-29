---
title: "task_from_exception Function (Concurrency Runtime)"
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
  - "ppltasks/concurrency::task_from_exception"
dev_langs: 
  - "C++"
ms.assetid: 8e915732-1433-44d4-ad40-597201cb766c
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_from_exception Function (Concurrency Runtime)
## Syntax  
  
```  
template<  
   typename _TaskType,  
   typename _ExType  
>  
task<_TaskType> task_from_exception(  
   _ExType_Exception,  
   const task_options& _TaskOptions = task_options()  
);  
```  
  
#### Parameters  
 `_TaskType`  
 `_ExType`  
 `_Exception`  
 `_TaskOptions`  
  
## Return Value  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)