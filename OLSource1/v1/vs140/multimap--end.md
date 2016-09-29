---
title: "multimap::end"
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
  - "std::multimap::end"
  - "std.multimap.end"
  - "map/std::multimap::end"
  - "multimap::end"
  - "end"
  - "multimap.end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: 58e1cb63-fa7b-4baa-84a6-1be5e6fff5f2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::end
Returns the past-the-end iterator.  
  
## Syntax  
  
```  
const_iterator end( ) const;  
  
iterator end( );  
```  
  
## Return Value  
 The past-the-end iterator. If the multimap is empty, then `multimap::end() == multimap::begin()`.  
  
## Remarks  
 **end** is used to test whether an iterator has passed the end of its multimap.  
  
 The value returned by **end** should not be dereferenced.  
  
 For a code example, see [multimap::find](../vs140/multimap--find.md).  
  
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)