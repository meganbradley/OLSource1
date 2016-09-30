---
title: "try-catch (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "try"
  - "try_CSharpKeyword"
  - "catch"
  - "catch_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "catch keyword [C#]"
  - "try-catch statement [C#]"
ms.assetid: cb5503c7-bfa1-4610-8fc2-ddcd2e84c438
caps.latest.revision: 49
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# try-catch (C# Reference)
The try-catch statement consists of a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block followed by one or more <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clauses, which specify handlers for different exceptions.  
  
## Remarks  
 When an exception is thrown, the common language runtime (CLR) looks for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement that handles this exception. If the currently executing method does not contain such a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block, the CLR looks at the method that called the current method, and so on up the call stack. If no <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block is found, then the CLR displays an unhandled exception message to the user and stops execution of the program.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> block contains the guarded code that may cause the exception. The block is executed until an exception is thrown or it is completed successfully. For example, the following attempt to cast a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object raises the \<xref:System.NullReferenceException*> exception:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Although the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> clause can be used without arguments to catch any type of exception, this usage is not recommended. In general, you should only catch those exceptions that you know how to recover from. Therefore, you should always specify an object argument derived from \<xref:System.Exception*?displayProperty=fullName> For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 It is possible to use more than one specific <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause in the same try-catch statement. In this case, the order of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> clauses is important because the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> clauses are examined in order. Catch the more specific exceptions before the less specific ones. The compiler produces an error if you order your catch blocks so that a later block can never be reached.  
  
 Using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> arguments is one way to filter for the exceptions you want to handle.  You can also use a predicate expression that further examines the exception to decide whether to handle it.  If the predicate expression returns false, then the search for a handler continues.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Exception filters are preferable to catching and rethrowing (explained below) because filters leave the stack unharmed.  If a later handler dumps the stack, you can see where the exception originally came from, rather than just the last place it was rethrown.  A common use of exception filter expressions is logging.  You can create a predicate function that always returns false that also outputs to a log, you can log exceptions as they go by without having to handle them and rethrow.  
  
 A [throw](../vs140/throw--csharp-reference-.md) statement can be used in a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> block to re-throw the exception that is caught by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statement. The following example extracts source information from an \<xref:System.IO.IOException*> exception, and then throws the exception to the parent method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can catch one exception and throw a different exception. When you do this, specify the exception that you caught as the inner exception, as shown in the following example.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 You can also re-throw an exception when a specified condition is true, as shown in the following example.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 From inside a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> block, initialize only variables that are declared therein. Otherwise, an exception can occur before the execution of the block is completed. For example, in the following code example, the variable <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is initialized inside the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block. An attempt to use this variable outside the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> block in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> statement will generate a compiler error.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 For more information about catch, see [try-catch-finally](../vs140/try-catch-finally--csharp-reference-.md).  
  
## Exceptions in Async Methods  
 An async method is marked  by an  [async](../vs140/async--csharp-reference-.md) modifier and usually contains one or more await expressions or statements. An await expression applies the [await](../vs140/await--csharp-reference-.md) operator to a \<xref:System.Threading.Tasks.Task*> or <xref:System.Threading.Tasks.Task<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>OperationCanceledException<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>try<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>try<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>ProcessString<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>throw<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>MyMethod<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>Exception caught<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>ProcessString<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>throw new Exception()<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>A previous catch clause already catches all exceptions of this or a super type ('System.Exception')<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>await<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>try<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>throw new Exception<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>IsFaulted<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>True<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>Exception.InnerException<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>throw new OperationCancelledException<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>IsCanceled<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>IsFaulted<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>IsCanceled<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>try<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>catch<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>Exception.InnerExceptions` property of the task that was returned by \<xref:System.Threading.Tasks.Task.WhenAll*?displayProperty=fullName>.  
  
 [!code[csAsyncExceptions#4](../vs140/codesnippet/CSharp/try-catch--csharp-reference-_4.cs)]  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [try, throw, and catch Statements (C++)](../vs140/try--throw--and-catch-statements--c---.md)   
 [Exception Handling Statements](../vs140/exception-handling-statements--csharp-reference-.md)   
 [throw](../vs140/throw--csharp-reference-.md)   
 [try-finally](../vs140/try-finally--csharp-reference-.md)   
 [Throwing Exceptions](assetId:///72bdd157-caa9-4478-9ee3-cb4500b84528)