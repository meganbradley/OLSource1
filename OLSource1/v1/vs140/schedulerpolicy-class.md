---
title: "SchedulerPolicy Class"
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
  - "concrt/concurrency::SchedulerPolicy"
  - "concrtrm/concurrency::SchedulerPolicy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SchedulerPolicy class"
ms.assetid: bcebf51a-65f8-45a3-809b-d1ff93527dc4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SchedulerPolicy Class
The             <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class contains a set of key/value pairs, one for each policy element, that control the behavior of a scheduler instance.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[SchedulerPolicy::SchedulerPolicy Constructor](#schedulerpolicy__schedulerpolicy_constructor)|Overloaded. Constructs a new scheduler policy and populates it with values for                                         [policy keys](concurrency_namespace_Enumerations) supported by Concurrency Runtime schedulers and the Resource Manager.|  
|[SchedulerPolicy::~SchedulerPolicy Destructor](#schedulerpolicy___dtorschedulerpolicy_destructor)|Destroys a scheduler policy.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SchedulerPolicy::GetPolicyValue Method](#schedulerpolicy__getpolicyvalue_method)|Retrieves the value of the policy key supplied as the                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.|  
|[SchedulerPolicy::SetConcurrencyLimits Method](#schedulerpolicy__setconcurrencylimits_method)|Simultaneously sets the                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> policies on the                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[SchedulerPolicy::SetPolicyValue Method](#schedulerpolicy__setpolicyvalue_method)|Sets the value of the policy key supplied as the                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter and returns the old value.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[SchedulerPolicy::operator= Operator](#schedulerpolicy__operator_eq_operator)|Assigns the scheduler policy from another scheduler policy.|  
  
## Remarks  
 For more information about the policies which can be controlled using the                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class, see                 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h, concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="schedulerpolicy__getpolicyvalue_method">\</a>  SchedulerPolicy::GetPolicyValue Method  
 Retrieves the value of the policy key supplied as the                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The policy key to retrieve a value for.  
  
### Return Value  
 If the key specified by the                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter is supported, the policy value for the key cast to an                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
### Remarks  
 The method will throw                         [invalid_scheduler_policy_key](../vs140/invalid_scheduler_policy_key-class.md) for an invalid policy key.  
  
##  \<a name="schedulerpolicy__operator_eq_operator">\</a>  SchedulerPolicy::operator= Operator  
 Assigns the scheduler policy from another scheduler policy.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The policy to assign to this policy.  
  
### Return Value  
 A reference to the scheduler policy.  
  
### Remarks  
 Often, the most convenient way to define a new scheduler policy is to copy an existing policy and modify it using the                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> methods.  
  
##  \<a name="schedulerpolicy__schedulerpolicy_constructor">\</a>  SchedulerPolicy::SchedulerPolicy Constructor  
 Constructs a new scheduler policy and populates it with values for                 [policy keys](concurrency_namespace_Enumerations) supported by Concurrency Runtime schedulers and the Resource Manager.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The number of key/value pairs that follow the                                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 The source policy to copy.  
  
### Remarks  
 The first constructor creates a new scheduler policy where all policies will be initialized to their default values.  
  
 The second constructor creates a new scheduler policy that uses a named-parameter style of initialization. Values after the                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter are supplied as key/value pairs. Any policy key which is not specified in this constructor will have its default value. This constructor could throw the exceptions                         [invalid_scheduler_policy_key](../vs140/invalid_scheduler_policy_key-class.md),                         [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md) or                         [invalid_scheduler_policy_thread_specification](../vs140/invalid_scheduler_policy_thread_specification-class.md).  
  
 The third constructor is a copy constructor. Often, the most convenient way to define a new scheduler policy is to copy an existing policy and modify it using the                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> methods.  
  
##  \<a name="schedulerpolicy___dtorschedulerpolicy_destructor">\</a>  SchedulerPolicy::~SchedulerPolicy Destructor  
 Destroys a scheduler policy.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="schedulerpolicy__setconcurrencylimits_method">\</a>  SchedulerPolicy::SetConcurrencyLimits Method  
 Simultaneously sets the                 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> policies on the                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The value for the                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> policy key.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The value for the                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> policy key.  
  
### Remarks  
 The method will throw                         [invalid_scheduler_policy_thread_specification](../vs140/invalid_scheduler_policy_thread_specification-class.md) if the value specified for the                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> policy is greater than that specified for the                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> policy.  
  
 The method can also throw                         [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md) for other invalid values.  
  
##  \<a name="schedulerpolicy__setpolicyvalue_method">\</a>  SchedulerPolicy::SetPolicyValue Method  
 Sets the value of the policy key supplied as the                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter and returns the old value.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The policy key to set a value for.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The value to set the policy key to.  
  
### Return Value  
 If the key specified by the                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> parameter is supported, the old policy value for the key cast to an                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Remarks  
 The method will throw                         [invalid_scheduler_policy_key](../vs140/invalid_scheduler_policy_key-class.md) for an invalid policy key or any policy key whose value cannot be set by the                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method.  
  
 The method will throw                         [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md) for a value that is not supported for the key specified by the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> parameter.  
  
 Note that this method is not allowed to set the                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> policies. To set these values, use the                         [SetConcurrencyLimits](#schedulerpolicy__setconcurrencylimits_method) method.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations)   
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)