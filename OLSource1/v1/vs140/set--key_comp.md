---
title: "set::key_comp"
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
  - "key_comp"
  - "std.set.key_comp"
  - "set/std::set::key_comp"
  - "std::set::key_comp"
  - "set::key_comp"
  - "set.key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 97bfc953-c4a1-44e2-b1fa-416e0122b649
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::key_comp
Retrieves a copy of the comparison object used to order keys in a set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator()**(**const Key&** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, **const Key&** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [key_compare](../vs140/set--key_compare.md) and [value_compare](../vs140/set--value_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **kc1( 2,3 ) returns value of true, where kc1 is the function object of s1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of s2.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::key_comp and set::value_comp](../vs140/set--key_comp-and-set--value_comp.md)   
 [Standard Template Library](../vs140/standard-template-library.md)