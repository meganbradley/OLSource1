---
title: "ctype::widen"
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
  - "widen"
  - "std::ctype::widen"
  - "ctype::widen"
  - "xlocale/std::ctype::widen"
  - "std.ctype.widen"
  - "ctype.widen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "widen method"
ms.assetid: 02a9ded9-4af9-44aa-a35e-235f2a586fd4
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::widen
Converts a character of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the native character set to the corresponding character of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> used by a locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character of type char in the native character set to be converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the first character of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first member function returns the character of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that corresponds to the parameter character of native type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The second member function returns a pointer to the destination range of characters of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> used by a locale converted from native characters of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first member function returns [do_widen](../vs140/ctype--do_widen.md)(<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). The second member function returns [do_widen](../vs140/ctype--do_widen.md)(<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Hello everyone!**  
**Hello everyone!**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)