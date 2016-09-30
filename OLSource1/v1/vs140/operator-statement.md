---
title: "Operator Statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.operator"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "operators [Visual Basic]"
  - "procedures, operator"
  - "Narrowing keyword, conversion operators"
  - "Visual Basic code, operators"
  - "Widening keyword, conversion operators"
  - "syntax, Operator procedures"
  - "operators [Visual Basic], overloading"
  - "overloaded operators"
  - "operator overloading"
  - "operator procedures"
  - "Operator statement"
  - "CType function, Operator statement"
ms.assetid: b12ec4af-1ad7-4a17-865b-c5ee96320ae5
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator Statement
Declares the operator symbol, operands, and code that define an operator procedure on a class or structure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Optional. See [Attribute List](../vs140/attribute-list--visual-basic-.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Required. Indicates that this operator procedure has [Public (Visual Basic)](../vs140/public--visual-basic-.md) access.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Optional. See [Overloads](../vs140/overloads--visual-basic-.md).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Required. Indicates that this operator procedure is a [Shared (Visual Basic)](../vs140/shared--visual-basic-.md) procedure.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Optional. See [Shadows](../vs140/shadows--visual-basic-.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Required for a conversion operator unless you specify <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Indicates that this operator procedure defines a [Widening](../vs140/widening--visual-basic-.md) conversion. See "Widening and Narrowing Conversions" on this Help page.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Required for a conversion operator unless you specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Indicates that this operator procedure defines a [Narrowing](../vs140/narrowing--visual-basic-.md) conversion. See "Widening and Narrowing Conversions" on this Help page.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Required. The symbol or identifier of the operator that this operator procedure defines.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Required. The name and type of the single operand of a unary operator (including a conversion operator) or the left operand of a binary operator.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Required for binary operators. The name and type of the right operand of a binary operator.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> have the following syntax and parts:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
|Part|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Optional, but the passing mechanism must be [ByVal](../vs140/byval--visual-basic-.md).|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Required. Name of the variable representing this operand. See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional unless <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Data type of this operand.|  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Optional unless <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Data type of the value the operator procedure returns.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Optional. Block of statements that the operator procedure runs.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Required. The value that the operator procedure returns to the calling code.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Required. Terminates the definition of this operator procedure.  
  
## Remarks  
 You can use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> only in a class or structure. This means the *declaration context* for an operator cannot be a source file, namespace, module, interface, procedure, or block. For more information, see [Declaration Contexts and Default Access Levels](../vs140/declaration-contexts-and-default-access-levels--visual-basic-.md).  
  
 All operators must be <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. You cannot specify <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> for either operand.  
  
 You cannot use the operator symbol or identifier to hold a return value. You must use the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> statement, and it must specify a value. Any number of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> statements can appear anywhere in the procedure.  
  
 Defining an operator in this way is called *operator overloading*, whether or not you use the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> keyword. The following table lists the operators you can define.  
  
|Type|Operators|  
|----------|---------------|  
|Unary|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|Binary|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|  
|Conversion (unary)|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|  
  
 Note that the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> operator in the binary list is the comparison operator, not the assignment operator.  
  
 When you define <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, you must specify either <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
## Matched Pairs  
 You must define certain operators as matched pairs. If you define either operator of such a pair, you must define the other as well. The matched pairs are the following:  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
  
## Data Type Restrictions  
 Every operator you define must involve the class or structure on which you define it. This means that the class or structure must appear as the data type of the following:  
  
-   The operand of a unary operator.  
  
-   At least one of the operands of a binary operator.  
  
-   Either the operand or the return type of a conversion operator.  
  
 Certain operators have additional data type restrictions, as follows:  
  
-   If you define the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> operators, they must both return the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> type.  
  
-   If you define the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> operators, they must both specify the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> type for the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 The return type does not have to correspond to the type of either operand. For example, a comparison operator such as <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> can return <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> even if neither operand is <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
## Logical and Bitwise Operators  
 The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> operators can perform either logical or bitwise operations in Visual Basic. However, if you define one of these operators on a class or structure, you can define only its bitwise operation.  
  
 You cannot define the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> operator directly with an <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> statement. However, you can use <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> if you have fulfilled the following conditions:  
  
-   You have defined <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> on the same operand types you want to use for <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
-   Your definition of <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> returns the same type as the class or structure on which you have defined it.  
  
-   You have defined the <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> operator on the class or structure on which you have defined <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
 Similarly, you can use <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if you have defined <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> on the same operands, with the return type of the class or structure, and you have defined <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> on the class or structure.  
  
## Widening and Narrowing Conversions  
 A *widening conversion* always succeeds at run time, while a *narrowing conversion* can fail at run time. For more information, see [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md).  
  
 If you declare a conversion procedure to be <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, your procedure code must not generate any failures. This means the following:  
  
-   It must always return a valid value of type <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
-   It must handle all possible exceptions and other error conditions.  
  
-   It must handle any error returns from any procedures it calls.  
  
 If there is any possibility that a conversion procedure might not succeed, or that it might cause an unhandled exception, you must declare it to be <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
## Example  
 The following code example uses the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> statement to define the outline of a structure that includes operator procedures for the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> operators. <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> each take two operands of type <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> and return type <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> each take a single operand of type <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>. These definitions allow the calling code to use <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> with operands of type <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrStatements#44](../vs140/codesnippet/VisualBasic/operator-statement_1.vb)]  
  
## See Also  
 [IsFalse Operator](../vs140/isfalse-operator--visual-basic-.md)   
 [IsTrue Operator](../vs140/istrue-operator--visual-basic-.md)   
 [Widening](../vs140/widening--visual-basic-.md)   
 [Narrowing](../vs140/narrowing--visual-basic-.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [How to: Call an Operator Procedure](../vs140/how-to--call-an-operator-procedure--visual-basic-.md)   
 [How to: Use a Class that Defines Operators](../vs140/how-to--use-a-class-that-defines-operators--visual-basic-.md)