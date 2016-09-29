---
title: "Character Data Types (Visual Basic)"
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
  - "data types [Visual Basic], character"
  - "String data type, character data types"
  - "character data types [Visual Basic]"
  - "Char data type, character data types"
  - "data types [Visual Basic], choosing"
ms.assetid: 902479ef-1679-47fc-9911-0c1c5008226c
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Character Data Types (Visual Basic)
[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] provides *character data types* to deal with printable and displayable characters. While they both deal with Unicode characters, `Char` holds a single character whereas `String` contains an indefinite number of characters.  
  
 For a table that displays a side-by-side comparison of the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] data types, see [Data Type Summary (Visual Basic)](../vs140/data-type-summary--visual-basic-.md).  
  
## Char Type  
 The `Char` data type is a single two-byte (16-bit) Unicode character. If a variable always stores exactly one character, declare it as `Char`. For example:  
  
 [!code[VbVbalrCharTypes#1](../vs140/codesnippet/VisualBasic/character-data-types--visual-basic-_1.vb)]  
  
 Each possible value in a `Char` or `String` variable is a *code point*, or character code, in the Unicode character set. Unicode characters include the basic ASCII character set, various other alphabet letters, accents, currency symbols, fractions, diacritics, and mathematical and technical symbols.  
  
> [!NOTE]
>  The Unicode character set reserves the code points D800 through DFFF (55296 through 55551 decimal) for *surrogate pairs*, which require two 16-bit values to represent a single code point. A `Char` variable cannot hold a surrogate pair, and a `String` uses two positions to hold such a pair.  
  
 For more information, see [Char Data Type](../vs140/char-data-type--visual-basic-.md).  
  
## String Type  
 The `String` data type is a sequence of zero or more two-byte (16-bit) Unicode characters. If a variable can contain an indefinite number of characters, declare it as `String`. For example:  
  
 [!code[VbVbalrCharTypes#2](../vs140/codesnippet/VisualBasic/character-data-types--visual-basic-_2.vb)]  
  
 For more information, see [String Data Type](../vs140/string-data-type--visual-basic-.md).  
  
## See Also  
 [Elementary Data Types](../vs140/elementary-data-types--visual-basic-.md)   
 [Composite Data Types](../vs140/composite-data-types--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Value Types and Reference Types](../vs140/value-types-and-reference-types.md)   
 [Type Conversions in Visual Basic](../vs140/type-conversions-in-visual-basic.md)   
 [Troubleshooting Data Types](../vs140/troubleshooting-data-types--visual-basic-.md)   
 [Type Characters](../vs140/type-characters--visual-basic-.md)