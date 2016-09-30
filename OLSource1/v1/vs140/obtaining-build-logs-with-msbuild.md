---
title: "Obtaining Build Logs with MSBuild"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "MSBuild, logging"
  - "logging [MSBuild]"
ms.assetid: 6ba9a754-9cc0-4fed-9fc8-4dcd3926a031
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Obtaining Build Logs with MSBuild
By using switches with MSBuild, you can specify how much build data you want to review and whether you want to save build data to one or more files. You can also specify a custom logger to collect build data. For information about MSBuild command-line switches that this topic doesn't cover, see [MSBuild Command-Line Reference](../vs140/msbuild-command-line-reference.md).  
  
> [!NOTE]
>  If you build projects by using the Visual Studio IDE, you can troubleshoot those builds by reviewing build logs. For more information, see [How to: View, Save, and Configure Build Log Files in Visual Studio](../vs140/how-to--view--save--and-configure-build-log-files.md).  
  
## Setting the level of detail  
 When you build a project by using MSBuild without specifying a level of detail, the following information appears in the output log:  
  
-   Errors, warnings, and messages that are categorized as highly important.  
  
-   Some status events.  
  
-   A summary of the build.  
  
 By using the **/verbosity** (**/v**) switch, you can control how much data appears in the output log. For troubleshooting, use a verbosity level of either <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), which provides the most information.  
  
 The build process may be slower when you set the **/verbosity** to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and even slower when you set the **/verbosity** to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Saving the build log to a file  
 You can use the **/fileLogger** (**fl**) switch to save build data to a file. The following example saves build data to a file that's named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the following example, the log file is named <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and the verbosity of the log output is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. You specify those two settings by using the **/filelogparameters** (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) switch.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information, see [MSBuild Command-Line Reference](../vs140/msbuild-command-line-reference.md).  
  
## Saving the log output to multiple files  
 The following example saves the entire log to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, just the errors to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and just the warnings to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The example uses file numbers for each of the three files. The file numbers are specified just after the **/fl** and **/flp** switches (for example, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>).  
  
 The **/filelogparameters** (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) switches for files 2 and 3 specify what to name each file and what to include in each file. No name is specified for file 1, so the default name of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is used.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For more information, see [MSBuild Command-Line Reference](../vs140/msbuild-command-line-reference.md).  
  
## Using a custom logger  
 You can write your own logger by authoring a managed type that implements the \<xref:Microsoft.Build.Framework.ILogger*> interface. You might use a custom logger, for instance, to send build errors in email, log them to a database, or log them to an XML file. For more information, see [How To: Write a Logger](../vs140/build-loggers.md).  
  
 In the MSBuild command line, you specify the custom logger by using the **/logger** switch. You can also use the **/noconsolelogger** switch to disable the default console logger.  
  
## See Also  
 \<xref:Microsoft.Build.Framework.LoggerVerbosity*>   
 [How To: Write a Logger](../vs140/build-loggers.md)   
 [Logging in a Multi-Processor Environment](../vs140/logging-in-a-multi-processor-environment.md)   
 [How to: Create a Forwarding Logger](../vs140/creating-forwarding-loggers.md)   
 [MSBuild Concepts](../vs140/msbuild-concepts.md)