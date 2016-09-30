---
title: "invalid_scheduler_policy_key Class"
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
  - "concrt/concurrency::invalid_scheduler_policy_key"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "invalid_scheduler_policy_key class"
ms.assetid: 6a7c42fe-9bc4-4a02-bebb-99fe9ef9817d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# invalid_scheduler_policy_key Class
This class describes an exception thrown when an invalid or unknown key is passed to a             <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object constructor, or the             <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method of a             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object is passed a key that must be changed using other means such as the             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[invalid_scheduler_policy_key::invalid_scheduler_policy_key Constructor](#invalid_scheduler_policy_key__invalid_scheduler_policy_key_constructor)|Overloaded. Constructs an                                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="invalid_scheduler_policy_key__invalid_scheduler_policy_key_constructor">\</a>  invalid_scheduler_policy_key::invalid_scheduler_policy_key Constructor  
 Constructs an                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A descriptive message of the error.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations)   
 [SchedulerPolicy::SetPolicyValue Method](../vs140/schedulerpolicy-class.md#schedulerpolicy__setpolicyvalue_method)   
 [SchedulerPolicy::SetConcurrencyLimits Method](../vs140/schedulerpolicy-class.md#schedulerpolicy__setconcurrencylimits_method)