---
title: "multiset::lower_bound"
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
  - "set/std::multiset::lower_bound"
  - "multiset::lower_bound"
  - "lower_bound"
  - "std::multiset::lower_bound"
  - "multiset.lower_bound"
  - "std.multiset.lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: d48dabb8-dea3-4275-8957-eec465dd9fd4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::lower_bound
Returns an iterator to the first element in a multiset with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multiset being searched.  
  
## Return Value  
 An **iterator** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a multiset that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the multiset if no match is found for the key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The element of multiset ms1 with a key of 20 is: 20.**  
**The multiset ms1 doesn't have an element with a key of 40.**  
**The element of ms1 with a key matching that of the last element is: 30.**   
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)