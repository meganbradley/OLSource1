---
title: "Walkthrough: Determining Where My.Application.Log Writes Information (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - My.Log object, output location
  - output, application log location
  - My.Application.Log object, outpout location
  - event logs, determining output location
  - application event logs, output location
  - applications [Visual Basic], output location
ms.assetid: 5b70143a-7741-45f2-ae1d-03324a3a4189
caps.latest.revision: 28
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Walkthrough: Determining Where My.Application.Log Writes Information (Visual Basic)
The `My.Application.Log` object can write information to several log listeners. The log listeners are configured by the computer's configuration file and can be overridden by an application's configuration file. This topic describes the default settings and how to determine the settings for your application.  
  
 For more information about the default output locations, see [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md).  
  
### To determine the listeners for My.Application.Log  
  
1.  Locate the assembly's configuration file. If you are developing the assembly, you can access the app.config in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] from the **Solution Explorer**. Otherwise, the configuration file name is the assembly's name appended with ".config", and it is located in the same directory as the assembly.  
  
    > [!NOTE]
    >  Not every assembly has a configuration file.  
  
     The configuration file is an XML file.  
  
2.  Locate the `<listeners>` section, in the `<source>` section with the `name` attribute "DefaultSource", located in the `<sources>` section. The `<sources>` section is located in the `<system.diagnostics>` section, in the top-level `<configuration>` section.  
  
     If these sections do not exist, then the computer's configuration file may configure the `My.Application.Log` log listeners. The following steps describe how to determine what the computer configuration file defines:  
  
    1.  Locate the computer's machine.config file. Typically, it is located in the *SystemRoot\Microsoft.NET\Framework\frameworkVersion\CONFIG* directory, where `SystemRoot` is the operating system directory, and `frameworkVersion` is the version of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)].  
  
         The settings in machine.config can be overridden by an application's configuration file.  
  
         If the optional elements listed below do not exist, you can create them.  
  
    2.  Locate the `<listeners>` section, in the `<source>` section with the `name` attribute "DefaultSource", in the `<sources>` section, in the `<system.diagnostics>` section, in the top-level `<configuration>` section.  
  
         If these sections do not exist, then the `My.Application.Log` has only the default log listeners.  
  
3.  Locate the <`add>` elements in the <`listeners>` section.  
  
     These elements add the named log listeners to `My.Application.Log` source.  
  
4.  Locate the `<add>` elements with the names of the log listeners in the `<sharedListeners>` section, in the `<system.diagnostics>` section, in the top-level `<configuration>` section.  
  
5.  For many types of shared listeners, the listener's initialization data includes a description of where the listener directs the data:  
  
    -   A <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=True> listener writes to a file log, as described in the introduction.  
  
    -   A <xref:System.Diagnostics.EventLogTraceListener?qualifyHint=True> listener writes information to the computer event log specified by the `initializeData` parameter. To view an event log, you can use **Server Explorer** or **Windows Event Viewer**. For more information, see [ETW Events in the .NET Framework](assetId:///d186276f-6afb-4dfd-bf3c-4251edc2c299).  
  
    -   The <xref:System.Diagnostics.DelimitedListTraceListener?qualifyHint=True> and <xref:System.Diagnostics.XmlWriterTraceListener?qualifyHint=True> listeners write to the file specified in the `initializeData` parameter.  
  
    -   A <xref:System.Diagnostics.ConsoleTraceListener?qualifyHint=True> listener writes to the command-line console.  
  
    -   For information about where other types of log listeners write information, consult that type's documentation.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.Log?qualifyHint=True>   
 <xref:System.Diagnostics.DefaultTraceListener?qualifyHint=False>   
 <xref:System.Diagnostics.EventLogTraceListener?qualifyHint=False>   
 <xref:System.Diagnostics.DelimitedListTraceListener?qualifyHint=False>   
 <xref:System.Diagnostics.XmlWriterTraceListener?qualifyHint=False>   
 <xref:System.Diagnostics.ConsoleTraceListener?qualifyHint=False>   
 <xref:System.Diagnostics?qualifyHint=False>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)   
 [How to: Write Log Messages](../vs140/how-to--write-log-messages--visual-basic-.md)   
 [Walkthrough: Changing Where My.Application.Log Writes Information](../vs140/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)   
 [ETW Events in the .NET Framework](assetId:///d186276f-6afb-4dfd-bf3c-4251edc2c299)   
 [Troubleshooting: Log Listeners](../vs140/troubleshooting--log-listeners--visual-basic-.md)