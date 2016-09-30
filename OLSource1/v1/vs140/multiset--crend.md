---
title: "multiset::crend"
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
  - "multiset.crend"
  - "std::multiset::crend"
  - "std.multiset.crend"
  - "set/std::multiset::crend"
  - "multiset::crend"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "crend method"
ms.assetid: 3f8454e7-1f37-4afe-a624-81c491ee27dc
caps.latest.revision: 11
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# multiset::crend
Returns a const iterator that addresses the location succeeding the last element in a reversed multiset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A  const reverse bidirectional iterator that addresses the location succeeding the last element in a reversed multiset (the location that had preceded the first element in the unreversed multiset).  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used with a reversed multiset just as [end](../vs140/multiset--end.md) is used with a multiset.  
  
 With the return value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the multiset object cannot be modified.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can be used to test to whether a reverse iterator has reached the end of its multiset.  
  
 The value returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> should not be dereferenced.  
  
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