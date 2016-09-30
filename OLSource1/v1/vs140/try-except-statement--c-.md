---
title: "try-except Statement (C)"
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
  - "__except"
  - "try"
  - "__try"
  - "except"
  - "__except_cpp"
  - "__try_cpp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "try-except keyword [C]"
  - "structured exception handling, try-except"
  - "try-catch keyword [C]"
  - "__try keyword [C]"
  - "__except keyword [C]"
  - "__except keyword [C], in try-except"
  - "try-catch keyword [C], try-except keyword [C]"
ms.assetid: f76db9d1-fc78-417f-b71f-18e545fc01c3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try-except Statement (C)
**Microsoft Specific**  
  
 The **try-except** statement is a Microsoft extension to the C language that enables applications to gain control of a program when events that normally terminate execution occur. Such events are called exceptions, and the mechanism that deals with exceptions is called structured exception handling.  
  
 Exceptions can be either hardware- or software-based. Even when applications cannot completely recover from hardware or software exceptions, structured exception handling makes it possible to display error information and trap the internal state of the application to help diagnose the problem. This is especially useful for intermittent problems that cannot be reproduced easily.  
  
## Syntax  
 *try-except-statement*:  
 **__try**  *compound-statement*  
  
 **__except (**  *expression*  **)**  *compound-statement*  
  
 The compound statement after the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause is the guarded section. The compound statement after the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause is the exception handler. The handler specifies a set of actions to be taken if an exception is raised during execution of the guarded section. Execution proceeds as follows:  
  
1.  The guarded section is executed.  
  
2.  If no exception occurs during execution of the guarded section, execution continues at the statement after the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause.  
  
3.  If an exception occurs during execution of the guarded section or in any routine the guarded section calls, the<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression is evaluated and the value returned determines how the exception is handled. There are three values:  
  
     <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Exception is not recognized. Continue to search up the stack for a handler, first for containing **try-except** statements, then for handlers with the next highest precedence.  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Exception is recognized but dismissed. Continue execution at the point where the exception occurred.  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Exception is recognized. Transfer control to the exception handler by executing the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> compound statement, then continue execution at the point the exception occurred.  
  
 Because the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> expression is evaluated as a C expression, it is limited to a single value, the conditional-expression operator, or the comma operator. If more extensive processing is required, the expression can call a routine that returns one of the three values listed above.  
  
> [!NOTE]
>  Structured exception handling works with C and C++ source files. However, it is not specifically designed for C++. You can ensure that your code is more portable by using C++ exception handling. Also, the C++ exception handling mechanism is much more flexible, in that it can handle exceptions of any type.  
  
> [!NOTE]
>  For C++ programs, C++ exception handling should be used instead of structured exception handling. For more information, see [Exception Handling](../vs140/exception-handling-in-visual-c--.md) in the *C++ Language Reference*.  
  
 Each routine in an application can have its own exception handler. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> expression executes in the scope of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> body. This means it has access to any local variables declared there.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword is valid within a **try-except** statement block. The effect of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is to jump to the end of the **try-except** block. Execution resumes after the end of the exception handler. Although a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement can be used to accomplish the same result, a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement causes stack unwinding. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement is more efficient because it does not involve stack unwinding.  
  
 Exiting a **try-except** statement using the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> run-time function is considered abnormal termination. It is illegal to jump into a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statement, but legal to jump out of one. The exception handler is not called if a process is killed in the middle of executing a **try-except** statement.  
  
## Example  
 Following is an example of an exception handler and a termination handler. See [The try-finally Statement](../vs140/try-finally-statement--c-.md) for more information about termination handlers.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This is the output from the example, with commentary added on the right:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [try-except Statement](../vs140/try-except-statement.md)