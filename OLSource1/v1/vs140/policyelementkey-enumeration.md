---
title: "PolicyElementKey Enumeration"
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
  - "concrt/concurrency::PolicyElementKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PolicyElementKey enumeration"
ms.assetid: 6376ca26-54c8-4804-863f-c081e387fe36
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PolicyElementKey Enumeration
Policy keys describing aspects of scheduler behavior. Each policy element is described by a key-value pair. For more information about scheduler policies and their impact on schedulers, see [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The operating system thread priority of each context in the scheduler. If this key is set to the value [INHERIT_THREAD_PRIORITY](../vs140/inherit_thread_priority-constant.md) the contexts in the scheduler will inherit the priority of the thread that created the scheduler.\<br />\<br /> Valid values : Any of the valid values for the Windows <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function and the special value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>\<br />\<br /> Default value : <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The reserved stack size of each context in the scheduler in kilobytes.\<br />\<br /> Valid values : Positive integers\<br />\<br /> Default value : <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, indicating that the process' default value for stack size be used.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Determines whether the resources for the scheduler will be rebalanced according to statistical information gathered from the scheduler or only based on the subscription level of underlying hardware threads. For more information, see [DynamicProgressFeedbackType Enumeration](../vs140/dynamicprogressfeedbacktype-enumeration.md).\<br />\<br /> Valid values : A member of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> enumeration, either <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>\<br />\<br /> Default value : <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|When the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> policy key is set to the value <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, this specifies the maximum number of runnable contexts allowed to be cached in per virtual processor local queues. Such contexts will typically run in last-in-first-out (LIFO) order on the virtual processor that caused them to become runnable. Note that this policy key has no meaning when the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> key is set to the value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.\<br />\<br /> Valid values : Non-negative integers\<br />\<br /> Default value : <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The maximum concurrency level desired by the scheduler. The resource manager will try to initially allocate this many virtual processors. The special value [MaxExecutionResources](../vs140/maxexecutionresources-constant.md) indicates that the desired concurrency level is same as the number of hardware threads on the machine. If the value specified for <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is greater than the number of hardware threads on the machine and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is specified as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the value for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is raised to match what is set for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.\<br />\<br /> Valid values : Positive integers and the special value <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>\<br />\<br /> Default value : <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|The maximum policy element key. Not a valid element key.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The minimum concurrency level that must be provided to the scheduler by the resource manager. The number of virtual processors assigned to a scheduler will never go below the minimum. The special value [MaxExecutionResources](../vs140/maxexecutionresources-constant.md) indicates that the minimum concurrency level is same as the number of hardware threads on the machine. If the value specified for <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is less than the number of hardware threads on the machine and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is specified as <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the value for <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is lowered to match what is set for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.\<br />\<br /> Valid values : Non-negative integers and the special value <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. Note that for scheduler policies used for the construction of Concurrency Runtime schedulers, the value <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is invalid.\<br />\<br /> Default value : <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|The type of threads that the scheduler will utilize for underlying execution contexts. For more information, see [SchedulerType Enumeration](../vs140/schedulertype-enumeration.md).\<br />\<br /> Valid values : A member of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> enumeration, for example, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>\<br />\<br /> Default value : <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. This translates to Win32 threads on all operating systems.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Describes which scheduling algorithm will be used by the scheduler. For more information, see [SchedulingProtocolType Enumeration](../vs140/schedulingprotocoltype-enumeration.md).\<br />\<br /> Valid values : A member of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> enumeration, either <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>\<br />\<br /> Default value : <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Tentative number of virtual processors per hardware thread. The target oversubscription factor can be increased by the Resource Manager, if necessary, to satisfy <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> with the hardware threads on the machine.\<br />\<br /> Valid values : Positive integers\<br />\<br /> Default value : <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>||  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)