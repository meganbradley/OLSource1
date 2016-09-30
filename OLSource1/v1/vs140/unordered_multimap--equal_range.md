---
title: "unordered_multimap::equal_range"
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
  - "unordered_multimap.equal_range"
  - "std.tr1.unordered_multimap.equal_range"
  - "equal_range"
  - "unordered_map/std::tr1::unordered_multimap::equal_range"
  - "unordered_multimap::equal_range"
  - "std::tr1::unordered_multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method [TR1]"
ms.assetid: 86007e66-5d6e-46ea-b6a2-6d6c67797d18
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multimap::equal_range
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
  **[c, 3] [b, 2] [a, 1]**  
**equal_range('x'):**  
**equal_range('b'): [b, 2]**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_multimap](../vs140/unordered_multimap-class.md)