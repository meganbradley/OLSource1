---
title: "hash_multimap::equal_range (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multimap::equal_range (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multimap::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range member [STL/CLR]"
ms.assetid: 3ea11e31-d4af-4d2e-a80b-eafe12c97d0c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multimap::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [lower_bound](../vs140/hash_multimap--lower_bound--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [upper_bound](../vs140/hash_multimap--upper_bound--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **[a 1] [b 2] [c 3]**  
**equal_range(L'x') empty = True**  
 **[b 2]**   
## Requirements  
 **Header:** \<cliext/hash_map>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multimap](../vs140/hash_multimap--stl-clr-.md)   
 [count](../vs140/hash_multimap--count--stl-clr-.md)   
 [find](../vs140/hash_multimap--find--stl-clr-.md)   
 [lower_bound](../vs140/hash_multimap--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/hash_multimap--upper_bound--stl-clr-.md)