---
title: "invalid_scheduler_policy_thread_specification Class"
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
  - "concrt/concurrency::invalid_scheduler_policy_thread_specification"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_scheduler_policy_thread_specification class"
ms.assetid: 2d0fafb2-18f8-4284-8040-3db640d33303
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_scheduler_policy_thread_specification Class
This class describes an exception thrown when an attempt is made to set the concurrency limits of a             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object such that the value of the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> key is less than the value of the             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[invalid_scheduler_policy_thread_specification::invalid_scheduler_policy_thread_specification Constructor](../vs140/invalid_scheduler_policy_value-class.md#invalid_scheduler_policy_thread_specification__invalid_scheduler_policy_thread_specification_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="invalid_scheduler_policy_value__invalid_scheduler_policy_value_constructor">\</a>  invalid_scheduler_policy_value::invalid_scheduler_policy_value Constructor  
 Constructs an                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations)   
 [SchedulerPolicy::SetConcurrencyLimits Method](../vs140/schedulerpolicy-class.md#schedulerpolicy__setconcurrencylimits_method)