---
title: "unordered_map::equal_range"
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
  - "std.tr1.unordered_map.equal_range"
  - "std::tr1::unordered_map::equal_range"
  - "unordered_map::equal_range"
  - "unordered_map/std::tr1::unordered_map::equal_range"
  - "unordered_map.equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method [TR1]"
ms.assetid: 1dba703b-513b-4c28-b7c2-9296ba7f17b6
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::equal_range
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
 [unordered_map](../vs140/unordered_map-class.md)