---
title: "Recursive Functions: The rec Keyword (F#)"
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
  - "recursive functions [F#]"
  - "mutually recursive functions [F#]"
  - "mutual recursion [F#]"
  - "recursion [F#]"
  - "rec keyword [F#]"
ms.assetid: b0355a2d-9d36-4403-929d-c6537fdc0a45
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Recursive Functions: The rec Keyword (F#)
The `rec` keyword is used together with the `let` keyword to define a recursive function.  
  
## Syntax  
  
```  
// Recursive function:  
let rec function-name parameter-list =   
   function-body  
  
// Mutually recursive functions:  
let rec function1-name parameter-list =  
   function1-body  
and function2-name parameter-list =  
   function2-body  
...  
```  
  
## Remarks  
 Recursive functions, functions that call themselves, are identified explicitly in the F# language. This makes the identifer that is being defined available in the scope of the function.  
  
 The following code illustrates a recursive function that computes the *n*th Fibonacci number.  
  
 [!code[FsLangRef1#4001](../vs140/codesnippet/FSharp/recursive-functions--the-rec-keyword--fsharp-_1.fs)]  
  
> [!NOTE]
>  In practice, code like that above is wasteful of memory and processor time because it involves the recomputation of previously computed values.  
  
 Methods are implicitly recursive within the type; there is no need to add the `rec` keyword. Let bindings within classes are not implicitly recursive.  
  
## Mutually Recursive Functions  
 Sometimes functions are *mutually recursive*, meaning that calls form a circle, where one function calls another which in turn calls the first, with any number of calls in between. You must define such functions together in the one `let` binding, using the `and` keyword to link them together.  
  
 The following example shows two mutually recursive functions.  
  
 [!code[FsLangRef1#4002](../vs140/codesnippet/FSharp/recursive-functions--the-rec-keyword--fsharp-_2.fs)]  
  
## See Also  
 [Functions (F#)](../vs140/functions--fsharp-.md)