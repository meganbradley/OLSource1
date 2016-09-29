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
A virtual function called to converts a character of type `char` in the native character set to the corresponding character of type `CharType` used by a locale.  
  
## Syntax  
  
```  
virtual CharType do_widen(  
    char byte  
) const;  
virtual const char *do_widen(  
    const char* first,   
    const char* last,   
    CharType* dest  
) const;  
```  
  
#### Parameters  
 `byte`  
 The character of type `char` in the native character set to be converted.  
  
 `first`  
 A pointer to the first character in the range of characters to be converted.  
  
 `last`  
 A pointer to the character immediately following the last character in the range of characters to be converted.  
  
 `dest`  
 A pointer to the first character of type `CharType` in the destination range that stores the converted range of characters.  
  
## Return Value  
 The first protected member function returns the character of type `CharType` that corresponds to the parameter character of native type `char`.  
  
 The second protected member function returns a pointer to the destination range of characters of type `CharType` used by a locale converted from native characters of type `char`.  
  
## Remarks  
 The second protected member template function stores in `dest`[`I`] the value `do_widen`(`first`[`I`]), for `I` in the interval [0, `last` - `first`).  
  
## Example  
 See the example for [widen](../vs140/ctype--widen.md), which calls `do_widen`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)