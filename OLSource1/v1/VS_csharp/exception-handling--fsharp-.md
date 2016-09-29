---
title: "Exception Handling (F#)"
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
  - "exceptions, F#"
  - "exception handling [F#]"
  - "exceptions [F#]"
  - "exception handling, F#"
ms.assetid: 80c4e196-5671-4dcb-bf16-63539da9c90f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exception Handling (F#)
This section contains information about exception handling support in the F# language.  
  
## Exception Handling Basics  
 Exception handling is the standard way of handling error conditions in the .NET Framework. Thus, any .NET language must support this mechanism, including F#. An *exception* is an object that encapsulates information about an error. When errors occur, exceptions are raised and regular execution stops. Instead, the runtime searches for an appropriate handler for the exception. The search starts in the current function, and proceeds up the stack through the layers of callers until a matching handler is found. Then the handler is executed.  
  
 In addition, as the stack is unwound, the runtime executes any code in `finally` blocks, to guarantee that objects are cleaned up correctly during the unwinding process.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Exception Types](../VS_csharp/exception-types--fsharp-.md)|Describes how to declare an exception type.|  
|[Exceptions: the try .. with Expression](../VS_csharp/exceptions--the-try...with-expression--fsharp-.md)|Describes the language construct that supports exception handling.|  
|[Exceptions: the try .. finally Expression](../VS_csharp/exceptions--the-try...finally-expression--fsharp-.md)|Describes the language construct that enables you to execute clean-up code as the stack unwinds when an exception is thrown.|  
|[Exceptions: the raise Function](../VS_csharp/exceptions--the-raise-function--fsharp-.md)|Describes how to throw an exception object.|  
|[Exceptions: the failwith Function](../VS_csharp/exceptions--the-failwith-function--fsharp-.md)|Describes how to generate a general F# exception.|  
|[Exceptions: the invalidArg Function](../VS_csharp/exceptions--the-invalidarg-function--fsharp-.md)|Describes how to generate an invalid argument exception.|