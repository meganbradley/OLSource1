---
title: "task_canceled Class"
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
  - concrt/concurrency::task_canceled
dev_langs: 
  - C++
helpviewer_keywords: 
  - task_canceled class
ms.assetid: c3f0b234-2cc1-435f-a48e-995f45b190be
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# task_canceled Class
This class describes an exception thrown by the PPL tasks layer in order to force the current task to cancel. It is also thrown by the             `get()` method on             [task](../vs140/task-class---internal-members.md), for a canceled task.  
  
## Syntax  
  
```  
class task_canceled : public std::exception;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[task_canceled::task_canceled Constructor](#task_canceled__task_canceled_constructor)|Overloaded. Constructs a                                         `task_canceled` object.|  
  
## Inheritance Hierarchy  
 `exception`  
  
 `task_canceled`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  <a name="task_canceled__task_canceled_constructor"></a>  task_canceled::task_canceled Constructor  
 Constructs a                 `task_canceled` object.  
  
```  
explicit _CRTIMP task_canceled(  
   _In_z_ const char *                 _Message  
) throw();  
  
task_canceled() throw();  
```  
  
### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task::get Method](../vs140/task-class--concurrency-runtime-.md#task__get_method)   
 [cancel_current_task Method](concurrency_namespace_Functions)