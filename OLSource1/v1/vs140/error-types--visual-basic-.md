---
title: "Error Types (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "exceptions, types"
  - "errors [Visual Basic], types"
  - "errors [Visual Basic], logic"
  - "errors [Visual Basic], syntax"
  - "logic errors, Visual Basic"
  - "run-time errors, types of errors"
  - "syntax errors, Visual Basic"
ms.assetid: 3048aabf-8c97-4e13-9150-853769cb5f6f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error Types (Visual Basic)
In [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)], errors (also called *exceptions*) fall into one of three categories: syntax errors, run-time errors, and logic errors.  
  
## Syntax Errors  
 *Syntax errors* are those that appear while you write code. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] checks your code as you type it in the **Code Editor** window and alerts you if you make a mistake, such as misspelling a word or using a language element improperly. Syntax errors are the most common type of errors. You can fix them easily in the coding environment as soon as they occur.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement is one means of avoiding syntax errors. It forces you to declare, in advance, all the variables to be used in the application. Therefore, when those variables are used in the code, any typographic errors are caught immediately and can be fixed.  
  
## Run-Time Errors  
 *Run-time errors* are those that appear only after you compile and run your code. These involve code that may appear to be correct in that it has no syntax errors, but that will not execute. For example, you might correctly write a line of code to open a file. But if the file is corrupted, the application cannot carry out the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function, and it stops running. You can fix most run-time errors by rewriting the faulty code, and then recompiling and rerunning it.  
  
## Logic Errors  
 *Logic errors* are those that appear once the application is in use. They are most often unwanted or unexpected results in response to user actions. For example, a mistyped key or other outside influence might cause your application to stop working within expected parameters, or altogether. Logic errors are generally the hardest type to fix, since it is not always clear where they originate.  
  
## See Also  
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Debugger Roadmap](../vs140/debugger-basics.md)