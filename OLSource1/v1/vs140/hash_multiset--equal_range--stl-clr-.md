---
title: "hash_multiset::equal_range (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::equal_range (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range member [STL/CLR]"
ms.assetid: a4141d7e-4964-4c78-8989-ae1d1258b50a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::equal_range (STL-CLR)
Finds range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns a pair of iterators <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [lower_bound](../vs140/hash_multiset--lower_bound--stl-clr-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [upper_bound](../vs140/hash_multiset--upper_bound--stl-clr-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. You use it to determine the range of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**equal_range(L'x') empty = True**  
 **b**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [count](../vs140/hash_multiset--count--stl-clr-.md)   
 [find](../vs140/hash_multiset--find--stl-clr-.md)   
 [lower_bound](../vs140/hash_multiset--lower_bound--stl-clr-.md)   
 [upper_bound](../vs140/hash_multiset--upper_bound--stl-clr-.md)