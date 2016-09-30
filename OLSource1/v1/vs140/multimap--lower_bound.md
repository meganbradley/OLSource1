---
title: "multimap::lower_bound"
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
  - "multimap::lower_bound"
  - "std.multimap.lower_bound"
  - "map/std::multimap::lower_bound"
  - "lower_bound"
  - "std::multimap::lower_bound"
  - "multimap.lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound function"
ms.assetid: a60a3bea-a891-47d6-8f15-3ea63ffaad1a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::lower_bound
Returns an iterator to the first element in a multimap that with a key that is equal to or greater than a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
## Return Value  
 An iterator or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a multimap that with a key that is equal to or greater than the argument key, or that addresses the location succeeding the last element in the multimap if no match is found for the key.  
  
 If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is assigned to an **iterator**, the multimap object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The element of multimap m1 with a key of 2 is: 20.**  
**The first element of multimap m1 with a key of 3 is: 20.**  
**The multimap m1 doesn't have an element with a key of 4.**  
**The first element of m1 with a key matching**  
**that of the last element is: 20.**  
**This is not the last element of multimap m1.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)