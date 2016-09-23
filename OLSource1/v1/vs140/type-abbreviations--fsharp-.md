---
title: "Type Abbreviations (F#)"
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
  - aliases, types [F#]
  - type abbreviations [F#]
ms.assetid: ec54a853-ad98-4966-8d6d-b60a65605748
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type Abbreviations (F#)
A *type abbreviation* is an alias or alternate name for a type.  
  
## Syntax  
  
```  
type type-abbreviation = type-name  
```  
  
## Remarks  
 You can use type abbreviations to give a type a more meaningful name, in order to make code easier to read. You can also use them to create an easy to use name for a type that is otherwise cumbersome to write out. Additionally, you can use type abbreviations to make it easier to change an underlying type without changing all the code that uses the type. The following is a simple type abbreviation.  
  
 [!code[FsLangRef1#2301](../vs140/codesnippet/FSharp/type-abbreviations--fsharp-_1.fs)]
  
  
 Type abbreviations can include generic parameters, as in the following code.  
  
 [!code[FsLangRef1#2302](../vs140/codesnippet/FSharp/type-abbreviations--fsharp-_2.fs)]
  
  
 In the previous code, `transform` is a type abbreviation that represents a function that takes a single argument of any type and that returns a single value of that same type.  
  
 Type abbreviations are not preserved in the .NET Framework MSIL code. Therefore, when you use an F# assembly from another .NET Framework language, you must use the underlying type name for a type abbreviation.  
  
 Type abbreviations can also be used on units of measure. For more information, see [Units of Measure](../vs140/units-of-measure--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)