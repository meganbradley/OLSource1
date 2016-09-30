---
title: "unordered_map::swap"
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
  - "unordered_map.swap"
  - "tr1.unordered_map.swap"
  - "unordered_map::swap"
  - "tr1::unordered_map::swap"
  - "std::tr1::unordered_map::swap"
  - "std.tr1.unordered_map.swap"
  - "unordered_map/std::tr1::unordered_map::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
  - "swap method"
ms.assetid: 462328fb-043e-405e-8399-62f2e961b246
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::swap
Swaps the contents of two containers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The container to swap with.  
  
## Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If [get_allocator](../vs140/unordered_map--get_allocator.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
 **[f, 6] [e, 5] [d, 4]**  
 **[c, 3] [b, 2] [a, 1]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [swap](../vs140/swap-function--unordered_map-.md)