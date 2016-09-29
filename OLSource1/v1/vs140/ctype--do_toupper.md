---
title: "ctype::do_toupper"
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
  - "ctype.do_toupper"
  - "xlocale/std::ctype::do_toupper"
  - "do_toupper"
  - "ctype::do_toupper"
  - "std::ctype::do_toupper"
  - "std.ctype.do_toupper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_toupper method"
ms.assetid: 94b604c2-cc9c-4eb1-9c01-ea13a2a88e28
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_toupper
A virtual function called to convert a character or a range of characters to upper case.  
  
## Syntax  
  
```  
virtual CharType do_toupper(  
    CharType ch  
) const;  
virtual const CharType *do_toupper(  
    CharType* first,   
    const CharType* last  
) const;  
```  
  
#### Parameters  
 `ch`  
 The character to be converted to upper case.  
  
 `first`  
 A pointer to the first character in the range of characters whose cases are to be converted.  
  
 `last`  
 A pointer to character immediately following the last character in the range of characters whose cases are to be converted.  
  
## Return Value  
 The first protected member function returns the uppercase form of the parameter `ch`. If no uppercase form exists, it returns `ch`. The second protected member function returns `last`.  
  
## Remarks  
 The second protected member template function replaces each element `first` [`I`], for `I` in the interval [0, `last` – `first`), with `do_toupper`(`first` [`I`]).  
  
## Example  
 See the example for [toupper](../vs140/ctype--toupper.md), which calls `do_toupper`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)