---
title: "Cast Operator: ()"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cast operators"
  - "() cast operator"
ms.assetid: 4c99eb92-1b19-4a5d-9840-5d8c29b8453e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cast Operator: ()
A type cast provides a method for explicit conversion of the type of an object in a specific situation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Any unary expression is considered a cast expression.  
  
 The compiler treats *cast-expression* as type *type-name* after a type cast has been made. Casts can be used to convert objects of any scalar type to or from any other scalar type. Explicit type casts are constrained by the same rules that determine the effects of implicit conversions. Additional restraints on casts may result from the actual sizes or representation of specific types.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **RawBytes truncated to 10 chars:   Exciting!!**  
**Casted Bytes:   Exciting**  
**Note that the cast changed the raw internal string**  
**Raw Bytes after cast:   Exciting**   
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [C++ Operators](../vs140/c---operators.md)   
 [C++ Built-in Operators, Precedence and Associativity](../vs140/c---built-in-operators--precedence-and-associativity.md)   
 [Explicit Type Conversion Operator: ()](../vs140/explicit-type-conversion-operator----.md)   
 [Casting Operators](../vs140/casting-operators.md)   
 [Cast Operators](../vs140/cast-operators.md)