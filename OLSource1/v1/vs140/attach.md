---
title: "Attach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 79614283-6733-4592-a53a-d428052271ad
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Attach
The VSPerfCmd.exe **Attach** option begins sample profiling of the running process specified by the process ID (PID).  
  
 To use the **Attach** option, you must specify the **Sample** method in the Start option.  
  
> [!NOTE]
>  If the **Start** option was specified with the **Crosssession** option, any calls to **VSPerfCmd /Attach** or to **VSPerfCmd /Detach** must also specify **Crosssession**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The process ID (PID) of the running process. The PID of a running process is listed on the Processes tab of Windows Task Manager.  
  
## Valid Options  
 The following **VSPerfCmd** options can be combined with the **Attach** option on a single command line.  
  
 **Crosssession**  
 Enables profiling applications in sessions other than the logon session. Required if the **Start** option was specified with the **Crosssession** option.  
  
 **Start:** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Initializes the command-line profiler session and sets the specified profiling method.  
  
 **TargetCLR**  
 Specifies the version of the .NET Framework Common Language Runtime (CLR) to profile when more than one version is loaded in a profiling session. By default, the first loaded version is profiled.  
  
 **GlobalOn GlobalOff**  
 Resumes (**GlobalOn**) or pauses (**GlobalOff**) profiling, but does not end the profiling session.  
  
 **ProcessOn:** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> **ProcessOff:** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Resumes (**ProcessOn**) or pauses (**ProcessOff**) profiling for the specified process.  
  
## Interval Options  
 One of the following sampling interval options can be specified on the Attach command line. The default sampling interval is 10,000,000 processor clock cycles.  
  
 **Timer**[**:**<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>]**PF**[**:**<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>]**Sys**[**:**Events]**Counter**[**:**<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>]  
 Specifies the number and type of the sampling interval.  
  
-   **Timer** - Samples every <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> processor clock cycles. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not specified, 10,000,000 cycles are used.  
  
-   **PF** - Samples every <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> page faults. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not specified, 10 page faults are used.  
  
-   **Sys** - Samples every <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> calls to the operating system. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not specified, 10 system calls are used.  
  
-   **Counter** - Samples every <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> number of the CPU performance counter specified by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Optionally, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> can specify a string to use as the column header in profiler reports.  
  
## Example  
 This example demonstrates how to attach to a running instance of an application with the process ID of 12345.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)