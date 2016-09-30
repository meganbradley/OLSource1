---
title: "unordered_multimap::erase"
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
  - "std.tr1.unordered_multimap.erase"
  - "std::tr1::unordered_multimap::erase"
  - "tr1::unordered_multimap::erase"
  - "unordered_multimap.erase"
  - "unordered_map/std::tr1::unordered_multimap::erase"
  - "tr1.unordered_multimap.erase"
  - "unordered_multimap::erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erase method"
  - "erase method [TR1]"
ms.assetid: f0f52d80-9a4b-4194-9177-38bdb66648f4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::erase
Removes an element or a range of elements in a unordered_multimap from specified positions or removes elements that match a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Position of the element to be removed.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Position of the first element to be removed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Position just beyond the last element to be removed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The key value of the elements to be removed.  
  
## Return Value  
 For the first two member functions, a bidirectional iterator that designates the first element remaining beyond any elements removed, or an element that is the end of the map if no such element exists.  
  
 For the third member function, returns the number of elements that have been removed from the unordered_multimap.  
  
## Remarks  
 For a code example, see [map::erase](../vs140/map--erase.md).  
  
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::clear](../vs140/unordered_multimap--clear.md)   
 [Standard Template Library](../vs140/standard-template-library.md)