---
title: "Character Assignment"
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
  - "characters [C++], assignments"
  - "MBCS [C++], character assignments"
ms.assetid: dcc329cd-92df-4e20-817d-364be62ff28f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Character Assignment
Consider the following example, in which the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop scans a string, copying all characters except 'X' into another string:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The code copies the byte at <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the location pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then increments <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to receive the next byte. But if the next character in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a double-byte character, the assignment to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> copies only the first byte. The following code uses a portable function to copy the character safely and another to increment <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> correctly:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [MBCS Programming Tips](../vs140/mbcs-programming-tips.md)   
 [Character Comparison](../vs140/character-comparison.md)