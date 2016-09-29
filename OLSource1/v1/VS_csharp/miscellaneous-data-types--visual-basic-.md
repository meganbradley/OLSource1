---
title: "Miscellaneous Data Types (Visual Basic)"
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
  - "Object data type, data types"
  - "data types [Visual Basic], choosing"
ms.assetid: 64c71a12-9057-4dbf-baca-7379c4aada69
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Miscellaneous Data Types (Visual Basic)
[!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] supplies several data types that are not oriented toward numbers or characters. Instead, they deal with specialized data such as yes/no values, date/time values, and object addresses.  
  
 For a table showing a side-by-side comparison of the [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] data types, see [Data Type Summary (Visual Basic)](../VS_csharp/data-type-summary--visual-basic-.md).  
  
## Boolean Type  
 The [Boolean Data Type (Visual Basic)](../VS_csharp/boolean-data-type--visual-basic-.md) is an unsigned value that is interpreted as either `True` or `False`. Its data width depends on the implementing platform. If a variable can contain only two-state values such as true/false, yes/no, or on/off, declare it as `Boolean`.  
  
## Date Type  
 The [Date Data Type (Visual Basic)](../VS_csharp/date-data-type--visual-basic-.md) is a 64-bit value that holds both date and time information. Each increment represents 100 nanoseconds of elapsed time since the beginning (12:00 AM) of January 1 of the year 1 in the Gregorian calendar. If a variable can contain a date value, a time value, or both, declare it as `Date`.  
  
## Object Type  
 The [Object Data Type](../VS_csharp/object-data-type.md) is a 32-bit address that points to an object instance within your application or in some other application. An `Object` variable can refer to any object your application recognizes, or to data of any data type. This includes both *value types*, such as `Integer`, `Boolean`, and structure instances, and *reference types*, which are instances of objects created from classes such as `String` and <xref:System.Windows.Forms.Form*>, and array instances.  
  
 If a variable stores a pointer to an instance of a class that you do not know at compile time, or if it can point to data of various data types, declare it as `Object`.  
  
 The advantage of the `Object` data type is that you can use it to store data of any data type. The disadvantage is that you incur extra operations that take more execution time and make your application perform slower. If you use an `Object` variable for value types, you incur *boxing* and *unboxing*. If you use it for reference types, you incur *late binding*.  
  
## See Also  
 [Type Characters](../VS_csharp/type-characters--visual-basic-.md)   
 [Elementary Data Types](../VS_csharp/elementary-data-types--visual-basic-.md)   
 [Numeric Data Types](../VS_csharp/numeric-data-types--visual-basic-.md)   
 [Character Data Types](../VS_csharp/character-data-types--visual-basic-.md)   
 [Troubleshooting Data Types](../VS_csharp/troubleshooting-data-types--visual-basic-.md)   
 [Early and Late Binding (Visual Basic)](../VS_csharp/early-and-late-binding--visual-basic-.md)