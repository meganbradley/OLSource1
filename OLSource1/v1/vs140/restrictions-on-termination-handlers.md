---
title: "Restrictions on Termination Handlers"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "termination handlers, limitations"
  - "restrictions, termination handlers"
  - "try-catch keyword [C++], termination handlers"
ms.assetid: 8b1cb481-303f-4e79-b409-57a002a9fa9e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Restrictions on Termination Handlers
You cannot use a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement to jump into a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement block or a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement block. Instead, you must enter the statement block through normal flow of control. (You can, however, jump out of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement block.) Also, you cannot nest an exception handler or termination handler inside a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block.  
  
 In addition, some kinds of code permitted in a termination handler produce questionable results, so you should use them with caution, if at all. One is a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement that jumps out of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement block. If the block is executing as part of normal termination, nothing unusual happens. But if the system is unwinding the stack, that unwinding stops, and the current function gains control as if there were no abnormal termination.  
  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement inside a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement block presents roughly the same situation. Control returns to the immediate caller of the function containing the termination handler. If the system was unwinding the stack, this process is halted, and the program proceeds as if there had been no exception raised.  
  
## See Also  
 [Writing a Termination Handler](../vs140/writing-a-termination-handler.md)   
 [Structured Exception Handling (C/C++)](../vs140/structured-exception-handling--c-c---.md)