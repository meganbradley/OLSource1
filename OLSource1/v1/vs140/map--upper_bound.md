---
title: "map::upper_bound"
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
  - "map.upper_bound"
  - "map/std::map::upper_bound"
  - "upper_bound"
  - "std.map.upper_bound"
  - "std::map::upper_bound"
  - "map::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound method"
ms.assetid: 26418d42-e8ae-4c1b-b6d0-3309aa841e3f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::upper_bound
Returns an iterator to the first element in a map that with a key having a value that is greater than that of a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The argument key value to be compared with the sort key value of an element from the map being searched.  
  
## Return Value  
 An **iterator** or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that addresses the location of an element in a map that with a key that is greater than the argument key, or that addresses the location succeeding the last element in the map if no match is found for the key.  
  
 If the return value is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the map object cannot be modified. If the return value is assigned to a **iterator**, the map object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of map m1 with a key greater than 2 is: 30.**  
**The map m1 doesn't have an element with a key greater than 4.**  
**The 1st element of m1 with a key greater than**  
**that of the initial element of m1 is: 20.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)