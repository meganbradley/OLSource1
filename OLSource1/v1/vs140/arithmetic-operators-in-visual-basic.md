---
title: "Arithmetic Operators in Visual Basic"
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
  - "type safety"
  - "operators [Visual Basic], bitwise"
  - "operators [Visual Basic], bit-shift"
  - "bitwise operators"
  - "bit-shift operators"
  - "zero, division by zero"
  - "operators [Visual Basic], arithmetic"
  - "division, by zero"
  - "Visual Basic code, operators"
  - "arithmetic operators, about arithmetic operators"
ms.assetid: 325dac7a-ea4f-41d5-8b48-f6e904211569
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arithmetic Operators in Visual Basic
Arithmetic operators are used to perform many of the familiar arithmetic operations that involve the calculation of numeric values represented by literals, variables, other expressions, function and property calls, and constants. Also classified with arithmetic operators are the bit-shift operators, which act at the level of the individual bits of the operands and shift their bit patterns to the left or right.  
  
## Arithmetic Operations  
 You can add two values in an expression together with the [+ Operator (Visual Basic)](../vs140/--operator--visual-basic-.md), or subtract one from another with the [- Operator (Visual Basic)](../vs140/--operator--visual-basic-1.md), as the following example demonstrates.  
  
 [!code[VbVbalrOperators#57](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_1.vb)]  
  
 Negation also uses the [- Operator (Visual Basic)](../vs140/--operator--visual-basic-1.md), but with only one operand, as the following example demonstrates.  
  
 [!code[VbVbalrOperators#58](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_2.vb)]  
  
 Multiplication and division use the [* Operator (Visual Basic)](../vs140/--operator--visual-basic-.md) and [/ Operator (Visual Basic)](../vs140/--operator--visual-basic-3.md), respectively, as the following example demonstrates.  
  
 [!code[VbVbalrOperators#59](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_3.vb)]  
  
 Exponentiation uses the [^ Operator](../vs140/^-operator--visual-basic-.md), as the following example demonstrates.  
  
 [!code[VbVbalrOperators#60](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_4.vb)]  
  
 Integer division is carried out using the [\ Operator](../vs140/--operator--visual-basic-2.md). Integer division returns the quotient, that is, the integer that represents the number of times the divisor can divide into the dividend without consideration of any remainder. Both the divisor and the dividend must be integral types (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) for this operator. All other types must be converted to an integral type first. The following example demonstrates integer division.  
  
 [!code[VbVbalrOperators#61](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_5.vb)]  
  
 Modulus arithmetic is performed using the [Mod Operator (Visual Basic)](../vs140/mod-operator--visual-basic-.md). This operator returns the remainder after dividing the divisor into the dividend an integral number of times. If both divisor and dividend are integral types, the returned value is integral. If divisor and dividend are floating-point types, the returned value is also floating-point. The following example demonstrates this behavior.  
  
 [!code[VbVbalrOperators#62](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_6.vb)]  
  
 [!code[VbVbalrOperators#63](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_7.vb)]  
  
### Attempted Division by Zero  
 Division by zero has different results depending on the data types involved. In integral divisions (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] throws a \<xref:System.DivideByZeroException*> exception. In division operations on the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> data type, the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] also throws a \<xref:System.DivideByZeroException*> exception.  
  
 In floating-point divisions involving the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data type, no exception is thrown, and the result is the class member representing \<xref:System.Double.NaN*>, \<xref:System.Double.PositiveInfinity*>, or \<xref:System.Double.NegativeInfinity*>, depending on the dividend. The following table summarizes the various results of attempting to divide a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value by zero.  
  
|||||  
|-|-|-|-|  
|Dividend data type|Divisor data type|Dividend value|Result|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|0|\<xref:System.Double.NaN*> (not a mathematically defined number)|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|> 0|\<xref:System.Double.PositiveInfinity*>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|< 0|\<xref:System.Double.NegativeInfinity*>|  
  
 When you catch a \<xref:System.DivideByZeroException*> exception, you can use its members to help you handle it. For example, the \<xref:System.Exception.Message*> property holds the message text for the exception. For more information, see [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md).  
  
## Bit-Shift Operations  
 A bit-shift operation performs an arithmetic shift on a bit pattern. The pattern is contained in the operand on the left, while the operand on the right specifies the number of positions to shift the pattern. You can shift the pattern to the right with the [>> Operator (Visual Basic)](../vs140/---operator--visual-basic-.md) or to the left with the [<< Operator (Visual Basic)](../vs140/---operator--visual-basic-.md).  
  
 The data type of the pattern operand must be <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The data type of the shift amount operand must be <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> or must widen to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 Arithmetic shifts are not circular, which means the bits shifted off one end of the result are not reintroduced at the other end. The bit positions vacated by a shift are set as follows:  
  
-   0 for an arithmetic left shift  
  
-   0 for an arithmetic right shift of a positive number  
  
-   0 for an arithmetic right shift of an unsigned data type (<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>)  
  
-   1 for an arithmetic right shift of a negative number (<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>)  
  
 The following example shifts an <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value both left and right.  
  
 [!code[VbVbalrOperators#64](../vs140/codesnippet/VisualBasic/arithmetic-operators-in-visual-basic_8.vb)]  
  
 Arithmetic shifts never generate overflow exceptions.  
  
## Bitwise Operations  
 In addition to being logical operators, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> also perform bitwise arithmetic when used on numeric values. For more information, see "Bitwise Operations" in [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md).  
  
## Type Safety  
 Operands should normally be of the same type. For example, if you are doing addition with an <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> variable, you should add it to another <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> variable, and you should assign the result to a variable of type <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> as well.  
  
 One way to ensure good type-safe coding practice is to use the [Option Strict Statement](../vs140/option-strict-statement.md). If you set <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] automatically performs *type-safe* conversions. For example, if you try to add an <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> variable to a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> variable and assign the value to a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> variable, the operation proceeds normally, because an <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> value can be converted to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> without loss of data. Type-unsafe conversions, on the other hand, cause a compiler error with <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. For example, if you try to add an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> variable to a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> variable and assign the value to an <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> variable, a compiler error results, because a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> variable cannot be implicitly converted to type <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 If you set <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, however, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] allows implicit narrowing conversions to take place, although they can result in the unexpected loss of data or precision. For this reason, we recommend that you use <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> when writing production code. For more information, see [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md).  
  
## See Also  
 [Arithmetic Operators](../vs140/arithmetic-operators--visual-basic-.md)   
 [Bit Shift Operators](../vs140/bit-shift-operators--visual-basic-.md)   
 [Comparison Operators in Visual Basic](../vs140/comparison-operators-in-visual-basic.md)   
 [Concatenation Operators in Visual Basic](../vs140/concatenation-operators-in-visual-basic.md)   
 [Logical and Bitwise Operators in Visual Basic](../vs140/logical-and-bitwise-operators-in-visual-basic.md)   
 [Efficient Combination of Operators](../vs140/efficient-combination-of-operators--visual-basic-.md)