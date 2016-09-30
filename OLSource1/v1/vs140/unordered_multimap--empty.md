---
title: "unordered_multimap::empty"
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
  - "std.tr1.unordered_multimap.empty"
  - "unordered_multimap::empty"
  - "unordered_multimap.empty"
  - "unordered_map/std::tr1::unordered_multimap::empty"
  - "std::tr1::unordered_multimap::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method [TR1]"
ms.assetid: c9862809-affd-47b9-b811-6595d8b4f3ed
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::empty
Tests whether no elements are present.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns true for an empty controlled sequence.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**size == 0**  
**empty() == true**  
 **[e, 5] [d, 4]**  
**size == 2**  
**empty() == false**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)   
 [unordered_multimap::size](../vs140/unordered_multimap--size.md)