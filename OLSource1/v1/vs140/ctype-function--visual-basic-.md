---
title: "CType Function (Visual Basic)"
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
  - "vb.CType"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "expression conversion results"
  - "explicit data type conversions"
  - "CType function"
  - "conversions, expression"
ms.assetid: dd4b29e7-6fa1-428c-877e-69955420bb72
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CType Function (Visual Basic)
Returns the result of explicitly converting an expression to a specified data type, object, structure, class, or interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Any valid expression. If the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is outside the range allowed by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, Visual Basic throws an exception.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Any expression that is legal within an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause in a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement, that is, the name of any data type, object, structure, class, or interface.  
  
## Remarks  
  
> [!TIP]
>  You can also use the following functions to perform a type conversion:  
>   
>  -   Type conversion functions such as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that perform a conversion to a specific data type. For more information, see [Type Conversion Functions (Visual Basic)](../vs140/type-conversion-functions--visual-basic-.md).  
> -   [DirectCast Operator (Visual Basic)](../vs140/directcast-operator--visual-basic-.md) or [TryCast Operator (Visual Basic)](../vs140/trycast-operator--visual-basic-.md). These operators require that one type inherit from or implement the other type. They can provide somewhat better performance than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when converting to and from the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> data type.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is compiled inline, which means that the conversion code is part of the code that evaluates the expression. In some cases, the code runs faster because no procedures are called to perform the conversion.  
  
 If no conversion is defined from <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (for example, from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>), Visual Basic displays a compile-time error message.  
  
 If a conversion fails at run time, the appropriate exception is thrown. If a narrowing conversion fails, an \<xref:System.OverflowException*> is the most common result. If the conversion is undefined, an \<xref:System.InvalidCastException*> in thrown. For example, this can happen  if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and its run-time type has no conversion to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 If the data type of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a class or structure you've defined, you can define <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> on that class or structure as a conversion operator. This makes <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> act as an *overloaded operator*. If you do this, you can control the behavior of conversions to and from your class or structure, including the exceptions that can be thrown.  
  
## Overloading  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> operator can also be overloaded on a class or structure defined outside your code. If your code converts to or from such a class or structure, be sure you understand the behavior of its <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> operator. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
## Converting Dynamic Objects  
 Type conversions of dynamic objects are performed by user-defined dynamic conversions that use the \<xref:System.Dynamic.DynamicObject.TryConvert*> or \<xref:System.Dynamic.DynamicMetaObject.BindConvert*> methods. If you're working with dynamic objects, use the \<xref:Microsoft.VisualBasic.Conversion.CTypeDynamic*> method to convert the dynamic object.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> function to convert an expression to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> data type.  
  
 [!code[VbVbalrFunctions#24](../vs140/codesnippet/VisualBasic/ctype-function--visual-basic-_1.vb)]  
  
 For additional examples, see [Implicit and Explicit Conversions (Visual Basic)](../vs140/implicit-and-explicit-conversions--visual-basic-.md).  
  
## See Also  
 \<xref:System.OverflowException*>   
 \<xref:System.InvalidCastException*>   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)   
 [Conversion Functions](../vs140/conversion-functions--visual-basic-.md)   
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)   
 [Type Conversion in the .NET Framework](assetId:///ba36154f-064c-47d3-9f05-72f93a7ca96d)