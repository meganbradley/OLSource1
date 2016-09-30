---
title: "SchedulerPolicy::SchedulerPolicy Constructor"
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
  - "concrt/concurrency::SchedulerPolicy::SchedulerPolicy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SchedulerPolicy, constructor"
ms.assetid: 73ba1d7b-71f2-4a67-aaf8-8243556a64e3
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SchedulerPolicy::SchedulerPolicy Constructor
Constructs a new scheduler policy and populates it with values for [policy keys](../vs140/policyelementkey-enumeration.md) supported by Concurrency Runtime schedulers and the Resource Manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of key/value pairs that follow the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The source policy to copy.  
  
## Remarks  
 The first constructor creates a new scheduler policy where all policies will be initialized to their default values.  
  
 The second constructor creates a new scheduler policy that uses a named-parameter style of initialization. Values after the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter are supplied as key/value pairs. Any policy key which is not specified in this constructor will have its default value. This constructor could throw the exceptions [invalid_scheduler_policy_key](../vs140/invalid_scheduler_policy_key-class.md), [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md) or [invalid_scheduler_policy_thread_specification](../vs140/invalid_scheduler_policy_thread_specification-class.md).  
  
 The third constructor is a copy constructor. Often, the most convenient way to define a new scheduler policy is to copy an existing policy and modify it using the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> methods.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [SchedulerPolicy::SetPolicyValue Method](../vs140/schedulerpolicy--setpolicyvalue-method.md)   
 [SchedulerPolicy::GetPolicyValue Method](../vs140/schedulerpolicy--getpolicyvalue-method.md)   
 [SchedulerPolicy::SetConcurrencyLimits Method](../vs140/schedulerpolicy--setconcurrencylimits-method.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)