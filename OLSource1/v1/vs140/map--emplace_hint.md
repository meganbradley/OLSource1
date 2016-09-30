---
title: "map::emplace_hint"
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
  - "map/std::map::emplace_hint"
  - "std.map.emplace_hint"
  - "std::map::emplace_hint"
  - "map.emplace_hint"
  - "map::emplace_hint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_hint method"
ms.assetid: f4988068-3392-4ab8-980b-90f8d866a030
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# map::emplace_hint
Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the map unless the map already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The place to start searching for the correct point of insertion. (If that point immediately precedes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, insertion can occur in amortized constant time instead of logarithmic time.)|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element with its key.  
  
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