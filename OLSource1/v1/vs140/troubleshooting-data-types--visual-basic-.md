---
title: "Troubleshooting Data Types (Visual Basic)"
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
  - "Char data type, converting"
  - "Decimal data type, conversions"
  - "data types [Visual Basic], troubleshooting"
  - "literals, default types"
  - "type characters, literal"
  - "Mod operator [Visual Basic], in floating-point operations"
  - "troubleshooting Visual Basic, data types"
  - "troubleshooting data types"
  - "floating-point numbers, precision"
  - "Boolean data type, converting"
  - "literal types"
  - "literal type characters"
  - "floating-point numbers, imprecision"
  - "String data type, converting"
  - "floating-point numbers, comparison"
  - "floating-point numbers"
ms.assetid: 90040d67-b630-4125-a6ae-37195b079042
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Data Types (Visual Basic)
This page lists some common problems that can occur when you perform operations on intrinsic data types.  
  
## Floating-Point Expressions Do Not Compare as Equal  
 When you work with floating-point numbers ([Single Data Type (Visual Basic)](../vs140/single-data-type--visual-basic-.md) and [Double Data Type (Visual Basic)](../vs140/double-data-type--visual-basic-.md)), remember that they are stored as binary fractions. This means they cannot hold an exact representation of any quantity that is not a binary fraction (of the form k / (2 ^ n) where k and n are integers). For example, 0.5 (= 1/2) and 0.3125 (= 5/16) can be held as precise values, whereas 0.2 (= 1/5) and 0.3 (= 3/10) can be only approximations.  
  
 Because of this imprecision, you cannot rely on exact results when you operate on floating-point values. In particular, two values that are theoretically equal might have slightly different representations.  
  
||  
|-|  
|To compare floating-point quantities|  
|1.  Calculate the absolute value of their difference by using the \<xref:System.Math.Abs*> method of the \<xref:System.Math*> class in the \<xref:System*> namespace.\<br />2.  Determine an acceptable maximum difference, such that you can consider the two quantities to be equal for practical purposes if their difference is no larger.\<br />3.  Compare the absolute value of the difference to the acceptable difference.|  
  
 The following example demonstrates both incorrect and correct comparison of two <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> values.  
  
 [!code[VbVbalrDataTypes#10](../vs140/codesnippet/VisualBasic/troubleshooting-data-types--visual-basic-_1.vb)]  
  
 The previous example uses the \<xref:System.Double.ToString*> method of the \<xref:System.Double*> structure so that it can specify better  precision than the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword uses. The default is 15 digits, but the "G17" format extends it to 17 digits.  
  
## Mod Operator Does Not Return Accurate Result  
 Because of the imprecision of floating-point storage, the [Mod Operator (Visual Basic)](../vs140/mod-operator--visual-basic-.md) can return an unexpected result when at least one of the operands is floating-point.  
  
 The [Decimal Data Type (Visual Basic)](../vs140/decimal-data-type--visual-basic-.md) does not use floating-point representation. Many numbers that are inexact in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are exact in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (for example 0.2 and 0.3). Although arithmetic is slower in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> than in floating-point, it might be worth the performance decrease to achieve better precision.  
  
||  
|-|  
|To find the integer remainder of floating-point quantities|  
|1.  Declare variables as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.\<br />2.  Use the literal type character <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to force literals to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, in case their values are too large for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> data type.|  
  
 The following example demonstrates the potential imprecision of floating-point operands.  
  
 [!code[VbVbalrDataTypes#11](../vs140/codesnippet/VisualBasic/troubleshooting-data-types--visual-basic-_2.vb)]  
  
 The previous example uses the \<xref:System.Double.ToString*> method of the \<xref:System.Double*> structure so that it can specify better precision than the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> keyword uses. The default is 15 digits, but the "G17" format extends it to 17 digits.  
  
 Because <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, its value for 0.2 is an infinitely repeating binary fraction with a stored value of 0.20000000000000001. Dividing 2.0 by this quantity yields 9.9999999999999995 with a remainder of 0.19999999999999991.  
  
 In the expression for <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the literal type character <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> forces both operands to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and 0.2 has a precise representation. Therefore the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> operator yields the expected remainder of 0.0.  
  
 Note that it is not sufficient to declare <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. You must also force the literals to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, or they use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> by default and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> receives the same inaccurate value as <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## Boolean Type Does Not Convert to Numeric Type Accurately  
 [Boolean Data Type (Visual Basic)](../vs140/boolean-data-type--visual-basic-.md) values are not stored as numbers, and the stored values are not intended to be equivalent to numbers. For compatibility with earlier versions, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides conversion keywords ([CType Function](../vs140/ctype-function--visual-basic-.md), <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, and so on) to convert between <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and numeric types. However, other languages sometimes perform these conversions differently, as do the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] methods.  
  
 You should never write code that relies on equivalent numeric values for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. Whenever possible, you should restrict usage of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> variables to the logical values for which they are designed. If you must mix <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and numeric values, make sure that you understand the conversion method that you select.  
  
### Conversion in Visual Basic  
 When you use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> conversion keywords to convert numeric data types to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, 0 becomes <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and all other values become <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. When you convert <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> values to numeric types by using the conversion keywords, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> becomes 0 and <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> becomes -1.  
  
### Conversion in the Framework  
 The \<xref:System.Convert.ToInt32*> method of the \<xref:System.Convert*> class in the \<xref:System*> namespace converts <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to +1.  
  
 If you must convert a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> value to a numeric data type, be careful about which conversion method you use.  
  
## Character Literal Generates Compiler Error  
 In the absence of any type characters, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] assumes default data types for literals. The default type for a character literal — enclosed in quotation marks (<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>) — is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> data type does not widen to the [Char Data Type (Visual Basic)](../vs140/char-data-type--visual-basic-.md). This means that if you want to assign a literal to a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> variable, you must either make a narrowing conversion or force the literal to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> type.  
  
||  
|-|  
|To create a Char literal to assign to a variable or constant|  
|1.  Declare the variable or constant as <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.\<br />2.  Enclose the character value in quotation marks (<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>).\<br />3.  Follow the closing double quotation mark with the literal type character <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to force the literal to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. This is necessary if the type checking switch ([Option Strict Statement](../vs140/option-strict-statement.md)) is <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, and it is desirable in any case.|  
  
 The following example demonstrates both unsuccessful and successful assignments of a literal to a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> variable.  
  
 [!CODE [VbVbalrStatements#49](../CodeSnippet/VS_Snippets_VBCSharp/VbVbalrStatements#49)]  
  
 [!code[VbVbalrDataTypes#12](../vs140/codesnippet/VisualBasic/troubleshooting-data-types--visual-basic-_4.vb)]  
  
 There is always a risk in using narrowing conversions, because they can fail at run time. For example, a conversion from <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> can fail if the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> value contains more than one character. Therefore, it is better programming to use the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> type character.  
  
## String Conversion Fails at Run Time  
 The [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md) participates in very few widening conversions. <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> widens only to itself and <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, and only <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> (a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> array) widen to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. This is because <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> variables and constants can contain values that other data types cannot contain.  
  
 When the type checking switch ([Option Strict Statement](../vs140/option-strict-statement.md)) is <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, the compiler disallows all implicit narrowing conversions. This includes those involving <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. Your code can still use conversion keywords such as <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and [CType Function](../vs140/ctype-function--visual-basic-.md), which direct the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] to attempt the conversion.  
  
> [!NOTE]
>  The narrowing-conversion error is suppressed for conversions from the elements in a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> collection to the loop control variable. For more information and examples, see the "Narrowing Conversions" section in [For Each…Next Statement](../vs140/for-each...next-statement--visual-basic-.md).  
  
### Narrowing Conversion Protection  
 The disadvantage of narrowing conversions is that they can fail at run time. For example, if a <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> variable contains anything other than "True" or "False," it cannot be converted to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>. If it contains punctuation characters, conversion to any numeric type fails. Unless you know that your <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> variable always holds values that the destination type can accept, you should not try a conversion.  
  
 If you must convert from <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> to another data type, the safest procedure is to enclose the attempted conversion in the [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md). This lets you deal with a run-time failure.  
  
### Character Arrays  
 A single <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> and an array of <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> elements both widen to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. However, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> does not widen to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. To convert a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> value to a <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> array, you can use the \<xref:System.String.ToCharArray*> method of the \<xref:System.String*?displayProperty=fullName> class.  
  
### Meaningless Values  
 In general, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> values are not meaningful in other data types, and conversion is highly artificial and dangerous. Whenever possible, you should restrict usage of <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> variables to the character sequences for which they are designed. You should never write code that relies on equivalent values in other types.  
  
## See Also  
 [Data Types in Visual Basic](../vs140/data-types-in-visual-basic.md)   
 [Type Characters](../vs140/type-characters--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Efficient Use of Data Types](../vs140/efficient-use-of-data-types--visual-basic-.md)