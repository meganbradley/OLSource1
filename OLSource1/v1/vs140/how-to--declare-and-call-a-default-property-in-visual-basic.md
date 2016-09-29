---
title: "How to: Declare and Call a Default Property in Visual Basic"
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
  - "defaults, properties"
  - "properties [Visual Basic], default"
  - "procedures, defining"
  - "default properties, in Visual Basic"
  - "Visual Basic code, procedures"
  - "Visual Basic code, properties"
  - "default properties"
ms.assetid: 68b4026e-09ef-4613-808e-f6287494ff63
caps.latest.revision: 27
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare and Call a Default Property in Visual Basic
A *default property* is a class or structure property that your code can access without specifying it. When calling code names a class or structure but not a property, and the context allows access to a property, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] resolves the access to that class or structure's default property if one exists.  
  
 A class or structure can have at most one default property. However, you can overload a default property and have more than one version of it.  
  
 For more information, see [Default (Visual Basic)](../vs140/default--visual-basic-.md).  
  
### To declare a default property  
  
1.  Declare the property in the normal way. Do not specify the `Shared` or `Private` keyword.  
  
2.  Include the `Default` keyword in the property declaration.  
  
3.  Specify at least one parameter for the property. You cannot define a default property that does not take at least one argument.  
  
     [!code[VbVbcnProcedures#17](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_1.vb)]  
  
### To call a default property  
  
1.  Declare a variable of the containing class or structure type.  
  
     [!code[VbVbcnProcedures#16](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_2.vb)]  
  
2.  Use the variable name alone in an expression where you would normally include the property name.  
  
     [!code[VbVbcnProcedures#21](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_3.vb)]  
  
3.  Follow the variable name with an argument list in parentheses. A default property must take at least one argument.  
  
     [!code[VbVbcnProcedures#20](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_4.vb)]  
  
4.  To retrieve the default property value, use the variable name, with an argument list, in an expression or following the equal (`=`) sign in an assignment statement.  
  
     [!code[VbVbcnProcedures#15](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_5.vb)]  
  
5.  To set the default property value, use the variable name, with an argument list, on the left side of an assignment statement.  
  
     [!code[VbVbcnProcedures#14](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_6.vb)]  
  
6.  You can always specify the default property name together with the variable name, just as you would do to access any other property.  
  
     [!code[VbVbcnProcedures#19](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_7.vb)]  
  
## Example  
 The following example declares a default property on a class.  
  
 [!code[VbVbcnProcedures#12](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_8.vb)]  
  
## Example  
 The following example demonstrates how to call the default property `myProperty` on class `class1`. The three assignment statements store values in `myProperty`, and the [MsgBox](assetId:///M:Microsoft.VisualBasic.Interaction.MsgBox(System.Object,Microsoft.VisualBasic.MsgBoxStyle,System.Object)?qualifyHint=False&autoUpgrade=True) call reads the values.  
  
 [!code[VbVbcnProcedures#13](../vs140/codesnippet/VisualBasic/how-to--declare-and-call-a-default-property-in-visual-basic_9.vb)]  
  
 The most common use of a default property is the [Item](assetId:///P:Microsoft.VisualBasic.Collection.Item(System.String)?qualifyHint=False&autoUpgrade=True) property on various collection classes.  
  
## Robust Programming  
 Default properties can result in a small reduction in source code-characters, but they can make your code more difficult to read. If the calling code is not familiar with your class or structure, when it makes a reference to the class or structure name it cannot be certain whether that reference accesses the class or structure itself, or a default property. This can lead to compiler errors or subtle run-time logic errors.  
  
 You can somewhat reduce the chance of default property errors by always using the [Option Strict Statement](../vs140/option-strict-statement.md) to set compiler type checking to `On`.  
  
 If you are planning to use a predefined class or structure in your code, you must determine whether it has a default property, and if so, what its name is.  
  
 Because of these disadvantages, you should consider not defining default properties. For code readability, you should also consider always referring to all properties explicitly, even default properties.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Default](../vs140/default--visual-basic-.md)   
 [Differences Between Properties and Variables in Visual Basic](../vs140/differences-between-properties-and-variables-in-visual-basic.md)   
 [How to: Create a Property](../vs140/how-to--create-a-property--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)   
 [How to: Call a Property Procedure](../vs140/how-to--call-a-property-procedure--visual-basic-.md)   
 [How to: Put a Value in a Property](../vs140/how-to--put-a-value-in-a-property--visual-basic-.md)   
 [How to: Get a Value from a Property](../vs140/how-to--get-a-value-from-a-property--visual-basic-.md)