---
title: "Variable Windows"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
helpviewer_keywords: 
  - Autos window
  - debugger, variable windows
  - debugging [Visual Studio], variable windows
  - Locals window
  - Watch window
ms.assetid: ce0a67f6-2502-4b7a-ba45-cc32f8aeba3e
caps.latest.revision: 21
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Variable Windows
The debugger provides a number of variable windows for displaying, evaluating, and editing variables and expressions.  
  
 The type of information displayed in the grid depends on which variable window you are using:  
  
-   The **Locals** window displays variables local to the current context or scope. Usually, this means the procedure or function you are currently executing. The debugger populates this window automatically. In Visual C#, when the Exception Assistant is disabled, the **Locals** window also displays a pseudovariable `$exception` whenever there is an active exception. You can expand the pseudovariable to see details of the exception.  
  
-   The **Autos** window displays variables used in the current line of code and the preceding line of code. For native C++, the **Autos** window displays function return values as well. Like the **Locals** window, the **Autos** window is populated automatically by the debugger.  
  
-   The **Watch** window is where you can add variables whose value you want to watch. You can add more than just variables, however. You can add any valid expression recognized by the debugger. (For valid expression syntax, see [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)). Some editions of Visual Studio have multiple **Watch** windows, which are numbered **Watch1** through **Watch4**.  
  
-   The **QuickWatch** dialog box is similar in concept to the **Watch** window, but **QuickWatch** can display only one variable or expression at a time. **QuickWatch** can be useful when you want to take a quick look at a variable or expression without bringing up the **Watch** window. However, many users find the new enhanced DataTips so powerful that they use **QuickWatch** much less often. (See [How to: Use DataTips](../vs140/view-data-values-in-data-tips--in-the-code-editor.md).)  
  
     Even though **QuickWatch** is a dialog box, it functions much like the other variable windows. Except where otherwise noted, the procedures described in this section apply to the **QuickWatch** dialog box as well as other variable windows.  
  
## In This Section  
 [How to: Use Variable Windows](../vs140/autos-and-locals-windows.md)  
 Describes how to use variable windows such as **Autos** and **Locals**.  
  
 [How to: Watch an Expression in the Debugger](../vs140/watch-and-quickwatch-windows.md)  
 Describes how to use the **Watch** window.  
  
 [How to: Use the QuickWatch Dialog Box](../vs140/how-to--use-the-quickwatch-dialog-box.md)  
 Describes how to use the **QuickWatch** dialog box for a quick look at a single variable or expression.  
  
## Reference  
 [Format Specifiers in Native Code](../vs140/format-specifiers-in-c--.md)  
 Describes specifiers that can be used to change the display of a value in native code.  
  
 [Format Specifiers in C#](../vs140/format-specifiers-in-csharp.md)  
 Describes specifiers that can be used to change the display of a value in C# code.  
  
 [Pseudovariables](../vs140/pseudovariables.md)  
 Describes useful variable-like commands that display useful information in variable windows.  
  
## Related Sections  
 [Expressions in the Debugger](../vs140/expressions-in-the-debugger.md)  
 Describes the valid syntax for expressions you can enter in the **Watch** window and **QuickWatch** dialog box