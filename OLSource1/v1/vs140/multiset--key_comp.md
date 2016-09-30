---
title: "multiset::key_comp"
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
  - "multiset::key_comp"
  - "key_comp"
  - "std::multiset::key_comp"
  - "set/std::multiset::key_comp"
  - "std.multiset.key_comp"
  - "multiset.key_comp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "key_comp method"
ms.assetid: 490a2540-a186-49b7-b92b-b944596a46d3
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::key_comp
Retrieves a copy of the comparison object used to order keys in a multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the function object that a multiset uses to order its elements, which is the template parameter <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, see the Remarks section of the [multiset Class](../vs140/multiset-class.md) topic.  
  
## Remarks  
 The stored object defines the member function:  
  
 **bool operator**(**const Key&** *x*, **const Key&** *y*);  
  
 which returns true if *x* strictly precedes *y* in the sort order.  
  
 Note that both [key_compare](../vs140/multiset--key_compare.md) and [value_compare](../vs140/multiset--value_compare.md) are synonyms for the template parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Both types are provided for the classes set and multiset, where they are identical, for compatibility with the classes map and multimap, where they are distinct.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **kc1( 2,3 ) returns value of true, where kc1 is the function object of s1.**  
**kc2( 2,3 ) returns value of false, where kc2 is the function object of ms2.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)