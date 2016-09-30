---
title: "Parallel Diagnostic Tools (Concurrency Runtime)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Parallel Diagnostic Tools [Concurrency Runtime]"
ms.assetid: b1a3f1d2-f5df-4f29-852e-906b3d8341fc
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parallel Diagnostic Tools (Concurrency Runtime)
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] provides extensive support for debugging and profiling multi-threaded applications.  
  
## Debugging  
 The Visual Studio debugger includes the **Parallel Stacks** window, **Parallel Tasks** window, and **Parallel Watch** window. For more information, see [Walkthrough: Debugging a Parallel Application](../vs140/walkthrough--debugging-a-parallel-application.md) and [How to: Use the Parallel Watch Window](../vs140/how-to--use-the-parallel-watch-window.md).  
  
## Profiling  
 The profiling tools provide three data views that display graphical, tabular and numerical information about how a multi-threaded application interacts with itself and with other programs. The views enable you to quickly identify areas of concern, and to navigate from points on the graphical displays to call stacks, call sites, and source code. For more information, see [Concurrency Visualizer](../vs140/concurrency-visualizer.md).  
  
## Event Tracing  
 The Concurrency Runtime uses [Event Tracing for Windows](http://msdn.microsoft.com/library/windows/desktop/bb968803) (ETW) to notify instrumentation tools, such as profilers, when various events occur. These events include when a scheduler is activated or deactivated, when a context begins, ends, blocks, unblocks, or yields, and when a parallel algorithm begins or ends.  
  
 Tools such as the [Concurrency Visualizer](../vs140/concurrency-visualizer.md) utilize this functionality; therefore, you typically do not have to work with these events directly. However, these events are useful when you are developing a custom profiler or when you use event tracing tools such as [Xperf](http://go.microsoft.com/fwlink/?LinkID=160628).  
  
 The Concurrency Runtime raises these events only when tracing is enabled. Call the [concurrency::EnableTracing](../vs140/enabletracing-function.md) function to enable event tracing and the [concurrency::DisableTracing](../vs140/disabletracing-function.md) function to disable tracing.  
  
 The following table describes the events that the runtime raises when event tracing is enabled:  
  
|Event|Description|Value|  
|-----------|-----------------|-----------|  
|[concurrency::ConcRT_ProviderGuid](../vs140/concrt_providerguid-constant.md)|The ETW provider identifier for the Concurrency Runtime.|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|  
|[concurrency::ContextEventGuid](../vs140/contexteventguid-constant.md)|Marks events that are related to contexts.|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|[concurrency::PPLParallelForEventGuid](../vs140/pplparallelforeventguid-constant.md)|Marks the entrance and exit to calls to the [concurrency::parallel_for](../vs140/parallel_for-function.md) algorithm.|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|[concurrency::PPLParallelForeachEventGuid](../vs140/pplparallelforeacheventguid-constant.md)|Marks the entrance and exit to calls to the [concurrency::parallel_for_each](../vs140/parallel_for_each-function.md) algorithm.|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|[concurrency::PPLParallelInvokeEventGuid](../vs140/pplparallelinvokeeventguid-constant.md)|Marks the entrance and exit to calls to the [concurrency::parallel_invoke](../vs140/parallel_invoke-function.md) algorithm.|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|[concurrency::SchedulerEventGuid](../vs140/schedulereventguid-constant.md)|Marks events that are related to the [Task Scheduler](../vs140/task-scheduler--concurrency-runtime-.md).|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|[concurrency::VirtualProcessorEventGuid](../vs140/virtualprocessoreventguid-constant.md)|Marks events that are related to virtual processors.|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
  
 The Concurrency Runtime defines, but does not currently raise, the following events. The runtime reserves these events for future use:  
  
-   [concurrency::ConcRTEventGuid](../vs140/concrteventguid-constant.md)  
  
-   [concurrency::ScheduleGroupEventGuid](../vs140/schedulereventguid-constant.md)  
  
-   [concurrency::ChoreEventGuid](../vs140/choreeventguid-constant.md)  
  
-   [concurrency::LockEventGuid](../vs140/lockeventguid-constant.md)  
  
-   [concurrency::ResourceManagerEventGuid](../vs140/resourcemanagereventguid-constant.md)  
  
 The [concurrency::ConcRT_EventType](../vs140/concrt_eventtype-enumeration.md) enumeration specifies the possible operations that an event tracks. For example, at the entrance of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> algorithm, the runtime raises the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> event and provides <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as the operation. Before the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> algorithm returns, the runtime again raises the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> event and provides <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as the operation.  
  
 The following example illustrates how to enable tracing for a call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The runtime does not trace the first call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> because tracing it not enabled. The call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> enables the runtime to trace the second call to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 [!code[concrt-etw#1](../vs140/codesnippet/CPP/parallel-diagnostic-tools--concurrency-runtime-_1.cpp)]  
  
 The runtime tracks the number of times that you call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Therefore, if you call <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> multiple times, you must call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> the same number of times in order to disable tracing.  
  
## See Also  
 [Concurrency Runtime](../vs140/concurrency-runtime.md)