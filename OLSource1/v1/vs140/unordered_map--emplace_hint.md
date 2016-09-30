---
title: "unordered_map::emplace_hint"
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
  - "unordered_map/std::tr1::unordered_map::emplace_hint"
  - "unordered_map::emplace_hint"
  - "std::tr1::unordered_map::emplace_hint"
  - "std.tr1.unordered_map.emplace_hint"
  - "unordered_map.emplace_hint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace_hint method"
ms.assetid: 5655f5e8-8633-4e3c-84ae-155e598274c8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::emplace_hint
Inserts an element constructed in place (no copy or move operations are performed), with a placement hint.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the unordered_map unless the unordered_map already contains that element or, more generally, unless it already contains an element whose key is equivalently ordered.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A hint regarding the place to start searching for the correct point of insertion.|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
 If the insertion failed because the element already exists, returns an iterator to the existing element.  
  
## Remarks  
 No references are invalidated by this function.  
  
 During the insertion, if an exception is thrown but does not occur in the container's hash function, the container is not modified. If the exception is thrown in the hash function, the result is undefined.  
  
 The [value_type](../vs140/map--value_type.md) of an element is a pair, so that the value of an element will be an ordered pair with the first component equal to the key value and the second component equal to the data value of the element.  
  
 For a code example, see [map::emplace_hint](../vs140/map--emplace_hint.md).  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map Class](../vs140/unordered_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)