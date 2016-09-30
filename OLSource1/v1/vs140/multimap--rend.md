---
title: "multimap::rend"
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
  - "rend"
  - "multimap::rend"
  - "map/std::multimap::rend"
  - "multimap.rend"
  - "std.multimap.rend"
  - "std::multimap::rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 123acd21-9da0-455d-a7c4-d39ac7fa5fd7
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::rend
Returns an iterator that addresses the location succeeding the last element in a reversed multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multimap (the location that had preceded the first element in the unreversed multimap).  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed multimap just as [end](../vs140/map--end.md) is used with a multimap.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then the multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then the multimap object can be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its multimap.  
  
 The value returned by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last element of the reversed multimap m1 is 1.**  
**The multimap is: 1 2 3 .**  
**The reversed multimap is: 3 2 1 .**  
**After the erasure, the last element in the reversed multimap is 2.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)