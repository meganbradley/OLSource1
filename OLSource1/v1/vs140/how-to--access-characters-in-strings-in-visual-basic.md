---
title: "How to: Access Characters in Strings in Visual Basic"
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
  - "strings [Visual Basic], accessing characters"
  - "characters [Visual Basic], accessing in strings"
ms.assetid: 02c5206c-ffab-494d-b648-3b2ea358dc34
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Access Characters in Strings in Visual Basic
This example demonstrates how to use the <xref:System.String.Chars*> property to access the character at the specified location in a string.  
  
## Example  
 Sometimes it is useful to have data about the characters in your string and the positions of those characters within your string. You can think of a string as an array of characters (`Char` instances); you can retrieve a particular character by referencing the index of that character through the <xref:System.String.Chars*> property.  
  
 [!code[VbVbalrStrings#49](../vs140/codesnippet/VisualBasic/how-to--access-characters-in-strings-in-visual-basic_1.vb)]  
  
 The `index` parameter of the <xref:System.String.Chars*> property is zero-based.  
  
## Robust Programming  
 The <xref:System.String.Chars*> property returns the character at the specified position. However, some Unicode characters can be represented by more than one character. For more information on how to work with Unicode characters, see [How to: Convert a String to an Array of Characters in Visual Basic](../vs140/how-to--convert-a-string-to-an-array-of-characters-in-visual-basic.md).  
  
 The <xref:System.String.Chars*> property throws an <xref:System.IndexOutOfRangeException*> exception if the `index` parameter is greater than or equal to the length of the string, or if it is less than zero  
  
## See Also  
 <xref:System.String.Chars*>   
 [How to: Convert a String to an Array of Characters in Visual Basic](../vs140/how-to--convert-a-string-to-an-array-of-characters-in-visual-basic.md)   
 [Converting between Strings and Other Data Types in Visual Basic](../vs140/converting-between-strings-and-other-data-types-in-visual-basic.md)   
 [Strings in Visual Basic](../vs140/strings-in-visual-basic.md)