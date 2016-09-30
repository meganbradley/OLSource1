---
title: "ctype::do_widen"
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
  - "std.ctype.do_widen"
  - "ctype.do_widen"
  - "xlocale/std::ctype::do_widen"
  - "ctype::do_widen"
  - "std::ctype::do_widen"
  - "do_widen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_widen method"
ms.assetid: 4cffeaff-8b98-4651-9b9a-c66c3dc13b35
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_widen
A virtual function called to converts a character of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the native character set to the corresponding character of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> used by a locale.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The character of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the native character set to be converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the first character of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first protected member function returns the character of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that corresponds to the parameter character of native type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 The second protected member function returns a pointer to the destination range of characters of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> used by a locale converted from native characters of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 The second protected member template function stores in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>] the value <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>]), for <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> - <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>).  
  
## Example  
 See the example for [widen](../vs140/ctype--widen.md), which calls <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)