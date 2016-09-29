---
title: "C String Literals"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "string literals, syntax"
  - "strings [C++], string literals"
  - "literal strings, C"
ms.assetid: 4b05523e-49a2-4900-b21a-754350af3328
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C String Literals
A "string literal" is a sequence of characters from the source character set enclosed in double quotation marks (**" "**). String literals are used to represent a sequence of characters which, taken together, form a null-terminated string. You must always prefix wide-string literals with the letter **L**.  
  
## Syntax  
 *string-literal*:  
 **"** *s-char-sequence* opt**"**  
  
 **L"** *s-char-sequence* opt**"**  
  
 *s-char-sequence*:  
 *s-char*  
  
 *s-char-sequence s-char*  
  
 *s-char*:  
 any member of the source character set except the double quotation mark ("), backslash (\\), or newline character  
  
 *escape-sequence*  
  
 The example below is a simple string literal:  
  
```  
char *amessage = "This is a string literal.";  
```  
  
 All escape codes listed in the [Escape Sequences](../vs140/escape-sequences.md) table are valid in string literals. To represent a double quotation mark in a string literal, use the escape sequence **\\"**. The single quotation mark (**'**) can be represented without an escape sequence. The backslash (**\\**) must be followed with a second backslash (**\\\\**) when it appears within a string. When a backslash appears at the end of a line, it is always interpreted as a line-continuation character.  
  
## See Also  
 [Elements of C](../vs140/elements-of-c.md)