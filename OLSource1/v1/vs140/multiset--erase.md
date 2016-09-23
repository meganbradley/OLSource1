---
title: "multiset::erase"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - erase
  - multiset::erase
  - multiset.erase
  - set/std::multiset::erase
  - std.multiset.erase
  - std::multiset::erase
dev_langs: 
  - C++
helpviewer_keywords: 
  - erase method
ms.assetid: 367ca60b-1696-4119-b64d-a3647229413b
caps.latest.revision: 25
translation.priority.ht: 
  - de-de
  - ja-jp
---
# multiset::erase
Removes an element or a range of elements in a multiset from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
```  
iterator erase(  
   const_iterator Where  
);  
iterator erase(  
   const_iterator First,  
   const_iterator Last  
);  
size_type erase(  
   const key_type& Key  
);  
```  
  
#### Parameters  
 `Where`  
 Position of the element to be removed.  
  
 `First`  
 Position of the first element to be removed.  
  
 `Last`  
 Position just beyond the last element to be removed.  
  
 `Key`  
 The key value of the elements to be removed.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the multiset if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the multiset.  
  
## Remarks  
 For a code example, see [set::erase](../vs140/set--erase.md).  
  
## Requirements  
 **Header:** <set\>  
  
 **Namespace:** std  
  
## See Also  
 [<set\>](../vs140/-set-.md)   
 [multiset Class](../vs140/multiset-class.md)   
 [multiset::clear](../vs140/multiset--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)