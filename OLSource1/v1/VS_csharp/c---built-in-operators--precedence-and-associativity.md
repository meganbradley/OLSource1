---
title: "C++ Built-in Operators, Precedence and Associativity"
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
  - "operators (C++), hierarchy"
  - "operator precedence"
  - "precedence, operators"
  - "operators (C++), associativity"
  - "multiple operators"
  - "associativity of operators"
  - "operators [C++], precedence"
  - "evaluation order"
  - "hierarchy, operator"
ms.assetid: 95c1f0ba-dad8-4034-b039-f79a904f112f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C++ Built-in Operators, Precedence and Associativity
The C++ language includes all C operators and adds several new operators. Operators specify an evaluation to be performed on one or more operands.  
  
 Operator precedence specifies the order of operations in expressions that contain more than one operator. Operator associativity specifies whether, in an expression that contains multiple operators with the same precedence, an operand is grouped with the one on its left or the one on its right. The following table shows the precedence and associativity of C++ operators (from highest to lowest precedence). Operators with the same precedence number have equal precedence unless another relationship is explicitly forced by parentheses.  
  
### C++ Operator Precedence and Associativity  
  
|Operator Description|Operator|  
|--------------------------|--------------|  
|`Group 1 precedence, no associativity`|  
|[Scope resolution](../VS_csharp/scope-resolution-operator----.md)|`::`|  
|`Group 2 precedence, left to right associativity`|  
|[Member selection (object or pointer)](../VS_csharp/member-access-operators--.-and---.md)|`. or –>`|  
|[Array subscript](../VS_csharp/subscript-operator-.md)|`[ ]`|  
|[Function call](../VS_csharp/function-call-operator----.md)|`( )`|  
|[Postfix increment](../VS_csharp/postfix-increment-and-decrement-operators-----and---.md)|`++`|  
|[Postfix decrement](../VS_csharp/postfix-increment-and-decrement-operators-----and---.md)|`––`|  
|[Type name](../VS_csharp/typeid-operator.md)|`typeid( )`|  
|[Constant type conversion](../VS_csharp/const_cast-operator.md)|`const_cast`|  
|[Dynamic type conversion](../VS_csharp/dynamic_cast-operator.md)|`dynamic_cast`|  
|[Reinterpreted type conversion](../VS_csharp/reinterpret_cast-operator.md)|`reinterpret_cast`|  
|[Static type conversion](../VS_csharp/static_cast-operator.md)|`static_cast`|  
|`Group 3 precedence, right to left associativity`|  
|[Size of object or type](../VS_csharp/sizeof-operator.md)|`sizeof`|  
|[Prefix increment](../VS_csharp/prefix-increment-and-decrement-operators-----and---.md)|`++`|  
|[Prefix decrement](../VS_csharp/prefix-increment-and-decrement-operators-----and---.md)|`––`|  
|[One's complement](../VS_csharp/one-s-complement-operator--~.md)|`~`|  
|[Logical not](../VS_csharp/logical-negation-operator--!.md)|`!`|  
|[Unary negation](../Topic/Unary%20Negation%20Operator:%20-.md)|`-`|  
|[Unary plus](../VS_csharp/unary-plus-and-negation-operators----and--.md)|`+`|  
|[Address-of](../VS_csharp/lvalue-reference-declarator---.md)|`&`|  
|[Indirection](../VS_csharp/indirection-operator---.md)|`*`|  
|[Create object](../VS_csharp/new-operator--c---.md)|`new`|  
|[Destroy object](../VS_csharp/delete-operator--c---.md)|`delete`|  
|[Cast](../VS_csharp/cast-operator----.md)|`Cast: ()`|  
|`Group 4 precedence, left to right associativity`|  
|[Pointer-to-member (objects or pointers)](../VS_csharp/pointer-to-member-operators--.--and----.md)|`.* or –>*`|  
|`Group 5 precedence, left to right associativity`|  
|[Multiplication](../VS_csharp/multiplicative-operators-and-the-modulus-operator.md)|`*`|  
|[Division](../VS_csharp/multiplicative-operators-and-the-modulus-operator.md)|`/`|  
|[Modulus](../VS_csharp/multiplicative-operators-and-the-modulus-operator.md)|`%`|  
|`Group 6 precedence, left to right associativity`|  
|[Addition](../VS_csharp/additive-operators----and--.md)|`+`|  
|[Subtraction](../VS_csharp/additive-operators----and--.md)|`–`|  
|`Group 7 precedence, left to right associativity`|  
|[Left shift](../VS_csharp/left-shift-and-right-shift-operators-----and----.md)|`<<`|  
|[Right shift](../VS_csharp/left-shift-and-right-shift-operators-----and----.md)|`>>`|  
|`Group 8 precedence, left to right associativity`|  
|[Less than](../VS_csharp/relational-operators---------=--and--=.md)|`<`|  
|[Greater than](../VS_csharp/relational-operators---------=--and--=.md)|`>`|  
|[Less than or equal to](../VS_csharp/relational-operators---------=--and--=.md)|`<=`|  
|[Greater than or equal to](../VS_csharp/relational-operators---------=--and--=.md)|`>=`|  
|`Group 9 precedence, left to right associativity`|  
|[Equality](../VS_csharp/equality-operators--==-and-!=.md)|`==`|  
|[Inequality](../VS_csharp/equality-operators--==-and-!=.md)|`!=`|  
|`Group 10 precedence left to right associativity`|  
|[Bitwise AND](../VS_csharp/bitwise-and-operator---.md)|`&`|  
|`Group 11 precedence, left to right associativity`|  
|[Bitwise exclusive OR](../VS_csharp/bitwise-exclusive-or-operator--^.md)|`^`|  
|`Group 12 precedence, left to right associativity`|  
|[Bitwise inclusive OR](../VS_csharp/bitwise-inclusive-or-operator---.md)|`&#124;`|  
|`Group 13 precedence, left to right associativity`|  
|[Logical AND](../VS_csharp/logical-and-operator----.md)|`&&`|  
|`Group 14 precedence, left to right associativity`|  
|[Logical OR](../VS_csharp/logical-or-operator----.md)|`&#124;&#124;`|  
|`Group 15 precedence, right to left associativity`|  
|[Conditional](../VS_csharp/conditional-operator-----.md)|`? :`|  
|`Group 16 precedence, right to left associativity`|  
|[Assignment](../VS_csharp/assignment-operators.md)|`=`|  
|[Multiplication assignment](../VS_csharp/assignment-operators.md)|`*=`|  
|[Division assignment](../VS_csharp/assignment-operators.md)|`/=`|  
|[Modulus assignment](../VS_csharp/assignment-operators.md)|`%=`|  
|[Addition assignment](../VS_csharp/assignment-operators.md)|`+=`|  
|[Subtraction assignment](../VS_csharp/assignment-operators.md)|`–=`|  
|[Left-shift assignment](../VS_csharp/assignment-operators.md)|`<<=`|  
|[Right-shift assignment](../VS_csharp/assignment-operators.md)|`>>=`|  
|[Bitwise AND assignment](../VS_csharp/assignment-operators.md)|`&=`|  
|[Bitwise inclusive OR assignment](../VS_csharp/assignment-operators.md)|`&#124;=`|  
|[Bitwise exclusive OR assignment](../VS_csharp/assignment-operators.md)|`^=`|  
|`Group 17 precedence, right to left associativity`|  
|[throw expression](../VS_csharp/try--throw--and-catch-statements--c---.md)|`throw`|  
|`Group 18 precedence, left to right associativity`|  
|[Comma](../VS_csharp/comma-operator---.md)|`,`|  
  
## See Also  
 [C++ Operators](../Topic/C++%20Operators.md)   
 [Operator Overloading](../VS_csharp/operator-overloading.md)