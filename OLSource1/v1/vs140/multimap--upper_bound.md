---
title: "multimap::upper_bound"
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
  - "multimap.upper_bound"
  - "std::multimap::upper_bound"
  - "std.multimap.upper_bound"
  - "multimap::upper_bound"
  - "upper_bound"
  - "map/std::multimap::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: 5d103738-4480-480a-bb7d-3187626bbb35
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::upper_bound
Returns an iterator to the first element in a multimap that with a key that is greater than a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key to be compared with the sort key of an element from the multimap being searched.  
  
## Return Value  
 An iterator or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a multimap that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the multimap if no match is found for the key.  
  
 If the return value is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the multimap object cannot be modified. If the return value is assigned to a **iterator**, the multimap object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The 1st element of multimap m1 with a key greater than 1 is: 20.**  
**The first element of multimap m1 with a key  greater than 2 is: 30.**  
**The multimap m1 doesn't have an element with a key of 4.**  
**The first element of m1 with a key greater than**  
**that of the initial element of m1 is: 20.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)