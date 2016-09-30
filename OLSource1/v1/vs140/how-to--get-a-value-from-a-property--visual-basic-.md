---
title: "How to: Get a Value from a Property (Visual Basic)"
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
  - "property values"
  - "Visual Basic code, procedures"
  - "values, properties"
  - "Visual Basic code, properties"
  - "properties [Visual Basic], values"
ms.assetid: 3954423e-6ab7-4a4c-b55c-a8d27be47891
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Get a Value from a Property (Visual Basic)
You retrieve a property's value by including the property name in an expression.  
  
 The property's <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedure retrieves the value, but you do not explicitly call it by name. You use the property just as you would use a variable. [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] makes the calls to the property's procedures.  
  
### To retrieve a value from a property  
  
1.  Use the property name in an expression the same way you would use a variable name. You can use a property anywhere you can use a variable or a constant.  
  
     -or-  
  
     Use the property name following the equal (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) sign in an assignment statement.  
  
     The following example reads the value of the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property, implicitly calling its <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure.  
  
     [!code[VbVbalrDateProperties#4](../vs140/codesnippet/VisualBasic/how-to--get-a-value-from-a-property--visual-basic-_1.vb)]  
  
2.  If the property takes arguments, follow the property name with parentheses to enclose the argument list. If there are no arguments, you can optionally omit the parentheses.  
  
3.  Place the arguments in the argument list within the parentheses, separated by commas. Be sure you supply the arguments in the same order that the property defines the corresponding parameters.  
  
 The value of the property participates in the expression just as a variable or constant would, or it is stored in the variable or property on the left side of the assignment statement.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Differences Between Properties and Variables](../vs140/differences-between-properties-and-variables-in-visual-basic.md)   
 [How to: Create a Property](../vs140/how-to--create-a-property--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)   
 [How to: Call a Property Procedure](../vs140/how-to--call-a-property-procedure--visual-basic-.md)   
 [How to: Declare and Call a Default Property (Visual Basic)](../vs140/how-to--declare-and-call-a-default-property-in-visual-basic.md)   
 [How to: Put a Value in a Property](../vs140/how-to--put-a-value-in-a-property--visual-basic-.md)