---
title: "SchedulerPolicy::SetConcurrencyLimits Method"
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
  - concrt/concurrency::SchedulerPolicy::SetConcurrencyLimits
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetConcurrencyLimits method
ms.assetid: 829ac25b-ad8e-4901-910d-02fda8dc720d
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# SchedulerPolicy::SetConcurrencyLimits Method
Simultaneously sets the `MinConcurrency` and `MaxConcurrency` policies on the `SchedulerPolicy` object.  
  
## Syntax  
  
```  
void SetConcurrencyLimits(  
   unsigned int _MinConcurrency,  
   unsigned int _MaxConcurrency = MaxExecutionResources  
);  
```  
  
#### Parameters  
 `_MinConcurrency`  
 The value for the `MinConcurrency` policy key.  
  
 `_MaxConcurrency`  
 The value for the `MaxConcurrency` policy key.  
  
## Remarks  
 The method will throw [invalid_scheduler_policy_thread_specification](../vs140/invalid_scheduler_policy_thread_specification-class.md) if the value specified for the `MinConcurrency` policy is greater than that specified for the `MaxConcurrency` policy.  
  
 The method can also throw [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md) for other invalid values.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [SchedulerPolicy::GetPolicyValue Method](../vs140/schedulerpolicy--getpolicyvalue-method.md)   
 [SchedulerPolicy::SetPolicyValue Method](../vs140/schedulerpolicy--setpolicyvalue-method.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)