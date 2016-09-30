---
title: "Diagnostic Messages in the Output Window"
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
  - "vs.output"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "diagnostic messages [C#]"
  - "System.Diagnostics.Debug class, Output window"
  - "messages, diagnostic"
  - "Debug.Print replacements"
  - "diagnosis"
  - "Output window, diagnostic messages"
  - "System.Diagnostics.Trace class, Output window"
  - "Trace class, diagnostic messages"
  - "diagnostics"
  - "debugger, Output window"
  - "debugging [Visual Studio], diagnostic messages in Output window"
  - "Debug class"
ms.assetid: 386e9524-be17-4573-83fb-4f7c5cae0be0
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Diagnostic Messages in the Output Window
You can write run-time messages to the Output window using the Debug class or the Trace class, which are part of the \<xref:System.Diagnostics*> class library. Use the Debug class if you only output in the Debug version of your program. Use the Trace class if you want output in both the Debug and Release versions.  
  
## Output Methods  
 The \<xref:System.Diagnostics.Trace*> and \<xref:System.Diagnostics.Debug*> classes provide the following output methods:  
  
-   Various <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> methods, which output information without breaking execution. These methods replace the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method used in previous versions of Visual Basic.  
  
-   \<xref:System.Diagnostics.Debug.Assert*?displayProperty=fullName> and \<xref:System.Diagnostics.Trace.Assert*?displayProperty=fullName> methods, which break execution and outputs information if a specified condition fails. By default, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method displays the information in a dialog box. For more information, see [Assertions in Managed Code](../vs140/assertions-in-managed-code.md).  
  
-   The \<xref:System.Diagnostics.Debug.Fail*?displayProperty=fullName> and \<xref:System.Diagnostics.Trace.Fail*?displayProperty=fullName> methods, which always breaks execution and outputs information. By default, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> methods display the information in a dialog box.  
  
 In addition to program out from your application, the **Output** window can display the information about:  
  
-   Modules the debugger has loaded or unloaded.  
  
-   Exceptions that are thrown.  
  
-   Processes that exit.  
  
-   Threads that exit.  
  
## See Also  
 [Debugger Security](../vs140/debugger-security.md)   
 [Output Window](../vs140/output-window.md)   
 [Instrumentation Techniques (Debug and Trace) for the .NET Framework](assetId:///773b6fc4-9013-4322-b728-5dec7a72e743)   
 [Introduction to Instrumentation and Tracing](assetId:///e924e57c-33cf-4b0e-9e7f-a45d13e38f2c)   
 [C#, F#, and Visual Basic Project Types](../vs140/debugging-preparation--csharp--fsharp--and-visual-basic-project-types.md)   
 [Debugging Managed Code](../vs140/debugging-managed-code.md)