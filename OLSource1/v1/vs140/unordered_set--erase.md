---
title: "unordered_set::erase"
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
  - "tr1::unordered_set::erase"
  - "erase"
  - "tr1.unordered_set.erase"
  - "std.tr1.unordered_set.erase"
  - "unordered_set::erase"
  - "std::tr1::unordered_set::erase"
  - "unordered_set/std::tr1::unordered_set::erase"
  - "unordered_set.erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
  - "erase method [TR1]"
ms.assetid: 2b5cdd90-1459-4296-9602-d7a474b43028
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_set::erase
Removes an element or a range of elements in a unordered_set from specified positions or removes elements that match a specified key.  
  
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
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the unordered_set if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_set.  
  
## Remarks  
 For a code example, see [set::erase](../vs140/set--erase.md).  
  
## Requirements  
 **Header:** <unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_set](../vs140/unordered_set-class.md)   
 [unordered_set::clear](../vs140/unordered_set--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)