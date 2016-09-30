---
title: "map::count"
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
  - "map.count"
  - "count"
  - "map::count"
  - "std.map.count"
  - "map/std::map::count"
  - "std::map::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: 0d93c45f-78b6-4022-b6f9-6338844740fc
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::count
Returns the number of elements in a map whose key matches a parameter-specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The key value of the elements to be matched from the map.  
  
## Return Value  
 1 if the map contains an element whose sort key matches the parameter key; 0 if the map does not contain an element with a matching key.  
  
## Remarks  
 The member function returns the number of elements *x* in the range  
  
 [<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (_*Key* ), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (\_*Key* ) )  
  
 which is 0 or 1 in the case of map, which is a unique associative container.  
  
## Example  
 The following example demonstrates the use of the map::count member function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The number of elements in m1 with a sort key of 1 is: 1.**  
**The number of elements in m1 with a sort key of 2 is: 1.**  
**The number of elements in m1 with a sort key of 3 is: 0.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)