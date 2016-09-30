---
title: "set::emplace"
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
  - "set::emplace"
  - "std::set::emplace"
  - "std.set.emplace"
  - "set.emplace"
  - "set/std::set::emplace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "emplace method"
ms.assetid: e22bf350-faa2-4217-9f21-b4bd41119084
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set::emplace
Inserts an element constructed in place (no copy or move operations are performed).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|The arguments forwarded to construct an element to be inserted into the set unless it already contains an element whose value is equivalently ordered.|  
  
## Return Value  
 A [pair](../vs140/pair-structure.md) whose bool component returns true if an insertion was made, and false if the map already contained an element whose value had an equivalent value in the ordering. The iterator component of the return value pair returns the address where a new element was inserted (if the bool component is true) or where the element was already located (if the bool component is false).  
  
## Remarks  
 No iterators or references are invalidated by this function.  
  
 During emplacement, if an exception is thrown, the container's state is not modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [\<set>](../vs140/-set-.md)   
 [set Class](../vs140/set-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)