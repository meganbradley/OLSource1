---
title: "Character Types"
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
  - "character data types [C]"
  - "types [C], character"
ms.assetid: d3ca8cda-c0d7-43af-9472-697e8ef015ce
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Character Types
An integer character constant not preceded by the letter **L** has type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. The value of an integer character constant containing a single character is the numerical value of the character interpreted as an integer. For example, the numerical value of the character <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is 97 in decimal and 61 in hexadecimal.  
  
 Syntactically, a "wide-character constant" is a character constant prefixed by the letter **L**. A wide-character constant has type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, an integer type defined in the STDDEF.H header file. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Wide-character constants are 16 bits wide and specify members of the extended execution character set. They allow you to express characters in alphabets that are too large to be represented by type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. See [Multibyte and Wide Characters](../vs140/multibyte-and-wide-characters.md) for more information about wide characters.  
  
## See Also  
 [C Character Constants](../vs140/c-character-constants.md)