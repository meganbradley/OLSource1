---
title: "Optional (Visual Basic)"
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
  - "vb.Optional"
  - "vb.optional"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Optional keyword, contexts"
  - "Optional keyword"
ms.assetid: 4571ce88-a539-4115-b230-54eb277c6aa7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Optional (Visual Basic)
Specifies that a procedure argument can be omitted when the procedure is called.  
  
## Remarks  
 For each optional parameter, you must specify a constant expression as the default value of that parameter. If the expression evaluates to [Nothing](../vs140/nothing--visual-basic-.md), the default value of the value data type is used as the default value of the parameter.  
  
 If the parameter list contains an optional parameter, every parameter that follows it must also be optional.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
-   [Declare Statement](../vs140/declare-statement.md)  
  
-   [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
-   [Property Statement](../vs140/property-statement.md)  
  
-   [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
> [!NOTE]
>  When calling a procedure with or without optional parameters, you can pass arguments by position or by name. For more information, see [Passing Arguments by Position and by Name (Visual Basic)](../vs140/passing-arguments-by-position-and-by-name--visual-basic-.md).  
  
> [!NOTE]
>  You can also define a procedure with optional parameters by using overloading. If you have one optional parameter, you can define two overloaded versions of the procedure, one that accepts the parameter and one that doesn’t. For more information, see [Procedure Overloading (Visual Basic)](../vs140/procedure-overloading--visual-basic-.md).  
  
## Example  
 The following example defines a procedure that has an optional parameter.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following example demonstrates how to call a procedure with arguments passed by position and with arguments passed by name. The procedure has two optional parameters.  
  
 [!code[VbVbalrKeywords#21](../vs140/codesnippet/VisualBasic/optional--visual-basic-_1.vb)]  
  
## See Also  
 [Parameter List (Visual Basic)](../vs140/parameter-list--visual-basic-.md)   
 [Optional Parameters (Visual Basic)](../vs140/optional-parameters--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)