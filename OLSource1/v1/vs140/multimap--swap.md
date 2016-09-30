---
title: "multimap::swap"
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
  - "map/std::multimap::swap"
  - "std::multimap::swap"
  - "multimap::swap"
  - "std.multimap.swap"
  - "swap"
  - "multimap.swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 38751864-0738-4381-a3fb-e18b0956dd37
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::swap
Exchanges the elements of two multimaps.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The multimap providing the elements to be swapped, or the multimap whose elements are to be exchanged with those of the multimap <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The member function invalidates no references, pointers, or iterators that designate elements in the two multimaps whose elements are being exchanged.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original multimap m1 is: 10 20 30.**  
**After swapping with m2, multimap m1 is: 100 200.**  
**After swapping with m3, multimap m1 is: 300.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)