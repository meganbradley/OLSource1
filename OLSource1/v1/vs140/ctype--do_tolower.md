---
title: "ctype::do_tolower"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::ctype::do_tolower
  - ctype.do_tolower
  - ctype::do_tolower
  - std.ctype.do_tolower
  - xlocale/std::ctype::do_tolower
  - do_tolower
dev_langs: 
  - C++
helpviewer_keywords: 
  - do_tolower method
ms.assetid: 593cec79-c7c8-4b15-8068-8780f4f80581
caps.latest.revision: 18
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ctype::do_tolower
A virtual function called to convert a character or a range of characters to lower case.  
  
## Syntax  
  
```  
virtual CharType do_tolower(  
    CharType ch  
) const;  
virtual const CharType *do_tolower(  
    CharType* first,   
    const CharType* last  
) const;  
```  
  
#### Parameters  
 `ch`  
 The character to be converted to lower case.  
  
 `first`  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 `last`  
 A pointer to the character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first protected member function returns the lowercase form of the parameter `ch`. If no lowercase form exists, it returns `ch`. The second protected member function returns `last`.  
  
## Remarks  
 The second protected member template function replaces each element `first` [`I`], for `I` in the interval [0, `last` – `first`), with `do_tolower`(`first` [`I`]).  
  
## Example  
 See the example for [tolower](../vs140/ctype--tolower.md), which calls `do_tolower`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)