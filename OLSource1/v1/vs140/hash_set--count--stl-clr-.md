---
title: "hash_set::count (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "hash_set::count (STL/CLR)"
f1_keywords: 
  - "cliext::hash_set::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count member [STL/CLR]"
ms.assetid: 99dbaef5-64fd-4bef-bac4-a6072dd231f1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# hash_set::count (STL-CLR)
Finds the number of elements matching a specified key.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 key  
 Key value to search for.  
  
## Remarks  
 The member function returns the number of elements in the controlled sequence that have equivalent ordering with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You use it to determine the number of elements currently in the controlled sequence that match a specified key.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **a b c**  
**count(L'A') = 0**  
**count(L'b') = 1**  
**count(L'C') = 0**   
## Requirements  
 **Header:** \<cliext/hash_set>  
  
 **Namespace:** cliext  
  
## See Also  
 [hash_set](../vs140/hash_set--stl-clr-.md)   
 [equal_range](../vs140/hash_set--equal_range--stl-clr-.md)