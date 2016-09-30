---
title: "concurrent_unordered_multiset::max_size Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 11d7afd5-8ca7-4d9e-a81a-b453d567c050
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multiset::max_size Method
Returns the maximum size of the concurrent container, determined by the allocator. This method is concurrency safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The maximum number of elements that can be inserted into this concurrent container.  
  
## Remarks  
 This upper bound value may actually be higher than what the container can actually hold.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)