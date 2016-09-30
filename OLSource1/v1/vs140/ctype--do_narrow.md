---
title: "ctype::do_narrow"
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
  - "do_narrow"
  - "std::ctype::do_narrow"
  - "ctype::do_narrow"
  - "ctype.do_narrow"
  - "xlocale/std::ctype::do_narrow"
  - "std.ctype.do_narrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_narrow method"
ms.assetid: 30f5a29d-064f-45d3-9996-97d56951f5a8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_narrow
A virtual function called to convert a character of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> used by a locale to the corresponding character of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the native character set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The character of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> used by the locale to be converted.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The default value to be assigned by the member function to characters of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that do not have counterpart characters of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A const pointer to the first character of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first protected member function returns the native character of type char that corresponds to the parameter character of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if no counterpart is defined.  
  
 The second protected member function returns a pointer to the destination range of native characters converted from characters of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The second protected member template function stores in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>] the value <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>], <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>), for <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> in the interval [0, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>).  
  
## Example  
 See the example for [narrow](../vs140/ctype--narrow.md), which calls <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)