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
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|  
|[Scope resolution](../vs140/scope-resolution-operator----.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|[Member selection (object or pointer)](../vs140/member-access-operators--.-and---.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|[Array subscript](../vs140/subscript-operator-.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|[Function call](../vs140/function-call-operator----.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|[Postfix increment](../vs140/postfix-increment-and-decrement-operators-----and---.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|[Postfix decrement](../vs140/postfix-increment-and-decrement-operators-----and---.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|[Type name](../vs140/typeid-operator.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|[Constant type conversion](../vs140/const_cast-operator.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|[Dynamic type conversion](../vs140/dynamic_cast-operator.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|[Reinterpreted type conversion](../vs140/reinterpret_cast-operator.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|[Static type conversion](../vs140/static_cast-operator.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|[Size of object or type](../vs140/sizeof-operator.md)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|[Prefix increment](../vs140/prefix-increment-and-decrement-operators-----and---.md)|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|[Prefix decrement](../vs140/prefix-increment-and-decrement-operators-----and---.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|[One's complement](../vs140/one-s-complement-operator--~.md)|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|[Logical not](../vs140/logical-negation-operator--!.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|[Unary negation](../vs140/unary-negation-operator---.md)|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|[Unary plus](../vs140/unary-plus-and-negation-operators----and--.md)|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|[Address-of](../vs140/lvalue-reference-declarator---.md)|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|[Indirection](../vs140/indirection-operator---.md)|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|[Create object](../vs140/new-operator--c---.md)|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|[Destroy object](../vs140/delete-operator--c---.md)|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|[Cast](../vs140/cast-operator----.md)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|[Pointer-to-member (objects or pointers)](../vs140/pointer-to-member-operators--.--and----.md)|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|[Multiplication](../vs140/multiplicative-operators-and-the-modulus-operator.md)|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|[Division](../vs140/multiplicative-operators-and-the-modulus-operator.md)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|[Modulus](../vs140/multiplicative-operators-and-the-modulus-operator.md)|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|[Addition](../vs140/additive-operators----and--.md)|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
|[Subtraction](../vs140/additive-operators----and--.md)|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|[Left shift](../vs140/left-shift-and-right-shift-operators-----and----.md)|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|[Right shift](../vs140/left-shift-and-right-shift-operators-----and----.md)|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
|[Less than](../vs140/relational-operators---------=--and--=.md)|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|[Greater than](../vs140/relational-operators---------=--and--=.md)|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|[Less than or equal to](../vs140/relational-operators---------=--and--=.md)|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|  
|[Greater than or equal to](../vs140/relational-operators---------=--and--=.md)|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|[Equality](../vs140/equality-operators--==-and-!=.md)|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|[Inequality](../vs140/equality-operators--==-and-!=.md)|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|  
|[Bitwise AND](../vs140/bitwise-and-operator---.md)|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|[Bitwise exclusive OR](../vs140/bitwise-exclusive-or-operator--^.md)|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|[Bitwise inclusive OR](../vs140/bitwise-inclusive-or-operator---.md)|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|[Logical AND](../vs140/logical-and-operator----.md)|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|[Logical OR](../vs140/logical-or-operator----.md)|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|  
|[Conditional](../vs140/conditional-operator-----.md)|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|[Assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
|[Multiplication assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
|[Division assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
|[Modulus assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|[Addition assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
|[Subtraction assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|  
|[Left-shift assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|  
|[Right-shift assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|[Bitwise AND assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|  
|[Bitwise inclusive OR assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|  
|[Bitwise exclusive OR assignment](../vs140/assignment-operators.md)|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|  
|[throw expression](../vs140/try--throw--and-catch-statements--c---.md)|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|  
|[Comma](../vs140/comma-operator---.md)|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|  
  
## See Also  
 [C++ Operators](../vs140/c---operators.md)   
 [Operator Overloading](../vs140/operator-overloading.md)