---
title: "concurrency namespace enums"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a40e3b2d-ad21-4229-9880-2cfa84f7ab8f
caps.latest.revision: 7
---
# concurrency namespace enums
||||  
|-|-|-|  
|[Agents_EventType Enumeration](#agents_eventtype_enumeration)|[ConcRT_EventType Enumeration](#concrt_eventtype_enumeration)|[Concrt_TraceFlags Enumeration](#concrt_traceflags_enumeration)|  
|[CriticalRegionType Enumeration](#criticalregiontype_enumeration)|[DynamicProgressFeedbackType Enumeration](#dynamicprogressfeedbacktype_enumeration)|[PolicyElementKey Enumeration](#policyelementkey_enumeration)|  
|[SchedulerType Enumeration](#schedulertype_enumeration)|[SchedulingProtocolType Enumeration](#schedulingprotocoltype_enumeration)|[SwitchingProxyState Enumeration](#switchingproxystate_enumeration)|  
|[WinRTInitializationType Enumeration](#winrtinitializationtype_enumeration)|[agent_status Enumeration](#agent_status_enumeration)|[join_type Enumeration](#join_type_enumeration)|  
|[message_status Enumeration](#message_status_enumeration)|[task_group_status Enumeration](#task_group_status_enumeration)|  
  
##  \<a name="agent_status_enumeration">\</a>  agent_status Enumeration  
 The valid states for an                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [Asynchronous Agents](../vs140/asynchronous-agents.md).  
  
##  \<a name="agents_eventtype_enumeration">\</a>  Agents_EventType Enumeration  
 The types of events that can be traced using the tracing functionality offered by the Agents Library  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="concrt_eventtype_enumeration">\</a>  ConcRT_EventType Enumeration  
 The types of events that can be traced using the tracing functionality offered by the Concurrency Runtime.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="concrt_traceflags_enumeration">\</a>  Concrt_TraceFlags Enumeration  
 Trace flags for the event types  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="criticalregiontype_enumeration">\</a>  CriticalRegionType Enumeration  
 The type of critical region a context is inside.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="dynamicprogressfeedbacktype_enumeration">\</a>  DynamicProgressFeedbackType Enumeration  
 Used by the                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> policy to describe whether resources for the scheduler will be rebalanced according to statistical information gathered from the scheduler or only based on virtual processors going in and out of the idle state through calls to the                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> methods on the                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface. For more information on available scheduler policies, see                 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="join_type_enumeration">\</a>  join_type Enumeration  
 The type of a                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> messaging block.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="message_status_enumeration">\</a>  message_status Enumeration  
 The valid responses for an offer of a                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object to a block.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="policyelementkey_enumeration">\</a>  PolicyElementKey Enumeration  
 Policy keys describing aspects of scheduler behavior. Each policy element is described by a key-value pair. For more information about scheduler policies and their impact on schedulers, see                 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="schedulertype_enumeration">\</a>  SchedulerType Enumeration  
 Used by the                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> policy to describe the type of threads that the scheduler should utilize for underlying execution contexts. For more information on available scheduler policies, see                 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="schedulingprotocoltype_enumeration">\</a>  SchedulingProtocolType Enumeration  
 Used by the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> policy to describe which scheduling algorithm will be utilized for the scheduler. For more information on available scheduler policies, see                 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="switchingproxystate_enumeration">\</a>  SwitchingProxyState Enumeration  
 Used to denote the state a thread proxy is in, when it is executing a cooperative context switch to a different thread proxy.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 A parameter of type                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is passed in to the method                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to instruct the Resource Manager how to treat the thread proxy that is making the call.  
  
 For more information on how this type is used, see                         [IThreadProxy::SwitchTo](../vs140/ithreadproxy-structure.md#ithreadproxy__switchto_method).  
  
##  \<a name="task_group_status_enumeration">\</a>  task_group_status Enumeration  
 Describes the execution status of a                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object. A value of this type is returned by numerous methods that wait on tasks scheduled to a task group to complete.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="winrtinitializationtype_enumeration">\</a>  WinRTInitializationType Enumeration  
 Used by the                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> policy to describe whether and how the Windows Runtime will be initialized on scheduler threads for an application which runs on operating systems with version Windows 8 or higher. For more information on available scheduler policies, see                 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations).  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)