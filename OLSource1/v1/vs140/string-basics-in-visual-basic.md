---
title: "String Basics in Visual Basic"
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
  - strings [Visual Basic], Like operator
  - strings [Visual Basic], Visual Basic
  - strings [Visual Basic], regular expressions
ms.assetid: 5674418d-f00d-4f72-9f98-d15897793350
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# String Basics in Visual Basic
The `String` data type represents a series of characters (each representing in turn an instance of the `Char` data type). This topic introduces the basic concepts of strings in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)].  
  
## String Variables  
 An instance of a string can be assigned a literal value that represents a series of characters. For example:  
  
 [!code[VbVbalrStrings#63](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_1.vb)]
  
  
 A `String` variable can also accept any expression that evaluates to a string. Examples are shown below:  
  
 [!code[VbVbalrStrings#64](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_2.vb)]
  
  
 Any literal that is assigned to a `String` variable must be enclosed in quotation marks (""). This means that a quotation mark within a string cannot be represented by a quotation mark. For example, the following code causes a compiler error:  
  
 [!code[VbVbalrStrings#65](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_3.vb)]
  
  
 This code causes an error because the compiler terminates the string after the second quotation mark, and the remainder of the string is interpreted as code. To solve this problem, [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] interprets two quotation marks in a string literal as one quotation mark in the string. The following example demonstrates the correct way to include a quotation mark in a string:  
  
 [!code[VbVbalrStrings#66](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_4.vb)]
  
  
 In the preceding example, the two quotation marks preceding the word `Look` become one quotation mark in the string. The three quotation marks at the end of the line represent one quotation mark in the string and the string termination character.  
  
 String literals can contain multiple lines:  
  
```vb  
Dim x = "hello  
world"  
  
```  
  
 The resulting string contains newline sequences that you used in your string literal (vbcr, vbcrlf, etc.).  You no longer need to use the old workaround:  
  
```vb  
Dim x = <xml><![CDATA[Hello  
World]]></xml>.Value  
  
```  
  
## Characters in Strings  
 A string can be thought of as a series of `Char` values, and the `String` type has built-in functions that allow you to perform many manipulations on a string that resemble the manipulations allowed by arrays. Like all array in [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], these are zero-based arrays. You may refer to a specific character in a string through the `Chars` property, which provides a way to access a character by the position in which it appears in the string. For example:  
  
 [!code[VbVbalrStrings#67](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_5.vb)]
  
  
 In the above example, the `Chars` property of the string returns the fourth character in the string, which is `D`, and assigns it to `myChar`. You can also get the length of a particular string through the `Length` property. If you need to perform multiple array-type manipulations on a string, you can convert it to an array of `Char` instances using the `ToCharArray` function of the string. For example:  
  
 [!code[VbVbalrStrings#68](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_6.vb)]
  
  
 The variable `myArray` now contains an array of `Char` values, each representing a character from `myString`.  
  
## The Immutability of Strings  
 A string is *immutable*, which means its value cannot be changed once it has been created. However, this does not prevent you from assigning more than one value to a string variable. Consider the following example:  
  
 [!code[VbVbalrStrings#69](../vs140/codesnippet/VisualBasic/string-basics-in-visual-basic_7.vb)]
  
  
 Here, a string variable is created, given a value, and then its value is changed.  
  
 More specifically, in the first line, an instance of type `String` is created and given the value `This string is immutable`. In the second line of the example, a new instance is created and given the value `Or is it?`, and the string variable discards its reference to the first instance and stores a reference to the new instance.  
  
 Unlike other intrinsic data types, `String` is a reference type. When a variable of reference type is passed as an argument to a function or subroutine, a reference to the memory address where the data is stored is passed instead of the actual value of the string. So in the previous example, the name of the variable remains the same, but it points to a new and different instance of the `String` class, which holds the new value.  
  
## See Also  
 [Introduction to Strings in Visual Basic](../vs140/introduction-to-strings-in-visual-basic.md)   
 [String Data Type (Visual Basic)](../vs140/string-data-type--visual-basic-.md)   
 [Char Data Type](../vs140/char-data-type--visual-basic-.md)   
 [Basic String Operations](assetId:///8133d357-90b5-4b62-9927-43323d99b6b6)