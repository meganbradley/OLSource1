---
title: "How to: Pass Arguments to a Procedure (Visual Basic)"
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
  - "arguments [Visual Basic], passing to procedures"
  - "procedures, arguments"
  - "procedures, parameters"
  - "procedure arguments"
  - "Visual Basic code, procedures"
  - "procedure parameters"
  - "procedures, calling"
  - "argument passing, procedures"
ms.assetid: 08723588-3890-4ddc-8249-79e049e0f241
caps.latest.revision: 14
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
# How to: Pass Arguments to a Procedure (Visual Basic)
When you call a procedure, you follow the procedure name with an argument list in parentheses. You supply an argument corresponding to every required parameter the procedure defines, and you can optionally supply arguments to the `Optional` parameters. If you do not supply an `Optional` parameter in the call, you must include a comma to mark its place in the argument list if you are supplying any subsequent arguments.  
  
 If you intend to pass an argument of a data type different from that of its corresponding parameter, such as `Byte` to `String`, you can set the type-checking switch ([Option Strict Statement](../VS_visualbasic/option-strict-statement.md)) to `Off`. If `Option Strict` is `On`, you must use either widening conversions or explicit conversion keywords. For more information, see [Widening and Narrowing Conversions](../VS_visualbasic/widening-and-narrowing-conversions--visual-basic-.md) and [Type Conversion Functions](../VS_visualbasic/type-conversion-functions--visual-basic-.md).  
  
 For more information, see [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md).  
  
### To pass one or more arguments to a procedure  
  
1.  In the calling statement, follow the procedure name with parentheses.  
  
2.  Inside the parentheses, put an argument list. Include an argument for each required parameter the procedure defines, and separate the arguments with commas.  
  
3.  Make sure each argument is a valid expression that evaluates to a data type convertible to the type the procedure defines for the corresponding parameter.  
  
4.  If a parameter is defined as [Optional](../VS_visualbasic/optional--visual-basic-.md), you can either include it in the argument list or omit it. If you omit it, the procedure uses the default value defined for that parameter.  
  
5.  If you omit an argument for an `Optional` parameter and there is another parameter after it in the parameter list, you can mark the place of the omitted argument by an extra comma in the argument list.  
  
     The following example calls the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] \<xref:Microsoft.VisualBasic.Interaction.MsgBox*> function.  
  
     [!code[VbVbcnProcedures#34](../VS_visualbasic/codesnippet/VisualBasic/how-to--pass-arguments-to-a-procedure--visual-basic-_1.vb)]  
  
     The preceding example supplies the required first argument, which is the message string to be displayed. It omits an argument for the optional second parameter, which specifies the buttons to be displayed on the message box. Because the call does not supply a value, `MsgBox` uses the default value, `MsgBoxStyle.OKOnly`, which displays only an **OK** button.  
  
     The second comma in the argument list marks the place of the omitted second argument, and the last string is passed to the optional third parameter of `MsgBox`, which is the text to be displayed in the title bar.  
  
## See Also  
 [Sub Procedures](../VS_visualbasic/sub-procedures--visual-basic-.md)   
 [Function Procedures](../VS_visualbasic/function-procedures--visual-basic-.md)   
 [Property Procedures](../VS_visualbasic/property-procedures--visual-basic-.md)   
 [Operator Procedures](../VS_visualbasic/operator-procedures--visual-basic-.md)   
 [How to: Define a Parameter for a Procedure](../VS_visualbasic/how-to--define-a-parameter-for-a-procedure--visual-basic-.md)   
 [Passing Arguments by Value and by Reference](../VS_visualbasic/passing-arguments-by-value-and-by-reference--visual-basic-.md)   
 [Recursive Procedures](../VS_visualbasic/recursive-procedures--visual-basic-.md)   
 [Procedure Overloading](../VS_visualbasic/procedure-overloading--visual-basic-.md)   
 [Objects and Classes](../VS_visualbasic/objects-and-classes-in-visual-basic.md)   
 [Object-Oriented Programming](../Topic/Object-Oriented%20Programming%20\(C%23%20and%20Visual%20Basic\).md)