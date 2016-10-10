---
title: "How to: Overload a Procedure that Takes an Indefinite Number of Parameters (Visual Basic)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "procedures, parameters"
  - "procedure overloading, indefinite number of parameters"
  - "procedures, defining"
  - "Visual Basic code, procedures"
  - "procedure parameters"
  - "procedures, overloading"
  - "procedures, multiple versions"
ms.assetid: c7042de2-2422-4039-94e8-ac298896af69
caps.latest.revision: 18
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
# How to: Overload a Procedure that Takes an Indefinite Number of Parameters (Visual Basic)
If a procedure has a [ParamArray](../VS_visualbasic/paramarray--visual-basic-.md) parameter, you cannot define an overloaded version taking a one-dimensional array for the parameter array. For more information, see "Implicit Overloads for a ParamArray Parameter" in [Considerations in Overloading Procedures](../VS_visualbasic/considerations-in-overloading-procedures--visual-basic-.md).  
  
### To overload a procedure that takes a variable number of parameters  
  
1.  Ascertain that the procedure and calling code logic benefits from overloaded versions more than from a `ParamArray` parameter. See "Overloads and ParamArrays" in [Considerations in Overloading Procedures](../VS_visualbasic/considerations-in-overloading-procedures--visual-basic-.md).  
  
2.  Determine which numbers of supplied values the procedure should accept in the variable part of the parameter list. This might include the case of no value, and it might include the case of a single one-dimensional array.  
  
3.  For each acceptable number of supplied values, write a `Sub` or `Function` declaration statement that defines the corresponding parameter list. Do not use either the `Optional` or the `ParamArray` keyword in this overloaded version.  
  
4.  In each declaration, precede the `Sub` or `Function` keyword with the [Overloads](../VS_visualbasic/overloads--visual-basic-.md) keyword.  
  
5.  Following each declaration, write the procedure code that should execute when the calling code supplies values corresponding to that declaration's parameter list.  
  
6.  Terminate each procedure with the `End Sub` or `End Function` statement as appropriate.  
  
## Example  
 The following example shows a procedure defined with a [ParamArray](../VS_visualbasic/paramarray--visual-basic-.md) parameter, and then an equivalent set of overloaded procedures.  
  
 [!code[VbVbcnProcedures#69](../VS_visualbasic/codesnippet/VisualBasic/how-to--overload-a-procedure-that-takes-an-indefinite-number-of-parameters--visual-basic-_1.vb)]  
  
 [!code[VbVbcnProcedures#70](../VS_visualbasic/codesnippet/VisualBasic/how-to--overload-a-procedure-that-takes-an-indefinite-number-of-parameters--visual-basic-_2.vb)]  
  
 You cannot overload such a procedure with a parameter list that takes a one-dimensional array for the parameter array. However, you can use the signatures of the other implicit overloads. The following declarations illustrate this.  
  
 [!code[VbVbcnProcedures#71](../VS_visualbasic/codesnippet/VisualBasic/how-to--overload-a-procedure-that-takes-an-indefinite-number-of-parameters--visual-basic-_3.vb)]  
  
 The code in the overloaded versions does not have to test whether the calling code supplied one or more values for the `ParamArray` parameter, or if so, how many. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] passes control to the version matching the calling argument list.  
  
## Compiling the Code  
 Because a procedure with a `ParamArray` parameter is equivalent to a set of overloaded versions, you cannot overload such a procedure with a parameter list corresponding to any of these implicit overloads. For more information, see [Considerations in Overloading Procedures](../VS_visualbasic/considerations-in-overloading-procedures--visual-basic-.md).  
  
## .NET Framework Security  
 Whenever you deal with an array which can be indefinitely large, there is a risk of overrunning some internal capacity of your application. If you accept a parameter array, you should test for the length of the array the calling code passed to it, and take appropriate steps if it is too large for your application.  
  
## See Also  
 [Procedures](../VS_visualbasic/procedures-in-visual-basic.md)   
 [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md)   
 [Optional Parameters](../VS_visualbasic/optional-parameters--visual-basic-.md)   
 [Parameter Arrays](../VS_visualbasic/parameter-arrays--visual-basic-.md)   
 [Procedure Overloading](../VS_visualbasic/procedure-overloading--visual-basic-.md)   
 [Troubleshooting Procedures](../VS_visualbasic/troubleshooting-procedures--visual-basic-.md)   
 [How to: Define Multiple Versions of a Procedure](../VS_visualbasic/how-to--define-multiple-versions-of-a-procedure--visual-basic-.md)   
 [How to: Call an Overloaded Procedure](../VS_visualbasic/how-to--call-an-overloaded-procedure--visual-basic-.md)   
 [How to: Overload a Procedure that Takes Optional Parameters](../VS_visualbasic/how-to--overload-a-procedure-that-takes-optional-parameters--visual-basic-.md)   
 [Overload Resolution](../VS_visualbasic/overload-resolution--visual-basic-.md)