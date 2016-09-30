---
title: "Parameter Arrays (Visual Basic)"
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
  - "parameter arrays, about parameter arrays"
  - "ParamArray keyword, parameter arrays"
  - "Visual Basic code, procedures"
  - "parameters, parameter arrays"
  - "arguments [Visual Basic], parameter arrays"
  - "procedures, indefinite number of argument values"
  - "arrays [Visual Basic], parameter arrays"
ms.assetid: c43edfae-9114-4096-9ebc-8c5c957a1067
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Parameter Arrays (Visual Basic)
Usually, you cannot call a procedure with more arguments than the procedure declaration specifies. When you need an indefinite number of arguments, you can declare a *parameter array*, which allows a procedure to accept an array of values for a parameter. You do not have to know the number of elements in the parameter array when you define the procedure. The array size is determined individually by each call to the procedure.  
  
## Declaring a ParamArray  
 You use the [ParamArray](../vs140/paramarray--visual-basic-.md) keyword to denote a parameter array in the parameter list. The following rules apply:  
  
-   A procedure can define only one parameter array, and it must be the last parameter in the procedure definition.  
  
-   The parameter array must be passed by value. It is good programming practice to explicitly include the [ByVal](../vs140/byval--visual-basic-.md) keyword in the procedure definition.  
  
-   The parameter array is automatically optional. Its default value is an empty one-dimensional array of the parameter array's element type.  
  
-   All parameters preceding the parameter array must be required. The parameter array must be the only optional parameter.  
  
## Calling a ParamArray  
 When you call a procedure that defines a parameter array, you can supply the argument in any one of the following ways:  
  
-   Nothing — that is, you can omit the [ParamArray](../vs140/paramarray--visual-basic-.md) argument. In this case, an empty array is passed to the procedure. You can also pass the [Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md) keyword, with the same effect.  
  
-   A list of an arbitrary number of arguments, separated by commas. The data type of each argument must be implicitly convertible to the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> element type.  
  
-   An array with the same element type as the parameter array's element type.  
  
 In all cases, the code within the procedure treats the parameter array as a one-dimensional array with elements of the same data type as the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type.  
  
> [!IMPORTANT]
>  Whenever you deal with an array which can be indefinitely large, there is a risk of overrunning some internal capacity of your application. If you accept a parameter array, you should test for the size of the array that the calling code passed to it. Take appropriate steps if it is too large for your application. For more information, see [Arrays](../vs140/arrays-in-visual-basic.md).  
  
## Example  
 The following example defines and calls the function <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier for the parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> enables the function to accept a variable number of arguments.  
  
 [!code[VbVbalrStatements#26](../vs140/codesnippet/VisualBasic/parameter-arrays--visual-basic-_1.vb)]  
  
 The following example defines a procedure with a parameter array, and outputs the values of all the array elements passed to the parameter array.  
  
 [!code[VbVbcnProcedures#48](../vs140/codesnippet/VisualBasic/parameter-arrays--visual-basic-_2.vb)]  
  
 [!code[VbVbcnProcedures#49](../vs140/codesnippet/VisualBasic/parameter-arrays--visual-basic-_3.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.UBound*>   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Argument Passing By Value and By Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Passing Arguments by Position and by Name](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md)   
 [Optional Parameters](../vs140/optional-parameters--visual-basic-.md)   
 [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md)   
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [Optional](../vs140/optional--visual-basic-.md)