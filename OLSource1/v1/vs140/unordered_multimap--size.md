---
title: "unordered_multimap::size"
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
  - "std::tr1::unordered_multimap::size"
  - "std.tr1.unordered_multimap.size"
  - "unordered_multimap.size"
  - "unordered_map/std::tr1::unordered_multimap::size"
  - "unordered_multimap::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method [TR1]"
ms.assetid: 24433838-24ab-4329-a61d-636b390fce11
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::size
Counts the number of elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns the length of the controlled sequence.  
  
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
 [unordered_multimap::max_size](../vs140/unordered_multimap--max_size.md)