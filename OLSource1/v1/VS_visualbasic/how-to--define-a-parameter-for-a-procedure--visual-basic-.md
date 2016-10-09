---
title: "How to: Define a Parameter for a Procedure (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "procedure parameters, defining data types for"
  - "procedures, parameters"
  - "procedures, defining"
  - "Visual Basic code, procedures"
  - "procedure parameters, defining"
ms.assetid: 7962808d-407e-4e84-984e-43e9857c53c9
caps.latest.revision: 15
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Define a Parameter for a Procedure (Visual Basic)
A *parameter* allows the calling code to pass a value to the procedure when it calls it. You declare each parameter for a procedure the same way you declare a variable, specifying its name and data type. You also specify the passing mechanism, and whether the parameter is optional.  
  
 For more information, see [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md).  
  
### To define a procedure parameter  
  
1.  In the procedure declaration, add the parameter name to the procedure's parameter list, separating it from other parameters by commas.  
  
2.  Decide the data type of the parameter.  
  
3.  Follow the parameter name with an `As` clause to specify the data type.  
  
4.  Decide the passing mechanism you want for the parameter. Normally you pass a parameter by value, unless you want the procedure to be able to change its value in the calling code.  
  
5.  Precede the parameter name with [ByVal](../VS_visualbasic/byval--visual-basic-.md) or [ByRef](../VS_visualbasic/byref--visual-basic-.md) to specify the passing mechanism. For more information, see [Differences Between Passing an Argument By Value and By Reference](../VS_visualbasic/differences-between-passing-an-argument-by-value-and-by-reference--visual-basic-.md).  
  
6.  If the parameter is optional, precede the passing mechanism with [Optional](../VS_visualbasic/optional--visual-basic-.md) and follow the parameter data type with an equal sign (`=`) and a default value.  
  
     The following example defines the outline of a `Sub` procedure with three parameters. The first two are required and the third is optional. The parameter declarations are separated in the parameter list by commas.  
  
     [!code[VbVbcnProcedures#33](../VS_visualbasic/codesnippet/VisualBasic/how-to--define-a-parameter-for-a-procedure--visual-basic-_1.vb)]  
  
     The first parameter accepts a `customer` object, and `updateCustomer` can directly update the variable passed to `c` because the argument is passed [ByRef](../VS_visualbasic/byref--visual-basic-.md). The procedure cannot change the values of the last two arguments because they are passed [ByVal](../VS_visualbasic/byval--visual-basic-.md).  
  
     If the calling code does not supply a value for the `level` parameter, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] sets it to the default value of 0.  
  
     If the type checking switch ([Option Strict Statement](../VS_visualbasic/option-strict-statement.md)) is `Off`, the `As` clause is optional when you define a parameter. However, if any one parameter uses an `As` clause, all of them must use it. If the type checking switch is `On`, the `As` clause is required for every parameter definition.  
  
     Specifying data types for all your programming elements is known as *strong typing*. When you set `Option Strict On`, [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] enforces strong typing. This is strongly recommended, for the following reasons:  
  
    -   It enables IntelliSense support for your variables and parameters. This allows you to see their properties and other members as you type in your code.  
  
    -   It allows the compiler to perform type checking. This helps catch statements that can fail at run time due to errors such as overflow. It also catches calls to methods on objects that do not support them.  
  
    -   It results in faster execution of your code. One reason for this is that if you do not specify a data type for a programming element, the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler assigns it the `Object` type. Your compiled code might have to convert back and forth between `Object` and other data types, which reduces performance.  
  
## See Also  
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Sub Procedures](../VS_visualbasic/sub-procedures--visual-basic-.md)   
 [Function Procedures](../VS_visualbasic/function-procedures--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../VS_visualbasic/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Passing Arguments by Value and by Reference](../VS_visualbasic/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Recursive Procedures](../VS_visualbasic/recursive-procedures--visual-basic-.md)   
 [Procedure Overloading](../VS_visualbasic/procedure-overloading--visual-basic-.md)   
 [Objects and Classes](../VS_visualbasic/objects-and-classes-in-visual-basic.md)   
 [Object-Oriented Programming](../Topic/Object-Oriented%20Programming%20\(C%23%20and%20Visual%20Basic\).md)