---
title: "multimap::emplace"
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
  - "multimap.emplace"
  - "map/std::multimap::emplace"
  - "multimap::emplace"
  - "std::multimap::emplace"
  - "std.multimap.emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: 2e60cee0-1cec-482d-aa1f-caf3e58cb2f2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::emplace
Inserts an element constructed in place (no copy or move operations are performed).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the multimap.|  
  
## Return Value  
 An iterator to the newly inserted element.  
  
## Remarks  
 No references to container elements are invalidated by this function, but it may invalidate all iterators to the container.  
  
 If an exception is thrown during the insertion, the container is left unaltered and the exception is rethrown.  
  
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
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)