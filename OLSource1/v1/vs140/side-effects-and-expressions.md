---
title: "Side Effects and Expressions"
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
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "side effects in debugging"
  - "expression evaluation, side effects"
  - "debugging [Visual Studio], side effects"
ms.assetid: e1f8a6ea-9e19-481d-b6bd-df120ad3bf4e
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Side Effects and Expressions
A side effect occurs when evaluating an expression changes the value of data in your application.  
  
 Side effects are something to watch for if you are evaluating expressions in the debugger. If you evaluate an expression in the **Watch** window or the **QuickWatch** dialog box and the expression has side effects, you might change the value of variables in another part of your program without realizing it. Side effects can make debugging more difficult by creating the appearance of bugs where none exist or masking the appearance of real bugs.  
  
 One common cause of side effects is evaluating a function call in a debugger window. Such evaluations are usually noticeable. A more subtle cause of side effects is the evaluation of properties and other implicit function calls in managed code.  
  
 The debugger cannot tell whether a property evaluation or implicit function call has side effects. Therefore, by default, the debugger does not evaluate implicit function calls automatically. Property evaluation is allowed by default, but can be turned off in the Options dialog box. When a function call or property has not been evaluated, a refresh icon appears. You can manually evaluate the expression by clicking the refresh icon. For details, see [How to Refresh Watch Values](../vs140/refresh-watch-values.md).  
  
 When evaluation of properties or implicit function calls is turned off, you can force evaluation by using the `ac` format modifier (for C# only). See [Format Specifiers in C#](../vs140/format-specifiers-in-csharp.md).  
  
## See Also  
 [How to: Deal With Red ! Marks](../vs140/refresh-watch-values.md)