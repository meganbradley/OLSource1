---
title: "ctype::do_scan_is"
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
  - "ctype.do_scan_is"
  - "std::ctype::do_scan_is"
  - "do_scan_is"
  - "ctype::do_scan_is"
  - "std.ctype.do_scan_is"
  - "xlocale/std::ctype::do_scan_is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_scan_is method"
ms.assetid: da6a230b-5f02-4dbd-9c8e-695aa4e3ab99
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_scan_is
A virtual function called to locate the first character in a range that matches a specified mask.  
  
## Syntax  
  
```  
virtual const CharType *do_scan_is(  
    mask maskVal,   
    const CharType* first,   
    const CharType* last,  
) const;  
```  
  
#### Parameters  
 `maskVal`  
 The mask value to be matched by a character.  
  
 `first`  
 A pointer to the first character in the range to be scanned.  
  
 `last`  
 A pointer to the character immediately following the last character in the range to be scanned.  
  
## Return Value  
 A pointer to the first character in a range that does match a specified mask. If no such value exists, the function returns `last.`  
  
## Remarks  
 The protected member function returns the smallest pointer `ptr` in the range [`first`, `last`) for which [do_is](../vs140/ctype--do_is.md)(`maskVal`, *`ptr`) is true.  
  
## Example  
 See the example for [scan_is](../vs140/ctype--scan_is.md), which calls `do_scan_is`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)