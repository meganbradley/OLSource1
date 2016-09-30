---
title: "Operator Procedures (Visual Basic)"
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
  - "Visual Basic code, procedures"
  - "procedures, operator"
  - "Visual Basic code, operators"
  - "syntax, Operator procedures"
  - "operators [Visual Basic], overloading"
  - "overloaded operators"
  - "operator overloading"
  - "operator procedures"
ms.assetid: 8c513d38-246b-4fb7-8b75-29e1364e555b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator Procedures (Visual Basic)
An operator procedure is a series of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] statements that define the behavior of a standard operator (such as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) on a class or structure you have defined. This is also called *operator overloading*.  
  
## When to Define Operator Procedures  
 When you have defined a class or structure, you can declare variables to be of the type of that class or structure. Sometimes such a variable needs to participate in an operation as part of an expression. To do this, it must be an operand of an operator.  
  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] defines operators only on its fundamental data types. You can define the behavior of an operator when one or both of the operands are of the type of your class or structure.  
  
 For more information, see [Operator Statement](../vs140/operator-statement.md).  
  
## Types of Operator Procedure  
 An operator procedure can be one of the following types:  
  
-   A definition of a unary operator where the argument is of the type of your class or structure.  
  
-   A definition of a binary operator where at least one of the arguments is of the type of your class or structure.  
  
-   A definition of a conversion operator where the argument is of the type of your class or structure.  
  
-   A definition of a conversion operator that returns the type of your class or structure.  
  
 Conversion operators are always unary, and you always use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as the operator you are defining.  
  
## Declaration Syntax  
 The syntax for declaring an operator procedure is as follows:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  *operatorsymbol*  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> *operand1*  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  *operand2* <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  *datatype*  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 You use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword only on a type conversion operator. The operator symbol is always [CType Function](../vs140/ctype-function--visual-basic-.md) for a type conversion operator.  
  
 You declare two operands to define a binary operator, and you declare one operand to define a unary operator, including a type conversion operator. All operands must be declared <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 You declare each operand the same way you declare parameters for [Sub Procedures](../vs140/sub-procedures--visual-basic-.md).  
  
### Data Type  
 Because you are defining an operator on a class or structure you have defined, at least one of the operands must be of the data type of that class or structure. For a type conversion operator, either the operand or the return type must be of the data type of the class or structure.  
  
 For more details, see [Operator Statement](../vs140/operator-statement.md).  
  
## Calling Syntax  
 You invoke an operator procedure implicitly by using the operator symbol in an expression. You supply the operands the same way you do for predefined operators.  
  
 The syntax for an implicit call to an operator procedure is as follows:  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  *structurename*  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  *structurename*  <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  *operatorsymbol*  <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
### Illustration of Declaration and Call  
 The following structure stores a signed 128-bit integer value as the constituent high-order and low-order parts. It defines the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> operator to add two <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> values and generate a resulting <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value.  
  
 [!code[VbVbcnProcedures#23](../vs140/codesnippet/VisualBasic/operator-procedures--visual-basic-_1.vb)]  
  
 The following example shows a typical call to the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> operator defined on <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 [!code[VbVbcnProcedures#24](../vs140/codesnippet/VisualBasic/operator-procedures--visual-basic-_2.vb)]  
  
 For more information and examples, see [Operator Overloading in Visual Basic 2005](http://go.microsoft.com/fwlink/?LinkId=101703).  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [How to: Call an Operator Procedure](../vs140/how-to--call-an-operator-procedure--visual-basic-.md)   
 [How to: Consume a Class that Defines Operators](../vs140/how-to--use-a-class-that-defines-operators--visual-basic-.md)