---
title: "Using the Profiling Tools From the Command-Line"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "command line, performance tools"
  - "command-line tools, performance tools"
  - "profiling tools,command line"
  - "tools, command-line"
  - "command line, tools"
ms.assetid: 6593fa82-181e-4009-a0ed-02aa24c2c063
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using the Profiling Tools From the Command-Line
You can use the command-line tools of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Profiling Tools to profile applications at the command prompt and to automate profiling by using batch files and scripting. You can also generate report files at a command prompt. You can use the lightweight stand-alone profiler to collect data on computers that do not have [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] installed.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Profiling Windows 8 and Windows Server 2012 applications](../vs140/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
## Common Tasks  
  
|Task|Related Content|  
|----------|---------------------|  
|**Set the location of symbols:** To display the names of functions and parameters, the profiler must have access to the symbol (.pdb) files of the profiled binaries. These files should include the symbol files for the Microsoft operating system and applications that you want to view in your analysis. You can use the public Microsoft symbol server to make sure that you have the correct .pdb files for the Microsoft binaries.|-   [How to: Specify Symbol File Locations from the Command-Line](../vs140/how-to--specify-symbol-file-locations-from-the-command-line.md)|  
|**Profile your application:** The command-line tools and options that you use to profile a target application depend on the type of the application, the profiling method, and whether the target is a managed or native application.|-   [Using Profiling Methods to Collect Performance Data from the Command Line](../vs140/using-profiling-methods-to-collect-performance-data-from-the-command-line.md)<br />-   [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)<br />-   [Command-Line Profiling of ASP.NET Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)<br />-   [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)|  
|**Create .xml and .csv reports:** Profiling at the command prompt creates data files that can be viewed in the interface for [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. You can also generate .xml or comma-separated value (.csv) files of the data by using the VSPerfReport command-line tool.|-   [Creating Profiler Reports from the Command-Line](../vs140/creating-profiler-reports-from-the-command-line.md)<br />-   [VSPerfReport](../vs140/vsperfreport.md)|  
|**Profile code on computers without Visual Studio:** You can use the Profiling Tools stand-alone profiler to collect data for applications on computers that do not have [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] installed.|-   [How To: Install the Stand-Alone Profiler](../vs140/how-to--install-the-stand-alone-profiler.md)|  
  
## Reference  
 [Command-Line Profiling Tools Reference](../vs140/command-line-profiling-tools-reference.md)  
  
## See Also  
 [Analyzing Application Performance](../vs140/performance-explorer.md)