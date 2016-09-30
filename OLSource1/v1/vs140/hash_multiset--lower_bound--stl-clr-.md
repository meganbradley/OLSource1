---
title: "hash_multiset::lower_bound (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_multiset::lower_bound (STL/CLR)"
f1_keywords: 
  - "cliext::hash_multiset::lower_bound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lower_bound member [STL/CLR]"
ms.assetid: 891898fa-c9e8-4132-a71d-36e5141793f1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_multiset::lower_bound (STL-CLR)
Finds beginning of range that matches a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function determines the first element <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in the controlled sequence that hashes to the same bucket as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and has equivalent ordering to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If no such element exists, it returns [end](../vs140/hash_multiset--end--stl-clr-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise it returns an iterator that designates <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. You use it to locate the beginning of a sequence of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**lower_bound(L'x')==end() = True**  
**\*lower_bound(L'a') = a**  
**\*lower_bound(L'b') = b**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_multiset](../vs140/hash_multiset--stl-clr-.md)   
 [count](../vs140/hash_multiset--count--stl-clr-.md)   
 [equal_range](../vs140/hash_multiset--equal_range--stl-clr-.md)   
 [find](../vs140/hash_multiset--find--stl-clr-.md)   
 [upper_bound](../vs140/hash_multiset--upper_bound--stl-clr-.md)