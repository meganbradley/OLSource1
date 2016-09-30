---
title: "unordered_multiset::equal_range"
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
  - "unordered_set/std::tr1::unordered_multiset::equal_range"
  - "unordered_multiset.equal_range"
  - "std::tr1::unordered_multiset::equal_range"
  - "std.tr1.unordered_multiset.equal_range"
  - "unordered_multiset::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method [TR1]"
ms.assetid: d9ea45b5-0940-4f1d-b3f2-c203f00d7dc8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::equal_range
Finds range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> such that <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> delimits just those elements of the controlled sequence that have equivalent ordering with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If no such elements exist, both iterators are <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**equal_range('x'):**  
**equal_range('b'): [b]**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)