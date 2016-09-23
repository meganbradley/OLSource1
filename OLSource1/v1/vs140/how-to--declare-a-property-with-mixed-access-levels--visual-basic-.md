---
title: "How to: Declare a Property with Mixed Access Levels (Visual Basic)"
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
  - access levels, properties
  - procedures, defining
  - Visual Basic code, procedures
  - mixed access levels
  - Visual Basic code, properties
  - properties [Visual Basic], access levels
  - Property statement, declaring mixed access levels
ms.assetid: fdbb2d97-279a-4956-b26c-cbdfbc34915a
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Declare a Property with Mixed Access Levels (Visual Basic)
If you want the `Get` and `Set` procedures on a property to have different access levels, you can use the more permissive level in the `Property` statement and the more restrictive level in either the `Get` or `Set` statement. You use mixed access levels on a property when you want certain parts of the code to be able to get the property's value, and certain other parts of the code to be able to change the value.  
  
 For more information on access levels, see [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md).  
  
### To declare a property with mixed access levels  
  
1.  Declare the property in the normal way, and specify the less restrictive access level (such as `Public`) in the `Property` statement.  
  
2.  Declare either the `Get` or the `Set` procedure specifying the more restrictive access level (such as `Friend`).  
  
3.  Do not specify an access level on the other property procedure. It assumes the access level declared in the `Property` statement. You can restrict access on only one of the property procedures.  
  
     [!code[VbVbcnProcedures#10](../vs140/codesnippet/VisualBasic/how-to--declare-a-property-with-mixed-access-levels--visual-basic-_1.vb)]
  
  
     In the preceding example, the `Get` procedure has the same `Protected` access as the property itself, while the `Set` procedure has `Private` access. A class derived from `employee` can read the `salary` value, but only the `employee` class can set it.  
  
## See Also  
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Differences Between Properties and Variables in Visual Basic](../vs140/differences-between-properties-and-variables-in-visual-basic.md)   
 [How to: Create a Property](../vs140/how-to--create-a-property--visual-basic-.md)   
 [How to: Call a Property Procedure](../vs140/how-to--call-a-property-procedure--visual-basic-.md)   
 [How to: Declare and Call a Default Property in Visual Basic](../vs140/how-to--declare-and-call-a-default-property-in-visual-basic.md)   
 [How to: Put a Value in a Property](../vs140/how-to--put-a-value-in-a-property--visual-basic-.md)   
 [How to: Get a Value from a Property](../vs140/how-to--get-a-value-from-a-property--visual-basic-.md)