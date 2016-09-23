---
title: "Exception Types (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - exceptions [F#], types
  - exceptions, F#
  - exceptions [F#]
ms.assetid: 26da7351-aa16-4b41-8a70-1d932ccef99f
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Exception Types (F#)
There are two categories of exceptions in F#: .NET exception types and F# exception types. This topic describes how to define and use F# exception types.  
  
## Syntax  
  
```  
exception exception-type of argument-type  
```  
  
## Remarks  
 In the previous syntax, `exception-type` is the name of a new F# exception type, and `argument-type` represents the type of an argument that can be supplied when you raise an exception of this type. You can specify multiple arguments by using a tuple type for `argument-type`.  
  
 A typical definition for an F# exception resembles the following.  
  
 [!code[FsLangRef2#5501](../vs140/codesnippet/FSharp/exception-types--fsharp-_1.fs)]
  
  
 You can generate an exception of this type by using the `raise` function, as follows.  
  
 [!code[FsLangRef2#5502](../vs140/codesnippet/FSharp/exception-types--fsharp-_2.fs)]
  
  
 You can use an F# exception type directly in the filters in a `try...with` expression, as shown in the following example.  
  
 [!code[FsLangRef2#5503](../vs140/codesnippet/FSharp/exception-types--fsharp-_3.fs)]
  
  
 The exception type that you define with the `exception` keyword in F# is a new type that inherits from <xref:System.Exception?qualifyHint=False>.  
  
## See Also  
 [Exception Handling (F#)](../vs140/exception-handling--fsharp-.md)   
 [Exceptions: the raise Function](../vs140/exceptions--the-raise-function--fsharp-.md)   
 [Exception Hierarchy](assetId:///f7d68675-be06-40fb-a555-05f0c5a6f66b)