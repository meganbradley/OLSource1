---
title: "DirectCast Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.directCast"
  - "directCast"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "DirectCast keyword"
ms.assetid: 63e5a1d0-4d9e-4732-bf8f-e90c0c8784b8
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DirectCast Operator (Visual Basic)
Introduces a type conversion operation based on inheritance or implementation.  
  
## Remarks  
 `DirectCast` does not use the Visual Basic run-time helper routines for conversion, so it can provide somewhat better performance than `CType` when converting to and from data type `Object`.  
  
 You use the `DirectCast` keyword similar to the way you use the [CType Function](../VS_csharp/ctype-function--visual-basic-.md) and the [TryCast](../VS_csharp/trycast-operator--visual-basic-.md) keyword. You supply an expression as the first argument and a type to convert it to as the second argument. `DirectCast` requires an inheritance or implementation relationship between the data types of the two arguments. This means that one type must inherit from or implement the other.  
  
## Errors and Failures  
 `DirectCast` generates a compiler error if it detects that no inheritance or implementation relationship exists. But the lack of a compiler error does not guarantee a successful conversion. If the desired conversion is narrowing, it could fail at run time. If this happens, the runtime throws an <xref:System.InvalidCastException*> error.  
  
## Conversion Keywords  
 A comparison of the type conversion keywords is as follows.  
  
|||||  
|-|-|-|-|  
|Keyword|Data types|Argument relationship|Run-time failure|  
|[CType Function](../VS_csharp/ctype-function--visual-basic-.md)|Any data types|Widening or narrowing conversion must be defined between the two data types|Throws <xref:System.InvalidCastException*>|  
|`DirectCast`|Any data types|One type must inherit from or implement the other type|Throws <xref:System.InvalidCastException*>|  
|[TryCast](../VS_csharp/trycast-operator--visual-basic-.md)|Reference types only|One type must inherit from or implement the other type|Returns [Nothing (Visual Basic)](../VS_csharp/nothing--visual-basic-.md)|  
  
## Example  
 The following example demonstrates two uses of `DirectCast`, one that fails at run time and one that succeeds.  
  
 [!code[VbVbalrKeywords#1](../VS_csharp/codesnippet/VisualBasic/directcast-operator--visual-basic-_1.vb)]  
  
 In the preceding example, the run-time type of `q` is `Double`. `CType` succeeds because `Double` can be converted to `Integer`. However, the first `DirectCast` fails at run time because the run-time type of `Double` has no inheritance relationship with `Integer`, even though a conversion exists. The second `DirectCast` succeeds because it converts from type <xref:System.Windows.Forms.Form*> to type <xref:System.Windows.Forms.Control*>, from which <xref:System.Windows.Forms.Form*> inherits.  
  
## See Also  
 <xref:System.Convert.ChangeType*?displayProperty=fullName>   
 [Widening and Narrowing Conversions](../VS_csharp/widening-and-narrowing-conversions--visual-basic-.md)   
 [Implicit and Explicit Conversions](../VS_csharp/implicit-and-explicit-conversions--visual-basic-.md)