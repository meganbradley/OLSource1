---
title: "unordered_map::erase"
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
  - "tr1.unordered_map.erase"
  - "std.tr1.unordered_map.erase"
  - "std::tr1::unordered_map::erase"
  - "unordered_map.erase"
  - "unordered_map::erase"
  - "unordered_map/std::tr1::unordered_map::erase"
  - "tr1::unordered_map::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
  - "erase method [TR1]"
ms.assetid: 613b51e5-92e8-4b31-9275-432e4795d7fe
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::erase
Removes an element or a range of elements in a unordered_map from specified positions or removes elements that match a specified key.  
  
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
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_map.  
  
## Remarks  
 For a code example, see [map::erase](../vs140/map--erase.md).  
  
## Requirements  
 **Header:** <unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::clear](../vs140/unordered_map--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)