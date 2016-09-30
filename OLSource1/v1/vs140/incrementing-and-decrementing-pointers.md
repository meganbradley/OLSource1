---
title: "Incrementing and Decrementing Pointers"
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
helpviewer_keywords: 
  - "incrementing pointers"
  - "MBCS [C++], pointers"
  - "pointers [C++], multibyte characters"
  - "decrementing pointers"
ms.assetid: 0872b4a0-e2bd-4004-8319-070efb76f2fd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Incrementing and Decrementing Pointers
Use the following tips:  
  
-   Point to lead bytes, not trail bytes. It is usually unsafe to have a pointer to a trail byte. It is usually safer to scan a string forward rather than in reverse.  
  
-   There are pointer increment/decrement functions and macros available that move over a whole character:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     becomes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions correctly increment and decrement in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> units, regardless of the character size.  
  
-   For decrements, you need a pointer to the head of the string, as in the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     becomes:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Alternatively, your head pointer could be to a valid character in the string, such that:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     You must have a pointer to a known valid lead byte.  
  
-   You might want to maintain a pointer to the previous character for faster calls to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## See Also  
 [MBCS Programming Tips](../vs140/mbcs-programming-tips.md)   
 [Byte Indices](../vs140/byte-indices.md)