---
title: "missing_wait Class"
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
  - "concrt/concurrency::missing_wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "missing_wait class"
ms.assetid: ff981875-bd43-47e3-806f-b03c9f418b18
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# missing_wait Class
This class describes an exception thrown when there are tasks still scheduled to a             `task_group` or             `structured_task_group` object at the time that object's destructor executes. This exception will never be thrown if the destructor is reached because of a stack unwinding as the result of an exception.  
  
## Syntax  
  
```  
class missing_wait : public std::exception;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[missing_wait::missing_wait Constructor](#missing_wait__missing_wait_constructor)|Overloaded. Constructs a                                         `missing_wait` object.|  
  
## Remarks  
 Absent exception flow, you are responsible for calling either the                 `wait` or                 `run_and_wait` method of a                 `task_group` or                 `structured_task_group` object before allowing that object to destruct. The runtime throws this exception as an indication that you forgot to call the                 `wait` or                 `run_and_wait` method.  
  
## Inheritance Hierarchy  
 `exception`  
  
 `missing_wait`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="missing_wait__missing_wait_constructor"></a>  missing_wait::missing_wait Constructor  
 Constructs a                 `missing_wait` object.  
  
```  
explicit _CRTIMP missing_wait(  
   _In_z_ const char *                 _Message  
) throw();  
  
missing_wait() throw();  
```  
  
### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [task_group::wait Method](../vs140/task_group-class.md#task_group__wait_method)   
 [task_group::run_and_wait Method](../vs140/task_group-class.md#task_group__run_and_wait_method)   
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [structured_task_group::wait Method](../vs140/structured_task_group-class.md#structured_task_group__wait_method)   
 [structured_task_group::run_and_wait Method](../vs140/structured_task_group-class.md#structured_task_group__run_and_wait_method)