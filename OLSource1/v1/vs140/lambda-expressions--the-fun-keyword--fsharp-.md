---
title: "Lambda Expressions: The fun Keyword (F#)"
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
  - "lambda expressions [F#]"
  - "fun keyword [F#]"
  - "anonymous functions [F#]"
ms.assetid: 556283bc-c82d-4cb5-b20a-d24b346b619d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Lambda Expressions: The fun Keyword (F#)
The `fun` keyword is used to define a lambda expression, that is, an anonymous function.  
  
## Syntax  
  
```  
fun parameter-list -> expression  
```  
  
## Remarks  
 The `parameter-list` typically consists of names and, optionally, types of parameters. More generally, the `parameter-list` can be composed of any F# patterns. For a full list of possible patterns, see [Patterns](../vs140/pattern-matching--fsharp-.md). Lists of valid parameters include the following examples.  
  
```f#  
  
// Lambda expressions with parameter lists.  
fun a b c -> ...  
fun (a: int) b c -> ...  
fun (a : int) (b : string) (c:float) -> ...  
  
// A lambda expression with a tuple pattern.  
fun (a, b) -> …  
  
// A lambda expression with a list pattern.  
fun head :: tail -> …  
```  
  
 The `expression` is the body of the function, the last expression of which generates a return value. Examples of valid lambda expressions include the following:  
  
 [!code[FsLangRef1#301](../vs140/codesnippet/FSharp/lambda-expressions--the-fun-keyword--fsharp-_1.fs)]  
  
## Using Lambda Expressions  
 Lambda expressions are especially useful when you want to perform operations on a list or other collection and want to avoid the extra work of defining a function. Many F# library functions take function values as arguments, and it can be especially convenient to use a lambda expression in those cases. The following code applies a lambda expression to elements of a list. In this case, the anonymous function adds 1 to every element of a list.  
  
 [!code[FsLangRef1#302](../vs140/codesnippet/FSharp/lambda-expressions--the-fun-keyword--fsharp-_2.fs)]  
  
## See Also  
 [Functions (F#)](../vs140/functions--fsharp-.md)