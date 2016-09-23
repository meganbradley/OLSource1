---
title: "C++ Built-in Operators, Precedence and Associativity"
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
  - operators (C++), hierarchy
  - operator precedence
  - precedence, operators
  - operators (C++), associativity
  - multiple operators
  - associativity of operators
  - operators [C++], precedence
  - evaluation order
  - hierarchy, operator
ms.assetid: 95c1f0ba-dad8-4034-b039-f79a904f112f
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# C++ Built-in Operators, Precedence and Associativity
The C++ language includes all C operators and adds several new operators. Operators specify an evaluation to be performed on one or more operands.  
  
 Operator precedence specifies the order of operations in expressions that contain more than one operator. Operator associativity specifies whether, in an expression that contains multiple operators with the same precedence, an operand is grouped with the one on its left or the one on its right. The following table shows the precedence and associativity of C++ operators (from highest to lowest precedence). Operators with the same precedence number have equal precedence unless another relationship is explicitly forced by parentheses.  
  
### C++ Operator Precedence and Associativity  
  
|Operator Description|Operator|  
|--------------------------|--------------|  
|`Group 1 precedence, no associativity`|  
|[Scope resolution](../vs140/scope-resolution-operator----.md)|`::`|  
|`Group 2 precedence, left to right associativity`|  
|[Member selection (object or pointer)](../vs140/member-access-operators--.-and---.md)|`. or –>`|  
|[Array subscript](../vs140/subscript-operator-.md)|`[ ]`|  
|[Function call](../vs140/function-call-operator----.md)|`( )`|  
|[Postfix increment](../vs140/postfix-increment-and-decrement-operators-----and---.md)|`++`|  
|[Postfix decrement](../vs140/postfix-increment-and-decrement-operators-----and---.md)|`––`|  
|[Type name](../vs140/typeid-operator.md)|`typeid( )`|  
|[Constant type conversion](../vs140/const_cast-operator.md)|`const_cast`|  
|[Dynamic type conversion](../vs140/dynamic_cast-operator.md)|`dynamic_cast`|  
|[Reinterpreted type conversion](../vs140/reinterpret_cast-operator.md)|`reinterpret_cast`|  
|[Static type conversion](../vs140/static_cast-operator.md)|`static_cast`|  
|`Group 3 precedence, right to left associativity`|  
|[Size of object or type](../vs140/sizeof-operator.md)|`sizeof`|  
|[Prefix increment](../vs140/prefix-increment-and-decrement-operators-----and---.md)|`++`|  
|[Prefix decrement](../vs140/prefix-increment-and-decrement-operators-----and---.md)|`––`|  
|[One's complement](../vs140/one-s-complement-operator--~.md)|`~`|  
|[Logical not](../vs140/logical-negation-operator--!.md)|`!`|  
|[Unary negation](../vs140/unary-negation-operator---.md)|`-`|  
|[Unary plus](../vs140/unary-plus-and-negation-operators----and--.md)|`+`|  
|[Address-of](../vs140/lvalue-reference-declarator---.md)|`&`|  
|[Indirection](../vs140/indirection-operator---.md)|`*`|  
|[Create object](../vs140/new-operator--c---.md)|`new`|  
|[Destroy object](../vs140/delete-operator--c---.md)|`delete`|  
|[Cast](../vs140/cast-operator----.md)|`Cast: ()`|  
|`Group 4 precedence, left to right associativity`|  
|[Pointer-to-member (objects or pointers)](../vs140/pointer-to-member-operators--.--and----.md)|`.* or –>*`|  
|`Group 5 precedence, left to right associativity`|  
|[Multiplication](../vs140/multiplicative-operators-and-the-modulus-operator.md)|`*`|  
|[Division](../vs140/multiplicative-operators-and-the-modulus-operator.md)|`/`|  
|[Modulus](../vs140/multiplicative-operators-and-the-modulus-operator.md)|`%`|  
|`Group 6 precedence, left to right associativity`|  
|[Addition](../vs140/additive-operators----and--.md)|`+`|  
|[Subtraction](../vs140/additive-operators----and--.md)|`–`|  
|`Group 7 precedence, left to right associativity`|  
|[Left shift](../vs140/left-shift-and-right-shift-operators-----and----.md)|`<<`|  
|[Right shift](../vs140/left-shift-and-right-shift-operators-----and----.md)|`>>`|  
|`Group 8 precedence, left to right associativity`|  
|[Less than](../vs140/relational-operators---------=--and--=.md)|`<`|  
|[Greater than](../vs140/relational-operators---------=--and--=.md)|`>`|  
|[Less than or equal to](../vs140/relational-operators---------=--and--=.md)|`<=`|  
|[Greater than or equal to](../vs140/relational-operators---------=--and--=.md)|`>=`|  
|`Group 9 precedence, left to right associativity`|  
|[Equality](../vs140/equality-operators--==-and-!=.md)|`==`|  
|[Inequality](../vs140/equality-operators--==-and-!=.md)|`!=`|  
|`Group 10 precedence left to right associativity`|  
|[Bitwise AND](../vs140/bitwise-and-operator---.md)|`&`|  
|`Group 11 precedence, left to right associativity`|  
|[Bitwise exclusive OR](../vs140/bitwise-exclusive-or-operator--^.md)|`^`|  
|`Group 12 precedence, left to right associativity`|  
|[Bitwise inclusive OR](../vs140/bitwise-inclusive-or-operator---.md)|`&#124;`|  
|`Group 13 precedence, left to right associativity`|  
|[Logical AND](../vs140/logical-and-operator----.md)|`&&`|  
|`Group 14 precedence, left to right associativity`|  
|[Logical OR](../vs140/logical-or-operator----.md)|`&#124;&#124;`|  
|`Group 15 precedence, right to left associativity`|  
|[Conditional](../vs140/conditional-operator-----.md)|`? :`|  
|`Group 16 precedence, right to left associativity`|  
|[Assignment](../vs140/assignment-operators.md)|`=`|  
|[Multiplication assignment](../vs140/assignment-operators.md)|`*=`|  
|[Division assignment](../vs140/assignment-operators.md)|`/=`|  
|[Modulus assignment](../vs140/assignment-operators.md)|`%=`|  
|[Addition assignment](../vs140/assignment-operators.md)|`+=`|  
|[Subtraction assignment](../vs140/assignment-operators.md)|`–=`|  
|[Left-shift assignment](../vs140/assignment-operators.md)|`<<=`|  
|[Right-shift assignment](../vs140/assignment-operators.md)|`>>=`|  
|[Bitwise AND assignment](../vs140/assignment-operators.md)|`&=`|  
|[Bitwise inclusive OR assignment](../vs140/assignment-operators.md)|`&#124;=`|  
|[Bitwise exclusive OR assignment](../vs140/assignment-operators.md)|`^=`|  
|`Group 17 precedence, right to left associativity`|  
|[throw expression](../vs140/try--throw--and-catch-statements--c---.md)|`throw`|  
|`Group 18 precedence, left to right associativity`|  
|[Comma](../vs140/comma-operator---.md)|`,`|  
  
## See Also  
 [C++ Operators](../vs140/c---operators.md)   
 [Operator Overloading](../vs140/operator-overloading.md)