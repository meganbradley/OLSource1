---
title: "Debugging Your Visual Basic Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "debugging [Visual Basic], common tasks"
ms.assetid: 904760b8-9fe9-42a7-9d65-d93774253219
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging Your Visual Basic Application
This page provides links to documentation for the debugging features that are built into [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. For example, you can find semantic errors in your application by observing its run-time behavior in the debugger itself.  
  
 By using the debugger, you can examine the content of variables in your application without inserting additional calls to output the values. Similarly, you can insert a breakpoint in your code to halt execution at the point that you specify.  
  
## Controlling Execution  
 The following table lists debugging tasks involving execution control and provides links to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Start to debug a Visual Studio project, attach to a process, break into code, step through code, run to the cursor, run to a function on the call stack, set the next statement, step through Just My Code, stop debugging, restart debugging, or detach from a debugged process.|[Start, Break, Step, Run through Code, and Stop Debugging in Visual Studio](../VS_csharp/navigating-through-code-with-the-debugger.md)|  
|Specify the configurations for the debug and release versions of a program.|[Debug and Release Project Configurations](assetId:///0440b300-0614-4511-901a-105b771b236e)|  
|Set start options (command-line arguments, working directory, remote machine)|[NIB: How to: Set Start Options for Application Debugging](assetId:///ce792058-7bac-4dd6-858b-466e872687b8)|  
|Debug at design time.|[Walkthrough: Debugging at Design Time](../VS_csharp/walkthrough--debugging-at-design-time.md)|  
|Enable just-in-time debugging, which launches the Visual Studio debugger when a program running outside Visual Studio encounters a fatal error.|[Just-In-Time Debugging](../VS_csharp/just-in-time-debugging-in-visual-studio.md)|  
|Set breakpoints for source lines, assembly instructions, and call stack function. Specify conditions, hit counts, and execution location.|[Breakpoints: Use Hit Counts, Call Stack Functions, and Conditions to Break When and Where You Want in the Visual Studio Debugger](../VS_csharp/using-breakpoints.md)|  
  
## Handling Exceptions  
 The following table lists debugging tasks involving exception handling and points to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Break on unhandled exceptions.|[How to: Break on User-Unhandled Exceptions](../Topic/How%20to:%20Break%20on%20User-Unhandled%20Exceptions.md)|  
|Break when an exception is thrown.|[How to: Break When an Exception is Thrown](../Topic/How%20to:%20Break%20When%20an%20Exception%20is%20Thrown.md)|  
|Break on first-chance exceptions.|[How to: Break When an Exception is Thrown](../Topic/How%20to:%20Break%20When%20an%20Exception%20is%20Thrown.md)|  
|Use the exception assistant.|[How to: Correct Run-Time Errors with the Exception Assistant](../Topic/How%20to:%20Correct%20Run-Time%20Errors%20with%20the%20Exception%20Assistant.md)|  
|Add a new exception.|[How to: Add New Exceptions](../Topic/How%20to:%20Add%20New%20Exceptions.md)|  
|Continue execution after an exception has been thrown.|[Continuing Execution After an Exception](../VS_csharp/continuing-execution-after-an-exception.md)|  
  
## Edit and Continue  
 The following table lists debugging tasks involving Edit and Continue and points to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Turn Edit and Continue off and on.|[How to: Enable and Disable Edit and Continue](../VS_csharp/how-to--enable-and-disable-edit-and-continue.md)|  
|Stop Edit and Continue from applying code changes.|[How to: Stop Code Changes](../VS_csharp/how-to--stop-code-changes.md)|  
|Apply edits in break mode.|[How to: Apply Edits in Break Mode with Edit and Continue](../VS_csharp/how-to--apply-edits-in-break-mode-with-edit-and-continue.md)|  
  
## Examining Debugging Data  
 The following table lists debugging tasks involving viewing debugging data and points to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Use the **Registers** window to display register contents.|[How to: Use the Registers Window](../VS_csharp/how-to--use-the-registers-window.md)|  
|Use the **Call Stack** window to view function or procedure calls that are currently on the stack.|[How to: Use the Call Stack Window](../VS_csharp/how-to--use-the-call-stack-window.md)|  
|Use the **Disassembly** window to view assembly code corresponding to the instructions created by the compiler.|[How to: Use the Disassembly Window](../VS_csharp/how-to--use-the-disassembly-window.md)|  
|Use the **Modules** window to list and describe modules used by your program.|[How to: Use the Modules Window](../VS_csharp/how-to--use-the-modules-window.md)|  
|Use the **Script Explorer** window to list script files that are currently loaded into the program.|[How to: View Script Documents](../VS_csharp/how-to--view-script-documents.md)|  
|Use the **Threads** window to examine and control threads in the program.|[How to: Use the Threads Window](../VS_csharp/how-to--use-the-threads-window.md)|  
  
## See Also  
 [Walkthrough: Debugging a Windows Form](../VS_csharp/walkthrough--debugging-a-windows-form.md)   
 [Debugging Managed Code](../VS_csharp/debugging-managed-code.md)   
 [Debugging Native Code](../VS_csharp/debugging-native-code.md)   
 [Debugging Web Applications](../VS_csharp/debugging-web-applications-and-script.md)   
 [Debugging User Interface Reference](../VS_csharp/debugging-user-interface-reference.md)   
 [Debug Settings and Preparation](../VS_csharp/debugger-settings-and-preparation.md)   
 [Debugger Roadmap](../VS_csharp/debugger-basics.md)   
 [Execution Control](../VS_csharp/navigating-through-code-with-the-debugger.md)   
 [Debug Your App by Recording Execution History with IntelliTrace](../VS_csharp/intellitrace.md)   
 [Debugging Preparation: C#, J#, and Visual Basic Project Types](../VS_csharp/debugging-preparation--csharp--fsharp--and-visual-basic-project-types.md)   
 [How to: Apply Edits in Break Mode with Edit and Continue](../VS_csharp/how-to--apply-edits-in-break-mode-with-edit-and-continue.md)