---
title: "distance"
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
  - "std.distance"
  - "distance"
  - "std::distance"
  - "xutility/std::distance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "distance"
  - "distance function"
ms.assetid: f863cae2-852b-4f9c-8006-84d24b4f5f8f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# distance
Determines the number of increments between the positions addressed by two iterators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The first iterator whose distance from the second is to be determined.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The second iterator whose distance from the first is to be determined.  
  
## Return Value  
 The number of times that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be incremented until it equal <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The distance function has constant complexity when **InputIterator** satisfies the requirements for a random-access iterator; otherwise, it has linear complexity and so is potentially expensive.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The list L is: ( -2 0 2 4 6 8 10 12 14 16 ).**  
**The iterator LPOS initially points to the first element: -2.**  
**LPOS is advanced 7 steps forward to point  to the eighth element: 12.**  
**The distance from L.begin( ) to LPOS is: 7.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [distance](../vs140/distance--stl-samples-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)