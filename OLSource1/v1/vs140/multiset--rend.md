---
title: "multiset::rend"
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
  - "multiset::rend"
  - "set/std::multiset::rend"
  - "std::multiset::rend"
  - "multiset.rend"
  - "std.multiset.rend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "rend method"
ms.assetid: 61fb207b-0251-4f0e-8d7a-1f9911714b7a
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multiset::rend
Returns an iterator that addresses the location succeeding the last element in a reversed multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multiset (the location that had preceded the first element in the unreversed multiset).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed multiset just as [end](../vs140/multiset--end.md) is used with a multiset.  
  
 If the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, then the multiset object cannot be modified. If the return value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is assigned to a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then the multiset object can be modified.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its multiset.  
  
 The value returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> should not be dereferenced.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<set>  
  
 **Namespace:** std  
  
## See Also  
 [multiset Class](../vs140/multiset-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)