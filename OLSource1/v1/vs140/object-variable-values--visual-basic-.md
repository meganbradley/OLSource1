---
title: "Object Variable Values (Visual Basic)"
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
  - object variables, values
  - values, of object variables
  - data types [Visual Basic], object variable
  - variables [Visual Basic], object
ms.assetid: 31555704-58a3-49f1-9a0a-6421f605664f
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Object Variable Values (Visual Basic)
A variable of the [Object Data Type](../vs140/object-data-type.md) can refer to data of any type. The value you store in an `Object` variable is kept elsewhere in memory, while the variable itself holds a pointer to the data.  
  
## Object Classifier Functions  
 [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] supplies functions that return information about what an `Object` variable refers to, as shown in the following table.  
  
|Function|Returns True if the Object variable refers to|  
|--------------|---------------------------------------------------|  
|<xref:Microsoft.VisualBasic.Information.IsArray?qualifyHint=False>|An array of values, rather than a single value|  
|<xref:Microsoft.VisualBasic.Information.IsDate?qualifyHint=False>|A [Date Data Type (Visual Basic)](../vs140/date-data-type--visual-basic-.md) value, or a string that can be interpreted as a date and time value|  
|<xref:Microsoft.VisualBasic.Information.IsDBNull?qualifyHint=False>|An object of type <xref:System.DBNull?qualifyHint=False>, which represents missing or nonexistent data|  
|<xref:Microsoft.VisualBasic.Information.IsError?qualifyHint=False>|An exception object, which derives from <xref:System.Exception?qualifyHint=False>|  
|<xref:Microsoft.VisualBasic.Information.IsNothing?qualifyHint=False>|[Nothing (Visual Basic)](../vs140/nothing--visual-basic-.md), that is, no object is currently assigned to the variable|  
|<xref:Microsoft.VisualBasic.Information.IsNumeric?qualifyHint=False>|A number, or a string that can be interpreted as a number|  
|<xref:Microsoft.VisualBasic.Information.IsReference?qualifyHint=False>|A reference type (such as a string, array, delegate, or class type)|  
  
 You can use these functions to avoid submitting an invalid value to an operation or a procedure.  
  
## TypeOf Operator  
 You can also use the [TypeOf Operator (Visual Basic)](../vs140/typeof-operator--visual-basic-.md) to determine whether an object variable currently refers to a specific data type. The `TypeOf`...`Is` expression evaluates to `True` if the run-time type of the operand is derived from or implements the specified type.  
  
 The following example uses `TypeOf` on object variables referring to value and reference types.  
  
```  
' The following statement puts a value type (Integer) in an Object variable.  
Dim num As Object = 10  
' The following statement puts a reference type (Form) in an Object variable.  
Dim frm As Object = New Form()  
If TypeOf num Is Long Then Debug.WriteLine("num is Long")  
If TypeOf num Is Integer Then Debug.WriteLine("num is Integer")  
If TypeOf num Is Short Then Debug.WriteLine("num is Short")  
If TypeOf num Is Object Then Debug.WriteLine("num is Object")  
If TypeOf frm Is Form Then Debug.WriteLine("frm is Form")  
If TypeOf frm Is Label Then Debug.WriteLine("frm is Label")  
If TypeOf frm Is Object Then Debug.WriteLine("frm is Object")  
```  
  
 The preceding example writes the following lines to the **Debug** window:  
  
 `num is Integer`  
  
 `num is Object`  
  
 `frm is Form`  
  
 `frm is Object`  
  
 The object variable `num` refers to data of type `Integer`, and `frm` refers to an object of class <xref:System.Windows.Forms.Form?qualifyHint=False>.  
  
## Object Arrays  
 You can declare and use an array of `Object` variables. This is useful when you need to handle a variety of data types and object classes. All the elements in an array must have the same declared data type. Declaring this data type as `Object` allows you to store objects and class instances alongside other data types in the array.  
  
## See Also  
 [Object Variables](../vs140/object-variables-in-visual-basic.md)   
 [Object Variable Declaration](../vs140/object-variable-declaration--visual-basic-.md)   
 [Object Variable Assignment](../vs140/object-variable-assignment--visual-basic-.md)   
 [How to: Refer to the Current Instance of an Object](../vs140/how-to--refer-to-the-current-instance-of-an-object--visual-basic-.md)   
 [How to: Determine What Type an Object Variable Refers To](../vs140/how-to--determine-what-type-an-object-variable-refers-to--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Related](../vs140/how-to--determine-whether-two-objects-are-related--visual-basic-.md)   
 [How to: Determine Whether Two Objects Are Identical](../vs140/how-to--determine-whether-two-objects-are-identical--visual-basic-.md)   
 [Data Types](../vs140/data-types-in-visual-basic.md)