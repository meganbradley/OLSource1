---
title: "SchedulerPolicy::SetPolicyValue Method"
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
  - "concrt/concurrency::SchedulerPolicy::SetPolicyValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPolicyValue method"
ms.assetid: bc74de7d-e564-4d9c-aa16-c71bc61470c5
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SchedulerPolicy::SetPolicyValue Method
Sets the value of the policy key supplied as the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter and returns the old value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The policy key to set a value for.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value to set the policy key to.  
  
## Return Value  
 If the key specified by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is supported, the old policy value for the key cast to an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The method will throw [invalid_scheduler_policy_key](../vs140/invalid_scheduler_policy_key-class.md) for an invalid policy key or any policy key whose value cannot be set by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
 The method will throw [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md) for a value that is not supported for the key specified by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
 Note that this method is not allowed to set the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> policies. To set these values, use the [SetConcurrencyLimits](../vs140/schedulerpolicy--setconcurrencylimits-method.md) method.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [SchedulerPolicy::GetPolicyValue Method](../vs140/schedulerpolicy--getpolicyvalue-method.md)   
 [SchedulerPolicy::SetConcurrencyLimits Method](../vs140/schedulerpolicy--setconcurrencylimits-method.md)   
 [PolicyElementKey Enumeration](../vs140/policyelementkey-enumeration.md)