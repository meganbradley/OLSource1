---
title: "Exception Handling (C# Programming Guide)"
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
  - "exceptions [C#], handling"
ms.assetid: b4e4ecf2-b907-4e58-891f-2563762258e9
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exception Handling (C# Programming Guide)
A [try](../vs140/try-catch--csharp-reference-.md) block is used by C# programmers to partition code that might be affected by an exception. Associated [catch](../vs140/try-catch--csharp-reference-.md) blocks are used to handle any resulting exceptions. A [finally](../vs140/try-finally--csharp-reference-.md) block contains code that is run regardless of whether or not an exception is thrown in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> block, such as releasing resources that are allocated in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block. A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> block requires one or more associated <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> blocks, or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block, or both.  
  
 The following examples show a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement, a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement, and a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement.  
  
 [!code[csProgGuideExceptions#6](../vs140/codesnippet/CSharp/exception-handling--csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuideExceptions#7](../vs140/codesnippet/CSharp/exception-handling--csharp-programming-guide-_2.cs)]  
  
 [!code[csProgGuideExceptions#8](../vs140/codesnippet/CSharp/exception-handling--csharp-programming-guide-_3.cs)]  
  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block without a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block causes a compiler error.  
  
## Catch Blocks  
 A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block can specify the type of exception to catch. The type specification is called an *exception filter*. The exception type should be derived from \<xref:System.Exception*>. In general, do not specify \<xref:System.Exception*> as the exception filter unless either you know how to handle all exceptions that might be thrown in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block, or you have included a [throw](../vs140/throw--csharp-reference-.md) statement at the end of your <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block.  
  
 Multiple <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> blocks with different exception filters can be chained together. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> blocks are evaluated from top to bottom in your code, but only one <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> block is executed for each exception that is thrown. The first <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> block that specifies the exact type or a base class of the thrown exception is executed. If no <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> block specifies a matching exception filter, a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> block that does not have a filter is selected, if one is present in the statement. It is important to position <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> blocks with the most specific (that is, the most derived) exception types first.  
  
 You should catch exceptions when the following conditions are true:  
  
-   You have a good understanding of why the exception might be thrown, and you can implement a specific recovery, such as prompting the user to enter a new file name when you catch a \<xref:System.IO.FileNotFoundException*> object.  
  
-   You can create and throw a new, more specific exception.  
  
     [!code[csProgGuideExceptions#9](../vs140/codesnippet/CSharp/exception-handling--csharp-programming-guide-_4.cs)]  
  
-   You want to partially handle an exception before passing it on for additional handling. In the following example, a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> block is used to add an entry to an error log before re-throwing the exception.  
  
     [!code[csProgGuideExceptions#10](../vs140/codesnippet/CSharp/exception-handling--csharp-programming-guide-_5.cs)]  
  
## Finally Blocks  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block enables you to clean up actions that are performed in a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block. If present, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block executes last, after the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> block and any matched <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> block. A <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> block always runs, regardless of whether an exception is thrown or a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> block matching the exception type is found.  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> block can be used to release resources such as file streams, database connections, and graphics handles without waiting for the garbage collector in the runtime to finalize the objects. See [using Statement (C# Reference)](../vs140/using-statement--csharp-reference-.md) for more information.  
  
 In the following example, the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> block is used to close a file that is opened in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> block. Notice that the state of the file handle is checked before the file is closed. If the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block cannot open the file, the file handle still has the value <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> block does not try to close it. Alternatively, if the file is opened successfully in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block, the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> block closes the open file.  
  
 [!code[csProgGuideExceptions#11](../vs140/codesnippet/CSharp/exception-handling--csharp-programming-guide-_6.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Exceptions and Exception Handling (Visual C#)](../vs140/exceptions-and-exception-handling--csharp-programming-guide-.md)   
 [try-catch (C# Reference)](../vs140/try-catch--csharp-reference-.md)   
 [try-finally (C# Reference)](../vs140/try-finally--csharp-reference-.md)   
 [try-catch-finally (C# Reference)](../vs140/try-catch-finally--csharp-reference-.md)   
 [using Statement (C# Reference)](../vs140/using-statement--csharp-reference-.md)