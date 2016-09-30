---
title: "Type parameter with a &#39;Structure&#39; constraint cannot be used as a constraint"
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
  - "vbc32114"
  - "bc32114"
helpviewer_keywords: 
  - "BC32114"
ms.assetid: 442b2048-9dc4-4223-bcfc-4d96bf8d14de
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type parameter with a &#39;Structure&#39; constraint cannot be used as a constraint
A type parameter with a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> constraint is used as the constraint for another type parameter.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> constraint requires that the type argument passed to its type parameter be a value type. However, a value type cannot be implemented or inherited, so it is not meaningful to use it as a constraint, which would require the other type parameter to implement it or inherit from it.  
  
 The only meaningful interpretation of this situation is that both type arguments must be of the exact same type. If that is the case, your generic type needs only one type parameter.  
  
 The following statement can generate this error.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The type passed to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot implement or inherit the type passed to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, because the type passed to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be a value type.  
  
 **Error ID:** BC32114  
  
### To correct this error  
  
-   Remove the type parameter constrained to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> from the constraint list on the other type parameter.  
  
-   If both type parameters require the same value type, define the generic type with only one type parameter.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)   
 [Structure (Visual Basic)](assetId:///263ce115-ac36-4c05-8cb7-0e0eead5c6d0)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)