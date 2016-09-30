---
title: "Logical and Bitwise Operators in Visual Basic"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "short-circuiting"
  - "Boolean expressions"
  - "logical operators, Boolean expressions"
  - "operators [Visual Basic], logical"
  - "AndAlso operator"
  - "Not operator [Visual Basic], Boolean expressions"
  - "Xor operator [Visual Basic], Boolean expressions"
  - "And operator [Visual Basic], logical operators"
  - "logical operators"
  - "expressions [Visual Basic], Boolean"
  - "Or operator, logical operators"
  - "Visual Basic code, operators"
  - "short-circuiting, logical operators"
  - "logical operators, short-circuiting"
  - "Visual Basic code, expressions"
  - "logical operators, binary"
  - "OrElse operator [Visual Basic]"
  - "logical operators, unary"
ms.assetid: ca474e13-567d-4b1d-a18b-301433705e57
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Logical and Bitwise Operators in Visual Basic
Logical operators compare <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> expressions and return a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> result. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> operators are *binary* because they take two operands, while the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator is *unary* because it takes a single operand. Some of these operators can also perform bitwise logical operations on integral values.  
  
## Unary Logical Operator  
 The [Not Operator (Visual Basic)](../vs140/not-operator--visual-basic-.md) performs logical *negation* on a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expression. It yields the logical opposite of its operand. If the expression evaluates to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; if the expression evaluates to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The following example illustrates this.  
  
 [!code[VbVbalrOperators#77](../vs140/codesnippet/VisualBasic/logical-and-bitwise-operators-in-visual-basic_1.vb)]  
  
## Binary Logical Operators  
 The [And Operator (Visual Basic)](../vs140/and-operator--visual-basic-.md) performs logical *conjunction* on two <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> expressions. If both expressions evaluate to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. If at least one of the expressions evaluates to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The [Or Operator (Visual Basic)](../vs140/or-operator--visual-basic-.md) performs logical *disjunction* or *inclusion* on two <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> expressions. If either expression evaluates to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, or both evaluate to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, then <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If neither expression evaluates to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 The [Xor Operator (Visual Basic)](../vs140/xor-operator--visual-basic-.md) performs logical *exclusion* on two <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> expressions. If exactly one expression evaluates to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, but not both, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. If both expressions evaluate to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or both evaluate to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 The following example illustrates the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> operators.  
  
 [!code[VbVbalrOperators#78](../vs140/codesnippet/VisualBasic/logical-and-bitwise-operators-in-visual-basic_2.vb)]  
  
## Short-Circuiting Logical Operations  
 The [AndAlso Operator](../vs140/andalso-operator--visual-basic-.md) is very similar to the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> operator, in that it also performs logical conjunction on two <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> expressions. The key difference between the two is that <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> exhibits *short-circuiting* behavior. If the first expression in an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> expression evaluates to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, then the second expression is not evaluated because it cannot alter the final result, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 Similarly, the [OrElse Operator](../vs140/orelse-operator--visual-basic-.md) performs short-circuiting logical disjunction on two <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> expressions. If the first expression in an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> expression evaluates to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, then the second expression is not evaluated because it cannot alter the final result, and <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Short-Circuiting Trade-Offs  
 Short-circuiting can improve performance by not evaluating an expression that cannot alter the result of the logical operation. However, if that expression performs additional actions, short-circuiting skips those actions. For example, if the expression includes a call to a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> procedure, that procedure is not called if the expression is short-circuited, and any additional code contained in the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> does not run. Therefore, the function might run only occasionally, and might not be tested correctly. Or the program logic might depend on the code in the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
 The following example illustrates the difference between <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, and their short-circuiting counterparts.  
  
 [!code[VbVbalrOperators#81](../vs140/codesnippet/VisualBasic/logical-and-bitwise-operators-in-visual-basic_3.vb)]  
  
 [!code[VbVbalrOperators#80](../vs140/codesnippet/VisualBasic/logical-and-bitwise-operators-in-visual-basic_4.vb)]  
  
 [!code[VbVbalrOperators#79](../vs140/codesnippet/VisualBasic/logical-and-bitwise-operators-in-visual-basic_5.vb)]  
  
 In the preceding example, note that some important code inside <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> does not run when the call is short-circuited. The first <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> statement calls <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> even though <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, because <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> does not short-circuit. The second <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> statement does not call <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, because when <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> short-circuits the second expression. The third <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> statement calls <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> even though <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, because <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> does not short-circuit. The fourth <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> statement does not call <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, because when <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> short-circuits the second expression.  
  
## Bitwise Operations  
 Bitwise operations evaluate two integral values in binary (base 2) form. They compare the bits at corresponding positions and then assign values based on the comparison. The following example illustrates the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> operator.  
  
 [!code[VbVbalrConcepts#2](../vs140/codesnippet/VisualBasic/logical-and-bitwise-operators-in-visual-basic_6.vb)]  
  
 The preceding example sets the value of <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to 1. This happens for the following reasons:  
  
-   The values are treated as binary:  
  
     3 in binary form = 011  
  
     5 in binary form = 101  
  
-   The <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> operator compares the binary representations, one binary position (bit) at a time. If both bits at a given position are 1, then a 1 is placed in that position in the result. If either bit is 0, then a 0 is placed in that position in the result. In the preceding example this works out as follows:  
  
     011 (3 in binary form)  
  
     101 (5 in binary form)  
  
     001 (The result, in binary form)  
  
-   The result is treated as decimal. The value 001 is the binary representation of 1, so <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> = 1.  
  
 The bitwise <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> operation is similar, except that a 1 is assigned to the result bit if either or both of the compared bits is 1. <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> assigns a 1 to the result bit if exactly one of the compared bits (not both) is 1. <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> takes a single operand and inverts all the bits, including the sign bit, and assigns that value to the result. This means that for signed positive numbers, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> always returns a negative value, and for negative numbers, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> always returns a positive or zero value.  
  
 The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> operators do not support bitwise operations.  
  
> [!NOTE]
>  Bitwise operations can be performed on integral types only. Floating-point values must be converted to integral types before bitwise operation can proceed.  
  
## See Also  
 [Logical/Bitwise Operators (Visual Basic)](../vs140/logical-bitwise-operators--visual-basic-.md)   
 [Boolean Expressions](../vs140/boolean-expressions--visual-basic-.md)   
 [Arithmetic Operators in Visual Basic](../vs140/arithmetic-operators-in-visual-basic.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)   
 [Concatenation Operators in Visual Basic](../vs140/concatenation-operators-in-visual-basic.md)   
 [Efficient Combination of Operators](../vs140/efficient-combination-of-operators--visual-basic-.md)