---
title: "Parameter Arrays (Visual Basic)"
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
  - "parameter arrays, about parameter arrays"
  - "ParamArray keyword, parameter arrays"
  - "Visual Basic code, procedures"
  - "parameters, parameter arrays"
  - "arguments [Visual Basic], parameter arrays"
  - "procedures, indefinite number of argument values"
  - "arrays [Visual Basic], parameter arrays"
ms.assetid: c43edfae-9114-4096-9ebc-8c5c957a1067
caps.latest.revision: 26
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
# Parameter Arrays (Visual Basic)
Usually, you cannot call a procedure with more arguments than the procedure declaration specifies. When you need an indefinite number of arguments, you can declare a *parameter array*, which allows a procedure to accept an array of values for a parameter. You do not have to know the number of elements in the parameter array when you define the procedure. The array size is determined individually by each call to the procedure.  
  
## Declaring a ParamArray  
 You use the [ParamArray](../VS_visualbasic/paramarray--visual-basic-.md) keyword to denote a parameter array in the parameter list. The following rules apply:  
  
-   A procedure can define only one parameter array, and it must be the last parameter in the procedure definition.  
  
-   The parameter array must be passed by value. It is good programming practice to explicitly include the [ByVal](../VS_visualbasic/byval--visual-basic-.md) keyword in the procedure definition.  
  
-   The parameter array is automatically optional. Its default value is an empty one-dimensional array of the parameter array's element type.  
  
-   All parameters preceding the parameter array must be required. The parameter array must be the only optional parameter.  
  
## Calling a ParamArray  
 When you call a procedure that defines a parameter array, you can supply the argument in any one of the following ways:  
  
-   Nothing — that is, you can omit the [ParamArray](../VS_visualbasic/paramarray--visual-basic-.md) argument. In this case, an empty array is passed to the procedure. You can also pass the [Nothing](../VS_visualbasic/nothing--visual-basic-.md) keyword, with the same effect.  
  
-   A list of an arbitrary number of arguments, separated by commas. The data type of each argument must be implicitly convertible to the `ParamArray` element type.  
  
-   An array with the same element type as the parameter array's element type.  
  
 In all cases, the code within the procedure treats the parameter array as a one-dimensional array with elements of the same data type as the `ParamArray` data type.  
  
> [!IMPORTANT]
>  Whenever you deal with an array which can be indefinitely large, there is a risk of overrunning some internal capacity of your application. If you accept a parameter array, you should test for the size of the array that the calling code passed to it. Take appropriate steps if it is too large for your application. For more information, see [Arrays](../VS_visualbasic/arrays-in-visual-basic.md).  
  
## Example  
 The following example defines and calls the function `calcSum`. The `ParamArray` modifier for the parameter `args` enables the function to accept a variable number of arguments.  
  
 [!code[VbVbalrStatements#26](../VS_visualbasic/codesnippet/VisualBasic/parameter-arrays--visual-basic-_1.vb)]  
  
 The following example defines a procedure with a parameter array, and outputs the values of all the array elements passed to the parameter array.  
  
 [!code[VbVbcnProcedures#48](../VS_visualbasic/codesnippet/VisualBasic/parameter-arrays--visual-basic-_2.vb)]  
  
 [!code[VbVbcnProcedures#49](../VS_visualbasic/codesnippet/VisualBasic/parameter-arrays--visual-basic-_3.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.UBound*>   
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md)   
 [Passing Arguments by Value and by Reference](../VS_visualbasic/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Passing Arguments by Position and by Name](../VS_visualbasic/passing-arguments-by-position-and-by-name--visual-basic-.md)   
 [Optional Parameters](../VS_visualbasic/optional-parameters--visual-basic-.md)   
 [Procedure Overloading](../VS_visualbasic/procedure-overloading--visual-basic-.md)   
 [Arrays](../VS_visualbasic/arrays-in-visual-basic.md)   
 [Optional](../VS_visualbasic/optional--visual-basic-.md)