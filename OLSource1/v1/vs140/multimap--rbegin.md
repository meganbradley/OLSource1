---
title: "multimap::rbegin"
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
  - "std.multimap.rbegin"
  - "std::multimap::rbegin"
  - "multimap.rbegin"
  - "rbegin"
  - "map/std::multimap::rbegin"
  - "multimap::rbegin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rbegin method"
ms.assetid: 2d08ac88-d8c6-4d9f-9247-0ad8d2796a78
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multimap::rbegin
Returns an iterator addressing the first element in a reversed multimap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator addressing the first element in a reversed multimap or addressing what had been the last element in the unreversed multimap.  
  
## Remarks  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is used with a reversed multimap just as [begin](../vs140/multimap--begin.md) is used with a multimap.  
  
 If the return value of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, then the multimap object cannot be modified. If the return value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then the multimap object can be modified.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be used to iterate through a multimap backwards.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The first element of the reversed multimap m1 is 3.**  
**The multimap is: 1 2 3 .**  
**The reversed multimap is: 3 2 1 .**  
**After the erasure, the first element in the reversed multimap is 2.**   
## Requirements  
 **Header:** \<map>  
  
 **Namespace:** std  
  
## See Also  
 [multimap Class](../vs140/multimap-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)