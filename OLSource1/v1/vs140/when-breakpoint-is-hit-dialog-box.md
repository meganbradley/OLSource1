---
title: "When Breakpoint Is Hit Dialog Box"
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
  - "vs.debug.whenbreakpointishit"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "SQL"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 476e3d98-cf35-4338-b124-cd0f3010d854
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# When Breakpoint Is Hit Dialog Box
With this dialog box, you can customize the action that occurs when a breakpoint is hit.  
  
## UIElement List  
 **Print a Message**  
 Prints a message, using DebuggerDisplay syntax. For more information, see [Using DebuggerDisplay Attribute](../vs140/using-the-debuggerdisplay-attribute.md).  
  
 This textbox also supports special keywords (such as $ADDRESS) that can be used by themselves or within the curly braces of a DebuggerDisplay expression. The available keywords are listed on the dialog box.  
  
 **Continue Execution**  
 This control is enabled only when **Print a Message** is selected. With this control selected, you can use a breakpoint as a tracepoint to trace your program execution, rather than breaking when the location is hit.  
  
## See Also  
 [Breakpoints: Use Hit Counts, Call Stack Functions, and Conditions to Break When and Where You Want in the Visual Studio Debugger](../vs140/using-breakpoints.md)   
 [Using DebuggerDisplay Attribute](../vs140/using-the-debuggerdisplay-attribute.md)