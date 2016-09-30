---
title: "Launch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: f81bde5c-3394-4b79-a315-c2f6491689b3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Launch
The **Launch** option starts the profiler using the sampling method and it also starts the specified application.  
  
 To use the **Launch** option, you must specify the **Sample** method in the **Start** option.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the application to launch. Full and partial paths from the current directory are supported.  
  
## Valid Options  
 The following VSPerfCmd options can be combined with the **Launch** option on a single command line.  
  
 **Start:** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Initializes the command-line profiler session and sets the specified profiling method.  
  
 **GlobalOn**and **GlobalOff**  
 Resumes (**GlobalOn**) or pauses (**GlobalOff**) profiling, but does not end the profiling session.  
  
 **ProcessOn:** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and **ProcessOff**:<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Resumes (**ProcessOn**) or pauses (**ProcessOff**) profiling for the specified process.  
  
 **TargetCLR**  
 Specifies the version of the .NET Framework Common Language Runtime (CLR) to profile when more than one version is loaded in a profiling session. By default, the first loaded version is profiled.  
  
## Exclusive Options  
 The following options can only be used with the **Launch** option.  
  
 **Console**  
 Launches the specified command-line application in a new window.  
  
 **Args:** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the list of arguments to pass to the application.  
  
 **LineOff**  
 Disables the collection of line-level profiling data.  
  
## Sampling Options  
 One of the following sampling interval options can be specified on the **Launch** command line. The default sampling interval is 10,000,000 processor clock cycles.  
  
 **Timer**[**:**<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>]**PF**[**:**<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>]**Sys**[**:**<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>]**Counter**[**:**<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>,<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>]**GC**[:**allocation**&#124;**lifetime**]  
 Specifies the number and type of sampling interval.  
  
-   **Timer** - Samples every <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> non-halted processor clock cycles. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not specified, 10,000,000 cycles are used.  
  
-   **PF** - Samples every <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> page faults. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is not specified, 10 page faults.  
  
-   **Sys** - Samples every <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> calls to the operating system. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is not specified, 10 system calls are used.  
  
-   **Counter** - Samples every <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> number of the CPU performance counter specified by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Optionally, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> can specify a string to use as the column header in profiler reports.  
  
-   **GC** - Collects .NET memory data. By default (**allocation**), data is collected at every memory allocation event. When the **lifetime** parameter is specified, data is also collected at each garbage collection event.  
  
## Example  
 This example demonstrates the use of **Launch** to start an application.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)