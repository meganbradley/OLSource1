---
title: "Determining Object Type (Visual Basic)"
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
  - "classes [Visual Basic], discovering which an object belongs to"
  - "types [Visual Basic], determining Visual Basic object types"
  - "object variables, testing values"
  - "TypeOf...Is expression, object type at run time"
  - "TypeName function"
  - "objects [Visual Basic], type determining"
ms.assetid: d95e7ad1-cd63-41d6-9a28-d7a1380d49c1
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
# Determining Object Type (Visual Basic)
Generic object variables (that is, variables you declare as `Object`) can hold objects from any class. When using variables of type `Object`, you may need to take different actions based on the class of the object; for example, some objects might not support a particular property or method. [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] provides two means of determining which type of object is stored in an object variable: the `TypeName` function and the `TypeOf...Is` operator.  
  
## TypeName and TypeOf…Is  
 The `TypeName` function returns a string and is the best choice when you need to store or display the class name of an object, as shown in the following code fragment:  
  
 [!code[VbVbalrOOP#92](../VS_visualbasic/codesnippet/VisualBasic/determining-object-type--visual-basic-_1.vb)]  
  
 The `TypeOf...Is` operator is the best choice for testing an object's type, because it is much faster than an equivalent string comparison using `TypeName`. The following code fragment uses `TypeOf...Is` within an `If...Then...Else` statement:  
  
 [!code[VbVbalrOOP#93](../VS_visualbasic/codesnippet/VisualBasic/determining-object-type--visual-basic-_2.vb)]  
  
 A word of caution is due here. The `TypeOf...Is` operator returns `True` if an object is of a specific type, or is derived from a specific type. Almost everything you do with [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] involves objects, which include some elements not normally thought of as objects, such as strings and integers. These objects are derived from and inherit methods from \<xref:System.Object>. When passed an `Integer` and evaluated with `Object`, the `TypeOf...Is` operator returns `True`. The following example reports that the parameter `InParam` is both an `Object` and an `Integer`:  
  
 [!code[VbVbalrOOP#94](../VS_visualbasic/codesnippet/VisualBasic/determining-object-type--visual-basic-_3.vb)]  
  
 The following example uses both `TypeOf...Is` and `TypeName` to determine the type of object passed to it in the `Ctrl` argument. The `TestObject` procedure calls `ShowType` with three different kinds of controls.  
  
#### To run the example  
  
1.  Create a new Windows Application project and add a \<xref:System.Windows.Forms.Button> control, a \<xref:System.Windows.Forms.CheckBox> control, and a \<xref:System.Windows.Forms.RadioButton> control to the form.  
  
2.  From the button on your form, call the `TestObject` procedure.  
  
3.  Add the following code to your form:  
  
     [!code[VbVbalrOOP#95](../VS_visualbasic/codesnippet/VisualBasic/determining-object-type--visual-basic-_4.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Information.TypeName*>   
 [Calling a Property or Method Using a String Name](../VS_visualbasic/calling-a-property-or-method-using-a-string-name--visual-basic-.md)   
 [Object Data Type](../VS_visualbasic/object-data-type.md)   
 [If...Then...Else Statement](../VS_visualbasic/if...then...else-statement--visual-basic-.md)   
 [String Data Type](../VS_visualbasic/string-data-type--visual-basic-.md)   
 [Integer Data Type](../VS_visualbasic/integer-data-type--visual-basic-.md)