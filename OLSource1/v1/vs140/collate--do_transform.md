---
title: "collate::do_transform"
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
  - "collate::do_transform"
  - "collate.do_transform"
  - "std.collate.do_transform"
  - "locale/std::collate::do_transform"
  - "do_transform"
  - "std::collate::do_transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_transform method"
ms.assetid: 9b0f6a68-0ea2-4004-86fd-21cdc78ca9f1
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# collate::do_transform
A virtual function called to convert a character sequence from a locale to a string that may be used in lexicographical comparisons with other character sequences similarly converted from the same locale.  
  
## Syntax  
  
```  
  
      virtual string  
      _  
      type do  
      _  
      transform(  
   const CharType* _First,  
   const CharType* _Last  
) const;  
```  
  
#### Parameters  
 `_First`  
 A pointer to the first character in the sequence to be converted.  
  
 `_Last`  
 A pointer to the last character in the sequence to be converted.  
  
## Return Value  
 A string that is the transformed character sequence.  
  
## Remarks  
 The protected virtual member function returns an object of class [string_type](../vs140/collate--string_type.md) whose controlled sequence is a copy of the sequence [`_First`, `_Last`). If a class derived from collate<**CharType**> overrides [do_compare](../vs140/collate--do_compare.md), it should also override `do_transform` to match. When passed to `collate::compare`, two transformed strings should yield the same result that you would get from passing the untransformed strings to compare in the derived class.  
  
## Example  
 See the example for [transform](../vs140/collate--transform.md), which calls `do_transform`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [collate Class](../vs140/collate-class.md)