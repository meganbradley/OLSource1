---
title: "How to: Put a Value in a Property (Visual Basic)"
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
  - "property values"
  - "Visual Basic code, procedures"
  - "values, properties"
  - "Visual Basic code, properties"
  - "properties [Visual Basic], values"
ms.assetid: c39401e5-b5fc-4439-8f31-ed640f7ce6ed
caps.latest.revision: 13
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
# How to: Put a Value in a Property (Visual Basic)
You store a value in a property by putting the property name on the left side of an assignment statement.  
  
 The property's `Set` procedure stores a value, but you do not explicitly call it by name. You use the property just as you would use a variable. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] makes the calls to the property's procedures.  
  
### To store a value in a property  
  
1.  Use the property name on the left side of an assignment statement.  
  
     The following example sets the value of the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] `TimeOfDay` property to noon, implicitly calling its `Set` procedure.  
  
     [!code[VbVbcnProcedures#11](../VS_visualbasic/codesnippet/VisualBasic/how-to--put-a-value-in-a-property--visual-basic-_1.vb)]  
  
2.  If the property takes arguments, follow the property name with parentheses to enclose the argument list. If there are no arguments, you can optionally omit the parentheses.  
  
3.  Place the arguments in the argument list within the parentheses, separated by commas. Be sure you supply the arguments in the same order that the property defines the corresponding parameters.  
  
4.  The value generated on the right side of the assignment statement is stored in the property.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.DateAndTime.TimeOfDay*>   
 [Property Procedures](../VS_visualbasic/property-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../VS_visualbasic/procedure-parameters-and-arguments--visual-basic-.md)   
 [Property Statement](../VS_visualbasic/property-statement.md)   
 [Differences Between Properties and Variables in Visual Basic](../VS_visualbasic/differences-between-properties-and-variables-in-visual-basic.md)   
 [How to: Create a Property](../VS_visualbasic/how-to--create-a-property--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../VS_visualbasic/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)   
 [How to: Call a Property Procedure](../VS_visualbasic/how-to--call-a-property-procedure--visual-basic-.md)   
 [How to: Declare and Call a Default Property in Visual Basic](../VS_visualbasic/how-to--declare-and-call-a-default-property-in-visual-basic.md)   
 [How to: Get a Value from a Property](../VS_visualbasic/how-to--get-a-value-from-a-property--visual-basic-.md)