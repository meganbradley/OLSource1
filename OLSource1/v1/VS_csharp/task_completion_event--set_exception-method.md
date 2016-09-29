---
title: "task_completion_event::set_exception Method"
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
  - "ppltasks/concurrency::task_completion_event::set_exception"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_exception method"
ms.assetid: 2421dbaa-bc5c-4965-9a13-2f81560d46e3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_completion_event::set_exception Method
Propagates an exception to all tasks associated with this event.  
  
## Syntax  
  
```  
template<  
   typename _E  
>  
__declspec(  
   noinline  
) bool set_exception(_E _Except) const;  
  
__declspec(  
   noinline  
) bool set_exception(std::exception_ptr _ExceptionPtr) const ;  
```  
  
#### Parameters  
 `_E`  
 `_Except`  
 `_ExceptionPtr`  
  
## Return Value  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_completion_event Class](../VS_csharp/task_completion_event-class.md)