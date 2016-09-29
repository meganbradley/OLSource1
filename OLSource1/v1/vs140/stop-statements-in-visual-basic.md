---
title: "Stop Statements in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
helpviewer_keywords: 
  - "End statements"
  - "breakpoints, Stop statements"
  - "debugging managed code, Stop statements vs breakpoints"
  - "Stop statements, about Stop statements"
  - "debugging [Visual Basic], Stop statements vs. breakpoints"
ms.assetid: 4ad3fe5c-3dfb-4913-b2eb-a0b635751c18
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Stop Statements in Visual Basic
The Visual Basic Stop statement provides a programmatic alternative to setting a breakpoint. When the debugger encounters a Stop statement, it breaks execution of the program (enters break mode). C# programmers can achieve the same effect using a call to System.Diagnostics.Debugger.Break.  
  
 You set or remove a Stop statement by editing your source code. You cannot set or clear Stop statements using debugger commands, as you would a breakpoint.  
  
 Unlike an End statement, the Stop statement does not reset variables or return you to design mode. You can choose Continue from the Debug menu to continue running the application.  
  
 When you run a Visual Basic application outside of the debugger, a Stop statement will launch the debugger if Just-in-Time debugging is enabled. If Just-in-Time debugging is not enabled, the Stop statement behaves as if it were an End statement, terminating execution. No QueryUnload or Unload event occurs, so you must remove all Stop statements from the Release version of your Visual Basic application. For more information, see [Just-In-Time Debugging](../vs140/just-in-time-debugging-in-visual-studio.md).  
  
 To avoid the necessity of removing Stop statements, you can use conditional compilation:  
  
```  
#If DEBUG Then  
   Stop  
#Else  
   ' Don't stop  
#End If  
```  
  
 Another alternative is to use an Assert statement instead of the Stop statement. A Debug.Assert statement breaks execution only when a specified condition is not met and is automatically removed when you build a Release version. For more information, see [Assertions in Managed Code](../vs140/assertions-in-managed-code.md). If you want an Assert statement that always breaks execution in the Debug version, you can do this:  
  
```  
Debug.Assert(false)  
```  
  
 Yet another alternative is to use the Debug.Fail method:  
  
```  
Debug.Fail("a clever output string goes here")  
```  
  
## See Also  
 [Debugger Security](../vs140/debugger-security.md)   
 [C#, F#, and Visual Basic Project Types](../vs140/debugging-preparation--csharp--fsharp--and-visual-basic-project-types.md)   
 [Debugging Managed Code](../vs140/debugging-managed-code.md)