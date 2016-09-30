---
title: "while Statement (C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "while_cpp"
  - "while"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "while keyword [C++]"
  - "while keyword [C++], syntax"
ms.assetid: 358dbe76-5e5e-4af5-b575-c2293c636899
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# while Statement (C++)
Executes *statement* repeatedly until *expression* evaluates to zero.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The test of *expression* takes place before each execution of the loop; therefore, a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop executes zero or more times. *expression* must be of an integral type, a pointer type, or a class type with an unambiguous conversion to an integral or pointer type.  
  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> loop can also terminate when a [break](../vs140/break-statement--c---.md), [goto](../vs140/goto-statement--c---.md), or [return](../vs140/return-statement--c---.md) within the statement body is executed. Use [continue](../vs140/continue-statement--c---.md) to terminate the current iteration without exiting the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop. **continue** passes control to the next iteration of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop.  
  
 The following code uses a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop to trim trailing underscores from a string:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The termination condition is evaluated at the top of the loop. If there are no trailing underscores, the loop never executes.  
  
## See Also  
 [Iteration Statements](../vs140/iteration-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [do-while Statement (C++)](../vs140/do-while-statement--c---.md)   
 [for Statement (C++)](../vs140/for-statement--c---.md)   
 [Range-based for Statement (C++)](../vs140/range-based-for-statement--c---.md)