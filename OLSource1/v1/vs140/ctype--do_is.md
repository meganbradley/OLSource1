---
title: "ctype::do_is"
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
  - "ctype::do_is"
  - "xlocale/std::ctype::do_is"
  - "ctype.do_is"
  - "do_is"
  - "std::ctype::do_is"
  - "std.ctype.do_is"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_is method"
ms.assetid: dfeb6ffe-c40b-4fe9-98a3-7e9b2f3485a8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype::do_is
A virtual function called to test whether a single character has a particular attribute, or classify the attributes of each character in a range and stores them in an array.  
  
## Syntax  
  
```  
virtual bool do_is(  
    mask maskVal,   
    CharType ch  
) const;  
virtual const CharType *do_is(  
    const CharType* first,   
    const CharType* last,  
    mask* dest  
) const;  
```  
  
#### Parameters  
 `maskVal`  
 The mask value for which the character is to be tested.  
  
 `ch`  
 The character whose attributes are to be tested.  
  
 `first`  
 A pointer to the first character in the range whose attributes are to be classified.  
  
 `last`  
 A pointer to the character immediately following the last character in the range whose attributes are to be classified.  
  
 `dest`  
 A pointer to the beginning of the array where the mask values characterizing the attributes of each of the characters are to be stored.  
  
## Return Value  
 The first member function returns a Boolean value that is **true** if the character tested has the attribute described by the mask value; **false** if it fails to have the attribute.  
  
 The second member function returns an array containing the mask values characterizing the attributes of each of the characters in the range.  
  
## Remarks  
 The mask values classifying the attributes of the characters are provided by the class [ctype_base](../vs140/ctype_base-class.md), from which ctype derives. The first member function can accept expressions for its first parameter referred to as bitmasks and formed from the combination of mask values by the logical bitwise operators (&#124; , & , ^ , ~).  
  
## Example  
 See the example for [is](../vs140/ctype--is.md), which calls `do_is`.  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [ctype Class](../vs140/ctype-class.md)