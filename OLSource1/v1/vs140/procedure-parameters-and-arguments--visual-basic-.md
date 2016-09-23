---
title: "Procedure Parameters and Arguments (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - procedures, arguments
  - procedures, argument lists
  - values, passing to procedures
  - arguments [Visual Basic], passing
  - procedures, parameters
  - Visual Basic code, argument lists
  - Visual Basic code, procedures
  - parameters, Visual Basic procedures
  - parameters, lists
  - arguments [Visual Basic], Visual Basic procedures
  - arguments [Visual Basic], procedures
  - parameter lists
  - Visual Basic code, parameter lists
  - argument lists
  - procedures, parameter lists
ms.assetid: ff275aff-aa13-40df-bd4c-63486db8c1e9
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Procedure Parameters and Arguments (Visual Basic)
In most cases, a procedure needs some information about the circumstances in which it has been called. A procedure that performs repeated or shared tasks uses different information for each call. This information consists of variables, constants, and expressions that you pass to the procedure when you call it.  
  
 A *parameter* represents a value that the procedure expects you to supply when you call it. The procedure's declaration defines its parameters.  
  
 You can define a procedure with no parameters, one parameter, or more than one. The part of the procedure definition that specifies the parameters is called the *parameter list*.  
  
 An *argument* represents the value you supply to a procedure parameter when you call the procedure. The calling code supplies the arguments when it calls the procedure. The part of the procedure call that specifies the arguments is called the *argument list*.  
  
 The following illustration shows code calling the procedure `safeSquareRoot` from two different places. The first call passes the value of the variable `x` (4.0) to the parameter `number`, and the return value in `root` (2.0) is assigned to the variable `y`. The second call passes the literal value 9.0 to `number`, and assigns the return value (3.0) to variable `z`.  
  
 ![Graphic diagram of passing argument to parameter](../vs140/media/parametersargue.gif "ParametersArgue")  
Passing an argument to a parameter  
  
 For more information, see [Differences Between Parameters and Arguments](../vs140/differences-between-parameters-and-arguments--visual-basic-.md).  
  
## Parameter Data Type  
 You define a data type for a parameter by using the `As` clause in its declaration. For example, the following function accepts a string and an integer.  
  
 [!code[VbVbcnProcedures#32](../vs140/codesnippet/VisualBasic/procedure-parameters-and-arguments--visual-basic-_1.vb)]
  
  
 If the type checking switch ([Option Strict Statement](../vs140/option-strict-statement.md)) is `Off,` the `As` clause is optional, except that if any one parameter uses it, all parameters must use it. If type checking is `On`, the `As` clause is required for all procedure parameters.  
  
 If the calling code expects to supply an argument with a data type different from that of its corresponding parameter, such as `Byte` to a `String` parameter, it must do one of the following:  
  
-   Supply only arguments with data types that widen to the parameter data type;  
  
-   Set `Option Strict Off` to allow implicit narrowing conversions; or  
  
-   Use a conversion keyword to explicitly convert the data type.  
  
### Type Parameters  
 A *generic procedure* also defines one or more *type parameters* in addition to its normal parameters. A generic procedure allows the calling code to pass different data types each time it calls the procedure, so it can tailor the data types to the requirements of each individual call. See [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md).  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Operator Procedures](../vs140/operator-procedures--visual-basic-.md)   
 [How to: Define a Parameter for a Procedure](../vs140/how-to--define-a-parameter-for-a-procedure--visual-basic-.md)   
 [How to: Pass Arguments to a Procedure](../vs140/how-to--pass-arguments-to-a-procedure--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)