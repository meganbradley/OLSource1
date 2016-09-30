---
title: "ctype::narrow"
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
  - "xlocale/std::ctype::narrow"
  - "ctype.narrow"
  - "narrow"
  - "ctype::narrow"
  - "Narrow"
  - "std.ctype.narrow"
  - "std::ctype::narrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "narrow method"
ms.assetid: 2d2f6865-babb-400e-9d65-eb651c31feda
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::narrow
Converts characters of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> used by a locale to the corresponding characters of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the native character set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The character of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> used by the locale to be converted.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The default value to be assigned by the member function to characters of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that do not have counterpart characters of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the first character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A const pointer to the first character of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first member function returns the native character of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that corresponds to the parameter character of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if not counterpart is defined.  
  
 The second member function returns a pointer to the destination range of native characters converted from characters of type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 The first member function returns [do_narrow](../vs140/ctype--do_narrow.md)(<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>). The second member function returns [do_narrow](../vs140/ctype--do_narrow.md) (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>). Only the basic source characters are guaranteed to have a unique inverse image <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> under <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For these basic source characters, the following invariant holds: <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> ( [widen](../vs140/ctype--widen.md) ( **c** ), 0 ) == **c**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Xhello everyone**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)