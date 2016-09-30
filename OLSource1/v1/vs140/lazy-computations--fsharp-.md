---
title: "Lazy Computations (F#)"
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
  - "lazy computations [F#]"
  - "lazy evaluation [F#]"
ms.assetid: efa29e1b-ebf2-4bec-bbd1-104847f84e71
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lazy Computations (F#)
*Lazy computations* are computations that are not evaluated immediately, but are instead evaluated when the result is needed. This can help to improve the performance of your code.  
  
## Syntax  
  
```  
let identifier = lazy ( expression )  
```  
  
## Remarks  
 In the previous syntax, `expression` is code that is evaluated only when a result is required, and `identifier` is a value that stores the result. The value is of type [Lazy\<'T>](../vs140/control.lazy--t--type-abbreviation--fsharp-.md), where the actual type that is used for `'T` is determined from the result of the expression.  
  
 Lazy computations enable you to improve performance by restricting the execution of a computation to only those situations in which a result is needed.  
  
 To force the computation to be performed, you call the method `Force`. `Force` causes the execution to be performed only one time. Subsequent calls to `Force` return the same result, but do not execute any code.  
  
 The following code illustrates the use of lazy computation and the use of `Force`. In this code, the type of `result` is `Lazy<int>`, and the `Force` method returns an `int`.  
  
 [!code[FsLangRef2#73011](../vs140/codesnippet/FSharp/lazy-computations--fsharp-_1.fs)]  
  
 Lazy evaluation, but not the `Lazy` type, is also used for sequences. For more information, see [Sequences (F#)](../vs140/sequences--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [LazyExtensions module](../vs140/control.lazyextensions-module--fsharp-.md)