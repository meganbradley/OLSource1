---
title: "Arithmetic Operators (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "operators [F#], comparison"
  - "+ operator [F#]"
  - "> operator [F#]"
  - "<> operator [F#]"
  - "= operator [F#]"
  - ">= operator [F#]"
  - "< operator [F#]"
  - "<= operator [F#]"
  - "arithmetic operators [F#]"
  - "/ operator [F#]"
  - "operators [F#], arithmetic"
  - "% operator [F#]"
  - "** operator [F#]"
  - "- operator [F#]"
  - "* operator [F#]"
ms.assetid: 93e38e45-c0f1-4e62-a130-b0399b3ab45a
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arithmetic Operators (F#)
This topic describes arithmetic operators that are available in the F# language.  
  
## Summary of Binary Arithmetic Operators  
 The following table summarizes the binary arithmetic operators that are available for unboxed integral and floating-point types.  
  
|Binary operator|Notes|  
|---------------------|-----------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> (addition, plus)|Unchecked. Possible overflow condition when numbers are added together and the sum exceeds the maximum absolute value supported by the type.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (subtraction, minus)|Unchecked. Possible underflow condition when unsigned types are subtracted, or when floating-point values are too small to be represented by the type.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (multiplication, times)|Unchecked. Possible overflow condition when numbers are multiplied and the product exceeds the maximum absolute value supported by the type.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (division, divided by)|Division by zero causes a \<xref:System.DivideByZeroException*> for integral types. For floating-point types, division by zero gives you the special floating-point values <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. There is also a possible underflow condition when a floating-point number is too small to be represented by the type.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (modulus, mod)|Returns the remainder of a division operation. The sign of the result is the same as the sign of the first operand.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> (exponentiation, to the power of)|Possible overflow condition when the result exceeds the maximum absolute value for the type.\<br />\<br /> The exponentiation operator works only with floating-point types.|  
  
## Summary of Unary Arithmetic Operators  
 The following table summarizes the unary arithmetic operators that are available for integral and floating-point types.  
  
|Unary operator|Notes|  
|--------------------|-----------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (positive)|Can be applied to any arithmetic expression. Does not change the sign of the value.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (negation, negative)|Can be applied to any arithmetic expression. Changes the sign of the value.|  
  
 The behavior at overflow or underflow for integral types is to wrap around. This causes an incorrect result. Integer overflow is a potentially serious problem that can contribute to security issues when software is not written to account for it. If this is a concern for your application, consider using the checked operators in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Summary of Binary Comparison Operators  
 The following table shows the binary comparison operators that are available for integral and floating-point types. These operators return values of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 Floating-point numbers should never be directly compared for equality, because the IEEE floating-point representation does not support an exact equality operation. Two numbers that you can easily verify to be equal by inspecting the code might actually have different bit representations.  
  
|Operator|Notes|  
|--------------|-----------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (equality, equals)|This is not an assignment operator. It is used only for comparison. This is a generic operator.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (greater than)|This is a generic operator.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (less than)|This is a generic operator.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> (greater than or equals)|This is a generic operator.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> (less than or equals)|This is a generic operator.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (not equal)|This is a generic operator.|  
  
## Overloaded and Generic Operators  
 All of the operators discussed in this topic are defined in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> namespace. Some of the operators are defined by using statically resolved type parameters. This means that there are individual definitions for each specific type that works with that operator. All of the unary and binary arithmetic and bitwise operators are in this category. The comparison operators are generic and therefore work with any type, not just primitive arithmetic types. Discriminated union and record types have their own custom implementations that are generated by the F# compiler. Class types use the method \<xref:System.Object.Equals*>.  
  
 The generic operators are customizable. To customize the comparison functions, override \<xref:System.Object.Equals*> to provide your own custom equality comparison, and then implement \<xref:System.IComparable*>. The \<xref:System.IComparable*> interface has a single method, the \<xref:System.IComparable.CompareTo*> method.  
  
## Operators and Type Inference  
 The use of an operator in an expression constrains type inference on that operator. Also, the use of operators prevents automatic generalization, because the use of operators implies an arithmetic type. In the absence of any other information, the F# compiler infers <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> as the type of arithmetic expressions. You can override this behavior by specifying another type. Thus the argument types and return type of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in the following code are inferred to be <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, but the types for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are inferred to be <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 [!code[FsLangRef1#3501](../vs140/codesnippet/FSharp/arithmetic-operators--fsharp-_1.fs)]  
  
## See Also  
 [Symbol and Operator Reference](../vs140/symbol-and-operator-reference--fsharp-.md)   
 [Operator Overloading](../vs140/operator-overloading--fsharp-.md)   
 [Bitwise Operators](../vs140/bitwise-operators--fsharp-.md)   
 [Boolean Operators](../vs140/boolean-operators--fsharp-.md)