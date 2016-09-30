---
title: "Exceptions: The try...with Expression (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "try...with expression [F#]"
  - "try-with expression [F#]"
  - "exceptions [F#], try...with expression"
  - "with keyword [F#]"
  - "try keyword [F#]"
ms.assetid: 38eeb1f2-3bd7-4b9f-a859-91662181ca41
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: The try...with Expression (F#)
This topic describes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> expression, the expression that is used for exception handling in the F# language.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression is used to handle exceptions in F#. It is similar to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement in C#. In the preceding syntax, the code in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> might generate an exception. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> expression returns a value. If no exception is thrown, the whole expression returns the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If an exception is thrown, each <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is compared in turn with the exception, and for the first matching pattern, the corresponding <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, known as the *exception handler*, for that branch is executed, and the overall expression returns the value of the expression in that exception handler. If no pattern matches, the exception propagates up the call stack until a matching handler is found. The types of the values returned from each expression in the exception handlers must match the type returned from the expression in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block.  
  
 Frequently, the fact that an error occurred also means that there is no valid value that can be returned from the expressions in each exception handler. A frequent pattern is to have the type of the expression be an option type. The following code example illustrates this pattern.  
  
 [!code[FsLangRef2#5601](../vs140/codesnippet/FSharp/exceptions--the-try...with-expression--fsharp-_1.fs)]  
  
 Exceptions can be .NET exceptions, or they can be F# exceptions. You can define F# exceptions by using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword.  
  
 You can use a variety of patterns to filter on the exception type and other conditions; the options are summarized in the following table.  
  
|Pattern|Description|  
|-------------|-----------------|  
|:? <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Matches the specified .NET exception type.|  
|:? <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Matches the specified .NET exception type, but gives the exception a named value.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>)|Matches an F# exception type and binds the arguments.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Matches any exception and binds the name to the exception object. Equivalent to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> *identifier*|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Matches any exception if the condition is true.|  
  
## Examples  
 The following code examples illustrate the use of the various exception handler patterns.  
  
 [!code[FsLangRef2#5602](../vs140/codesnippet/FSharp/exceptions--the-try...with-expression--fsharp-_2.fs)]  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> construct is a separate expression from the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> expression. Therefore, if your code requires both a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> block and a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> block, you will have to nest the two expressions.  
  
> [!NOTE]
>  You can use <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in asynchronous workflows and other computation expressions, in which case a customized version of the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> expression is used. For more information, see [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md), and [Computation Expressions (F#)](../vs140/computation-expressions--fsharp-.md).  
  
## See Also  
 [Exception Handling (F#)](../vs140/exception-handling--fsharp-.md)   
 [Exception Types](../vs140/exception-types--fsharp-.md)   
 [Exceptions: The try .. finally Expression](../vs140/exceptions--the-try...finally-expression--fsharp-.md)