---
title: "try-except Statement"
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
  - "_abnormal_termination_cpp"
  - "_exception_code_cpp"
  - "EXCEPTION_CONTINUE_SEARCH"
  - "_exception_info"
  - "__except"
  - "EXCEPTION_CONTINUE_EXECUTION"
  - "_exception_code"
  - "__except_cpp"
  - "_exception_info_cpp"
  - "EXCEPTION_EXECUTE_HANDLER"
  - "_abnormal_termination"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__try keyword [C++]"
  - "EXCEPTION_CONTINUE_EXECUTION macro"
  - "EXCEPTION_CONTINUE_SEARCH macro"
  - "EXCEPTION_EXECUTE_HANDLER macro"
  - "GetExceptionCode function"
  - "try-catch keyword [C++], try-except keyword [C++]"
  - "_exception_code keyword [C++]"
  - "try-except keyword [C++]"
  - "_exception_info keyword [C++]"
  - "_abnormal_termination keyword [C++]"
ms.assetid: 30d60071-ea49-4bfb-a8e6-7a420de66381
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try-except Statement
**Microsoft Specific**  
  
 The following syntax describes a try-except statement:  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **try-except** statement is a Microsoft extension to the C and C++ languages that enables target applications to gain control when events that normally terminate program execution occur. Such events are called exceptions, and the mechanism that deals with exceptions is called structured exception handling.  
  
 For related information, see the [try-finally statement](../vs140/try-finally-statement.md).  
  
 Exceptions can be either hardware-based or software-based. Even when applications cannot completely recover from hardware or software exceptions, structured exception handling makes it possible to display error information and trap the internal state of the application to help diagnose the problem. This is especially useful for intermittent problems that cannot be reproduced easily.  
  
> [!NOTE]
>  Structured exception handling works with Win32 for both C and C++ source files. However, it is not specifically designed for C++. You can ensure that your code is more portable by using C++ exception handling. Also, C++ exception handling is more flexible, in that it can handle exceptions of any type. For C++ programs, it is recommended that you use the C++ exception-handling mechanism ([try, catch, and throw](../vs140/try--throw--and-catch-statements--c---.md) statements).  
  
 The compound statement after the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause is the body or guarded section. The compound statement after the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause is the exception handler. The handler specifies a set of actions to be taken if an exception is raised during execution of the body of the guarded section. Execution proceeds as follows:  
  
1.  The guarded section is executed.  
  
2.  If no exception occurs during execution of the guarded section, execution continues at the statement after the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause.  
  
3.  If an exception occurs during execution of the guarded section or in any routine the guarded section calls, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> *expression* (called the *filter* expression) is evaluated and the value determines how the exception is handled. There are three values:  
  
     **EXCEPTION_CONTINUE_EXECUTION (–1)** Exception is dismissed. Continue execution at the point where the exception occurred.  
  
     **EXCEPTION_CONTINUE_SEARCH (0)** Exception is not recognized. Continue to search up the stack for a handler, first for containing **try-except** statements, then for handlers with the next highest precedence.  
  
     **EXCEPTION_EXECUTE_HANDLER (1)** Exception is recognized. Transfer control to the exception handler by executing the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> compound statement, then continue execution after the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block.  
  
 Because the __**except** expression is evaluated as a C expression, it is limited to a single value, the conditional-expression operator, or the comma operator. If more extensive processing is required, the expression can call a routine that returns one of the three values listed above.  
  
 Each application can have its own exception handler.  
  
 It is not valid to jump into a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement, but valid to jump out of one. The exception handler is not called if a process is terminated in the middle of executing a **try-except** statement.  
  
 For more information, see Knowledge Base article Q315937 : HOW TO: Trap Stack Overflow in a Visual C++ Application.  
  
## The __leave Keyword  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword is valid only within the guarded section of a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement, and its effect is to jump to the end of the guarded section. Execution continues at the first statement after the exception handler.  
  
 A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement can also jump out of the guarded section, and it does not degrade performance as it does in a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement because stack unwinding does not occur. However, we recommend that you use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword rather than a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> statement because you are less likely to make a programming mistake if the guarded section is large or complex.  
  
### Structured Exception Handling Intrinsic Functions  
 Structured exception handling provides two intrinsic functions that are available to use with the **try-except** statement: **GetExceptionCode** and **GetExceptionInformation**.  
  
 **GetExceptionCode** returns the code (a 32-bit integer) of the exception.  
  
 The intrinsic function **GetExceptionInformation** returns a pointer to a structure containing additional information about the exception. Through this pointer, you can access the machine state that existed at the time of a hardware exception. The structure is as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The pointer types _**EXCEPTION_RECORD** and \_**CONTEXT** are defined in the include file EXCPT.H.  
  
 You can use **GetExceptionCode** within the exception handler. However, you can use **GetExceptionInformation** only within the exception filter expression. The information it points to is generally on the stack and is no longer available when control is transferred to the exception handler.  
  
 The intrinsic function **AbnormalTermination** is available within a termination handler. It returns 0 if the body of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement terminates sequentially. In all other cases, it returns 1.  
  
 EXCPT.H defines some alternate names for these intrinsics:  
  
 **GetExceptionCode** is equivalent to _exception_code  
  
 **GetExceptionInformation** is equivalent to _exception_info  
  
 **AbnormalTermination** is equivalent to _abnormal_termination  
  
## Example  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END Microsoft Specific**  
  
## See Also  
 [Writing an Exception Handler](../vs140/writing-an-exception-handler.md)   
 [Structured Exception Handling (C/C++)](../vs140/structured-exception-handling--c-c---.md)   
 [Keywords](../vs140/keywords--c---.md)