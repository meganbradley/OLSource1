---
title: "unordered_map::empty"
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
  - "std::tr1::unordered_map::empty"
  - "unordered_map/std::tr1::unordered_map::empty"
  - "std.tr1.unordered_map.empty"
  - "unordered_map.empty"
  - "unordered_map::empty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "empty method [TR1]"
ms.assetid: 6632133c-4f9c-4beb-adbe-7c2d2a3721cb
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::empty
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
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::size](../vs140/unordered_map--size.md)