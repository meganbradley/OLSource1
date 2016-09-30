---
title: "concurrency namespace constants1"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "concurrency namespace constants"
ms.assetid: 6f81fc4c-b10c-479e-8717-9c292360d5a0
caps.latest.revision: 7
---
# concurrency namespace constants1
||||  
|-|-|-|  
|[AgentEventGuid Constant](#agenteventguid_constant)|[CONCRT_RM_VERSION_1 Constant](#concrt_rm_version_1_constant)|[COOPERATIVE_TIMEOUT_INFINITE Constant](#cooperative_timeout_infinite_constant)|  
|[COOPERATIVE_WAIT_TIMEOUT Constant](#cooperative_wait_timeout_constant)|[ChoreEventGuid Constant](#choreeventguid_constant)|[ConcRTEventGuid Constant](#concrteventguid_constant)|  
|[ConcRT_ProviderGuid Constant](#concrt_providerguid_constant)|[ContextEventGuid Constant](#contexteventguid_constant)|[INHERIT_THREAD_PRIORITY Constant](#inherit_thread_priority_constant)|  
|[LockEventGuid Constant](#lockeventguid_constant)|[MaxExecutionResources Constant](#maxexecutionresources_constant)|[PPLParallelForEventGuid Constant](#pplparallelforeventguid_constant)|  
|[PPLParallelForeachEventGuid Constant](#pplparallelforeacheventguid_constant)|[PPLParallelInvokeEventGuid Constant](#pplparallelinvokeeventguid_constant)|[ResourceManagerEventGuid Constant](#resourcemanagereventguid_constant)|  
|[ScheduleGroupEventGuid Constant](#schedulegroupeventguid_constant)|[SchedulerEventGuid Constant](#schedulereventguid_constant)|[VirtualProcessorEventGuid Constant](#virtualprocessoreventguid_constant)|  
  
##  \<a name="agenteventguid_constant">\</a>  AgentEventGuid Constant  
 A category GUID ({B9B5B78C-0713-4898-A21A-C67949DCED07}) describing ETW events fired by the Agents library in the Concurrency Runtime.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="choreeventguid_constant">\</a>  ChoreEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to chores or tasks.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
##  \<a name="concrt_providerguid_constant">\</a>  ConcRT_ProviderGuid Constant  
 The ETW provider GUID for the Concurrency Runtime.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="concrt_rm_version_1_constant">\</a>  CONCRT_RM_VERSION_1 Constant  
 Indicates support of the Resource Manager interface defined in Visual Studio 2010.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="concrteventguid_constant">\</a>  ConcRTEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are not more specifically described by another category.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
##  \<a name="cooperative_timeout_infinite_constant">\</a>  COOPERATIVE_TIMEOUT_INFINITE Constant  
 Value indicating that a wait should never time out.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cooperative_wait_timeout_constant">\</a>  COOPERATIVE_WAIT_TIMEOUT Constant  
 Value indicating that a wait timed out.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="contexteventguid_constant">\</a>  ContextEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to contexts.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="inherit_thread_priority_constant">\</a>  INHERIT_THREAD_PRIORITY Constant  
 Special value for the policy key                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> indicating that the thread priority of all contexts in the scheduler should be the same as that of the thread which created the scheduler.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="lockeventguid_constant">\</a>  LockEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to locks.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
##  \<a name="maxexecutionresources_constant">\</a>  MaxExecutionResources Constant  
 Special value for the policy keys                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Defaults to the number of hardware threads on the machine in the absence of other constraints.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="pplparallelforeventguid_constant">\</a>  PPLParallelForEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="pplparallelforeacheventguid_constant">\</a>  PPLParallelForeachEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="pplparallelinvokeeventguid_constant">\</a>  PPLParallelInvokeEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="resourcemanagereventguid_constant">\</a>  ResourceManagerEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to the resource manager.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
##  \<a name="schedulegroupeventguid_constant">\</a>  ScheduleGroupEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to schedule groups.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 This category of events is not currently fired by the Concurrency Runtime.  
  
##  \<a name="schedulereventguid_constant">\</a>  SchedulerEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to scheduler activity.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="virtualprocessoreventguid_constant">\</a>  VirtualProcessorEventGuid Constant  
 A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to virtual processors.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)