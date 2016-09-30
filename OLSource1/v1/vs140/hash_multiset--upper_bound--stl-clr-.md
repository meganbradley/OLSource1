---
title: "hash_multiset::upper_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::upper_bound (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::upper_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "upper_bound member [STL/CLR]"
ms.assetid: d5be0d79-ae60-42bb-8a53-051bc374407d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::upper_bound (STL-CLR)
Finds end of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the last element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that hashes to the same bucket as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and has equivalent ordering to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If no such element exists, or if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the last element in the controlled sequence, it returns [end](../vs140/hash_multiset--end--stl-clr-.md)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates the first element beyond <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You use it to locate the end of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**upper_bound(L'x')==end() = True**  
**\*upper_bound(L'a') = b**  
**\*upper_bound(L'b') = c**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [count](../vs140/hash_multiset--count--stl-clr-.md)   
 [equal_range](../vs140/hash_multiset--equal_range--stl-clr-.md)   
 [find](../vs140/hash_multiset--find--stl-clr-.md)   
 [lower_bound](../vs140/hash_multiset--lower_bound--stl-clr-.md)