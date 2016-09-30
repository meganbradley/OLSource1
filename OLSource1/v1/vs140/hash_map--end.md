---
title: "hash_map::end"
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
  - "std.hash_map.end"
  - "std::hash_map::end"
  - "hash_map/stdext::hash_map::end"
  - "hash_map::end"
  - "hash_map.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: b8cd9a77-9039-43cc-86a9-606078b97d40
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_map::end
> [!NOTE]
>  This API is obsolete. The alternative is [unordered_map Class](../vs140/unordered_map-class.md).  
  
 Returns an iterator that addresses the location succeeding the last element in a hash_map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A bidirectional iterator that addresses the location succeeding the last element in a hash_map. If the hash_map is empty, then hash_map::end == hash_map::begin.  
  
## Remarks  
 **end** is used to test whether an iterator has reached the end of its hash_map.  
  
 The value returned by **end** should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The value of last element of hm1 is 30.**  
**The value of last element of hm1 is now 20.**   
## Requirements  
 **Header:** \<hash_map>  
  
 **Namespace:** stdext  
  
## See Also  
 [hash_map Class](../vs140/hash_map-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)