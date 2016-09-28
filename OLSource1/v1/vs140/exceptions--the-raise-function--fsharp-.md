---
title: "Exceptions: the raise Function (F#)"
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
  - "exceptions, raising [F#]"
  - "reraise function [F#]"
  - "exceptions [F#], raising"
  - "raise function [F#]"
ms.assetid: c7b094db-3c76-4436-ae88-3def8fca2f75
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: the raise Function (F#)
The `raise` function is used to indicate that an error or exceptional condition has occurred. Information about the error is captured in an exception object.  
  
## Syntax  
  
```  
raise (expression)  
```  
  
## Remarks  
 The `raise` function generates an exception object and initiates a stack unwinding process. The stack unwinding process is managed by the common language runtime (CLR), so the behavior of this process is the same as it is in any other .NET language. The stack unwinding process is a search for an exception handler that matches the generated exception. The search starts in the current `try...with` expression, if there is one. Each pattern in the `with` block is checked, in order. When a matching exception handler is found, the exception is considered handled; otherwise, the stack is unwound and `with` blocks up the call chain are checked until a matching handler is found. Any `finally` blocks that are encountered in the call chain are also executed in sequence as the stack unwinds.  
  
 The `raise` function is the equivalent of `throw` in C# or C++. Use `reraise` in a catch handler to propagate the same exception up the call chain.  
  
 The following code examples illustrate the use of the `raise` function to generate an exception.  
  
 [!code[FsLangRef2#5801](../vs140/codesnippet/FSharp/exceptions--the-raise-function--fsharp-_1.fs)]  
  
 The `raise` function can also be used to raise .NET exceptions, as shown in the following example.  
  
 [!code[FsLangRef2#5802](../vs140/codesnippet/FSharp/exceptions--the-raise-function--fsharp-_2.fs)]  
  
## See Also  
 [Exception Handling (F#)](../vs140/exception-handling--fsharp-.md)   
 [Exception Types](../vs140/exception-types--fsharp-.md)   
 [Exceptions: the try .. with Expression](../vs140/exceptions--the-try...with-expression--fsharp-.md)   
 [Exceptions: the try .. finally Expression](../vs140/exceptions--the-try...finally-expression--fsharp-.md)   
 [Exceptions: the failwith Function](../vs140/exceptions--the-failwith-function--fsharp-.md)   
 [Exceptions: The invalidArg Function (F#)](../vs140/exceptions--the-invalidarg-function--fsharp-.md)