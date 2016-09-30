---
title: "unordered_map::count"
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
  - "std::tr1::unordered_map::count"
  - "std.tr1.unordered_map.count"
  - "unordered_map.count"
  - "unordered_map::count"
  - "count"
  - "unordered_map/std::tr1::unordered_map::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method [TR1]"
ms.assetid: bda30fcc-da49-463e-a602-97e00a5c0007
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_map::count
Finds the number of elements matching a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The member function returns the number of elements in the range delimited by [equal_range](../vs140/unordered_map--equal_range.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c, 3] [b, 2] [a, 1]**  
**count('A') == 0**  
**count('b') == 1**  
**count('C') == 0**   
## Requirements  
 **Header:** \<unordered_map>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_map>](../vs140/-unordered_map-.md)   
 [unordered_map](../vs140/unordered_map-class.md)   
 [unordered_map::equal_range](../vs140/unordered_map--equal_range.md)