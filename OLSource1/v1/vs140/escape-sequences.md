---
title: "Escape Sequences"
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
  - "\r escape sequence"
  - "double backslash"
  - "horizontal-tab \t escape sequence"
  - "(') single quotation mark"
  - "bell character \a escape sequence"
  - "escape sequences"
  - "hexadecimal escape sequence"
  - "carriage returns"
  - "tab \t escape sequence"
  - "\f escape sequence"
  - "quotation marks, single"
  - "formfeed \f escape sequence"
  - "\v escape sequence"
  - "control character escape sequences"
  - "\ symbol in escape sequences"
  - "octal escape sequence"
  - "escape characters"
  - "newline character \n escape sequence"
  - "nongraphic control characters"
  - "question mark, literal"
  - "\n escape sequence"
  - "vertical tab \v escape sequence"
  - "\a escape sequence"
  - "? symbol"
  - "? symbol, escape sequence character"
  - "\t escape sequence"
  - "backspace escape sequence"
ms.assetid: 5aef377f-a76c-4d5c-aa04-8308758ad6a8
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Escape Sequences
Character combinations consisting of a backslash (**\\**) followed by a letter or by a combination of digits are called "escape sequences." To represent a newline character, single quotation mark, or certain other characters in a character constant, you must use escape sequences. An escape sequence is regarded as a single character and is therefore valid as a character constant.  
  
 Escape sequences are typically used to specify actions such as carriage returns and tab movements on terminals and printers. They are also used to provide literal representations of nonprinting characters and characters that usually have special meanings, such as the double quotation mark (**"**). The following table lists the ANSI escape sequences and what they represent.  
  
 Note that the question mark preceded by a backslash (**\\?**) specifies a literal question mark in cases where the character sequence would be misinterpreted as a trigraph. See [Trigraphs](../vs140/trigraphs.md) for more information.  
  
### Escape Sequences  
  
|Escape Sequence|Represents|  
|---------------------|----------------|  
|**\a**|Bell (alert)|  
|**\b**|Backspace|  
|**\f**|Formfeed|  
|**\n**|New line|  
|**\r**|Carriage return|  
|**\t**|Horizontal tab|  
|**\v**|Vertical tab|  
|**\\'**|Single quotation mark|  
|**\\"**|Double quotation mark|  
|**\\\\**|Backslash|  
|**\\?**|Literal question mark|  
|**\\** *ooo*|ASCII character in octal notation|  
|**\x** *hh*|ASCII character in hexadecimal notation|  
|**\x** *hhhh*|Unicode character in hexadecimal notation if this escape sequence is used in a wide-character constant or a Unicode string literal.\<br />\<br /> For example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
  
 **Microsoft Specific**  
  
 If a backslash precedes a character that does not appear in the table, the compiler handles the undefined character as the character itself. For example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is treated as an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 **END Microsoft Specific**  
  
 Escape sequences allow you to send nongraphic control characters to a display device. For example, the ESC character (**\033**) is often used as the first character of a control command for a terminal or printer. Some escape sequences are device-specific. For instance, the vertical-tab and formfeed escape sequences (**\v** and **\f**) do not affect screen output, but they do perform appropriate printer operations.  
  
 You can also use the backslash (**\\**) as a continuation character. When a newline character (equivalent to pressing the RETURN key) immediately follows the backslash, the compiler ignores the backslash and the newline character and treats the next line as part of the previous line. This is useful primarily for preprocessor definitions longer than a single line. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [C Character Constants](../vs140/c-character-constants.md)