---
title: "improper_scheduler_reference Class"
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
  - "concrt/concurrency::improper_scheduler_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "improper_scheduler_reference class"
ms.assetid: 434a7512-7796-4255-92a7-f3bf71c6a7a7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# improper_scheduler_reference Class
This class describes an exception thrown when the             `Reference` method is called on a             `Scheduler` object that is shutting down, from a context that is not part of that scheduler.  
  
## Syntax  
  
```  
class improper_scheduler_reference : public std::exception;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[improper_scheduler_reference::improper_scheduler_reference Constructor](#improper_scheduler_reference__improper_scheduler_reference_constructor)|Overloaded. Constructs an                                         `improper_scheduler_reference` object.|  
  
## Inheritance Hierarchy  
 `exception`  
  
 `improper_scheduler_reference`  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  <a name="improper_scheduler_reference__improper_scheduler_reference_constructor"></a>  improper_scheduler_reference::improper_scheduler_reference Constructor  
 Constructs an                 `improper_scheduler_reference` object.  
  
```  
explicit _CRTIMP improper_scheduler_reference(  
   _In_z_ const char*                 _Message  
) throw();  
  
improper_scheduler_reference() throw();  
```  
  
### Parameters  
 `_Message`  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Scheduler::Reference Method](../vs140/scheduler-class.md#scheduler__reference_method)