---
title: "set::value_compare"
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
  - "value_compare"
  - "std::set::value_compare"
  - "set::value_compare"
  - "set.value_compare"
  - "std.set.value_compare"
  - "set/std::set::value_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_compare method"
  - "value_compare typedef"
ms.assetid: 3ea9e2d5-10c4-4501-9e89-ffe689806beb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::value_compare
A type that provides a function object that can compare two element values to determine their relative order in the set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a synonym for the template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
 Note that both [key_compare](../vs140/set--key_compare.md) and **value_compare** are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
## Example  
 See the example for [value_comp](../vs140/set--value_comp.md) for an example of how to declare and use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)