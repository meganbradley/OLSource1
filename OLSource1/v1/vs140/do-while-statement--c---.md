---
title: "do-while Statement (C++)"
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
  - "do-while_cpp"
  - "do-while"
  - "do"
  - "while_cpp"
  - "do_cpp"
  - "while"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do keyword [C++], do-while"
  - "do-while keyword [C++]"
  - "do keyword [C++]"
  - "while keyword [C++], do-while"
ms.assetid: e01e6f7c-7da1-4591-87f9-c26ff848e7b0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# do-while Statement (C++)
Executes a *statement* repeatedly until the specified termination condition (the *expression*) evaluates to zero.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The test of the termination condition is made after each execution of the loop; therefore, a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop executes one or more times, depending on the value of the termination expression. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement can also terminate when a [break](../vs140/break-statement--c---.md), [goto](../vs140/goto-statement--c---.md), or [return](../vs140/return-statement--c---.md) statement is executed within the statement body.  
  
 The *expression* must have arithmetic or pointer type. Execution proceeds as follows:  
  
1.  The statement body is executed.  
  
2.  Next, *expression* is evaluated. If *expression* is false, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement terminates and control passes to the next statement in the program. If *expression* is true (nonzero), the process is repeated, beginning with step 1.  
  
## Example  
 The following sample demonstrates the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Iteration Statements](../vs140/iteration-statements--c---.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [while Statement (C++)](../vs140/while-statement--c---.md)   
 [for Statement (C++)](../vs140/for-statement--c---.md)   
 [Range-based for Statement (C++)](../vs140/range-based-for-statement--c---.md)