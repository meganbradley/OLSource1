---
title: "Timer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1971868e-89fa-4452-8ee7-76e4daf31b66
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Timer
The VSPerfCmd.exe **Timer** option sets the profiling event that is sampled to processor clock cycles and optionally changes the number of cycles in a sampling interval from the default of 10,000,000. On a 1GH (one gigahertz) processor, 10,000,000 clock cycles is approximately 100 samples per second. The minimum number of cycles that can be specified is 50,000.  
  
 **Timer** can only be used when you use the sampling profiling method, and it can only be used in a command line that also contains the **Launch** or the **Attach** option.  
  
 By default, the profiler sampling event is set to processor clock cycles and the sampling interval is set to 10,000,000. The **Timer**, **PF**, **Sys**, and **Counter** options enable you to set the sampling event and the sampling interval. The **GC** option collects .NET memory data at each allocation and garbage collection event. Only one of these options can be specified on a command line.  
  
 The sampling event and the sampling interval can be set only in the first command line that contains a **Launch** or an **Attach** option.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An integer value that specifies the number of processor clock cycles in a sampling interval. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not specified, the interval is set to 10,000,000. Specify the value without commas.  
  
## Required Options  
 **Timer** can only be specified on a command line that contains one of the following options.  
  
 **Launch:** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Starts the profiler and the application specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 **Attach:** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Attaches the profiler to the process specified by the process ID (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>).  
  
## Invalid Options  
 The following options cannot be specified on the same command line as **Timer**.  
  
 **PF**[**:**<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>]  
 Sets the sampling event to page faults and optionally sets the sampling interval to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The default PF interval is 10.  
  
 **Sys**[**:**<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>]  
 Sets the sampling event to operating system calls and optionally sets the sampling interval to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The default Sys interval is 10.  
  
 **Counter**[**:**<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>]  
 Sets the sampling event to the CPU performance counter specified by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and sets the sampling interval to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 **GC**[**:**{**Allocation**&#124;**Lifetime**}]  
 Collects .NET memory data. By default (**Allocation**), data is collected at every memory allocation event. When the **Lifetime** parameter is specified, data is also collected at each garbage collection event.  
  
## Example  
 This example demonstrates how to set the profiler sampling interval to 1,000,000 processor cycles.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)