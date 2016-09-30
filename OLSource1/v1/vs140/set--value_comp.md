---
title: "set::value_comp"
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
  - "value_comp"
  - "set::value_comp"
  - "std::set::value_comp"
  - "set.value_comp"
  - "std.set.value_comp"
  - "set/std::set::value_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_comp method"
ms.assetid: 69aa575d-f2e2-4ed8-9a36-2eed6d325555
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::value_comp
Retrieves a copy of the comparison object used to order element values in a set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a set uses to order its elements, which is the template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> see the [set Class](../vs140/set-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator**(**const Key&** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, **const Key&** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>);  
  
 which returns **true** if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> precedes and is not equal to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the sort order.  
  
 Note that both [value_compare](../vs140/set--value_compare.md) and [key_compare](../vs140/set--key_compare.md) are synonyms for the template parameter **Traits**. Both types are provided for the set and multiset classes, where they are identical, for compatibility with the map and multimap classes, where they are distinct.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **vc1( 2,3 ) returns value of true, where vc1 is the function object of s1.**  
**vc2( 2,3 ) returns value of false, where vc2 is the function object of s2.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [set Class](../vs140/set-class.md)   
 [set::key_comp and set::value_comp](../vs140/set--key_comp-and-set--value_comp.md)   
 [Standard Template Library](../vs140/standard-template-library.md)