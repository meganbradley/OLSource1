---
title: "improper_scheduler_detach Class"
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
  - "concrt/concurrency::improper_scheduler_detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "improper_scheduler_detach class"
ms.assetid: 30132102-c900-4951-a470-b63b4e3aa2d2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# improper_scheduler_detach Class
This class describes an exception thrown when the             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method is called on a context which has not been attached to any scheduler using the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method of a             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[improper_scheduler_detach::improper_scheduler_detach Constructor](#improper_scheduler_detach__improper_scheduler_detach_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="improper_scheduler_detach__improper_scheduler_detach_constructor">\</a>  improper_scheduler_detach::improper_scheduler_detach Constructor  
 Constructs an                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [CurrentScheduler::Detach Method](../vs140/currentscheduler-class.md#currentscheduler__detach_method)   
 [Scheduler::Attach Method](../vs140/scheduler-class.md#scheduler__attach_method)