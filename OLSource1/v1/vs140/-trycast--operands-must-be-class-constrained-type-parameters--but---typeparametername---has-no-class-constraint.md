---
title: "&#39;TryCast&#39; operands must be class-constrained type parameters, but &#39;&lt;typeparametername&gt;&#39; has no class constraint"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - BC30793
  - vbc30793
helpviewer_keywords: 
  - BC30793
ms.assetid: a38a1da9-4413-4a69-a2ce-0b6d51c2c4ef
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;TryCast&#39; operands must be class-constrained type parameters, but &#39;&lt;typeparametername&gt;&#39; has no class constraint
The [TryCast](../vs140/trycast-operator--visual-basic-.md) operator is used with a type parameter operand that is not guaranteed to be a reference type.  
  
 `TryCast` operates only on reference types, such as classes or interfaces. When you pass a type parameter as an argument to `TryCast`, you must constrain that type parameter to be a reference type. You can do this by including one or more of the following in the type parameter's constraint list:  
  
-   One or more interface names (the type argument must implement all of them)  
  
-   At most one class name (the type argument must inherit from it)  
  
-   The [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) constraint (the type argument must expose a parameterless constructor that the creating code can access, and therefore it must be a class)  
  
-   The [Class (Visual Basic)](assetId:///0777c6e6-46bc-451b-ad70-57b49d4ef4f7) constraint (the type argument must be a reference type)  
  
 **Error ID:** BC30793  
  
### To correct this error  
  
-   If you need to pass this type parameter to `TryCast`, constrain it with one or more of the constraints in the preceding list.  
  
-   If you cannot require the type parameter to accept only a reference type, you cannot use it with `TryCast`. You might be able to use the [CType Function](../vs140/ctype-function--visual-basic-.md) instead.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)