---
title: "Resource Management: The use Keyword (F#)"
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
  - "use keyword [F#]"
  - "using function [F#]"
  - "resource management [F#]"
ms.assetid: cef3e196-4558-45bb-b2c8-65d9dab0d5c8
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Resource Management: The use Keyword (F#)
This topic describes the keyword `use` and the `using` function, which can control the initialization and release of resources.  
  
## Resources  
 The term *resource* is used in more than one way. Yes, resources can be data that an application uses, such as strings, graphics, and the like, but in this context, *resources* refers to software or operating system resources, such as graphics device contexts, file handles, network and database connections, concurrency objects such as wait handles, and so on. The use of these resources by applications involves the acquisition of the resource from the operating system or other resource provider, followed by the later release of the resource to the pool so that it can be provided to another application. Problems occur when applications do not release resources back to the common pool.  
  
## Managing Resources  
 To efficiently and responsibly manage resources in an application, you must release resources promptly and in a predictable manner. The .NET Framework helps you do this by providing the <xref:System.IDisposable*> interface. A type that implements <xref:System.IDisposable*> has the <xref:System.IDisposable.Dispose*> method, which correctly frees resources. Well-written applications guarantee that <xref:System.IDisposable.Dispose*> is called promptly when any object that holds a limited resource is no longer needed. Fortunately, most .NET languages provide support to make this easier, and F# is no exception. There are two useful language constructs that support the dispose pattern: the `use` binding and the `using` function.  
  
## use Binding  
 The `use` keyword has a form that resembles that of the `let` binding:  
  
 use `value` = `expression`  
  
 It provides the same functionality as a `let` binding but adds a call to `Dispose` on the value when the value goes out of scope. Note that the compiler inserts a null check on the value, so that if the value is `null`, the call to `Dispose` is not attempted.  
  
 The following example shows how to close a file automatically by using the `use` keyword.  
  
 [!code[FsLangRef2#6301](../vs140/codesnippet/FSharp/resource-management--the-use-keyword--fsharp-_1.fs)]  
  
> [!NOTE]
>  You can use `use` in computation expressions, in which case a customized version of the `use` expression is used. For more information, see [Sequences (F#)](../vs140/sequences--fsharp-.md), [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md), and [Computation Expressions (F#)](../vs140/computation-expressions--fsharp-.md).  
  
## using Function  
 The `using` function has the following form:  
  
 `using` (`expression1`) `function-or-lambda`  
  
 In a `using` expression, `expression1` creates the object that must be disposed. The result of `expression1` (the object that must be disposed) becomes an argument, `value`, to `function-or-lambda`, which is either a function that expects a single remaining argument of a type that matches the value produced by `expression1`, or a lambda expression that expects an argument of that type. At the end of the execution of the function, the runtime calls `Dispose` and frees the resources (unless the value is `null`, in which case the call to Dispose is not attempted).  
  
 The following example demonstrates the `using` expression with a lambda expression.  
  
 [!code[FsLangRef2#6302](../vs140/codesnippet/FSharp/resource-management--the-use-keyword--fsharp-_2.fs)]  
  
 The next example shows the `using` expression with a function.  
  
 [!code[FsLangRef2#6303](../vs140/codesnippet/FSharp/resource-management--the-use-keyword--fsharp-_3.fs)]  
  
 Note that the function could be a function that has some arguments applied already. The following code example demonstrates this. It creates a file that contains the string `XYZ`.  
  
 [!code[FsLangRef2#6304](../vs140/codesnippet/FSharp/resource-management--the-use-keyword--fsharp-_4.fs)]  
  
 The `using` function and the `use` binding are nearly equivalent ways to accomplish the same thing. The `using` keyword provides more control over when `Dispose` is called. When you use `using`, `Dispose` is called at the end of the function or lambda expression; when you use the `use` keyword, `Dispose` is called at the end of the containing code block. In general, you should prefer to use `use` instead of the `using` function.  
  
## See Also  
 <xref:System.IDisposable*>   
 [F# Language Reference](../vs140/fsharp-language-reference.md)