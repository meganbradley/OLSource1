---
title: "Multibyte and Wide Characters"
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
  - "globalization [C++], character sets"
  - "character data types [C]"
  - "Unicode [C++], wide character set"
  - "types [C], character"
  - "characters [C++], wide"
  - "international applications [C++], character display"
  - "multibyte characters [C++]"
  - "wide characters [C++]"
  - "characters [C++], codes"
  - "character codes [C++], wide"
  - "character codes [C++], multibyte"
ms.assetid: 1943c469-200d-4724-b18f-781d70520f9e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Multibyte and Wide Characters
A multibyte character is a character composed of sequences of one or more bytes. Each byte sequence represents a single character in the extended character set. Multibyte characters are used in character sets such as Kanji.  
  
 Wide characters are multilingual character codes that are always 16 bits wide. The type for character constants is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>; for wide characters, the type is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Since wide characters are always a fixed size, using wide characters simplifies programming with international character sets.  
  
 The wide-character-string literal <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> becomes an array of six integers of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The Unicode specification is the specification for wide characters. The run-time library routines for translating between multibyte and wide characters include <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## See Also  
 [C Identifiers](../vs140/c-identifiers.md)