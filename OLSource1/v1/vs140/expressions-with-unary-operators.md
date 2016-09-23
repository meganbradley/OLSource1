---
title: "Expressions with Unary Operators"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: language-reference
dev_langs: 
  - C++
helpviewer_keywords: 
  - expressions [C++], unary operators
  - unary operators, expressions with
  - expressions [C++], operators
ms.assetid: 1217685b-b85d-4b48-9ff4-d90f56a26c1b
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Expressions with Unary Operators
Unary operators act on only one operand in an expression. The unary operators are as follows:  
  
-   [Indirection operator (*)](../vs140/indirection-operator---.md)  
  
-   [Address-of operator (&)](../vs140/address-of-operator---.md)  
  
-   [Unary plus operator (+)](../vs140/unary-plus-and-negation-operators----and--.md)  
  
-   [Unary negation operator (–)](../vs140/unary-negation-operator---.md)  
  
-   [Logical negation operator (!)](../vs140/logical-negation-operator--!.md)  
  
-   [One's complement operator (~)](../vs140/one-s-complement-operator--~.md)  
  
-   [Prefix increment operator (++)](../vs140/prefix-increment-and-decrement-operators-----and---.md)  
  
-   [Prefix decrement operator (––)](../vs140/prefix-increment-and-decrement-operators-----and---.md)  
  
-   [Cast operator ()](../vs140/cast-operator----.md)  
  
-   [sizeof operator](../vs140/sizeof-operator.md)  
  
-   [__uuidof operator](../vs140/__uuidof-operator.md)  
  
-   [__alignof operator](../vs140/__alignof-operator.md)  
  
-   [new operator](../vs140/new-operator--c---.md)  
  
-   [delete operator](../vs140/delete-operator--c---.md)  
  
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
  
 Any *postfix-expression* is considered a *unary-expression*, and because any primary expression is considered a *postfix-expression*, any primary expressions is considered a *unary-expression* also. For more information, see [Postfix Expressions](../vs140/postfix-expressions.md) and [Primary Expressions](../vs140/primary-expressions.md).  
  
 A *unary-operator* consists of one or more of the following symbols: `* &``+``–``!``~`  
  
 The *cast-expression* is a unary expression with an optional cast to change the type. For more information see [Cast Operator: ()](../vs140/cast-operator----.md).  
  
 An *expression* can be any expression. For more information, see [Expressions (C++)](../vs140/expressions--c---.md).  
  
 The *allocation-expression* refers to the `new` operator. The *deallocation-expression* refers to the `delete` operator. For more information, see the links earlier in this topic.  
  
## See Also  
 [Types of Expressions](../vs140/types-of-expressions.md)