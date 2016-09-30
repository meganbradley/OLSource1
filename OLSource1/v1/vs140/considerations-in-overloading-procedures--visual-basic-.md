---
title: "Considerations in Overloading Procedures (Visual Basic)"
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
  - "signatures, ParamArray arguments"
  - "ParamArray keyword, parameter arrays"
  - "ParamArray keyword, arguments and signatures"
  - "function overloading, implicit overloads for ParamArray"
  - "ParamArray keyword, signatures"
  - "Visual Basic code, procedures"
  - "arguments [Visual Basic], parameter arrays"
  - "procedures, overloading"
  - "parameters, lists"
  - "function overloading, typeless programming"
  - "typeless programming"
  - "function overloading, restrictions"
  - "arguments [Visual Basic], optional"
  - "optional arguments, overloading"
  - "signatures, procedure"
  - "parameter lists"
  - "parameter arrays, overloading arguments"
  - "Visual Basic code, parameter lists"
  - "procedure overloading, considerations"
  - "Option Explicit statement"
  - "restrictions, overloading procedures"
  - "procedures, parameter lists"
ms.assetid: a2001248-10d0-42c5-b0ce-eeedc987319f
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Considerations in Overloading Procedures (Visual Basic)
When you overload a procedure, you must use a different *signature* for each overloaded version. This usually means each version must specify a different parameter list. For more information, see "Different Signature" in [Procedure Overloading](../vs140/procedure-overloading--visual-basic-.md).  
  
 You can overload a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedure with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure, and vice versa, provided they have different signatures. Two overloads cannot differ only in that one has a return value and the other does not.  
  
 You can overload a property the same way you overload a procedure, and with the same restrictions. However, you cannot overload a procedure with a property, or vice versa.  
  
## Alternatives to Overloaded Versions  
 You sometimes have alternatives to overloaded versions, particularly when the presence of arguments is optional or their number is variable.  
  
 Keep in mind that optional arguments are not necessarily supported by all languages, and parameter arrays are limited to [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]. If you are writing a procedure that is likely to be called from code written in any of several different languages, overloaded versions offer the greatest flexibility.  
  
### Overloads and Optional Arguments  
 When the calling code can optionally supply or omit one or more arguments, you can define multiple overloaded versions or use optional parameters.  
  
#### When to Use Overloaded Versions  
 You can consider defining a series of overloaded versions in the following cases:  
  
-   The logic in the procedure code is significantly different depending on whether the calling code supplies an optional argument or not.  
  
-   The procedure code cannot reliably test whether the calling code has supplied an optional argument. This is the case, for example, if there is no possible candidate for a default value that the calling code could not be expected to supply.  
  
#### When to Use Optional Parameters  
 You might prefer one or more optional parameters in the following cases:  
  
-   The only required action when the calling code does not supply an optional argument is to set the parameter to a default value. In such a case, the procedure code can be less complicated if you define a single version with one or more <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameters.  
  
 For more information, see [Optional Parameters](../vs140/optional-parameters--visual-basic-.md).  
  
### Overloads and ParamArrays  
 When the calling code can pass a variable number of arguments, you can define multiple overloaded versions or use a parameter array.  
  
#### When to Use Overloaded Versions  
 You can consider defining a series of overloaded versions in the following cases:  
  
-   You know that the calling code never passes more than a small number of values to the parameter array.  
  
-   The logic in the procedure code is significantly different depending on how many values the calling code passes.  
  
-   The calling code can pass values of different data types.  
  
#### When to Use a Parameter Array  
 You are better served by a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter in the following cases:  
  
-   You are not able to predict how many values the calling code can pass to the parameter array, and it could be a large number.  
  
-   The procedure logic lends itself to iterating through all the values the calling code passes, performing essentially the same operations on every value.  
  
 For more information, see [Parameter Arrays](../vs140/parameter-arrays--visual-basic-.md).  
  
## Implicit Overloads for Optional Parameters  
 A procedure with an [Optional (Visual Basic)](../vs140/optional--visual-basic-.md) parameter is equivalent to two overloaded procedures, one with the optional parameter and one without it. You cannot overload such a procedure with a parameter list corresponding to either of these. The following declarations illustrate this.  
  
 [!code[VbVbcnProcedures#58](../vs140/codesnippet/VisualBasic/considerations-in-overloading-procedures--visual-basic-_1.vb)]  
  
 [!code[VbVbcnProcedures#60](../vs140/codesnippet/VisualBasic/considerations-in-overloading-procedures--visual-basic-_2.vb)]  
  
 [!code[VbVbcnProcedures#61](../vs140/codesnippet/VisualBasic/considerations-in-overloading-procedures--visual-basic-_3.vb)]  
  
 For a procedure with more than one optional parameter, there is a set of implicit overloads, arrived at by logic similar to that in the preceding example.  
  
## Implicit Overloads for a ParamArray Parameter  
 The compiler considers a procedure with a [ParamArray](../vs140/paramarray--visual-basic-.md) parameter to have an infinite number of overloads, differing from each other in what the calling code passes to the parameter array, as follows:  
  
-   One overload for when the calling code does not supply an argument to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
-   One overload for when the calling code supplies a one-dimensional array of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element type  
  
-   For every positive integer, one overload for when the calling code supplies that number of arguments, each of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element type  
  
 The following declarations illustrate these implicit overloads.  
  
 [!code[VbVbcnProcedures#68](../vs140/codesnippet/VisualBasic/considerations-in-overloading-procedures--visual-basic-_4.vb)]  
  
 [!code[VbVbcnProcedures#70](../vs140/codesnippet/VisualBasic/considerations-in-overloading-procedures--visual-basic-_5.vb)]  
  
 You cannot overload such a procedure with a parameter list that takes a one-dimensional array for the parameter array. However, you can use the signatures of the other implicit overloads. The following declarations illustrate this.  
  
 [!code[VbVbcnProcedures#71](../vs140/codesnippet/VisualBasic/considerations-in-overloading-procedures--visual-basic-_6.vb)]  
  
## Typeless Programming as an Alternative to Overloading  
 If you want to allow the calling code to pass different data types to a parameter, an alternative approach is typeless programming. You can set the type checking switch to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with either the [Option Strict Statement](../vs140/option-strict-statement.md) or the [/optionstrict](../vs140/-optionstrict.md) compiler option. Then you do not have to declare the parameter's data type. However, this approach has the following disadvantages compared to overloading:  
  
-   Typeless programming produces less efficient execution code.  
  
-   The procedure must test for every data type it anticipates being passed.  
  
-   The compiler cannot signal an error if the calling code passes a data type that the procedure does not support.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Troubleshooting Procedures](../vs140/troubleshooting-procedures--visual-basic-.md)   
 [How to: Define Multiple Versions of a Procedure](../vs140/how-to--define-multiple-versions-of-a-procedure--visual-basic-.md)   
 [How to: Call an Overloaded Procedure](../vs140/how-to--call-an-overloaded-procedure--visual-basic-.md)   
 [How to: Overload a Procedure that Takes Optional Parameters](../vs140/how-to--overload-a-procedure-that-takes-optional-parameters--visual-basic-.md)   
 [How to: Overload a Procedure that Takes an Indefinite Number of Parameters](../vs140/how-to--overload-a-procedure-that-takes-an-indefinite-number-of-parameters--visual-basic-.md)   
 [Overload Resolution](../vs140/overload-resolution--visual-basic-.md)   
 [Overloads](../vs140/overloads--visual-basic-.md)