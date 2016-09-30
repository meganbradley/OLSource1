---
title: "Modules View"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.view.modules"
helpviewer_keywords: 
  - "Modules view"
  - "profiling tools reports, Modules view"
  - "profiling tools, Modules view"
ms.assetid: 4314a404-2120-425b-be42-180cd4bac840
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Modules View
The Modules view lists the modules of the profiling data. Each module is the root node of a hierarchical tree. The profiled functions of the module are listed underneath the module node. If the profiling data was collected by using the sampling method, line information is listed underneath the function node and instruction pointer data is listed underneath the line node.  
  
 Expand or collapse the module name to display or close the view of module performance data.  
  
 To add or remove columns, right-click in the report window, and then select **Add/Remove Columns**. You can sort the data by clicking a column name. For more information, see [How to: Customize Performance Report Views](../vs140/how-to--customize-report-view-columns.md).  
  
 The columns that are available in the Modules view depend on the profiling method (sampling or instrumentation) that was used to collect the data, and whether .NET memory data was collected in the profiling run.  
  
## See Also  
 [Modules View - Profiler Sampling Data](../vs140/modules-view---sampling-data.md)   
 [Modules View - Profiler Instrumentation Data](../vs140/modules-view---instrumentation-data.md)   
 [Modules View - Profiler .NET Memory Instrumentation Data](../vs140/modules-view---.net-memory-instrumentation-data.md)   
 [Modules View - Profiler .NET Memory Sampling Data](../vs140/modules-view---.net-memory-sampling-data.md)   
 [Modules View - Profiler Contention Data](../vs140/modules-view---contention-data.md)