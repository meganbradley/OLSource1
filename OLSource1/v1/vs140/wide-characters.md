---
title: "Wide Characters"
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
  - "wide characters"
ms.assetid: 165c4a12-8ab9-45fb-9964-c55e9956194c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Wide Characters
**ANSI 3.1.3.4** The value of an integer character constant that contains more than one character or a wide character constant that contains more than one multibyte character  
  
 The regular character constant, 'ab' has the integer value (int)0x6162. When there is more than one byte, previously read bytes are shifted left by the value of **CHAR_BIT** and the next byte is compared using the bitwise-OR operator with the low **CHAR_BIT** bits. The number of bytes in the multibyte character constant cannot exceed sizeof(int), which is 4 for 32-bit target code.  
  
 The multibyte character constant is read as above and this is converted to a wide-character constant using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> run-time function. If the result is not a valid wide-character constant, an error is issued. In any event, the number of bytes examined by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function is limited to the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## See Also  
 [Characters](../vs140/characters.md)