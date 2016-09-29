---
title: "Stop Statement (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.Stop"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "breakpoints, Stop statements"
  - "Stop statements, syntax"
  - "Stop statements"
  - "execution, suspending"
  - "processing, interrupting"
  - "processes, interrupting"
  - "execution, stopping"
ms.assetid: c9a9fde0-d649-4662-9bef-bd0146ebc2a7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Stop Statement (Visual Basic)
Suspends execution.  
  
## Syntax  
  
```  
Stop  
```  
  
## Remarks  
 You can place `Stop` statements anywhere in procedures to suspend execution. Using the `Stop` statement is similar to setting a breakpoint in the code.  
  
 The `Stop` statement suspends execution, but unlike `End`, it does not close any files or clear any variables, unless it is encountered in a compiled executable (.exe) file.  
  
> [!NOTE]
>  If the `Stop` statement is encountered in code that is running outside of the integrated development environment (IDE), the debugger is invoked. This is true regardless of whether the code was compiled in debug or retail mode.  
  
## Example  
 This example uses the `Stop` statement to suspend execution for each iteration through the `For...Next` loop.  
  
 [!code[VbVbalrStatements#56](../VS_csharp/codesnippet/VisualBasic/stop-statement--visual-basic-_1.vb)]  
  
## See Also  
 [End Statement](../VS_csharp/end-statement.md)