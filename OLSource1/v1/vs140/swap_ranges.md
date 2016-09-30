---
title: "swap_ranges"
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
  - "std.swap_ranges"
  - "std::swap_ranges"
  - "swap_ranges"
  - "algorithm/std::swap_ranges"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap_ranges"
  - "swap_ranges function"
ms.assetid: 6dbc8367-d97b-4a25-978d-7f94eb465cbc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap_ranges
Exchanges the elements of one range with the elements of another, equal sized range.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A forward iterator pointing to the first position of the first range whose elements are to be exchanged.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A forward iterator pointing to one past the final position of the first range whose elements are to be exchanged.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A forward iterator pointing to the first position of the second range whose elements are to be exchanged.  
  
## Return Value  
 A forward iterator pointing to one past the final position of the second range whose elements are to be exchanged.  
  
## Remarks  
 The ranges referenced must be valid; all pointers must be dereferenceable and within each sequence the last position is reachable from the first by incrementation. The second range has to be as large as the first range.  
  
 The complexity is linear with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> swaps performed. If elements from containers of the same type are being swapped, them the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function from that container should be used, because the member function typically has constant complexity.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Vector v1 is ( 0 1 2 3 4 5 ).**  
**Deque d1 is  ( 6 6 6 6 6 6 ).**  
**After the swap_range, vector v1 is ( 6 6 6 6 6 6 ).**  
**After the swap_range deque d1 is   ( 0 1 2 3 4 5 ).**   
## Requirements  
 **Header:** \<algorithm>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)