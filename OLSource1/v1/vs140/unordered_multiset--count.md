---
title: "unordered_multiset::count"
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
  - "unordered_multiset.count"
  - "unordered_multiset::count"
  - "std.tr1.unordered_multiset.count"
  - "std::tr1::unordered_multiset::count"
  - "unordered_set/std::tr1::unordered_multiset::count"
  - "count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method [TR1]"
ms.assetid: 5ad4192c-4694-422e-b205-a1718b47c9db
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unordered_multiset::count
Finds the number of elements matching a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Key value to search for.  
  
## Remarks  
 The member function returns the number of elements in the range delimited by [equal_range](../vs140/unordered_multiset--equal_range.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[c] [b] [a]**  
**count('A') == 0**  
**count('b') == 1**  
**count('C') == 0**   
## Requirements  
 **Header:** \<unordered_set>  
  
 **Namespace:** std  
  
## See Also  
 [\<unordered_set>](../vs140/-unordered_set-.md)   
 [unordered_multiset](../vs140/unordered_multiset-class.md)   
 [unordered_multiset::equal_range](../vs140/unordered_multiset--equal_range.md)