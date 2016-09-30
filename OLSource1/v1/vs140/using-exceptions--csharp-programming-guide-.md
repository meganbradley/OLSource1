---
title: "Using Exceptions (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "exception handling [C#], about exception handling"
  - "exceptions [C#], about exceptions"
ms.assetid: 71472c62-320a-470a-97d2-67995180389d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Exceptions (C# Programming Guide)
In C#, errors in the program at run time are propagated through the program by using a mechanism called exceptions. Exceptions are thrown by code that encounters an error and caught by code that can correct the error. Exceptions can be thrown by the .NET Framework common language runtime (CLR) or by code in a program. Once an exception is thrown, it propagates up the call stack until a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement for the exception is found. Uncaught exceptions are handled by a generic exception handler provided by the system that displays a dialog box.  
  
 Exceptions are represented by classes derived from \<xref:System.Exception*>. This class identifies the type of exception and contains properties that have details about the exception. Throwing an exception involves creating an instance of an exception-derived class, optionally configuring properties of the exception, and then throwing the object by using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword. For example:  
  
 [!code[csProgGuideExceptions#1](../vs140/codesnippet/CSharp/using-exceptions--csharp-programming-guide-_1.cs)]  
  
 After an exception is thrown, the runtime checks the current statement to see whether it is within a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block. If it is, any <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> blocks associated with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block are checked to see whether they can catch the exception. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> blocks typically specify exception types; if the type of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> block is the same type as the exception, or a base class of the exception, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block can handle the method. For example:  
  
 [!code[csProgGuideExceptions#2](../vs140/codesnippet/CSharp/using-exceptions--csharp-programming-guide-_2.cs)]  
  
 If the statement that throws an exception is not within a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block or if the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block that encloses it has no matching <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block, the runtime checks the calling method for a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> statement and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> blocks. The runtime continues up the calling stack, searching for a compatible <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block. After the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block is found and executed, control is passed to the next statement after that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> block.  
  
 A <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> statement can contain more than one <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> block. The first <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement that can handle the exception is executed; any following <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> statements, even if they are compatible, are ignored. Therefore, catch blocks should always be ordered from most specific (or most-derived) to least specific. For example:  
  
 [!code[csProgGuideExceptions#3](../vs140/codesnippet/CSharp/using-exceptions--csharp-programming-guide-_3.cs)]  
  
 Before the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> block is executed, the runtime checks for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> blocks. <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> blocks enable the programmer to clean up any ambiguous state that could be left over from an aborted <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block, or to release any external resources (such as graphics handles, database connections or file streams) without waiting for the garbage collector in the runtime to finalize the objects. For example:  
  
 [!code[csProgGuideExceptions#4](../vs140/codesnippet/CSharp/using-exceptions--csharp-programming-guide-_4.cs)]  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> threw an exception, the code in the second <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block that tries to reopen the file would fail if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is not called, and the file would remain locked. Because <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> blocks are executed even if an exception is thrown, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> block in the previous example allows for the file to be closed correctly and helps avoid an error.  
  
 If no compatible <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block is found on the call stack after an exception is thrown, one of three things occurs:  
  
-   If the exception is within a destructor, the destructor is aborted and the base destructor, if any, is called.  
  
-   If the call stack contains a static constructor, or a static field initializer, a \<xref:System.TypeInitializationException*> is thrown, with the original exception assigned to the \<xref:System.Exception.InnerException*> property of the new exception.  
  
-   If the start of the thread is reached, the thread is terminated.  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Exceptions and Exception Handling (Visual C#)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md)