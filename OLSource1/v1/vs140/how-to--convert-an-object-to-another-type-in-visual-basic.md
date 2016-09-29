---
title: "How to: Convert an Object to Another Type in Visual Basic"
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
  - "objects [Visual Basic], converting"
ms.assetid: 60cb5fc7-7ba4-4ab5-9c24-480fa12ddcdc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert an Object to Another Type in Visual Basic
You convert an `Object` variable to another data type by using a conversion keyword such as [CType Function](../vs140/ctype-function--visual-basic-.md).  
  
## Example  
 The following example converts an `Object` variable to an `Integer` and a `String`.  
  
```  
Public Sub objectConversion(ByVal anObject As Object)  
    Dim anInteger As Integer  
    Dim aString As String  
    anInteger = CType(anObject, Integer)  
    aString = CType(anObject, String)  
End Sub  
```  
  
 If you know that the contents of an `Object` variable are of a particular data type, it is better to convert the variable to that data type. If you continue to use the `Object` variable, you incur either *boxing* and *unboxing* (for a value type) or *late binding* (for a reference type). These operations all take extra execution time and make your performance slower.  
  
## Compiling the Code  
 This example requires:  
  
-   A reference to the <xref:System*?displayProperty=fullName> namespace.  
  
## See Also  
 <xref:System.Object*>   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Widening and Narrowing Conversions](../vs140/widening-and-narrowing-conversions--visual-basic-.md)   
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Conversions Between Strings and Other Types](../vs140/conversions-between-strings-and-other-types--visual-basic-.md)   
 [Array Conversions](../vs140/array-conversions--visual-basic-.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Data Types](../vs140/data-type-summary--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)