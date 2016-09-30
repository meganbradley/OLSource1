---
title: "Events (VSPerfCmd)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: eb139327-4783-4f2a-874c-efad377a7be4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Events (VSPerfCmd)
The VSPerfCmd.exe **Events** option controls Event Tracing for Windows (ETW) logging. ETW data is saved to an .etl file that is separate from the profiler data file. The data can be viewed in a report using the [VSPerfReport](../vs140/vsperfreport.md) /summary:etw command.  
  
 The **Events** option can be called at any time before the VSPerfCmd **Shutdown** command is called to stop profiling.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 **On**&#124;**Off**  
 Starts or stops collecting event data.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The GUID of the provider control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the provider that is registered with Windows Management Instrumentation (WMI).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A "0x"-prefixed hexadecimal flags value that is defined by the event provider.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the amount of data collected. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is defined by the event provider.  
  
 The **Events** option understands the following kernel keywords as provider names:  
  
 **Process**  
 Process events  
  
 **Thread**  
 Thread events  
  
 **Image**  
 Image load and unload events  
  
 **Disk**  
 Disk I/O events  
  
 **File**  
 File I/O events  
  
 **Hardfault**  
 Hard page faults  
  
 **Pagefault**  
 Soft page faults  
  
 **Network**  
 Network events  
  
 **Registry**  
 Registry access events  
  
 Note that the Kernel Provider can only be enabled. It cannot be disabled, nor can its flags be modified, until the monitor shuts down.  
  
## Remarks  
  
> [!NOTE]
>  When CLR ETW events are enabled, additional startup data is also collected in the Trace View report. To exclude startup events from appearing in the report, use the following command:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!IMPORTANT]
>  If you do not exclude the startup events, then because these events are not listed in the Managed Object Format (MOF) file, they appear as GUIDs in the report. For more information, see this page on the Microsoft Web site: [Sample Managed Object Format (MOF) File](http://go.microsoft.com/fwlink/?linkid=37118).  
  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)