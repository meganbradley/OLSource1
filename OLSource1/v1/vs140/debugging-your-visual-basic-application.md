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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging Your Visual Basic Application
This page provides links to documentation for the debugging features that are built into [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For example, you can find semantic errors in your application by observing its run-time behavior in the debugger itself.  
  
 By using the debugger, you can examine the content of variables in your application without inserting additional calls to output the values. Similarly, you can insert a breakpoint in your code to halt execution at the point that you specify.  
  
## Controlling Execution  
 The following table lists debugging tasks involving execution control and provides links to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Start to debug a Visual Studio project, attach to a process, break into code, step through code, run to the cursor, run to a function on the call stack, set the next statement, step through Just My Code, stop debugging, restart debugging, or detach from a debugged process.|[Start, Break, Step, Run through Code, and Stop Debugging in Visual Studio](../vs140/navigating-through-code-with-the-debugger.md)|  
|Specify the configurations for the debug and release versions of a program.|[Debug and Release Project Configurations](assetId:///0440b300-0614-4511-901a-105b771b236e)|  
|Set start options (command-line arguments, working directory, remote machine)|[NIB: How to: Set Start Options for Application Debugging](assetId:///ce792058-7bac-4dd6-858b-466e872687b8)|  
|Debug at design time.|[Walkthrough: Debugging at Design Time](../vs140/walkthrough--debugging-at-design-time.md)|  
|Enable just-in-time debugging, which launches the Visual Studio debugger when a program running outside Visual Studio encounters a fatal error.|[Just-In-Time Debugging](../vs140/just-in-time-debugging-in-visual-studio.md)|  
|Set breakpoints for source lines, assembly instructions, and call stack function. Specify conditions, hit counts, and execution location.|[Breakpoints: Use Hit Counts, Call Stack Functions, and Conditions to Break When and Where You Want in the Visual Studio Debugger](../vs140/using-breakpoints.md)|  
  
## Handling Exceptions  
 The following table lists debugging tasks involving exception handling and points to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Break on unhandled exceptions.|[How to: Break on User-Unhandled Exceptions](../vs140/how-to--break-on-user-unhandled-exceptions.md)|  
|Break when an exception is thrown.|[How to: Break When an Exception is Thrown](../vs140/how-to--break-when-an-exception-is-thrown.md)|  
|Break on first-chance exceptions.|[How to: Break When an Exception is Thrown](../vs140/how-to--break-when-an-exception-is-thrown.md)|  
|Use the exception assistant.|[How to: Correct Run-Time Errors with the Exception Assistant](../vs140/how-to--correct-run-time-errors-with-the-exception-assistant.md)|  
|Add a new exception.|[How to: Add New Exceptions](../vs140/how-to--add-new-exceptions.md)|  
|Continue execution after an exception has been thrown.|[Continuing Execution After an Exception](../vs140/continuing-execution-after-an-exception.md)|  
  
## Edit and Continue  
 The following table lists debugging tasks involving Edit and Continue and points to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Turn Edit and Continue off and on.|[How to: Enable and Disable Edit and Continue](../vs140/how-to--enable-and-disable-edit-and-continue.md)|  
|Stop Edit and Continue from applying code changes.|[How to: Stop Code Changes](../vs140/how-to--stop-code-changes.md)|  
|Apply edits in break mode.|[How to: Apply Edits in Break Mode with Edit and Continue](../vs140/how-to--apply-edits-in-break-mode-with-edit-and-continue.md)|  
  
## Examining Debugging Data  
 The following table lists debugging tasks involving viewing debugging data and points to their associated Help pages.  
  
|||  
|-|-|  
|To|See|  
|Use the **Registers** window to display register contents.|[How to: Use the Registers Window](../vs140/how-to--use-the-registers-window.md)|  
|Use the **Call Stack** window to view function or procedure calls that are currently on the stack.|[How to: Use the Call Stack Window](../vs140/how-to--use-the-call-stack-window.md)|  
|Use the **Disassembly** window to view assembly code corresponding to the instructions created by the compiler.|[How to: Use the Disassembly Window](../vs140/how-to--use-the-disassembly-window.md)|  
|Use the **Modules** window to list and describe modules used by your program.|[How to: Use the Modules Window](../vs140/how-to--use-the-modules-window.md)|  
|Use the **Script Explorer** window to list script files that are currently loaded into the program.|[How to: View Script Documents](../vs140/how-to--view-script-documents.md)|  
|Use the **Threads** window to examine and control threads in the program.|[How to: Use the Threads Window](../vs140/how-to--use-the-threads-window.md)|  
  
## See Also  
 [Walkthrough: Debugging a Windows Form](../vs140/walkthrough--debugging-a-windows-form.md)   
 [Debugging Managed Code](../vs140/debugging-managed-code.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)   
 [Debugging Web Applications](../vs140/debugging-web-applications-and-script.md)   
 [Debugging User Interface Reference](../vs140/debugging-user-interface-reference.md)   
 [Debug Settings and Preparation](../vs140/debugger-settings-and-preparation.md)   
 [Debugger Roadmap](../vs140/debugger-basics.md)   
 [Execution Control](../vs140/navigating-through-code-with-the-debugger.md)   
 [Debug Your App by Recording Execution History with IntelliTrace](../vs140/intellitrace.md)   
 [Debugging Preparation: C#, J#, and Visual Basic Project Types](../vs140/debugging-preparation--csharp--fsharp--and-visual-basic-project-types.md)   
 [How to: Apply Edits in Break Mode with Edit and Continue](../vs140/how-to--apply-edits-in-break-mode-with-edit-and-continue.md)