---
title: "Option Strict On disallows implicit conversions from &#39;&lt;type1&gt;&#39; to &#39;&lt;type2&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30512"
  - "vbc30512"
helpviewer_keywords: 
  - "BC30512"
ms.assetid: b9756d48-05fa-4027-8a80-b4a0ef92099d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict On disallows implicit conversions from &#39;&lt;type1&gt;&#39; to &#39;&lt;type2&gt;&#39;
You have tried to convert a type to another type that may not be able to contain the value, such as a `Long` to an `Integer`, while the type checking switch ([Option Strict Statement](../vs140/option-strict-statement.md)) is set to `On`.  
  
 This type of conversion is called a *narrowing conversion*, and it is possible for it to fail at run time. For this reason, `Option Strict On` disallows implicit narrowing conversions.  
  
 **Error ID:** BC30512  
  
### To correct this error  
  
1.  Determine whether a conversion of any type exists from `<type1>` to `<type2>`. If both are [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] elementary types, or if both are instances of classes, you can usually make this determination by consulting the table in [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md).  
  
2.  If only a narrowing conversion exists from `<type1>` to `<type2>`, you should use explicit casting. The [CType Function](../vs140/ctype-function--visual-basic-.md) and [DirectCast](../vs140/directcast-operator--visual-basic-.md) keywords throw a run-time exception if the conversion fails. The [TryCast](../vs140/trycast-operator--visual-basic-.md) keyword applies only to reference types and returns [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md) if the conversion fails.  
  
3.  If a narrowing conversion exists and your program can tolerate a run-time failure, or you are confident that a run-time failure is not possible, you can specify `Option Strict Off` at the beginning of your source code. But you should still enclose the conversion in a [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md) block to avoid unexpected results or early termination of your program.  
  
4.  If no conversion exists from `<type1>` to `<type2>`, you must re-evaluate your program logic. You might be able to write code that can assign values to `<type2>` corresponding to anticipated values of `<type1>`.  
  
5.  If no conversion exists from `<type1>` to `<type2>` and one of the types is a class or structure you have defined, you might be able to define a conversion operator from that type to or from the other type. For more information, see [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md).  
  
6.  In all cases and as a general guideline, you should avoid using narrowing conversions unless you can trap failures in a `Catch` block and deal with them effectively.  
  
## See Also  
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [CType Function](../vs140/ctype-function--visual-basic-.md)   
 [DirectCast](../vs140/directcast-operator--visual-basic-.md)   
 [TryCast](../vs140/trycast-operator--visual-basic-.md)   
 [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)