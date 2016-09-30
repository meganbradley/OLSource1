---
title: "unordered_multiset::swap"
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
  - "unordered_multiset.swap"
  - "tr1.unordered_multiset.swap"
  - "unordered_multiset::swap"
  - "unordered_set/std::tr1::unordered_multiset::swap"
  - "tr1::unordered_multiset::swap"
  - "swap"
  - "std.tr1.unordered_multiset.swap"
  - "std::tr1::unordered_multiset::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method [TR1]"
  - "swap method"
ms.assetid: 746337e0-047a-4efa-97b0-8f61f2329e86
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::swap
Swaps the contents of two containers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The container to swap with.  
  
## Remarks  
 The member function swaps the controlled sequences between <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If [get_allocator](../vs140/unordered_multiset--get_allocator.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, it does so in constant time, it throws an exception only as a result of copying the stored traits object of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and it invalidates no references, pointers, or iterators that designate elements in the two controlled sequences. Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
 **[f] [e] [d]**  
 **[c] [b] [a]**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [swap](../vs140/swap-function--unordered_multiset-.md)