---
title: "char_traits::find"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "find"
  - "char_traits::find"
  - "std::char_traits::find"
  - "Find"
  - "char_traits.find"
  - "std.char_traits.find"
  - "iosfwd/std::char_traits::find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "find method"
ms.assetid: bf374b73-d82b-4292-bfdb-618cce4d312d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::find
Searches for the first occurrence of a specified character in a range of characters.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first character in the string to be searched.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of positions, counting from the first, in the range to be searched.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character to be searched for in the range.  
  
## Return Value  
 A pointer to the first occurrence of the specified character in the range if a match is found; otherwise, a null pointer.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The string to be searched is: f2d-1234-abcd**  
**The character searched for in s1 is: d**  
**The string beginning with the first occurrence**  
 **of the character 'd' is: d-1234-abcd**  
**The result2 of the search is NULL.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)