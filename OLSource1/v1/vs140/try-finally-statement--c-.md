---
title: "try-finally Statement (C)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "try_cpp"
  - "try"
  - "finally"
  - "finally_cpp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "try-catch keyword [C], try-finally keyword [C]"
  - "__finally keyword [C], try-finally statement syntax"
  - "try-finally keyword [C]"
  - "__finally keyword [C]"
  - "try-catch keyword [C]"
  - "structured exception handling, try-finally"
ms.assetid: 514400c1-c322-4bf3-9e48-3047240b8a82
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try-finally Statement (C)
**Microsoft Specific**  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement is a Microsoft extension to the C language that enables applications to guarantee execution of cleanup code when execution of a block of code is interrupted. Cleanup consists of such tasks as deallocating memory, closing files, and releasing file handles. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement is especially useful for routines that have several places where a check is made for an error that could cause premature return from the routine.  
  
 *try-finally-statement*:  
 **__try**  *compound-statement*  
  
 **__finally**  *compound-statement*  
  
 The compound statement after the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause is the guarded section. The compound statement after the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause is the termination handler. The handler specifies a set of actions that execute when the guarded section is exited, whether the guarded section is exited by an exception (abnormal termination) or by standard fall through (normal termination).  
  
 Control reaches a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement by simple sequential execution (fall through). When control enters the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, its associated handler becomes active. Execution proceeds as follows:  
  
1.  The guarded section is executed.  
  
2.  The termination handler is invoked.  
  
3.  When the termination handler completes, execution continues after the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement. Regardless of how the guarded section ends (for example, via a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement out of the guarded body or via a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement), the termination handler is executed before the flow of control moves out of the guarded section.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword is valid within a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> statement block. The effect of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is to jump to the end of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block. The termination handler is immediately executed. Although a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement can be used to accomplish the same result, a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> statement causes stack unwinding. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement is more efficient because it does not involve stack unwinding.  
  
 Exiting a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement using a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement or the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> run-time function is considered abnormal termination. It is illegal to jump into a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement, but legal to jump out of one. All <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statements that are active between the point of departure and the destination must be run. This is called a "local unwind."  
  
 The termination handler is not called if a process is killed while executing a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement.  
  
> [!NOTE]
>  Structured exception handling works with C and C++ source files. However, it is not specifically designed for C++. You can ensure that your code is more portable by using C++ exception handling. Also, the C++ exception handling mechanism is much more flexible, in that it can handle exceptions of any type.  
  
> [!NOTE]
>  For C++ programs, C++ exception handling should be used instead of structured exception handling. For more information, see [Exception Handling](../vs140/exception-handling-in-visual-c--.md) in the *C++ Language Reference*.  
  
 See the example for the [try-except statement](../vs140/try-except-statement--c-.md) to see how the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> statement works.  
  
 **END Microsoft Specific**  
  
## See Also  
 [try-finally Statement](../vs140/try-finally-statement.md)