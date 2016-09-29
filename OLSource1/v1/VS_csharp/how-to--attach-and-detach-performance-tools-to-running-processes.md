---
title: "How to: Attach and Detach Performance Tools to Running Processes"
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
  - "vs.performance.attach"
helpviewer_keywords: 
  - "performance tools, attach process"
  - "profiling tools, detach process"
  - "profiling tools, attach process"
  - "performance tools, detach process"
  - "profiler"
ms.assetid: 56a99c39-e7f6-4f48-ae56-04ab8e022bf7
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Attach and Detach Performance Tools to Running Processes
The profiler can be used to attach to or detach from a running process to make sampling and gathering performance data easier. You can use this method to profile a process when you want to avoid gathering data about application load time, or to monitor the performance of a process after it reaches a specific state.  
  
> [!NOTE]
>  The following steps apply to attaching and detaching processes from within the [!INCLUDE[vs_current_short](../VS_csharp/includes/vs_current_short_md.md)] integrated development environmnent (IDE). For information about how to use command line tools, see [Command-line Tools](../VS_csharp/using-the-profiling-tools-from-the-command-line.md). For information about how to profile services, see [Command-Line Profiling of Services](../VS_csharp/command-line-profiling-of-services.md).  
  
 The processes that are available to profile depend on the User Access Permissions that are set by an administrator of the computer. A User account may, for example, have permission for any of the following:  
  
-   Advanced profiling features, when the administrator has set the driver and service to start.  
  
-   Sample profiling only (domain users).  
  
-   Deny access to profiling to everybody.  
  
 For more information, see [Profiling and Windows Vista Security](../VS_csharp/profiling-and-windows-vista-security.md) and the ADMIN options in [VSPerfCmd](../VS_csharp/vsperfcmd.md).  
  
### To attach to a running process  
  
1.  On the **Analyze** menu, point to **Profiler** and then click **Attach/Detach**.  
  
     \- or -  
  
     In **Performance Explorer**, right-click the performance session, and then click **Attach/Detach**.  
  
     The **Attach Profiler to Process** dialog box appears.  
  
2.  Click the name of the process that you want to attach to.  
  
3.  Click **Attach**.  
  
### To detach from a running process  
  
1.  On the **Analyze** menu, point to **Profiler** and then click **Attach/Detach**.  
  
     \- or -  
  
     In **Performance Explorer**, right-click the performance session, and then click **Attach/Detach**.  
  
     The **Attach Profiler to Process** dialog box appears.  
  
2.  Click the image name from which you want to detach.  
  
3.  Click **Detach**.  
  
## See Also  
 [Controlling Data Collection](../VS_csharp/controlling-data-collection.md)   
 [Performance Session Overview](../VS_csharp/performance-session-overview.md)   
 [How to: Start and End Performance Sessions](../VS_csharp/how-to--start-and-end-performance-data-collection.md)   
 [Profiling and Windows Vista Security](../VS_csharp/profiling-and-windows-vista-security.md)   
 [VSPerfCmd](../VS_csharp/vsperfcmd.md)