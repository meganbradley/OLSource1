---
title: "Expressions with Unary Operators"
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
  - "expressions [C++], unary operators"
  - "unary operators, expressions with"
  - "expressions [C++], operators"
ms.assetid: 1217685b-b85d-4b48-9ff4-d90f56a26c1b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expressions with Unary Operators
Unary operators act on only one operand in an expression. The unary operators are as follows:  
  
-   [Indirection operator (*)](../VS_csharp/indirection-operator---.md)  
  
-   [Address-of operator (&)](../VS_csharp/address-of-operator---.md)  
  
-   [Unary plus operator (+)](../VS_csharp/unary-plus-and-negation-operators----and--.md)  
  
-   [Unary negation operator (–)](../Topic/Unary%20Negation%20Operator:%20-.md)  
  
-   [Logical negation operator (!)](../VS_csharp/logical-negation-operator--!.md)  
  
-   [One's complement operator (~)](../VS_csharp/one-s-complement-operator--~.md)  
  
-   [Prefix increment operator (++)](../VS_csharp/prefix-increment-and-decrement-operators-----and---.md)  
  
-   [Prefix decrement operator (––)](../VS_csharp/prefix-increment-and-decrement-operators-----and---.md)  
  
-   [Cast operator ()](../VS_csharp/cast-operator----.md)  
  
-   [sizeof operator](../VS_csharp/sizeof-operator.md)  
  
-   [__uuidof operator](../VS_csharp/__uuidof-operator.md)  
  
-   [__alignof operator](../VS_csharp/__alignof-operator.md)  
  
-   [new operator](../VS_csharp/new-operator--c---.md)  
  
-   [delete operator](../VS_csharp/delete-operator--c---.md)  
  
 These operators have right-to-left associativity. Unary expressions generally involve syntax that precedes a postfix or primary expression.  
  
 The following are the possible forms of unary expressions.  
  
-   *postfix-expression*  
  
-   `++` *unary-expression*  
  
-   `––` *unary-expression*  
  
-   *unary-operator* *cast-expression*  
  
-   `sizeof` *unary-expression*  
  
-   `sizeof(` *type-name* `)`  
  
-   `decltype(` *expression* `)`  
  
-   *allocation-expression*  
  
-   *deallocation-expression*  
  
 Any *postfix-expression* is considered a *unary-expression*, and because any primary expression is considered a *postfix-expression*, any primary expressions is considered a *unary-expression* also. For more information, see [Postfix Expressions](../VS_csharp/postfix-expressions.md) and [Primary Expressions](../VS_csharp/primary-expressions.md).  
  
 A *unary-operator* consists of one or more of the following symbols: `* &``+``–``!``~`  
  
 The *cast-expression* is a unary expression with an optional cast to change the type. For more information see [Cast Operator: ()](../VS_csharp/cast-operator----.md).  
  
 An *expression* can be any expression. For more information, see [Expressions (C++)](../VS_csharp/expressions--c---.md).  
  
 The *allocation-expression* refers to the `new` operator. The *deallocation-expression* refers to the `delete` operator. For more information, see the links earlier in this topic.  
  
## See Also  
 [Types of Expressions](../VS_csharp/types-of-expressions.md)