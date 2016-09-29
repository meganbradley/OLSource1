---
title: "Unit Type (F#)"
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
  - "unit type [F#]"
ms.assetid: d9c887e3-231b-448f-8f18-2cb60e89d10a
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unit Type (F#)
The `unit` type is a type that indicates the absence of a specific value; the `unit` type has only a single value, which acts as a placeholder when no other value exists or is needed.  
  
## Syntax  
  
```  
// The value of the unit type.  
()  
```  
  
## Remarks  
 Every F# expression must evaluate to a value. For expressions that do not generate a value that is of interest, the value of type `unit` is used. The `unit` type resembles the `void` type in languages such as C# and C++.  
  
 The `unit` type has a single value, and that value is indicated by the token `()`.  
  
 The value of the `unit` type is often used in F# programming to hold the place where a value is required by the language syntax, but when no value is needed or desired. An example might be the return value of a `printf` function. Because the important actions of the `printf` operation occur in the function, the function does not have to return an actual value. Therefore, the return value is of type `unit`.  
  
 Some constructs expect a `unit` value. For example, a `do` binding or any code at the top level of a module is expected to evaluate to a `unit` value. The compiler reports a warning when a `do` binding or code at the top level of a module produces a result other than the `unit` value that is not used, as shown in the following example.  
  
 [!code[FsLangRef1#901](../VS_csharp/codesnippet/FSharp/unit-type--fsharp-_1.fs)]  
  
 This warning is a characteristic of functional programming; it does not appear in other .NET programming languages. In a purely functional program, in which functions do not have any side effects, the final return value is the only result of a function call. Therefore, when the result is ignored, it is a possible programming error. Although F# is not a purely functional programming language, it is a good practice to follow functional programming style whenever possible.  
  
## See Also  
 [Primitive Types](../VS_csharp/primitive-types--fsharp-.md)   
 [F# Language Reference](../VS_csharp/fsharp-language-reference.md)