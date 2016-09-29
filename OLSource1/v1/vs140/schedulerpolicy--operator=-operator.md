---
title: "SchedulerPolicy::operator= Operator"
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
  - "concrt/concurrency::SchedulerPolicy::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 88571f8a-8c65-4cfe-a036-25ca45e36964
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SchedulerPolicy::operator= Operator
Assigns the scheduler policy from another scheduler policy.  
  
## Syntax  
  
```  
SchedulerPolicy& operator=(  
   const SchedulerPolicy& _RhsPolicy  
);  
```  
  
#### Parameters  
 `_RhsPolicy`  
 The policy to assign to this policy.  
  
## Return Value  
 A reference to the scheduler policy.  
  
## Remarks  
 Often, the most convenient way to define a new scheduler policy is to copy an existing policy and modify it using the `SetPolicyValue` or `SetConcurrencyLimits` methods.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [SchedulerPolicy::SetPolicyValue Method](../vs140/schedulerpolicy--setpolicyvalue-method.md)   
 [SchedulerPolicy::SetConcurrencyLimits Method](../vs140/schedulerpolicy--setconcurrencylimits-method.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)