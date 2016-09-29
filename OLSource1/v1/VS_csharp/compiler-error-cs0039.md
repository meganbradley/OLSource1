---
title: "Compiler Error CS0039"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0039"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0039"
ms.assetid: f9fcb1c5-4ea4-41f3-826e-9ab0ac43dd3e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0039
Cannot convert type 'type1' to 'type2' via a reference conversion, boxing conversion, unboxing conversion, wrapping conversion, or null type conversion  
  
 A conversion with the [as](../VS_csharp/as--csharp-reference-.md) operator is allowed by inheritance, reference conversions, and boxing conversions. For more information, see [Conversion Operators (C# Programmers Reference)](../VS_csharp/conversion-operators--csharp-programming-guide-.md).  
  
## Example  
 The following example generates CS0039.  
  
```  
// CS0039.cs  
using System;  
class A  
{  
}  
class B: A  
{  
}  
class C: A  
{  
}  
class M  
{  
    static void Main()  
    {  
        A a = new C();  
        B b = new B();  
        C c;  
  
        // This is valid; there is a built-in reference  
        // conversion from A to C.  
        c = a as C;    
  
        //The following generates CS0039; there is no  
        // built-in reference conversion from B to C.  
        c = b as C;  // CS0039  
    }  
}  
```