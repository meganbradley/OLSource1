---
title: "Collecting Concurrency Data for a Service by Using the Profiler Command Line"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 275aacba-b2af-4d34-8931-ee30d777a256
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collecting Concurrency Data for a Service by Using the Profiler Command Line
The concurrency method of [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] Profiling Tools enables you to collect resource contention data and thread activity data that shows you CPU utilization, thread contention, thread migration, synchronization delays, areas of overlapped IO, and other system events.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Profiling Windows 8 and Windows Server 2012 applications](../VS_csharp/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Attach to a running .NET service**|-   [How to: Attach the Profiler to a .NET Service to Collect Concurrency Data by Using the Command Line](../VS_csharp/how-to--attach-the-profiler-to-a-.net-service-to-collect-concurrency-data-by-using-the-command-line.md)|  
|**Add tier-interaction data**|-   [How to: Add Tier Interaction Data to Profiling Data From the Command Line](../VS_csharp/adding-tier-interaction-data-from-the-command-line.md)|  
|**Attach to a running C/C++ service**|-   [How to: Attach the Profiler to a Native Service to Collect Concurrency Data by Using the Command Line](../VS_csharp/how-to--attach-the-profiler-to-a-native-service-to-collect-concurrency-data-by-using-the-command-line.md)|  
  
## Related Tasks  
  
### Profiling Windows Services  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile by using the sampling method**|-   [Collecting Application Statistics for Services by Using the Profiler Sampling Method](../VS_csharp/collecting-application-statistics-for-services-by-using-the-profiler-sampling-method.md)|  
|**Profile by using the instrumentation method**|-   [Collecting Detailed Timing Data for Services Using the Instrumentation Method from the Profiler Command-Line](../VS_csharp/collecting-detailed-timing-data-for-services-by-using-the-instrumentation-method-from-the-profiler-command-line.md)|  
|**Profile.NET memory allocation and garbage collection**|-   [Collecting .NET Memory Data from Services using the Profiler Command-Line](../VS_csharp/collecting-memory-data-from-.net-framework-services-by-using-the-profiler-command-line.md)|  
  
### Profiling Concurrency Data  
  
|Task|Related Content|  
|----------|---------------------|  
|**Profile stand-alone applications**|-   [Collecting Concurrency Data for Stand-Alone Applications by Using the Profiler Command Line](../VS_csharp/collecting-concurrency-data-for-stand-alone-applications-by-using-the-profiler-command-line.md)|  
|**Profile ASP.NET Web applications**|-   [Collecting Concurrency Data for an ASP.NET Web Application Using the Profiler Command Line](../VS_csharp/collecting-concurrency-data-for-an-asp.net-web-application-using-the-profiler-command-line.md)|  
  
### Analyzing Concurrency Data Views and Reports  
 [Resource Contention Data](../VS_csharp/resource-contention-data-views.md)  
  
 [Thread Execution Data Views](../VS_csharp/concurrency-visualizer.md)  
  
## Reference  
 [Command-Line Profiling Tools Reference](../VS_csharp/command-line-profiling-tools-reference.md)