---
title: "nested_scheduler_missing_detach Class"
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
  - "concrt/concurrency::nested_scheduler_missing_detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nested_scheduler_missing_detach class"
ms.assetid: 65d3f277-6d43-4160-97ef-caf8b26c1641
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nested_scheduler_missing_detach Class
This class describes an exception thrown when the Concurrency Runtime detects that you neglected to call the             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method on a context that attached to a second scheduler using the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method of the             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[nested_scheduler_missing_detach::nested_scheduler_missing_detach Constructor](#nested_scheduler_missing_detach__nested_scheduler_missing_detach_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 This exception is thrown only when you nest one scheduler inside another by calling the                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method of a                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object on a context that is already owned by or attached to another scheduler. The Concurrency Runtime throws this exception opportunistically when it can detect the scenario as an aid to locating the problem. Not every instance of neglecting to call the                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method is guaranteed to throw this exception.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="nested_scheduler_missing_detach__nested_scheduler_missing_detach_constructor">\</a>  nested_scheduler_missing_detach::nested_scheduler_missing_detach Constructor  
 Constructs a                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [CurrentScheduler::Detach Method](../vs140/currentscheduler-class.md#currentscheduler__detach_method)   
 [Scheduler::Attach Method](../vs140/scheduler-class.md#scheduler__attach_method)