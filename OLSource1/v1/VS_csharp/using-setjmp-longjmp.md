---
title: "Using setjmp-longjmp"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "Using setjmp/longjmp"
f1_keywords: 
  - "longjmp"
  - "setjmp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C++ exception handling, setjmp/longjmp functions"
  - "SETJMPEX.H"
  - "longjmp function in C++ programs"
  - "SETJMP.H"
  - "setjmp function"
  - "setjmp function, C++ programs"
ms.assetid: 96be8816-f6f4-4567-9a9c-0c3c720e37c5
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using setjmp-longjmp
When [setjmp](../VS_csharp/setjmp.md) and [longjmp](../VS_csharp/longjmp.md) are used together, they provide a way to execute a non-local `goto`. They are typically used to pass execution control to error-handling or recovery code in a previously called routine without using the standard calling or return conventions.  
  
> [!CAUTION]
>  However, because `setjmp` and `longjmp` do not support C++ object semantics, and because they might degrade performance by preventing optimization on local variables, we recommend that you do not use them in C++ programs. We recommend that you use `try`/`catch` constructs instead.  
  
 If you decide to use `setjmp`/`longjmp` in a C++ program, also include SETJMP.H or SETJMPEX.H to assure correct interaction between the functions and C++ exception handling. If you use [/EH](../VS_csharp/-eh--exception-handling-model-.md) to compile, destructors for local objects are called during the stack unwind. If you use **/EHs** to compile, and one of your functions calls a function that uses [nothrow](../VS_csharp/nothrow--c---.md) and the function that uses `nothrow` calls `longjmp`, then the destructor unwind might not occur, depending on the optimizer.  
  
 In portable code, when a non-local `goto` that calls `longjmp` is executed, correct destruction of frame-based objects might be unreliable.  
  
## See Also  
 [Mixing C (Structured) and C++ Exceptions](../VS_csharp/mixing-c--structured--and-c---exceptions.md)