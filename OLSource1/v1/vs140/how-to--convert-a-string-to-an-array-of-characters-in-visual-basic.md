---
title: "How to: Convert a String to an Array of Characters in Visual Basic"
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
  - "character arrays, converting strings"
  - "arrays [Visual Basic], converting strings to"
  - "examples [Visual Basic], string conversion"
  - "strings [Visual Basic], converting to arrays"
  - "string conversion [Visual Basic], arrays"
ms.assetid: 1b54b686-ab29-413b-adce-6bd5422376eb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert a String to an Array of Characters in Visual Basic
Sometimes it is useful to have data about the characters in your string and the positions of those characters within your string, such as when you are parsing a string. This example shows how you can get an array of the characters in a string by calling the string's <xref:System.String.ToCharArray*> method.  
  
## Example  
 This example demonstrates how to split a string into a `Char` array, and how to split a string into a `String` array of its Unicode text characters. The reason for this distinction is that Unicode text characters can be composed of two or more `Char` characters (such as a surrogate pair or a combining character sequence). For more information, see <xref:System.Globalization.TextElementEnumerator*> and "The Unicode Standard" at http://www.unicode.org.  
  
 [!code[VbVbalrStrings#75](../vs140/codesnippet/VisualBasic/how-to--convert-a-string-to-an-array-of-characters-in-visual-basic_1.vb)]  
  
## Example  
 It is more difficult to split a string into its Unicode text characters, but this is necessary if you need information about the visual representation of a string. This example uses the <xref:System.Globalization.StringInfo.SubstringByTextElements*> method to get information about the Unicode text characters that make up a string.  
  
 [!code[VbVbalrStrings#76](../vs140/codesnippet/VisualBasic/how-to--convert-a-string-to-an-array-of-characters-in-visual-basic_2.vb)]  
  
## See Also  
 <xref:System.String.Chars*>   
 <xref:System.Globalization.StringInfo*?displayProperty=fullName>   
 [How to: Access Characters in Strings in Visual Basic](../vs140/how-to--access-characters-in-strings-in-visual-basic.md)   
 [Converting between Strings and Other Data Types in Visual Basic](../vs140/converting-between-strings-and-other-data-types-in-visual-basic.md)   
 [Strings in Visual Basic](../vs140/strings-in-visual-basic.md)