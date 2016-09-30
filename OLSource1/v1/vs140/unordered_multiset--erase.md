---
title: "unordered_multiset::erase"
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
  - "erase"
  - "std::tr1::unordered_multiset::erase"
  - "unordered_set/std::tr1::unordered_multiset::erase"
  - "unordered_multiset::erase"
  - "tr1::unordered_multiset::erase"
  - "std.tr1.unordered_multiset.erase"
  - "unordered_multiset.erase"
  - "tr1.unordered_multiset.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
  - "erase method [TR1]"
ms.assetid: 1abb689a-9788-4147-be05-158ea88e1272
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::erase
Removes an element or a range of elements in a unordered_multiset from specified positions or removes elements that match a specified key.  
  
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
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the unordered_multiset if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_multiset.  
  
## Remarks  
 For a code example, see [set::erase](../vs140/set--erase.md).  
  
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::clear](../vs140/unordered_multiset--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)