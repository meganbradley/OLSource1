---
title: "map::emplace"
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
  - "std::map::emplace"
  - "map::emplace"
  - "map/std::map::emplace"
  - "std.map.emplace"
  - "map.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: ca98a183-6cf4-49db-82ae-92fac94c0407
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::emplace
Inserts an element constructed in place (no copy or move operations are performed) into a map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the map unless it already contains an element whose value is equivalently ordered.|  
  
## Return Value  
 A [pair](../vs140/pair-structure.md) whose <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> component is true if an insertion was made, and false if the map already contained an element of equivalent value in the ordering. The iterator component of the return-value pair points to the newly inserted element if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> component is true, or to the existing element if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> component is false.  
  
 To access the iterator component of a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; to dereference it, use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. To access the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> component, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For an example, see the sample code later in this article.  
  
## Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [\<map>](../vs140/-map-.md)   
 [map Class](../vs140/map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)